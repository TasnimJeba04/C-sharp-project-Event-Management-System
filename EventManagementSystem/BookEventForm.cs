using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class BookEventForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();
        private int eventId;
        private decimal hallPrice;
        private int hallCapacity;
        private int? appliedDiscountId = null;
        private decimal appliedPercent = 0;

        public BookEventForm(int eventId)
        {
            InitializeComponent();
            this.eventId = eventId;
        }

        private void BookEventForm_Load(object sender, EventArgs e)
        {
            cmbEventType.Items.AddRange(new object[]
            {
                "Wedding", "Birthday", "Engagement", "Corporate Conference",
                "Seminar", "Cultural Program", "Anniversary", "Family Gathering"
            });
            cmbEventType.SelectedIndex = 0;
            LoadHall();
            if (User.CurrentUser != null) txtPhone.Text = User.CurrentUser.Phone ?? "";
            UpdateTotal();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230), Color.FromArgb(140, 70, 220),
                LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
        }

        private void LoadHall()
        {
            DataTable dt = db.ExecuteQuery("SELECT * FROM Events WHERE EventID=@id",
                new SqlParameter[] { new SqlParameter("@id", eventId) });
            if (dt.Rows.Count == 0) { MessageBox.Show("Hall not found."); this.Close(); return; }
            DataRow r = dt.Rows[0];

            lblHallName.Text = r["EventName"].ToString();
            lblLocation.Text = "Location: " + r["Location"];
            lblCapacity.Text = "Capacity: " + r["AvailableSeats"] + " guests";
            lblCategory.Text = "Category: " + (r["Category"] == DBNull.Value ? "-" : r["Category"]);
            hallPrice = Convert.ToDecimal(r["Price"]);
            hallCapacity = Convert.ToInt32(r["AvailableSeats"]);
            lblPriceValue.Text = "BDT " + hallPrice.ToString("N0");
            numGuests.Maximum = Math.Max(1, hallCapacity);

            string imgPath = r["ImagePath"] == DBNull.Value ? "" : r["ImagePath"].ToString();
            if (!string.IsNullOrEmpty(imgPath))
            {
                string fullPath = Path.Combine(Application.StartupPath, imgPath);
                if (File.Exists(fullPath))
                {
                    try { picHall.Image = Image.FromFile(fullPath); } catch { }
                }
            }
        }

        private void numGuests_ValueChanged(object sender, EventArgs e) { UpdateTotal(); }

        private void UpdateTotal()
        {
            decimal subtotal = hallPrice;
            decimal discount = subtotal * appliedPercent / 100m;
            decimal total = subtotal - discount;

            lblSubtotal.Text = "Subtotal:  BDT " + subtotal.ToString("N0");
            lblDiscount.Text = "Discount:  - BDT " + discount.ToString("N0") + " (" + appliedPercent + "%)";
            lblTotal.Text = "TOTAL: BDT " + total.ToString("N0");
        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCoupon.Text))
            {
                appliedDiscountId = null; appliedPercent = 0;
                lblCouponMsg.Text = "";
                UpdateTotal(); return;
            }
            DataTable dt = db.ExecuteQuery(
                @"SELECT * FROM Discounts
                  WHERE CouponCode=@c AND IsActive=1 AND ExpiryDate >= GETDATE()",
                new SqlParameter[] { new SqlParameter("@c", txtCoupon.Text.Trim()) });
            if (dt.Rows.Count == 0)
            {
                appliedDiscountId = null; appliedPercent = 0;
                lblCouponMsg.Text = "Invalid coupon";
                lblCouponMsg.ForeColor = Color.FromArgb(220, 80, 80);
            }
            else
            {
                appliedDiscountId = Convert.ToInt32(dt.Rows[0]["DiscountID"]);
                appliedPercent = Convert.ToDecimal(dt.Rows[0]["DiscountPercent"]);
                lblCouponMsg.Text = appliedPercent + "% off applied!";
                lblCouponMsg.ForeColor = Color.FromArgb(40, 180, 130);
            }
            UpdateTotal();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (User.CurrentUser == null) { MessageBox.Show("Please login again."); return; }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                { MessageBox.Show("Please enter contact phone."); return; }

                int guests = (int)numGuests.Value;
                if (guests <= 0 || guests > hallCapacity)
                { MessageBox.Show("Invalid guest count."); return; }

                if (dtpDate.Value.Date < DateTime.Now.Date)
                { MessageBox.Show("Please choose a future date."); return; }

                decimal total = hallPrice - (hallPrice * appliedPercent / 100m);

                string sql = @"
                    INSERT INTO Bookings
                      (CustomerID, EventID, NumberOfTickets, TotalAmount, DiscountID, Status,
                       PreferredDate, StartTime, EndTime, EventType, ContactPhone, SpecialRequest)
                    VALUES (@cid, @eid, @qty, @amt, @did, 'Pending',
                       @pd, @st, @et, @type, @phone, @req);
                    SELECT SCOPE_IDENTITY();";

                int newBookingId;
                using (SqlConnection con = db.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@cid", User.CurrentUser.UserID);
                    cmd.Parameters.AddWithValue("@eid", eventId);
                    cmd.Parameters.AddWithValue("@qty", guests);
                    cmd.Parameters.AddWithValue("@amt", total);
                    cmd.Parameters.AddWithValue("@did", appliedDiscountId.HasValue ? (object)appliedDiscountId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@pd", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@st", dtpStart.Value.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@et", dtpEnd.Value.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@type", cmbEventType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@req", string.IsNullOrWhiteSpace(txtSpecialRequest.Text) ? (object)DBNull.Value : txtSpecialRequest.Text.Trim());
                    con.Open();
                    newBookingId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                MessageBox.Show("Booking created (status: Pending). Now please complete payment.",
                    "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PaymentForm pf = new PaymentForm(newBookingId, total);
                pf.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) { this.Close(); }
    }
}