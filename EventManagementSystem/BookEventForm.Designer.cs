namespace EventManagementSystem
{
    partial class BookEventForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancelTop = new System.Windows.Forms.Button();
            this.picHall = new System.Windows.Forms.PictureBox();
            this.lblHallName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblFormHeading = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEventType = new System.Windows.Forms.Label();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.numGuests = new System.Windows.Forms.NumericUpDown();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblSpecialRequest = new System.Windows.Forms.Label();
            this.txtSpecialRequest = new System.Windows.Forms.TextBox();
            this.lblCoupon = new System.Windows.Forms.Label();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.btnApplyCoupon = new EventManagementSystem.GradientButton();
            this.lblCouponMsg = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirm = new EventManagementSystem.GradientButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuests)).BeginInit();
            this.SuspendLayout();

            // Header
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnCancelTop);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);

            this.lblTitle.AutoSize = true; this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Text = "Book This Hall";

            this.btnCancelTop.BackColor = System.Drawing.Color.White;
            this.btnCancelTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelTop.FlatAppearance.BorderSize = 0;
            this.btnCancelTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelTop.ForeColor = System.Drawing.Color.FromArgb(110, 80, 220);
            this.btnCancelTop.Location = new System.Drawing.Point(990, 18);
            this.btnCancelTop.Size = new System.Drawing.Size(90, 32);
            this.btnCancelTop.Text = "Cancel";
            this.btnCancelTop.UseVisualStyleBackColor = false;
            this.btnCancelTop.Click += new System.EventHandler(this.btnCancel_Click);

            // Hall info column (left)
            this.picHall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picHall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHall.Location = new System.Drawing.Point(35, 90);
            this.picHall.Size = new System.Drawing.Size(450, 240);
            this.picHall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblHallName.AutoSize = true;
            this.lblHallName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblHallName.ForeColor = System.Drawing.Color.FromArgb(40, 30, 90);
            this.lblHallName.Location = new System.Drawing.Point(35, 345);
            this.lblHallName.Text = "Hall Name";

            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLocation.ForeColor = System.Drawing.Color.DimGray;
            this.lblLocation.Location = new System.Drawing.Point(35, 380);
            this.lblLocation.Text = "Location:";

            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCapacity.ForeColor = System.Drawing.Color.DimGray;
            this.lblCapacity.Location = new System.Drawing.Point(35, 405);
            this.lblCapacity.Text = "Capacity:";

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategory.Location = new System.Drawing.Point(35, 430);
            this.lblCategory.Text = "Category:";

            this.lblPriceTitle.AutoSize = true;
            this.lblPriceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPriceTitle.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblPriceTitle.Location = new System.Drawing.Point(35, 470);
            this.lblPriceTitle.Text = "BOOKING PRICE";

            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.lblPriceValue.Location = new System.Drawing.Point(35, 490);
            this.lblPriceValue.Text = "BDT 0";

            // Booking form (right)
            this.lblFormHeading.AutoSize = true;
            this.lblFormHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormHeading.ForeColor = System.Drawing.Color.FromArgb(40, 30, 90);
            this.lblFormHeading.Location = new System.Drawing.Point(530, 90);
            this.lblFormHeading.Text = "Booking Details";

            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblDate.Location = new System.Drawing.Point(530, 130);
            this.lblDate.Text = "EVENT DATE";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Location = new System.Drawing.Point(530, 152);
            this.dtpDate.Size = new System.Drawing.Size(255, 25);

            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblStart.Location = new System.Drawing.Point(810, 130);
            this.lblStart.Text = "START TIME";
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Location = new System.Drawing.Point(810, 152);
            this.dtpStart.Size = new System.Drawing.Size(255, 25);

            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblEnd.Location = new System.Drawing.Point(530, 190);
            this.lblEnd.Text = "END TIME";
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Location = new System.Drawing.Point(530, 212);
            this.dtpEnd.Size = new System.Drawing.Size(255, 25);

            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEventType.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblEventType.Location = new System.Drawing.Point(810, 190);
            this.lblEventType.Text = "EVENT TYPE";
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEventType.Location = new System.Drawing.Point(810, 212);
            this.cmbEventType.Size = new System.Drawing.Size(255, 25);

            this.lblGuests.AutoSize = true;
            this.lblGuests.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGuests.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblGuests.Location = new System.Drawing.Point(530, 250);
            this.lblGuests.Text = "NUMBER OF GUESTS";
            this.numGuests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numGuests.Location = new System.Drawing.Point(530, 272);
            this.numGuests.Size = new System.Drawing.Size(255, 25);
            this.numGuests.Minimum = 1; this.numGuests.Maximum = 10000; this.numGuests.Value = 50;
            this.numGuests.ValueChanged += new System.EventHandler(this.numGuests_ValueChanged);

            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblPhone.Location = new System.Drawing.Point(810, 250);
            this.lblPhone.Text = "CONTACT PHONE";
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(810, 272);
            this.txtPhone.Size = new System.Drawing.Size(255, 25);

            this.lblSpecialRequest.AutoSize = true;
            this.lblSpecialRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSpecialRequest.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblSpecialRequest.Location = new System.Drawing.Point(530, 310);
            this.lblSpecialRequest.Text = "SPECIAL REQUEST";
            this.txtSpecialRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialRequest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSpecialRequest.Location = new System.Drawing.Point(530, 332);
            this.txtSpecialRequest.Multiline = true;
            this.txtSpecialRequest.Size = new System.Drawing.Size(535, 60);

            this.lblCoupon.AutoSize = true;
            this.lblCoupon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCoupon.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblCoupon.Location = new System.Drawing.Point(530, 410);
            this.lblCoupon.Text = "COUPON CODE";
            this.txtCoupon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoupon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCoupon.Location = new System.Drawing.Point(530, 432);
            this.txtCoupon.Size = new System.Drawing.Size(255, 25);

            this.btnApplyCoupon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnApplyCoupon.ForeColor = System.Drawing.Color.White;
            this.btnApplyCoupon.Location = new System.Drawing.Point(795, 430);
            this.btnApplyCoupon.Size = new System.Drawing.Size(110, 28);
            this.btnApplyCoupon.Text = "APPLY";
            this.btnApplyCoupon.Click += new System.EventHandler(this.btnApplyCoupon_Click);

            this.lblCouponMsg.AutoSize = true;
            this.lblCouponMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCouponMsg.Location = new System.Drawing.Point(915, 437);
            this.lblCouponMsg.Text = "";

            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtotal.Location = new System.Drawing.Point(530, 480);
            this.lblSubtotal.Text = "Subtotal: BDT 0";

            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(40, 180, 130);
            this.lblDiscount.Location = new System.Drawing.Point(530, 505);
            this.lblDiscount.Text = "Discount: - BDT 0 (0%)";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.lblTotal.Location = new System.Drawing.Point(530, 540);
            this.lblTotal.Text = "TOTAL: BDT 0";

            // Confirm button
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(530, 600);
            this.btnConfirm.Size = new System.Drawing.Size(535, 55);
            this.btnConfirm.Text = "CONFIRM BOOKING & PAY";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // ===== BookEventForm =====
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(248, 246, 252);
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblCouponMsg);
            this.Controls.Add(this.btnApplyCoupon);
            this.Controls.Add(this.txtCoupon);
            this.Controls.Add(this.lblCoupon);
            this.Controls.Add(this.txtSpecialRequest);
            this.Controls.Add(this.lblSpecialRequest);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.numGuests);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.cmbEventType);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFormHeading);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblPriceTitle);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblHallName);
            this.Controls.Add(this.picHall);
            this.Controls.Add(this.pnlHeader);
            this.Name = "BookEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Hall";
            this.Load += new System.EventHandler(this.BookEventForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancelTop;
        private System.Windows.Forms.PictureBox picHall;
        private System.Windows.Forms.Label lblHallName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPriceTitle;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblFormHeading;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.NumericUpDown numGuests;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblSpecialRequest;
        private System.Windows.Forms.TextBox txtSpecialRequest;
        private System.Windows.Forms.Label lblCoupon;
        private System.Windows.Forms.TextBox txtCoupon;
        private EventManagementSystem.GradientButton btnApplyCoupon;
        private System.Windows.Forms.Label lblCouponMsg;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private EventManagementSystem.GradientButton btnConfirm;
    }
}