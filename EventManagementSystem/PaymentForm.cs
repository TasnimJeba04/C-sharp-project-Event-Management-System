using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class PaymentForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();
        private int bookingId;
        private decimal amount;
        private string selectedMethod = "Cash";
        private Panel[] cards;
        private string receiptText = "";

        public PaymentForm(int bookingId, decimal amount)
        {
            InitializeComponent();
            this.bookingId = bookingId;
            this.amount = amount;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblBookingId.Text = "Booking #" + bookingId;
            lblAmount.Text = "BDT " + amount.ToString("N0");

            pnlCash.Tag = "Cash"; pnlBkash.Tag = "bKash";
            pnlNagad.Tag = "Nagad"; pnlRocket.Tag = "Rocket";
            pnlVisa.Tag = "Visa"; pnlMaster.Tag = "Mastercard";

            cards = new[] { pnlCash, pnlBkash, pnlNagad, pnlRocket, pnlVisa, pnlMaster };

            // Bitmap-based fallback — ALWAYS shows something
            LoadOrDraw(picCash, "pay_cash.jpg", "TK", Color.FromArgb(40, 180, 130));
            LoadOrDraw(picBkash, "pay_bkash.jpg", "bK", Color.FromArgb(226, 19, 110));
            LoadOrDraw(picNagad, "pay_nagad.jpg", "N", Color.FromArgb(238, 110, 31));
            LoadOrDraw(picRocket, "pay_rocket.jpg", "R", Color.FromArgb(140, 52, 148));
            LoadOrDraw(picVisa, "pay_visa.jpg", "VISA", Color.FromArgb(26, 31, 113));
            LoadOrDraw(picMaster, "pay_mastercard.jpg", "MC", Color.FromArgb(220, 70, 50));

            foreach (Panel p in cards)
            {
                p.Click += (s, ev) => { selectedMethod = p.Tag.ToString(); RefreshCards(); };
                p.Paint += PaymentCard_Paint;
                foreach (Control c in p.Controls)
                    c.Click += (s, ev) => { selectedMethod = p.Tag.ToString(); RefreshCards(); };
            }
            RefreshCards();
        }

        // Either load the image, OR draw a brand-letter logo into a bitmap
        private void LoadOrDraw(PictureBox pb, string filename, string fallbackText, Color fallbackColor)
        {
            string path = Path.Combine(Application.StartupPath, "Images", filename);
            if (File.Exists(path))
            {
                try
                {
                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pb.Image = Image.FromStream(stream);
                    }
                    return;
                }
                catch { /* fallback below */ }
            }

            // Always-works fallback: paint a bitmap with the brand letters
            int w = Math.Max(1, pb.Width);
            int h = Math.Max(1, pb.Height);
            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.Clear(Color.White);
                float fontSize = fallbackText.Length > 2 ? 16f : 26f;
                using (var brush = new SolidBrush(fallbackColor))
                using (var font = new Font("Segoe UI Semibold", fontSize, FontStyle.Bold))
                using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    g.DrawString(fallbackText, font, brush, new Rectangle(0, 0, w, h), sf);
                }
            }
            pb.Image = bmp;
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230), Color.FromArgb(140, 70, 220),
                LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
        }

        private void PaymentCard_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            if (p.Tag.ToString() == selectedMethod)
            {
                using (var pen = new Pen(Color.FromArgb(134, 87, 220), 4))
                    e.Graphics.DrawRectangle(pen, 1, 1, p.Width - 3, p.Height - 3);
            }
        }

        private void RefreshCards()
        {
            foreach (Panel p in cards) p.Invalidate();
            lblSelected.Text = "Selected method: " + selectedMethod;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = db.ExecuteNonQuery(
                    @"INSERT INTO Payments (BookingID, Amount, PaymentMethod, PaymentStatus)
                      VALUES (@b, @a, @m, 'Paid')",
                    new SqlParameter[]
                    {
                        new SqlParameter("@b", bookingId),
                        new SqlParameter("@a", amount),
                        new SqlParameter("@m", selectedMethod)
                    });
                if (rows > 0)
                {
                    db.ExecuteNonQuery("UPDATE Bookings SET Status='Confirmed' WHERE BookingID=@b",
                        new SqlParameter[] { new SqlParameter("@b", bookingId) });

                    BuildReceipt();
                    pnlPaymentArea.Visible = false;
                    pnlReceiptArea.Visible = true;
                    txtReceipt.Text = receiptText;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BuildReceipt()
        {
            string sql = @"SELECT b.BookingID, b.NumberOfTickets, b.TotalAmount, b.Status, b.BookingDate,
                                  b.PreferredDate, b.StartTime, b.EndTime, b.EventType,
                                  b.ContactPhone, b.SpecialRequest,
                                  e.EventName, e.Location, e.Price,
                                  u.FullName AS Customer, u.Email,
                                  ISNULL(d.CouponCode,'-') AS Coupon,
                                  ISNULL(d.DiscountPercent,0) AS DiscountPct
                           FROM Bookings b
                           JOIN Events e ON b.EventID = e.EventID
                           JOIN Users u  ON b.CustomerID = u.UserID
                           LEFT JOIN Discounts d ON b.DiscountID = d.DiscountID
                           WHERE b.BookingID = @id";
            DataTable dt = db.ExecuteQuery(sql,
                new SqlParameter[] { new SqlParameter("@id", bookingId) });
            if (dt.Rows.Count == 0) return;
            DataRow r = dt.Rows[0];

            decimal subtotal = Convert.ToDecimal(r["Price"]);
            decimal pct = Convert.ToDecimal(r["DiscountPct"]);
            decimal discount = subtotal * pct / 100m;

            receiptText =
                "====================================\r\n" +
                "    BANGLADESH EVENT HALLS\r\n" +
                "       PAYMENT RECEIPT\r\n" +
                "====================================\r\n\r\n" +
                "Receipt Date:\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "\r\n\r\n" +
                "Booking ID:\r\n#" + r["BookingID"] + "\r\n\r\n" +
                "------------------------------------\r\n" +
                "    CUSTOMER INFORMATION\r\n" +
                "------------------------------------\r\n\r\n" +
                "Name:\r\n" + r["Customer"] + "\r\n\r\n" +
                "Email:\r\n" + r["Email"] + "\r\n\r\n" +
                "Phone:\r\n" + r["ContactPhone"] + "\r\n\r\n" +
                "------------------------------------\r\n" +
                "    BOOKING INFORMATION\r\n" +
                "------------------------------------\r\n\r\n" +
                "Hall Name:\r\n" + r["EventName"] + "\r\n\r\n" +
                "Location:\r\n" + r["Location"] + "\r\n\r\n" +
                "Event Date:\r\n" + Convert.ToDateTime(r["PreferredDate"]).ToString("yyyy-MM-dd") + "\r\n\r\n" +
                "Time:\r\n" + r["StartTime"] + " - " + r["EndTime"] + "\r\n\r\n" +
                "Event Type:\r\n" + r["EventType"] + "\r\n\r\n" +
                "Guest Count:\r\n" + r["NumberOfTickets"] + "\r\n\r\n" +
                "Special Request:\r\n" + (r["SpecialRequest"] == DBNull.Value ? "-" : r["SpecialRequest"]) + "\r\n\r\n" +
                "------------------------------------\r\n" +
                "    PAYMENT INFORMATION\r\n" +
                "------------------------------------\r\n\r\n" +
                "Subtotal:\r\nBDT " + subtotal.ToString("N0") + "\r\n\r\n" +
                "Coupon Code:\r\n" + r["Coupon"] + "\r\n\r\n" +
                "Discount:\r\n-BDT " + discount.ToString("N0") + " (" + pct + "%)\r\n\r\n" +
                "TOTAL PAID:\r\nBDT " + Convert.ToDecimal(r["TotalAmount"]).ToString("N0") + "\r\n\r\n" +
                "Payment Method:\r\n" + selectedMethod + "\r\n\r\n" +
                "Status:\r\nCONFIRMED\r\n\r\n" +
                "====================================\r\n" +
                "Thank you for booking with us!\r\n" +
                "Please show this receipt at\r\n" +
                "the hall on event day.\r\n" +
                "====================================\r\n";
        }

        private void btnSaveReceipt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "Receipt_Booking_" + bookingId + ".txt";
                sfd.Filter = "Text File|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, receiptText);
                        MessageBox.Show("Receipt saved successfully!", "Saved",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show("Save failed: " + ex.Message); }
                }
            }
        }

        private void btnCloseReceipt_Click(object sender, EventArgs e) { this.Close(); }
        private void btnCancel_Click(object sender, EventArgs e) { this.Close(); }
        private void txtReceipt_TextChanged(object sender, EventArgs e)
        {
            // empty — placeholder so the Designer wire-up has a target
        }

    }
}