using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class LoginForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();

        private const int CardX = 100;
        private const int CardY = 150;
        private const int CardW = 800;
        private const int CardH = 400;

        public LoginForm()
        {
            InitializeComponent();
            LoadBackground();
            this.DoubleBuffered = true;
        }

        private void LoadBackground()
        {
            string path = Path.Combine(Application.StartupPath, "Images", "login_bg.jpg");
            if (File.Exists(path))
            {
                this.BackgroundImage = Image.FromFile(path);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle card = new Rectangle(CardX, CardY, CardW, CardH);

            using (var brush = new LinearGradientBrush(card,
                Color.FromArgb(210, 200, 220, 250),
                Color.FromArgb(210, 230, 215, 250),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, card);
            }

            using (var brush = new LinearGradientBrush(
                new Rectangle(CardX, CardY, CardW, 5),
                Color.FromArgb(93, 173, 226),
                Color.FromArgb(134, 87, 220),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, CardX, CardY, CardW, 5);
            }

            using (var pen = new Pen(Color.FromArgb(70, 134, 87, 220), 1))
                e.Graphics.DrawLine(pen, CardX + 400, CardY + 80, CardX + 400, CardY + CardH - 80);

            using (var pen = new Pen(Color.FromArgb(120, 134, 87, 220), 1))
                e.Graphics.DrawRectangle(pen, card);
        }

        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnShowPwd.Text = txtPassword.UseSystemPasswordChar ? "\uE7B3" : "\uED1A";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both Email and Password.",
                    "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = "SELECT * FROM Users WHERE Email=@e AND Password=@p";
                SqlParameter[] p = new SqlParameter[]
                {
                    new SqlParameter("@e", txtEmail.Text.Trim()),
                    new SqlParameter("@p", txtPassword.Text.Trim())
                };

                DataTable dt = db.ExecuteQuery(sql, p);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid email or password.",
                        "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow row = dt.Rows[0];
                string type = row["UserType"].ToString();

                User user;
                switch (type)
                {
                    case "SuperAdmin": user = new SuperAdmin(); break;
                    case "Admin": user = new Admin(); break;
                    default: user = new Customer(); break;
                }
                user.UserID = Convert.ToInt32(row["UserID"]);
                user.FullName = row["FullName"].ToString();
                user.Email = row["Email"].ToString();
                user.Password = row["Password"].ToString();
                user.Phone = row["Phone"] == DBNull.Value ? "" : row["Phone"].ToString();

                User.CurrentUser = user;

                if (user is Customer)
                {
                    this.Hide();
                    new CustomerDashboardForm().ShowDialog();
                    this.Show();
                }
                else if (user is Admin)
                {
                    this.Hide();
                    new AdminDashboardForm().ShowDialog();
                    this.Show();
                }
                else if (user is SuperAdmin)
                {
                    this.Hide();
                    new SuperAdminDashboardForm().ShowDialog();
                    this.Show();
                }

                txtEmail.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}