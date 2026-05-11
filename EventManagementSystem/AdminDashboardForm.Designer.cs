namespace EventManagementSystem
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlStatEvents = new System.Windows.Forms.Panel();
            this.lblStatEventsTitle = new System.Windows.Forms.Label();
            this.lblNumEvents = new System.Windows.Forms.Label();
            this.pnlStatBookings = new System.Windows.Forms.Panel();
            this.lblStatBookingsTitle = new System.Windows.Forms.Label();
            this.lblNumBookings = new System.Windows.Forms.Label();
            this.pnlStatEarnings = new System.Windows.Forms.Panel();
            this.lblStatEarningsTitle = new System.Windows.Forms.Label();
            this.lblNumEarnings = new System.Windows.Forms.Label();
            this.lblBookingsHeading = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.btnManageEvents = new EventManagementSystem.GradientButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnApprove = new EventManagementSystem.GradientButton();
            this.btnReject = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlStatEvents.SuspendLayout();
            this.pnlStatBookings.SuspendLayout();
            this.pnlStatEarnings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
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
            this.lblSubtitle.Size = new System.Drawing.Size(765, 37);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Hall Owner Dashboard - manage your events, approve bookings";
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
            // pnlStatEvents
            // 
            this.pnlStatEvents.BackColor = System.Drawing.Color.White;
            this.pnlStatEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatEvents.Controls.Add(this.lblStatEventsTitle);
            this.pnlStatEvents.Controls.Add(this.lblNumEvents);
            this.pnlStatEvents.Location = new System.Drawing.Point(30, 115);
            this.pnlStatEvents.Name = "pnlStatEvents";
            this.pnlStatEvents.Size = new System.Drawing.Size(330, 110);
            this.pnlStatEvents.TabIndex = 8;
            this.pnlStatEvents.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatEvents_Paint);
            // 
            // lblStatEventsTitle
            // 
            this.lblStatEventsTitle.AutoSize = true;
            this.lblStatEventsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatEventsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.lblStatEventsTitle.Location = new System.Drawing.Point(25, 18);
            this.lblStatEventsTitle.Name = "lblStatEventsTitle";
            this.lblStatEventsTitle.Size = new System.Drawing.Size(144, 37);
            this.lblStatEventsTitle.TabIndex = 0;
            this.lblStatEventsTitle.Text = "MY HALLS";
            // 
            // lblNumEvents
            // 
            this.lblNumEvents.AutoSize = true;
            this.lblNumEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.lblNumEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.lblNumEvents.Location = new System.Drawing.Point(20, 45);
            this.lblNumEvents.Name = "lblNumEvents";
            this.lblNumEvents.Size = new System.Drawing.Size(89, 106);
            this.lblNumEvents.TabIndex = 1;
            this.lblNumEvents.Text = "0";
            // 
            // pnlStatBookings
            // 
            this.pnlStatBookings.BackColor = System.Drawing.Color.White;
            this.pnlStatBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatBookings.Controls.Add(this.lblStatBookingsTitle);
            this.pnlStatBookings.Controls.Add(this.lblNumBookings);
            this.pnlStatBookings.Location = new System.Drawing.Point(385, 115);
            this.pnlStatBookings.Name = "pnlStatBookings";
            this.pnlStatBookings.Size = new System.Drawing.Size(330, 110);
            this.pnlStatBookings.TabIndex = 7;
            this.pnlStatBookings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatBookings_Paint);
            // 
            // lblStatBookingsTitle
            // 
            this.lblStatBookingsTitle.AutoSize = true;
            this.lblStatBookingsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.lblStatBookingsTitle.Location = new System.Drawing.Point(25, 18);
            this.lblStatBookingsTitle.Name = "lblStatBookingsTitle";
            this.lblStatBookingsTitle.Size = new System.Drawing.Size(237, 37);
            this.lblStatBookingsTitle.TabIndex = 0;
            this.lblStatBookingsTitle.Text = "TOTAL BOOKINGS";
            // 
            // lblNumBookings
            // 
            this.lblNumBookings.AutoSize = true;
            this.lblNumBookings.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.lblNumBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.lblNumBookings.Location = new System.Drawing.Point(20, 45);
            this.lblNumBookings.Name = "lblNumBookings";
            this.lblNumBookings.Size = new System.Drawing.Size(89, 106);
            this.lblNumBookings.TabIndex = 1;
            this.lblNumBookings.Text = "0";
            // 
            // pnlStatEarnings
            // 
            this.pnlStatEarnings.BackColor = System.Drawing.Color.White;
            this.pnlStatEarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatEarnings.Controls.Add(this.lblStatEarningsTitle);
            this.pnlStatEarnings.Controls.Add(this.lblNumEarnings);
            this.pnlStatEarnings.Location = new System.Drawing.Point(740, 115);
            this.pnlStatEarnings.Name = "pnlStatEarnings";
            this.pnlStatEarnings.Size = new System.Drawing.Size(330, 110);
            this.pnlStatEarnings.TabIndex = 6;
            this.pnlStatEarnings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatEarnings_Paint);
            // 
            // lblStatEarningsTitle
            // 
            this.lblStatEarningsTitle.AutoSize = true;
            this.lblStatEarningsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatEarningsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.lblStatEarningsTitle.Location = new System.Drawing.Point(25, 18);
            this.lblStatEarningsTitle.Name = "lblStatEarningsTitle";
            this.lblStatEarningsTitle.Size = new System.Drawing.Size(234, 37);
            this.lblStatEarningsTitle.TabIndex = 0;
            this.lblStatEarningsTitle.Text = "TOTAL EARNINGS";
            // 
            // lblNumEarnings
            // 
            this.lblNumEarnings.AutoSize = true;
            this.lblNumEarnings.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumEarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(130)))));
            this.lblNumEarnings.Location = new System.Drawing.Point(20, 50);
            this.lblNumEarnings.Name = "lblNumEarnings";
            this.lblNumEarnings.Size = new System.Drawing.Size(191, 78);
            this.lblNumEarnings.TabIndex = 1;
            this.lblNumEarnings.Text = "BDT 0";
            // 
            // lblBookingsHeading
            // 
            this.lblBookingsHeading.AutoSize = true;
            this.lblBookingsHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookingsHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.lblBookingsHeading.Location = new System.Drawing.Point(30, 250);
            this.lblBookingsHeading.Name = "lblBookingsHeading";
            this.lblBookingsHeading.Size = new System.Drawing.Size(444, 45);
            this.lblBookingsHeading.TabIndex = 5;
            this.lblBookingsHeading.Text = "Recent Bookings on My Halls";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.ColumnHeadersHeight = 40;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookings.EnableHeadersVisualStyles = false;
            this.dgvBookings.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvBookings.Location = new System.Drawing.Point(30, 285);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.RowHeadersWidth = 82;
            this.dgvBookings.RowTemplate.Height = 32;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1040, 320);
            this.dgvBookings.TabIndex = 4;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // btnManageEvents
            // 
            this.btnManageEvents.CornerRadius = 0;
            this.btnManageEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEvents.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.btnManageEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageEvents.ForeColor = System.Drawing.Color.White;
            this.btnManageEvents.Location = new System.Drawing.Point(30, 625);
            this.btnManageEvents.Mode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnManageEvents.Name = "btnManageEvents";
            this.btnManageEvents.Size = new System.Drawing.Size(180, 42);
            this.btnManageEvents.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnManageEvents.TabIndex = 3;
            this.btnManageEvents.Text = "MANAGE MY HALLS";
            this.btnManageEvents.Click += new System.EventHandler(this.btnManageEvents_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(220)))));
            this.btnRefresh.Location = new System.Drawing.Point(225, 625);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 42);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.CornerRadius = 0;
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(380, 625);
            this.btnApprove.Mode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(180, 42);
            this.btnApprove.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(130)))));
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "APPROVE BOOKING";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.White;
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReject.Location = new System.Drawing.Point(575, 625);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(160, 42);
            this.btnReject.TabIndex = 0;
            this.btnReject.Text = "REJECT BOOKING";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // AdminDashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnManageEvents);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.lblBookingsHeading);
            this.Controls.Add(this.pnlStatEarnings);
            this.Controls.Add(this.pnlStatBookings);
            this.Controls.Add(this.pnlStatEvents);
            this.Controls.Add(this.pnlHeader);
           
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall Owner Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStatEvents.ResumeLayout(false);
            this.pnlStatEvents.PerformLayout();
            this.pnlStatBookings.ResumeLayout(false);
            this.pnlStatBookings.PerformLayout();
            this.pnlStatEarnings.ResumeLayout(false);
            this.pnlStatEarnings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStatEvents;
        private System.Windows.Forms.Label lblStatEventsTitle;
        private System.Windows.Forms.Label lblNumEvents;
        private System.Windows.Forms.Panel pnlStatBookings;
        private System.Windows.Forms.Label lblStatBookingsTitle;
        private System.Windows.Forms.Label lblNumBookings;
        private System.Windows.Forms.Panel pnlStatEarnings;
        private System.Windows.Forms.Label lblStatEarningsTitle;
        private System.Windows.Forms.Label lblNumEarnings;
        private System.Windows.Forms.Label lblBookingsHeading;
        private System.Windows.Forms.DataGridView dgvBookings;
        private EventManagementSystem.GradientButton btnManageEvents;
        private System.Windows.Forms.Button btnRefresh;
        private EventManagementSystem.GradientButton btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}