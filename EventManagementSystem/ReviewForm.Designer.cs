namespace EventManagementSystem
{
    partial class ReviewForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHallName = new System.Windows.Forms.Label();
            this.lblRateLabel = new System.Windows.Forms.Label();
            this.btnStar1 = new System.Windows.Forms.Button();
            this.btnStar2 = new System.Windows.Forms.Button();
            this.btnStar3 = new System.Windows.Forms.Button();
            this.btnStar4 = new System.Windows.Forms.Button();
            this.btnStar5 = new System.Windows.Forms.Button();
            this.lblRatingText = new System.Windows.Forms.Label();
            this.lblCommentLabel = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSubmit = new EventManagementSystem.GradientButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOthersLabel = new System.Windows.Forms.Label();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // Header
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(800, 80);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.lblTitle.AutoSize = true; this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTitle.Text = "Write a Review";
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(110, 80, 220);
            this.btnClose.Location = new System.Drawing.Point(680, 22);
            this.btnClose.Size = new System.Drawing.Size(95, 34);
            this.btnClose.Text = "Close"; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);

            // Hall name
            this.lblHallName.AutoSize = true;
            this.lblHallName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblHallName.ForeColor = System.Drawing.Color.FromArgb(40, 30, 90);
            this.lblHallName.Location = new System.Drawing.Point(35, 100);
            this.lblHallName.Text = "Hall";

            // Rate label
            this.lblRateLabel.AutoSize = true;
            this.lblRateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRateLabel.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblRateLabel.Location = new System.Drawing.Point(35, 145);
            this.lblRateLabel.Text = "RATE YOUR EXPERIENCE";

            // Star buttons
            int starX = 35, starY = 170, starW = 60, starH = 55, starGap = 8;
            ConfigStar(this.btnStar1, starX + 0 * (starW + starGap), starY, starW, starH);
            ConfigStar(this.btnStar2, starX + 1 * (starW + starGap), starY, starW, starH);
            ConfigStar(this.btnStar3, starX + 2 * (starW + starGap), starY, starW, starH);
            ConfigStar(this.btnStar4, starX + 3 * (starW + starGap), starY, starW, starH);
            ConfigStar(this.btnStar5, starX + 4 * (starW + starGap), starY, starW, starH);

            this.lblRatingText.AutoSize = true;
            this.lblRatingText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblRatingText.ForeColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.lblRatingText.Location = new System.Drawing.Point(370, 185);
            this.lblRatingText.Text = "Your rating: 5 / 5";

            // Comment
            this.lblCommentLabel.AutoSize = true;
            this.lblCommentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCommentLabel.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblCommentLabel.Location = new System.Drawing.Point(35, 245);
            this.lblCommentLabel.Text = "SHARE YOUR EXPERIENCE";
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtComment.Location = new System.Drawing.Point(35, 267);
            this.txtComment.Multiline = true;
            this.txtComment.Size = new System.Drawing.Size(730, 80);
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Submit + Cancel
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(35, 365);
            this.btnSubmit.Size = new System.Drawing.Size(360, 45);
            this.btnSubmit.Text = "SUBMIT REVIEW";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.btnCancel.Location = new System.Drawing.Point(405, 365);
            this.btnCancel.Size = new System.Drawing.Size(360, 45);
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Existing reviews
            this.lblOthersLabel.AutoSize = true;
            this.lblOthersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblOthersLabel.ForeColor = System.Drawing.Color.FromArgb(40, 30, 90);
            this.lblOthersLabel.Location = new System.Drawing.Point(35, 430);
            this.lblOthersLabel.Text = "What others said";

            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.BackgroundColor = System.Drawing.Color.White;
            this.dgvReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReviews.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(110, 80, 220);
            this.dgvReviews.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReviews.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvReviews.ColumnHeadersHeight = 40;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReviews.EnableHeadersVisualStyles = false;
            this.dgvReviews.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvReviews.Location = new System.Drawing.Point(35, 460);
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.RowHeadersVisible = false;
            this.dgvReviews.RowTemplate.Height = 32;
            this.dgvReviews.Size = new System.Drawing.Size(730, 150);

            // Form
            this.BackColor = System.Drawing.Color.FromArgb(248, 246, 252);
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.lblOthersLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblCommentLabel);
            this.Controls.Add(this.lblRatingText);
            this.Controls.Add(this.btnStar1);
            this.Controls.Add(this.btnStar2);
            this.Controls.Add(this.btnStar3);
            this.Controls.Add(this.btnStar4);
            this.Controls.Add(this.btnStar5);
            this.Controls.Add(this.lblRateLabel);
            this.Controls.Add(this.lblHallName);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Text = "Review Hall";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigStar(System.Windows.Forms.Button b, int x, int y, int w, int h)
        {
            b.BackColor = System.Drawing.Color.White;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            b.FlatAppearance.BorderSize = 1;
            b.Font = new System.Drawing.Font("Segoe UI Symbol", 24F);
            b.ForeColor = System.Drawing.Color.LightGray;
            b.Location = new System.Drawing.Point(x, y);
            b.Size = new System.Drawing.Size(w, h);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
            b.Text = "\u2606";
            b.UseVisualStyleBackColor = false;
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHallName;
        private System.Windows.Forms.Label lblRateLabel;
        private System.Windows.Forms.Button btnStar1;
        private System.Windows.Forms.Button btnStar2;
        private System.Windows.Forms.Button btnStar3;
        private System.Windows.Forms.Button btnStar4;
        private System.Windows.Forms.Button btnStar5;
        private System.Windows.Forms.Label lblRatingText;
        private System.Windows.Forms.Label lblCommentLabel;
        private System.Windows.Forms.TextBox txtComment;
        private EventManagementSystem.GradientButton btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOthersLabel;
        private System.Windows.Forms.DataGridView dgvReviews;
    }
}