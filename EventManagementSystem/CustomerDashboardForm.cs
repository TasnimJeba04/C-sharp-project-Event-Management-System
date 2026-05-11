using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class CustomerDashboardForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();

        public CustomerDashboardForm()
        {
            InitializeComponent();
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadHallCards();
        }

        // ----- Gradient header (blue → purple) -----
        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230),   // blue
                Color.FromArgb(140, 70, 220),   // purple
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
            }
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new object[] {
                "All",
                "Wedding",
                "Birthday",
                "Engagement",
                "Seminar",
                "Corporate Conference",
                "Cultural Program"
            });
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadHallCards(string keyword = "", string category = "All")
        {
            flowHalls.Controls.Clear();

            // Smart filter: searches the SupportedEventTypes column
            string sql = @"SELECT EventID, EventName, Category, EventDate, Location,
                                  Price, AvailableSeats, ImagePath, SupportedEventTypes
                           FROM Events
                           WHERE (@k='' OR EventName LIKE '%'+@k+'%' OR Location LIKE '%'+@k+'%')
                             AND (@c='All' OR SupportedEventTypes LIKE '%'+@c+'%')
                           ORDER BY EventName";
            DataTable dt = db.ExecuteQuery(sql, new SqlParameter[]
            {
                new SqlParameter("@k", keyword ?? ""),
                new SqlParameter("@c", category ?? "All")
            });

            if (dt.Rows.Count == 0)
            {
                Label none = new Label();
                none.Text = "No halls found. Try a different search.";
                none.Font = new Font("Segoe UI Semibold", 12, FontStyle.Italic);
                none.ForeColor = Color.Gray;
                none.AutoSize = true;
                none.Margin = new Padding(20);
                flowHalls.Controls.Add(none);
                return;
            }

            foreach (DataRow row in dt.Rows)
                flowHalls.Controls.Add(BuildHallCard(row));
        }

        private Panel BuildHallCard(DataRow row)
        {
            Panel card = new Panel();
            card.Width = 280;
            card.Height = 410;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(12);

            // ----- Image -----
            PictureBox pic = new PictureBox();
            pic.Width = 280;
            pic.Height = 170;
            pic.Location = new Point(0, 0);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BackColor = Color.LightGray;

            string imgPath = row["ImagePath"] == DBNull.Value ? "" : row["ImagePath"].ToString();
            if (!string.IsNullOrEmpty(imgPath))
            {
                string fullPath = Path.Combine(Application.StartupPath, imgPath);
                if (File.Exists(fullPath))
                {
                    try { pic.Image = Image.FromFile(fullPath); }
                    catch { /* ignore */ }
                }
            }
            card.Controls.Add(pic);

            // ----- Hall name -----
            Label lblName = new Label();
            lblName.Text = row["EventName"].ToString();
            lblName.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(50, 30, 100);
            lblName.Location = new Point(12, 178);
            lblName.Size = new Size(260, 24);
            lblName.AutoEllipsis = true;
            card.Controls.Add(lblName);

            // ----- Location -----
            Label lblLoc = new Label();
            lblLoc.Text = "Location: " + row["Location"];
            lblLoc.Font = new Font("Segoe UI", 9.5f);
            lblLoc.ForeColor = Color.DimGray;
            lblLoc.Location = new Point(12, 206);
            lblLoc.Size = new Size(260, 18);
            card.Controls.Add(lblLoc);

            // ----- Supported event types -----
            Label lblTypes = new Label();
            lblTypes.Text = "Good for: " + (row["SupportedEventTypes"] == DBNull.Value ? "—" : row["SupportedEventTypes"].ToString().Replace(",", ", "));
            lblTypes.Font = new Font("Segoe UI", 8.5f, FontStyle.Italic);
            lblTypes.ForeColor = Color.FromArgb(100, 80, 160);
            lblTypes.Location = new Point(12, 226);
            lblTypes.Size = new Size(260, 32);
            card.Controls.Add(lblTypes);

            // ----- Capacity -----
            Label lblCap = new Label();
            lblCap.Text = "Capacity: " + row["AvailableSeats"] + " guests";
            lblCap.Font = new Font("Segoe UI", 9.5f);
            lblCap.ForeColor = Color.DimGray;
            lblCap.Location = new Point(12, 262);
            lblCap.Size = new Size(260, 18);
            card.Controls.Add(lblCap);

            // ----- Price -----
            Label lblPrice = new Label();
            lblPrice.Text = "BDT " + Convert.ToDecimal(row["Price"]).ToString("N0");
            lblPrice.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(140, 70, 220);   // purple
            lblPrice.Location = new Point(12, 290);
            lblPrice.AutoSize = true;
            card.Controls.Add(lblPrice);

            // ----- Book Now button (gradient look using solid color) -----
            Button btnBook = new Button();
            btnBook.Text = "Book Now";
            btnBook.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnBook.Size = new Size(125, 38);
            btnBook.Location = new Point(12, 355);
            btnBook.BackColor = Color.FromArgb(80, 90, 230);
            btnBook.ForeColor = Color.White;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.Cursor = Cursors.Hand;
            btnBook.Click += (s, e) =>
            {
                int eId = Convert.ToInt32(row["EventID"]);
                new BookEventForm(eId).ShowDialog();
                LoadHallCards();
            };
            card.Controls.Add(btnBook);

            // ----- Reviews button -----
            Button btnReview = new Button();
            btnReview.Text = "Reviews";
            btnReview.Font = new Font("Segoe UI Semibold", 10);
            btnReview.Size = new Size(125, 38);
            btnReview.Location = new Point(143, 355);
            btnReview.BackColor = Color.White;
            btnReview.ForeColor = Color.FromArgb(80, 90, 230);
            btnReview.FlatStyle = FlatStyle.Flat;
            btnReview.FlatAppearance.BorderColor = Color.FromArgb(80, 90, 230);
            btnReview.Cursor = Cursors.Hand;
            btnReview.Click += (s, e) =>
            {
                int eId = Convert.ToInt32(row["EventID"]);
                new ReviewForm(eId).ShowDialog();
            };

            card.Controls.Add(btnReview);

            return card;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cat = cmbCategory.SelectedItem == null
                         ? "All" : cmbCategory.SelectedItem.ToString();
            LoadHallCards(txtSearch.Text.Trim(), cat);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbCategory.SelectedIndex = 0;
            LoadHallCards();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new BookingHistoryForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            User.CurrentUser = null;
            this.Close();
        }

        private void flowHalls_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}