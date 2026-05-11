using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class RegisterForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();
        private const int CardX = 100, CardY = 80, CardW = 800, CardH = 540;

        public RegisterForm()
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
                e.Graphics.FillRectangle(brush, card);
            using (var brush = new LinearGradientBrush(
                new Rectangle(CardX, CardY, CardW, 5),
                Color.FromArgb(93, 173, 226), Color.FromArgb(134, 87, 220),
                LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(brush, CardX, CardY, CardW, 5);
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

        private void btnShowConfirm_Click(object sender, EventArgs e)
        {
            txtConfirm.UseSystemPasswordChar = !txtConfirm.UseSystemPasswordChar;
            btnShowConfirm.Text = txtConfirm.UseSystemPasswordChar ? "\uE7B3" : "\uED1A";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirm.Text) ||
                    cmbUserType.SelectedItem == null)
                { MessageBox.Show("Please fill in all required fields.", "Validation"); return; }

                if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                { MessageBox.Show("Please enter a valid email address."); return; }

                if (txtPassword.Text != txtConfirm.Text)
                { MessageBox.Show("Passwords do not match."); return; }

                if (txtPassword.Text.Length < 4)
                { MessageBox.Show("Password must be at least 4 characters."); return; }

                object exists = db.ExecuteScalar("SELECT COUNT(*) FROM Users WHERE Email=@e",
                    new SqlParameter[] { new SqlParameter("@e", txtEmail.Text.Trim()) });
                if (Convert.ToInt32(exists) > 0)
                { MessageBox.Show("This email is already registered."); return; }

                int rows = db.ExecuteNonQuery(
                    @"INSERT INTO Users (FullName, Email, Password, Phone, UserType)
                      VALUES (@n, @e, @p, @ph, @t)",
                    new SqlParameter[]
                    {
                        new SqlParameter("@n",  txtName.Text.Trim()),
                        new SqlParameter("@e",  txtEmail.Text.Trim()),
                        new SqlParameter("@p",  txtPassword.Text.Trim()),
                        new SqlParameter("@ph", string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text.Trim()),
                        new SqlParameter("@t",  cmbUserType.SelectedItem.ToString())
                    });
                if (rows > 0)
                {
                    MessageBox.Show("Registration successful! You can now log in.", "Success");
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }
    }
}