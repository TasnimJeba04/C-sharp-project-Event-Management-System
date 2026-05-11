using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventManagementSystem
{
    public partial class ReviewForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();
        private int eventId;
        private int currentRating = 5;
        private Button[] stars;

        public ReviewForm(int eventId)
        {
            InitializeComponent();
            this.eventId = eventId;
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            object name = db.ExecuteScalar("SELECT EventName FROM Events WHERE EventID=@id",
                new SqlParameter[] { new SqlParameter("@id", eventId) });
            lblHallName.Text = name == null ? "Hall" : name.ToString();

            stars = new[] { btnStar1, btnStar2, btnStar3, btnStar4, btnStar5 };
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Tag = i + 1;
                stars[i].Click += Star_Click;
            }
            UpdateStars();
            LoadReviews();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230), Color.FromArgb(140, 70, 220),
                LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
        }

        private void Star_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            currentRating = (int)b.Tag;
            UpdateStars();
        }

        private void UpdateStars()
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Text = (i < currentRating) ? "\u2605" : "\u2606";
                stars[i].ForeColor = (i < currentRating) ? Color.FromArgb(255, 180, 0) : Color.LightGray;
            }
            lblRatingText.Text = "Your rating: " + currentRating + " / 5";
        }

        private void LoadReviews()
        {
            string sql = @"SELECT u.FullName AS [Customer], r.Rating AS [Stars],
                                  r.Comment, r.ReviewDate AS [Date]
                           FROM Reviews r JOIN Users u ON r.CustomerID = u.UserID
                           WHERE r.EventID=@id ORDER BY r.ReviewDate DESC";
            dgvReviews.DataSource = db.ExecuteQuery(sql,
                new SqlParameter[] { new SqlParameter("@id", eventId) });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (User.CurrentUser == null) { MessageBox.Show("Please login again."); return; }

                // Verify customer has a confirmed booking for this hall
                object cnt = db.ExecuteScalar(
                    @"SELECT COUNT(*) FROM Bookings
                      WHERE CustomerID=@c AND EventID=@e AND Status='Confirmed'",
                    new SqlParameter[]
                    {
                        new SqlParameter("@c", User.CurrentUser.UserID),
                        new SqlParameter("@e", eventId)
                    });
                if (Convert.ToInt32(cnt) == 0)
                {
                    MessageBox.Show("You can only review halls you have actually booked & paid for.",
                        "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.ExecuteNonQuery(
                    @"INSERT INTO Reviews (CustomerID, EventID, Rating, Comment)
                      VALUES (@c, @e, @r, @cm)",
                    new SqlParameter[]
                    {
                        new SqlParameter("@c",  User.CurrentUser.UserID),
                        new SqlParameter("@e",  eventId),
                        new SqlParameter("@r",  currentRating),
                        new SqlParameter("@cm", string.IsNullOrWhiteSpace(txtComment.Text) ? (object)DBNull.Value : txtComment.Text.Trim())
                    });
                MessageBox.Show("Review submitted. Thank you!", "Thanks",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtComment.Clear();
                LoadReviews();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) { this.Close(); }
    }
}