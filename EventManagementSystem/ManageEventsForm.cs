using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventManagementSystem
{
    public partial class ManageEventsForm : Form
    {
        private DatabaseConnection db = new DatabaseConnection();
        private int selectedEventId = 0;

        public ManageEventsForm()
        {
            InitializeComponent();
        }

        private void ManageEventsForm_Load(object sender, EventArgs e)
        {
            LoadHalls();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(pnlHeader.ClientRectangle,
                Color.FromArgb(33, 110, 230), Color.FromArgb(140, 70, 220),
                LinearGradientMode.Horizontal))
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
        }

        private void LoadHalls(string keyword = "")
        {
            string sql; SqlParameter[] prms;

            // Admin sees only own halls; SuperAdmin sees all
            if (User.CurrentUser != null && User.CurrentUser.UserType == "Admin")
            {
                sql = @"SELECT EventID AS [ID], EventName AS [Hall], Location, Price,
                               AvailableSeats AS [Capacity], Category, EventDate AS [Date],
                               ISNULL(ImagePath,'-') AS [Image]
                        FROM Events
                        WHERE OrganizerID=@id
                          AND (@k='' OR EventName LIKE '%'+@k+'%' OR Location LIKE '%'+@k+'%')
                        ORDER BY EventID";
                prms = new SqlParameter[]
                {
                    new SqlParameter("@id", User.CurrentUser.UserID),
                    new SqlParameter("@k",  keyword ?? "")
                };
            }
            else
            {
                sql = @"SELECT EventID AS [ID], EventName AS [Hall], Location, Price,
                               AvailableSeats AS [Capacity], Category, EventDate AS [Date],
                               ISNULL(ImagePath,'-') AS [Image]
                        FROM Events
                        WHERE (@k='' OR EventName LIKE '%'+@k+'%' OR Location LIKE '%'+@k+'%')
                        ORDER BY EventID";
                prms = new SqlParameter[] { new SqlParameter("@k", keyword ?? "") };
            }
            dgvHalls.DataSource = db.ExecuteQuery(sql, prms);
        }

        private void dgvHalls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedEventId = Convert.ToInt32(dgvHalls.Rows[e.RowIndex].Cells["ID"].Value);

            DataTable dt = db.ExecuteQuery("SELECT * FROM Events WHERE EventID=@id",
                new SqlParameter[] { new SqlParameter("@id", selectedEventId) });
            if (dt.Rows.Count == 0) return;
            DataRow r = dt.Rows[0];

            txtName.Text = r["EventName"].ToString();
            txtDesc.Text = r["Description"] == DBNull.Value ? "" : r["Description"].ToString();
            txtLocation.Text = r["Location"].ToString();
            txtPrice.Text = r["Price"].ToString();
            txtCapacity.Text = r["AvailableSeats"].ToString();
            txtCategory.Text = r["Category"] == DBNull.Value ? "" : r["Category"].ToString();
            dtpDate.Value = Convert.ToDateTime(r["EventDate"]);
            txtImagePath.Text = r["ImagePath"] == DBNull.Value ? "" : r["ImagePath"].ToString();
            ShowPreview();
        }

        private void ShowPreview()
        {
            picPreview.Image = null;
            if (string.IsNullOrEmpty(txtImagePath.Text)) return;
            string fullPath = Path.Combine(Application.StartupPath, txtImagePath.Text);
            if (File.Exists(fullPath))
            {
                try { picPreview.Image = Image.FromFile(fullPath); } catch { }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                string imagesDir = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(imagesDir)) Directory.CreateDirectory(imagesDir);
                string fileName = Path.GetFileName(ofd.FileName);
                string destPath = Path.Combine(imagesDir, fileName);
                if (!ofd.FileName.Equals(destPath, StringComparison.OrdinalIgnoreCase))
                {
                    try { File.Copy(ofd.FileName, destPath, true); }
                    catch (Exception ex) { MessageBox.Show("Copy failed: " + ex.Message); return; }
                }
                txtImagePath.Text = "Images/" + fileName;
                ShowPreview();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text))
            { MessageBox.Show("Hall name and location are required."); return false; }
            decimal price; int cap;
            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            { MessageBox.Show("Invalid price."); return false; }
            if (!int.TryParse(txtCapacity.Text, out cap) || cap < 0)
            { MessageBox.Show("Invalid capacity."); return false; }
            return true;
        }

        private SqlParameter[] BuildParams(bool includeId)
        {
            int organizerId = (User.CurrentUser != null && User.CurrentUser.UserType == "Admin")
                              ? User.CurrentUser.UserID : 1;
            var list = new System.Collections.Generic.List<SqlParameter>
            {
                new SqlParameter("@n",  txtName.Text.Trim()),
                new SqlParameter("@d",  string.IsNullOrWhiteSpace(txtDesc.Text) ? (object)DBNull.Value : txtDesc.Text.Trim()),
                new SqlParameter("@dt", dtpDate.Value),
                new SqlParameter("@l",  txtLocation.Text.Trim()),
                new SqlParameter("@pr", decimal.Parse(txtPrice.Text, CultureInfo.InvariantCulture)),
                new SqlParameter("@cap",int.Parse(txtCapacity.Text)),
                new SqlParameter("@c",  string.IsNullOrWhiteSpace(txtCategory.Text) ? (object)DBNull.Value : txtCategory.Text.Trim()),
                new SqlParameter("@img",string.IsNullOrWhiteSpace(txtImagePath.Text) ? (object)DBNull.Value : txtImagePath.Text.Trim()),
                new SqlParameter("@o",  organizerId)
            };
            if (includeId) list.Add(new SqlParameter("@id", selectedEventId));
            return list.ToArray();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                // Check if a hall with the same name already exists for this organizer
                int organizerId = (User.CurrentUser != null && User.CurrentUser.UserType == "Admin")
                                  ? User.CurrentUser.UserID : 1;

                object exists = db.ExecuteScalar(
                    "SELECT COUNT(*) FROM Events WHERE EventName=@n AND OrganizerID=@o",
                    new SqlParameter[]
                    {
                new SqlParameter("@n", txtName.Text.Trim()),
                new SqlParameter("@o", organizerId)
                    });

                if (Convert.ToInt32(exists) > 0)
                {
                    MessageBox.Show("A hall named \"" + txtName.Text.Trim() + "\" already exists.\n" +
                                    "Please use a different name, or click on the existing row in the table " +
                                    "and click UPDATE if you want to edit it.",
                        "Duplicate hall name",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // No duplicate — go ahead and insert
                db.ExecuteNonQuery(
                    @"INSERT INTO Events
              (EventName, Description, EventDate, Location, Price, AvailableSeats, Category, ImagePath, OrganizerID)
              VALUES (@n,@d,@dt,@l,@pr,@cap,@c,@img,@o)",
                    BuildParams(false));

                MessageBox.Show("Hall added successfully!", "Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHalls();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEventId == 0) { MessageBox.Show("Select a hall first."); return; }
            if (!ValidateInputs()) return;
            try
            {
                int organizerId = (User.CurrentUser != null && User.CurrentUser.UserType == "Admin")
                                  ? User.CurrentUser.UserID : 1;

                // Check if another hall (different ID) already has this name
                object exists = db.ExecuteScalar(
                    "SELECT COUNT(*) FROM Events WHERE EventName=@n AND OrganizerID=@o AND EventID<>@id",
                    new SqlParameter[]
                    {
                new SqlParameter("@n",  txtName.Text.Trim()),
                new SqlParameter("@o",  organizerId),
                new SqlParameter("@id", selectedEventId)
                    });

                if (Convert.ToInt32(exists) > 0)
                {
                    MessageBox.Show("Another hall already uses this name. Choose a different one.",
                        "Duplicate name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.ExecuteNonQuery(
                    @"UPDATE Events
              SET EventName=@n, Description=@d, EventDate=@dt, Location=@l,
                  Price=@pr, AvailableSeats=@cap, Category=@c, ImagePath=@img
              WHERE EventID=@id",
                    BuildParams(true));
                MessageBox.Show("Hall updated.");
                LoadHalls();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEventId == 0) { MessageBox.Show("Select a hall first."); return; }
            if (MessageBox.Show("Delete this hall?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                db.ExecuteNonQuery("DELETE FROM Events WHERE EventID=@id",
                    new SqlParameter[] { new SqlParameter("@id", selectedEventId) });
                MessageBox.Show("Deleted.");
                LoadHalls();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message + "\n(Hall may have related bookings.)"); }
        }

        private void btnSearch_Click(object sender, EventArgs e) { LoadHalls(txtSearch.Text.Trim()); }
        private void btnClear_Click(object sender, EventArgs e) { ClearForm(); }
        private void btnClose_Click(object sender, EventArgs e) { this.Close(); }

        private void ClearForm()
        {
            selectedEventId = 0;
            txtName.Clear(); txtDesc.Clear(); txtLocation.Clear();
            txtPrice.Clear(); txtCapacity.Clear(); txtCategory.Clear();
            txtImagePath.Clear();
            picPreview.Image = null;
            dtpDate.Value = DateTime.Now;
        }

        private void dgvHalls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}