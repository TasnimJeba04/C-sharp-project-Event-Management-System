using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class AdminDashboardForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();

        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            if (User.CurrentUser != null)
                lblTitle.Text = "Welcome, " + User.CurrentUser.FullName;
            LoadStats();
            LoadBookings();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230), Color.FromArgb(140, 70, 220),
                LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
        }

        private void pnlStatEvents_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(93, 173, 226)))
                e.Graphics.FillRectangle(brush, 0, 0, 5, pnlStatEvents.Height);
        }
        private void pnlStatBookings_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(134, 87, 220)))
                e.Graphics.FillRectangle(brush, 0, 0, 5, pnlStatBookings.Height);
        }
        private void pnlStatEarnings_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(40, 180, 130)))
                e.Graphics.FillRectangle(brush, 0, 0, 5, pnlStatEarnings.Height);
        }

        private void LoadStats()
        {
            try
            {
                int orgId = User.CurrentUser.UserID;

                lblNumEvents.Text = db.ExecuteScalar(
                    "SELECT COUNT(*) FROM Events WHERE OrganizerID=@id",
                    new SqlParameter[] { new SqlParameter("@id", orgId) }).ToString();

                lblNumBookings.Text = db.ExecuteScalar(
                    @"SELECT COUNT(*) FROM Bookings b
                       JOIN Events e ON b.EventID=e.EventID
                       WHERE e.OrganizerID=@id",
                    new SqlParameter[] { new SqlParameter("@id", orgId) }).ToString();

                object earn = db.ExecuteScalar(
                    @"SELECT ISNULL(SUM(p.Amount),0) FROM Payments p
                       JOIN Bookings b ON p.BookingID=b.BookingID
                       JOIN Events  e ON b.EventID=e.EventID
                       WHERE e.OrganizerID=@id AND p.PaymentStatus='Paid'",
                    new SqlParameter[] { new SqlParameter("@id", orgId) });

                lblNumEarnings.Text = "BDT " + Convert.ToDecimal(earn).ToString("N0");
            }
            catch (Exception ex) { MessageBox.Show("Stats error: " + ex.Message); }
        }

        private void LoadBookings()
        {
            string sql = @"
                SELECT b.BookingID            AS [Booking ID],
                       e.EventName            AS [Hall],
                       u.FullName             AS [Customer],
                       ISNULL(u.Phone,'-')    AS [Phone],
                       b.NumberOfTickets      AS [Guests],
                       b.TotalAmount          AS [Amount (BDT)],
                       b.Status,
                       b.BookingDate          AS [Booked On]
                FROM Bookings b
                JOIN Events e ON b.EventID    = e.EventID
                JOIN Users  u ON b.CustomerID = u.UserID
                WHERE e.OrganizerID = @id
                ORDER BY b.BookingDate DESC";
            dgvBookings.DataSource = db.ExecuteQuery(sql, new SqlParameter[]
            {
                new SqlParameter("@id", User.CurrentUser.UserID)
            });
        }

        private void btnManageEvents_Click(object sender, EventArgs e)
        {
            new ManageEventsForm().ShowDialog();
            LoadStats();
            LoadBookings();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStats();
            LoadBookings();
        }

        // ===== APPROVE pending booking → Confirmed =====
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow == null) { MessageBox.Show("Select a booking."); return; }
            int bid = Convert.ToInt32(dgvBookings.CurrentRow.Cells["Booking ID"].Value);
            string status = dgvBookings.CurrentRow.Cells["Status"].Value.ToString();
            if (status != "Pending")
            {
                MessageBox.Show("Only Pending bookings can be approved.\nThis booking is " + status + ".",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Approve this booking? Customer will see it as Confirmed.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                db.ExecuteNonQuery("UPDATE Bookings SET Status='Confirmed' WHERE BookingID=@b",
                    new SqlParameter[] { new SqlParameter("@b", bid) });
                MessageBox.Show("Booking approved & confirmed.");
                LoadStats();
                LoadBookings();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // ===== REJECT booking → Cancelled =====
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow == null) { MessageBox.Show("Select a booking."); return; }
            int bid = Convert.ToInt32(dgvBookings.CurrentRow.Cells["Booking ID"].Value);
            string status = dgvBookings.CurrentRow.Cells["Status"].Value.ToString();
            if (status == "Cancelled") { MessageBox.Show("Already cancelled."); return; }
            if (MessageBox.Show("Reject this booking? It will be marked Cancelled.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                db.ExecuteNonQuery("UPDATE Bookings SET Status='Cancelled' WHERE BookingID=@b",
                    new SqlParameter[] { new SqlParameter("@b", bid) });
                MessageBox.Show("Booking rejected.");
                LoadStats();
                LoadBookings();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            User.CurrentUser = null;
            this.Close();
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}