namespace EventManagementSystem
{
    partial class BookingHistoryForm
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
            this.lblFilterLabel = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new EventManagementSystem.GradientButton();
            this.btnCompletePayment = new EventManagementSystem.GradientButton();
            this.btnWriteReview = new EventManagementSystem.GradientButton();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // Header
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1100, 90);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.lblTitle.AutoSize = true; this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 16);
            this.lblTitle.Text = "My Booking History";
            this.lblSubtitle.AutoSize = true; this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(28, 53);
            this.lblSubtitle.Text = "Pay pending bookings, cancel, or leave reviews";
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(110, 80, 220);
            this.btnClose.Location = new System.Drawing.Point(960, 27);
            this.btnClose.Size = new System.Drawing.Size(120, 38);
            this.btnClose.Text = "Back"; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Filter & buttons row
            this.lblFilterLabel.AutoSize = true;
            this.lblFilterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblFilterLabel.Location = new System.Drawing.Point(30, 115);
            this.lblFilterLabel.Text = "Filter:";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location = new System.Drawing.Point(85, 112);
            this.cmbStatus.Size = new System.Drawing.Size(150, 26);
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(245, 110);
            this.btnRefresh.Size = new System.Drawing.Size(110, 30);
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // COMPLETE PAYMENT (sky blue → green gradient – stands out)
            this.btnCompletePayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCompletePayment.ForeColor = System.Drawing.Color.White;
            this.btnCompletePayment.StartColor = System.Drawing.Color.FromArgb(40, 180, 130);
            this.btnCompletePayment.EndColor = System.Drawing.Color.FromArgb(33, 130, 220);
            this.btnCompletePayment.Location = new System.Drawing.Point(495, 110);
            this.btnCompletePayment.Size = new System.Drawing.Size(170, 30);
            this.btnCompletePayment.Text = "COMPLETE PAYMENT";
            this.btnCompletePayment.Click += new System.EventHandler(this.btnCompletePayment_Click);

            this.btnWriteReview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnWriteReview.ForeColor = System.Drawing.Color.White;
            this.btnWriteReview.StartColor = System.Drawing.Color.FromArgb(220, 80, 140);
            this.btnWriteReview.EndColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.btnWriteReview.Location = new System.Drawing.Point(675, 110);
            this.btnWriteReview.Size = new System.Drawing.Size(140, 30);
            this.btnWriteReview.Text = "WRITE REVIEW";
            this.btnWriteReview.Click += new System.EventHandler(this.btnWriteReview_Click);

            this.btnCancelBooking.BackColor = System.Drawing.Color.White;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 80, 80);
            this.btnCancelBooking.FlatAppearance.BorderSize = 1;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.FromArgb(220, 80, 80);
            this.btnCancelBooking.Location = new System.Drawing.Point(825, 110);
            this.btnCancelBooking.Size = new System.Drawing.Size(135, 30);
            this.btnCancelBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelBooking.Text = "CANCEL BOOKING";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);

            // DataGridView
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(110, 80, 220);
            this.dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHistory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvHistory.ColumnHeadersHeight = 40;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvHistory.Location = new System.Drawing.Point(30, 160);
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowTemplate.Height = 32;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(1050, 480);

            // Form
            this.BackColor = System.Drawing.Color.FromArgb(248, 246, 252);
            this.ClientSize = new System.Drawing.Size(1100, 670);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnWriteReview);
            this.Controls.Add(this.btnCompletePayment);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblFilterLabel);
            this.Controls.Add(this.pnlHeader);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None; 
            this.Name = "BookingHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "My Bookings";
            this.Load += new System.EventHandler(this.BookingHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilterLabel;
        private System.Windows.Forms.ComboBox cmbStatus;
        private EventManagementSystem.GradientButton btnRefresh;
        private EventManagementSystem.GradientButton btnCompletePayment;
        private EventManagementSystem.GradientButton btnWriteReview;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}