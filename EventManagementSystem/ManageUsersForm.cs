using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventManagementSystem
{
    public partial class ManageUsersForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();
        private int selectedUserId = 0;

        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            cmbUserType.Items.Clear();
            cmbUserType.Items.AddRange(new object[] { "SuperAdmin", "Admin", "Customer" });
            cmbUserType.SelectedIndex = 2;
            LoadUsers();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230), Color.FromArgb(140, 70, 220),
                LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
        }

        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnShowPwd.Text = txtPassword.UseSystemPasswordChar ? "\uE7B3" : "\uED1A";
        }

        private void LoadUsers(string keyword = "")
        {
            string sql = @"SELECT UserID AS [ID], FullName AS [Full Name], Email,
                                  ISNULL(Phone,'-') AS [Phone], UserType AS [Type],
                                  CreatedDate AS [Joined]
                           FROM Users
                           WHERE (@k='' OR FullName LIKE '%'+@k+'%' OR Email LIKE '%'+@k+'%')
                           ORDER BY UserID";
            dgvUsers.DataSource = db.ExecuteQuery(sql,
                new SqlParameter[] { new SqlParameter("@k", keyword ?? "") });
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvUsers.Rows[e.RowIndex];
            selectedUserId = Convert.ToInt32(r.Cells["ID"].Value);

            // Pull full record
            DataTable dt = db.ExecuteQuery("SELECT * FROM Users WHERE UserID=@id",
                new SqlParameter[] { new SqlParameter("@id", selectedUserId) });
            if (dt.Rows.Count == 0) return;
            DataRow row = dt.Rows[0];

            txtName.Text = row["FullName"].ToString();
            txtEmail.Text = row["Email"].ToString();
            txtPassword.Text = row["Password"].ToString();
            txtPhone.Text = row["Phone"] == DBNull.Value ? "" : row["Phone"].ToString();
            cmbUserType.SelectedItem = row["UserType"].ToString();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbUserType.SelectedItem == null)
            { MessageBox.Show("Please fill all required fields."); return false; }
            if (!txtEmail.Text.Contains("@"))
            { MessageBox.Show("Invalid email."); return false; }
            return true;
        }

        private SqlParameter[] BuildParams(bool includeId = false)
        {
            var list = new System.Collections.Generic.List<SqlParameter>
            {
                new SqlParameter("@n",  txtName.Text.Trim()),
                new SqlParameter("@e",  txtEmail.Text.Trim()),
                new SqlParameter("@p",  txtPassword.Text.Trim()),
                new SqlParameter("@ph", string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text.Trim()),
                new SqlParameter("@t",  cmbUserType.SelectedItem.ToString())
            };
            if (includeId) list.Add(new SqlParameter("@id", selectedUserId));
            return list.ToArray();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                db.ExecuteNonQuery(
                    @"INSERT INTO Users (FullName, Email, Password, Phone, UserType)
                      VALUES (@n,@e,@p,@ph,@t)", BuildParams());
                MessageBox.Show("User added.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) { MessageBox.Show("Select a user first."); return; }
            if (!ValidateInputs()) return;
            try
            {
                db.ExecuteNonQuery(
                    @"UPDATE Users SET FullName=@n, Email=@e, Password=@p, Phone=@ph, UserType=@t
                      WHERE UserID=@id", BuildParams(true));
                MessageBox.Show("User updated.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) { MessageBox.Show("Select a user first."); return; }
            if (selectedUserId == User.CurrentUser.UserID)
            { MessageBox.Show("You cannot delete your own account."); return; }
            if (MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                db.ExecuteNonQuery("DELETE FROM Users WHERE UserID=@id",
                    new SqlParameter[] { new SqlParameter("@id", selectedUserId) });
                MessageBox.Show("User deleted.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message + "\n(They may have related bookings.)"); }
        }

        private void btnSearch_Click(object sender, EventArgs e) { LoadUsers(txtSearch.Text.Trim()); }
        private void btnClear_Click(object sender, EventArgs e) { ClearForm(); }
        private void btnClose_Click(object sender, EventArgs e) { this.Close(); }

        private void ClearForm()
        {
            selectedUserId = 0;
            txtName.Clear(); txtEmail.Clear(); txtPassword.Clear(); txtPhone.Clear();
            cmbUserType.SelectedIndex = 2;
        }
    }
}