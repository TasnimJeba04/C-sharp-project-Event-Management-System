using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class BookingHistoryForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();

        public BookingHistoryForm()
        {
            InitializeComponent();
        }

        private void BookingHistoryForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new object[] { "All", "Pending", "Confirmed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
            LoadHistory();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230), Color.FromArgb(140, 70, 220),
                LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
        }

        private void LoadHistory()
        {
            if (User.CurrentUser == null) return;
            string status = cmbStatus.SelectedItem == null ? "All" : cmbStatus.SelectedItem.ToString();
            string sql = @"
                SELECT b.BookingID AS [ID], e.EventName AS [Hall], e.Location,
                       b.PreferredDate AS [Event Date], b.StartTime AS [Start],
                       b.EndTime AS [End], b.EventType AS [Type],
                       b.NumberOfTickets AS [Guests], b.TotalAmount AS [Amount (BDT)],
                       b.Status, ISNULL(p.PaymentMethod,'-') AS [Method],
                       b.BookingDate AS [Booked On], b.EventID
                FROM Bookings b
                JOIN Events e ON b.EventID = e.EventID
                LEFT JOIN Payments p ON b.BookingID = p.BookingID
                WHERE b.CustomerID = @cid
                  AND (@s='All' OR b.Status=@s)
                ORDER BY b.BookingDate DESC";
            DataTable dt = db.ExecuteQuery(sql, new SqlParameter[]
            {
                new SqlParameter("@cid", User.CurrentUser.UserID),
                new SqlParameter("@s",   status)
            });
            dgvHistory.DataSource = dt;
            if (dgvHistory.Columns.Contains("EventID"))
                dgvHistory.Columns["EventID"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e) { LoadHistory(); }

        // NEW: complete payment for a Pending booking
        private void btnCompletePayment_Click(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow == null) { MessageBox.Show("Select a booking first."); return; }
            string status = dgvHistory.CurrentRow.Cells["Status"].Value.ToString();
            if (status != "Pending")
            {
                MessageBox.Show("Only Pending bookings need payment.\nThis booking is already " + status + ".",
                    "Not needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int bid = Convert.ToInt32(dgvHistory.CurrentRow.Cells["ID"].Value);
            decimal amt = Convert.ToDecimal(dgvHistory.CurrentRow.Cells["Amount (BDT)"].Value);
            new PaymentForm(bid, amt).ShowDialog();
            LoadHistory();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow == null) { MessageBox.Show("Select a booking first."); return; }
            string status = dgvHistory.CurrentRow.Cells["Status"].Value.ToString();
            if (status == "Cancelled") { MessageBox.Show("Already cancelled."); return; }
            if (MessageBox.Show("Cancel this booking?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            int bid = Convert.ToInt32(dgvHistory.CurrentRow.Cells["ID"].Value);
            try
            {
                db.ExecuteNonQuery(
                    "UPDATE Bookings SET Status='Cancelled' WHERE BookingID=@b",
                    new SqlParameter[] { new SqlParameter("@b", bid) });
                MessageBox.Show("Booking cancelled.");
                LoadHistory();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnWriteReview_Click(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow == null) { MessageBox.Show("Select a booking first."); return; }
            string status = dgvHistory.CurrentRow.Cells["Status"].Value.ToString();
            if (status != "Confirmed")
            { MessageBox.Show("You can only review confirmed (paid) bookings."); return; }
            int eid = Convert.ToInt32(dgvHistory.CurrentRow.Cells["EventID"].Value);
            new ReviewForm(eid).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) { this.Close(); }
    }
}