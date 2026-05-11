namespace EventManagementSystem
{
    partial class SuperAdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlStat1 = new System.Windows.Forms.Panel();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.lblNumUsers = new System.Windows.Forms.Label();
            this.pnlStat2 = new System.Windows.Forms.Panel();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.lblNumHalls = new System.Windows.Forms.Label();
            this.pnlStat3 = new System.Windows.Forms.Panel();
            this.lblStat3 = new System.Windows.Forms.Label();
            this.lblNumBookings = new System.Windows.Forms.Label();
            this.pnlStat4 = new System.Windows.Forms.Panel();
            this.lblStat4 = new System.Windows.Forms.Label();
            this.lblNumEarnings = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.btnManageUsers = new EventManagementSystem.GradientButton();
            this.btnManageHalls = new EventManagementSystem.GradientButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlStat1.SuspendLayout();
            this.pnlStat2.SuspendLayout();
            this.pnlStat3.SuspendLayout();
            this.pnlStat4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 90);
            this.pnlHeader.TabIndex = 9;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(28, 53);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(582, 37);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Super Admin Dashboard - full platform overview";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(220)))));
            this.btnLogout.Location = new System.Drawing.Point(960, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 38);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlStat1
            // 
            this.pnlStat1.BackColor = System.Drawing.Color.White;
            this.pnlStat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat1.Controls.Add(this.lblStat1);
            this.pnlStat1.Controls.Add(this.lblNumUsers);
            this.pnlStat1.Location = new System.Drawing.Point(30, 115);
            this.pnlStat1.Name = "pnlStat1";
            this.pnlStat1.Size = new System.Drawing.Size(250, 110);
            this.pnlStat1.TabIndex = 8;
            this.pnlStat1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStat1_Paint);
            // 
            // lblStat1
            // 
            this.lblStat1.AutoSize = true;
            this.lblStat1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStat1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.lblStat1.Location = new System.Drawing.Point(20, 18);
            this.lblStat1.Name = "lblStat1";
            this.lblStat1.Size = new System.Drawing.Size(181, 37);
            this.lblStat1.TabIndex = 0;
            this.lblStat1.Text = "TOTAL USERS";
            // 
            // lblNumUsers
            // 
            this.lblNumUsers.AutoSize = true;
            this.lblNumUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.lblNumUsers.Location = new System.Drawing.Point(15, 45);
            this.lblNumUsers.Name = "lblNumUsers";
            this.lblNumUsers.Size = new System.Drawing.Size(84, 100);
            this.lblNumUsers.TabIndex = 1;
            this.lblNumUsers.Text = "0";
            // 
            // pnlStat2
            // 
            this.pnlStat2.BackColor = System.Drawing.Color.White;
            this.pnlStat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat2.Controls.Add(this.lblStat2);
            this.pnlStat2.Controls.Add(this.lblNumHalls);
            this.pnlStat2.Location = new System.Drawing.Point(295, 115);
            this.pnlStat2.Name = "pnlStat2";
            this.pnlStat2.Size = new System.Drawing.Size(250, 110);
            this.pnlStat2.TabIndex = 7;
            this.pnlStat2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStat2_Paint);
            // 
            // lblStat2
            // 
            this.lblStat2.AutoSize = true;
            this.lblStat2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStat2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.lblStat2.Location = new System.Drawing.Point(20, 18);
            this.lblStat2.Name = "lblStat2";
            this.lblStat2.Size = new System.Drawing.Size(180, 37);
            this.lblStat2.TabIndex = 0;
            this.lblStat2.Text = "TOTAL HALLS";
            // 
            // lblNumHalls
            // 
            this.lblNumHalls.AutoSize = true;
            this.lblNumHalls.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumHalls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.lblNumHalls.Location = new System.Drawing.Point(15, 45);
            this.lblNumHalls.Name = "lblNumHalls";
            this.lblNumHalls.Size = new System.Drawing.Size(84, 100);
            this.lblNumHalls.TabIndex = 1;
            this.lblNumHalls.Text = "0";
            // 
            // pnlStat3
            // 
            this.pnlStat3.BackColor = System.Drawing.Color.White;
            this.pnlStat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat3.Controls.Add(this.lblStat3);
            this.pnlStat3.Controls.Add(this.lblNumBookings);
            this.pnlStat3.Location = new System.Drawing.Point(560, 115);
            this.pnlStat3.Name = "pnlStat3";
            this.pnlStat3.Size = new System.Drawing.Size(250, 110);
            this.pnlStat3.TabIndex = 6;
            this.pnlStat3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStat3_Paint);
            // 
            // lblStat3
            // 
            this.lblStat3.AutoSize = true;
            this.lblStat3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStat3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.lblStat3.Location = new System.Drawing.Point(20, 18);
            this.lblStat3.Name = "lblStat3";
            this.lblStat3.Size = new System.Drawing.Size(237, 37);
            this.lblStat3.TabIndex = 0;
            this.lblStat3.Text = "TOTAL BOOKINGS";
            // 
            // lblNumBookings
            // 
            this.lblNumBookings.AutoSize = true;
            this.lblNumBookings.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.lblNumBookings.Location = new System.Drawing.Point(15, 45);
            this.lblNumBookings.Name = "lblNumBookings";
            this.lblNumBookings.Size = new System.Drawing.Size(84, 100);
            this.lblNumBookings.TabIndex = 1;
            this.lblNumBookings.Text = "0";
            // 
            // pnlStat4
            // 
            this.pnlStat4.BackColor = System.Drawing.Color.White;
            this.pnlStat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat4.Controls.Add(this.lblStat4);
            this.pnlStat4.Controls.Add(this.lblNumEarnings);
            this.pnlStat4.Location = new System.Drawing.Point(825, 115);
            this.pnlStat4.Name = "pnlStat4";
            this.pnlStat4.Size = new System.Drawing.Size(250, 110);
            this.pnlStat4.TabIndex = 5;
            this.pnlStat4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStat4_Paint);
            // 
            // lblStat4
            // 
            this.lblStat4.AutoSize = true;
            this.lblStat4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStat4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.lblStat4.Location = new System.Drawing.Point(20, 18);
            this.lblStat4.Name = "lblStat4";
            this.lblStat4.Size = new System.Drawing.Size(234, 37);
            this.lblStat4.TabIndex = 0;
            this.lblStat4.Text = "TOTAL EARNINGS";
            // 
            // lblNumEarnings
            // 
            this.lblNumEarnings.AutoSize = true;
            this.lblNumEarnings.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumEarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(130)))));
            this.lblNumEarnings.Location = new System.Drawing.Point(15, 55);
            this.lblNumEarnings.Name = "lblNumEarnings";
            this.lblNumEarnings.Size = new System.Drawing.Size(155, 65);
            this.lblNumEarnings.TabIndex = 1;
            this.lblNumEarnings.Text = "BDT 0";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.lblHeading.Location = new System.Drawing.Point(30, 250);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(466, 45);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "Recent Activity Across All Halls";
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivity.ColumnHeadersHeight = 40;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActivity.EnableHeadersVisualStyles = false;
            this.dgvActivity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvActivity.Location = new System.Drawing.Point(30, 285);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.RowHeadersVisible = false;
            this.dgvActivity.RowHeadersWidth = 82;
            this.dgvActivity.RowTemplate.Height = 32;
            this.dgvActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivity.Size = new System.Drawing.Size(1040, 320);
            this.dgvActivity.TabIndex = 3;
            this.dgvActivity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellContentClick);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.CornerRadius = 0;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(30, 625);
            this.btnManageUsers.Mode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(190, 42);
            this.btnManageUsers.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "MANAGE USERS";
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageHalls
            // 
            this.btnManageHalls.CornerRadius = 0;
            this.btnManageHalls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageHalls.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.btnManageHalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageHalls.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageHalls.ForeColor = System.Drawing.Color.White;
            this.btnManageHalls.Location = new System.Drawing.Point(235, 625);
            this.btnManageHalls.Mode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnManageHalls.Name = "btnManageHalls";
            this.btnManageHalls.Size = new System.Drawing.Size(190, 42);
            this.btnManageHalls.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.btnManageHalls.TabIndex = 1;
            this.btnManageHalls.Text = "MANAGE HALLS";
            this.btnManageHalls.Click += new System.EventHandler(this.btnManageHalls_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.btnRefresh.Location = new System.Drawing.Point(440, 625);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 42);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SuperAdminDashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnManageHalls);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.dgvActivity);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pnlStat4);
            this.Controls.Add(this.pnlStat3);
            this.Controls.Add(this.pnlStat2);
            this.Controls.Add(this.pnlStat1);
            this.Controls.Add(this.pnlHeader);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
             
            this.Name = "SuperAdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Super Admin Dashboard";
            this.Load += new System.EventHandler(this.SuperAdminDashboardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStat1.ResumeLayout(false);
            this.pnlStat1.PerformLayout();
            this.pnlStat2.ResumeLayout(false);
            this.pnlStat2.PerformLayout();
            this.pnlStat3.ResumeLayout(false);
            this.pnlStat3.PerformLayout();
            this.pnlStat4.ResumeLayout(false);
            this.pnlStat4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStat1;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Label lblNumUsers;
        private System.Windows.Forms.Panel pnlStat2;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label lblNumHalls;
        private System.Windows.Forms.Panel pnlStat3;
        private System.Windows.Forms.Label lblStat3;
        private System.Windows.Forms.Label lblNumBookings;
        private System.Windows.Forms.Panel pnlStat4;
        private System.Windows.Forms.Label lblStat4;
        private System.Windows.Forms.Label lblNumEarnings;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dgvActivity;
        private EventManagementSystem.GradientButton btnManageUsers;
        private EventManagementSystem.GradientButton btnManageHalls;
        private System.Windows.Forms.Button btnRefresh;
    }
}