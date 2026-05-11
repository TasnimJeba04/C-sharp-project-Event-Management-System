using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class SuperAdminDashboardForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();

        public SuperAdminDashboardForm()
        {
            InitializeComponent();
        }

        private void SuperAdminDashboardForm_Load(object sender, EventArgs e)
        {
            if (User.CurrentUser != null)
                lblTitle.Text = "Welcome, " + User.CurrentUser.FullName;
            LoadStats();
            LoadActivity();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230),
                Color.FromArgb(140, 70, 220),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
            }
        }

        private void pnlStat1_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(33, 130, 220)))
                e.Graphics.FillRectangle(brush, 0, 0, 5, pnlStat1.Height);
        }
        private void pnlStat2_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(134, 87, 220)))
                e.Graphics.FillRectangle(brush, 0, 0, 5, pnlStat2.Height);
        }
        private void pnlStat3_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(220, 80, 140)))
                e.Graphics.FillRectangle(brush, 0, 0, 5, pnlStat3.Height);
        }
        private void pnlStat4_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(40, 180, 130)))
                e.Graphics.FillRectangle(brush, 0, 0, 5, pnlStat4.Height);
        }

        private void LoadStats()
        {
            try
            {
                lblNumUsers.Text = db.ExecuteScalar("SELECT COUNT(*) FROM Users").ToString();
                lblNumHalls.Text = db.ExecuteScalar("SELECT COUNT(*) FROM Events").ToString();
                lblNumBookings.Text = db.ExecuteScalar("SELECT COUNT(*) FROM Bookings").ToString();
                object earn = db.ExecuteScalar(
                    "SELECT ISNULL(SUM(Amount),0) FROM Payments WHERE PaymentStatus='Paid'");
                lblNumEarnings.Text = "BDT " + Convert.ToDecimal(earn).ToString("N0");
            }
            catch (Exception ex) { MessageBox.Show("Stats error: " + ex.Message); }
        }

        private void LoadActivity()
        {
            string sql = @"
        SELECT b.BookingID         AS [Booking ID],
               e.EventName         AS [Hall],
               org.FullName        AS [Hall Owner],
               u.FullName          AS [Customer],
               ISNULL(u.Phone,'-') AS [Phone],
               b.NumberOfTickets   AS [Guests],
               b.TotalAmount       AS [Amount (BDT)],
               b.Status,
               b.BookingDate       AS [Booked On]
        FROM Bookings b
        JOIN Events e   ON b.EventID     = e.EventID
        JOIN Users  u   ON b.CustomerID  = u.UserID
        JOIN Users  org ON e.OrganizerID = org.UserID
        ORDER BY b.BookingDate DESC";
            dgvActivity.DataSource = db.ExecuteQuery(sql);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            new ManageUsersForm().ShowDialog();
            LoadStats();
            LoadActivity();
        }

        private void btnManageHalls_Click(object sender, EventArgs e)
        {
            new ManageEventsForm().ShowDialog();
            LoadStats();
            LoadActivity();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStats();
            LoadActivity();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            User.CurrentUser = null;
            this.Close();
        }

        private void dgvActivity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}