namespace EventManagementSystem
{
    partial class ManageUsersForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFormHeading = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnShowPwd = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new EventManagementSystem.GradientButton();
            this.btnUpdate = new EventManagementSystem.GradientButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTableHeading = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new EventManagementSystem.GradientButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1100, 90);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // lblTitle
            this.lblTitle.AutoSize = true; this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 16);
            this.lblTitle.Text = "Manage Users";
            // lblSubtitle
            this.lblSubtitle.AutoSize = true; this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(28, 53);
            this.lblSubtitle.Text = "Add, edit, or remove users from the system";
            // btnClose (top right)
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(110, 80, 220);
            this.btnClose.Location = new System.Drawing.Point(960, 27);
            this.btnClose.Size = new System.Drawing.Size(120, 38);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // lblFormHeading
            this.lblFormHeading.AutoSize = true;
            this.lblFormHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormHeading.ForeColor = System.Drawing.Color.FromArgb(40, 30, 90);
            this.lblFormHeading.Location = new System.Drawing.Point(35, 110);
            this.lblFormHeading.Text = "User Details";
            // lblName, txtName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblName.Location = new System.Drawing.Point(35, 145); this.lblName.Text = "FULL NAME";
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtName.Location = new System.Drawing.Point(35, 167);
            this.txtName.Size = new System.Drawing.Size(350, 26);
            // lblEmail, txtEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblEmail.Location = new System.Drawing.Point(35, 205); this.lblEmail.Text = "EMAIL";
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmail.Location = new System.Drawing.Point(35, 227);
            this.txtEmail.Size = new System.Drawing.Size(350, 26);
            // lblPassword, txtPassword, btnShowPwd
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblPassword.Location = new System.Drawing.Point(35, 265); this.lblPassword.Text = "PASSWORD";
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPassword.Location = new System.Drawing.Point(35, 287);
            this.txtPassword.Size = new System.Drawing.Size(305, 26);
            this.txtPassword.UseSystemPasswordChar = true;
            this.btnShowPwd.BackColor = System.Drawing.Color.White;
            this.btnShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPwd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.btnShowPwd.FlatAppearance.BorderSize = 1;
            this.btnShowPwd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            this.btnShowPwd.ForeColor = System.Drawing.Color.FromArgb(110, 80, 220);
            this.btnShowPwd.Location = new System.Drawing.Point(345, 287);
            this.btnShowPwd.Size = new System.Drawing.Size(40, 26);
            this.btnShowPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPwd.Text = "\uE7B3";
            this.btnShowPwd.UseVisualStyleBackColor = false;
            this.btnShowPwd.Click += new System.EventHandler(this.btnShowPwd_Click);
            // lblPhone, txtPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblPhone.Location = new System.Drawing.Point(35, 325); this.lblPhone.Text = "PHONE";
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPhone.Location = new System.Drawing.Point(35, 347);
            this.txtPhone.Size = new System.Drawing.Size(350, 26);
            // lblUserType, cmbUserType
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserType.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblUserType.Location = new System.Drawing.Point(35, 385); this.lblUserType.Text = "USER TYPE";
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbUserType.Location = new System.Drawing.Point(35, 407);
            this.cmbUserType.Size = new System.Drawing.Size(350, 27);
            // btnAdd (purple gradient)
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(35, 460);
            this.btnAdd.Size = new System.Drawing.Size(170, 40);
            this.btnAdd.Text = "ADD USER";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // btnUpdate (pink-purple gradient)
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.StartColor = System.Drawing.Color.FromArgb(220, 80, 140);
            this.btnUpdate.EndColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.btnUpdate.Location = new System.Drawing.Point(215, 460);
            this.btnUpdate.Size = new System.Drawing.Size(170, 40);
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // btnDelete (red outlined)
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 80, 80);
            this.btnDelete.FlatAppearance.BorderSize = 1;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(220, 80, 80);
            this.btnDelete.Location = new System.Drawing.Point(35, 510);
            this.btnDelete.Size = new System.Drawing.Size(170, 40);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // btnClear (gray outlined)
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.DimGray;
            this.btnClear.Location = new System.Drawing.Point(215, 510);
            this.btnClear.Size = new System.Drawing.Size(170, 40);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // lblTableHeading
            this.lblTableHeading.AutoSize = true;
            this.lblTableHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTableHeading.ForeColor = System.Drawing.Color.FromArgb(40, 30, 90);
            this.lblTableHeading.Location = new System.Drawing.Point(420, 110);
            this.lblTableHeading.Text = "All Users";
            // lblSearch, txtSearch, btnSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblSearch.Location = new System.Drawing.Point(420, 152);
            this.lblSearch.Text = "Search:";
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(485, 149);
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(745, 147);
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // dgvUsers
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(110, 80, 220);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvUsers.Location = new System.Drawing.Point(420, 200);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 32;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(660, 460);
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // ManageUsersForm
            this.BackColor = System.Drawing.Color.FromArgb(248, 246, 252);
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTableHeading);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnShowPwd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFormHeading);
            this.Controls.Add(this.pnlHeader);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            
            this.Name = "ManageUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFormHeading;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnShowPwd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private EventManagementSystem.GradientButton btnAdd;
        private EventManagementSystem.GradientButton btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTableHeading;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private EventManagementSystem.GradientButton btnSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}