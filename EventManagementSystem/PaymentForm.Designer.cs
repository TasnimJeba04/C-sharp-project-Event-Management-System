namespace EventManagementSystem
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPaymentArea = new System.Windows.Forms.Panel();
            this.lblBookingTitle = new System.Windows.Forms.Label();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.lblAmountTitle = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblChooseMethod = new System.Windows.Forms.Label();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.picCash = new System.Windows.Forms.PictureBox();
            this.lblCashName = new System.Windows.Forms.Label();
            this.lblCashDesc = new System.Windows.Forms.Label();
            this.pnlBkash = new System.Windows.Forms.Panel();
            this.picBkash = new System.Windows.Forms.PictureBox();
            this.lblBkashName = new System.Windows.Forms.Label();
            this.lblBkashDesc = new System.Windows.Forms.Label();
            this.pnlNagad = new System.Windows.Forms.Panel();
            this.picNagad = new System.Windows.Forms.PictureBox();
            this.lblNagadName = new System.Windows.Forms.Label();
            this.lblNagadDesc = new System.Windows.Forms.Label();
            this.pnlRocket = new System.Windows.Forms.Panel();
            this.picRocket = new System.Windows.Forms.PictureBox();
            this.lblRocketName = new System.Windows.Forms.Label();
            this.lblRocketDesc = new System.Windows.Forms.Label();
            this.pnlVisa = new System.Windows.Forms.Panel();
            this.picVisa = new System.Windows.Forms.PictureBox();
            this.lblVisaName = new System.Windows.Forms.Label();
            this.lblVisaDesc = new System.Windows.Forms.Label();
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.picMaster = new System.Windows.Forms.PictureBox();
            this.lblMasterName = new System.Windows.Forms.Label();
            this.lblMasterDesc = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnPay = new EventManagementSystem.GradientButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlReceiptArea = new System.Windows.Forms.Panel();
            this.lblReceiptHeading = new System.Windows.Forms.Label();
            this.lblReceiptSub = new System.Windows.Forms.Label();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.btnSaveReceipt = new EventManagementSystem.GradientButton();
            this.btnCloseReceipt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBkash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNagad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaster)).BeginInit();
            this.SuspendLayout();

            // Header
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(720, 80);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.lblTitle.AutoSize = true; this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTitle.Text = "Complete Payment";

            // Payment Area
            this.pnlPaymentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentArea.BackColor = System.Drawing.Color.FromArgb(248, 246, 252);

            // Booking info
            this.lblBookingTitle.AutoSize = true;
            this.lblBookingTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookingTitle.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblBookingTitle.Location = new System.Drawing.Point(40, 18);
            this.lblBookingTitle.Text = "BOOKING";
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblBookingId.ForeColor = System.Drawing.Color.FromArgb(40, 30, 90);
            this.lblBookingId.Location = new System.Drawing.Point(40, 38);
            this.lblBookingId.Text = "Booking #";
            this.lblAmountTitle.AutoSize = true;
            this.lblAmountTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmountTitle.ForeColor = System.Drawing.Color.FromArgb(110, 60, 200);
            this.lblAmountTitle.Location = new System.Drawing.Point(450, 18);
            this.lblAmountTitle.Text = "AMOUNT TO PAY";
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.lblAmount.Location = new System.Drawing.Point(450, 36);
            this.lblAmount.Text = "BDT 0";

            this.lblChooseMethod.AutoSize = true;
            this.lblChooseMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblChooseMethod.ForeColor = System.Drawing.Color.FromArgb(40, 30, 90);
            this.lblChooseMethod.Location = new System.Drawing.Point(40, 88);
            this.lblChooseMethod.Text = "Choose Payment Method";

            // ===== CASH CARD (green) =====
            this.pnlCash.BackColor = System.Drawing.Color.FromArgb(40, 180, 130);
            this.pnlCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCash.Location = new System.Drawing.Point(40, 120);
            this.pnlCash.Size = new System.Drawing.Size(200, 150);
            this.pnlCash.Controls.Add(this.picCash);
            this.pnlCash.Controls.Add(this.lblCashName);
            this.pnlCash.Controls.Add(this.lblCashDesc);
            this.picCash.BackColor = System.Drawing.Color.White;
            this.picCash.Location = new System.Drawing.Point(60, 12);
            this.picCash.Size = new System.Drawing.Size(80, 60);
            this.picCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashName.BackColor = System.Drawing.Color.Transparent;
            this.lblCashName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblCashName.ForeColor = System.Drawing.Color.White;
            this.lblCashName.Location = new System.Drawing.Point(0, 80);
            this.lblCashName.Size = new System.Drawing.Size(200, 24);
            this.lblCashName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCashName.Text = "Cash"; this.lblCashName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblCashDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCashDesc.ForeColor = System.Drawing.Color.White;
            this.lblCashDesc.Location = new System.Drawing.Point(0, 110);
            this.lblCashDesc.Size = new System.Drawing.Size(200, 20);
            this.lblCashDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCashDesc.Text = "Pay at venue"; this.lblCashDesc.Cursor = System.Windows.Forms.Cursors.Hand;

            // ===== BKASH CARD (pink) =====
            this.pnlBkash.BackColor = System.Drawing.Color.FromArgb(226, 19, 110);
            this.pnlBkash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBkash.Location = new System.Drawing.Point(250, 120);
            this.pnlBkash.Size = new System.Drawing.Size(200, 150);
            this.pnlBkash.Controls.Add(this.picBkash);
            this.pnlBkash.Controls.Add(this.lblBkashName);
            this.pnlBkash.Controls.Add(this.lblBkashDesc);
            this.picBkash.BackColor = System.Drawing.Color.White;
            this.picBkash.Location = new System.Drawing.Point(60, 12);
            this.picBkash.Size = new System.Drawing.Size(80, 60);
            this.picBkash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBkash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBkashName.BackColor = System.Drawing.Color.Transparent;
            this.lblBkashName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblBkashName.ForeColor = System.Drawing.Color.White;
            this.lblBkashName.Location = new System.Drawing.Point(0, 80);
            this.lblBkashName.Size = new System.Drawing.Size(200, 24);
            this.lblBkashName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBkashName.Text = "bKash"; this.lblBkashName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBkashDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblBkashDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBkashDesc.ForeColor = System.Drawing.Color.White;
            this.lblBkashDesc.Location = new System.Drawing.Point(0, 110);
            this.lblBkashDesc.Size = new System.Drawing.Size(200, 20);
            this.lblBkashDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBkashDesc.Text = "Mobile Banking"; this.lblBkashDesc.Cursor = System.Windows.Forms.Cursors.Hand;

            // ===== NAGAD CARD (orange) =====
            this.pnlNagad.BackColor = System.Drawing.Color.FromArgb(238, 110, 31);
            this.pnlNagad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNagad.Location = new System.Drawing.Point(460, 120);
            this.pnlNagad.Size = new System.Drawing.Size(200, 150);
            this.pnlNagad.Controls.Add(this.picNagad);
            this.pnlNagad.Controls.Add(this.lblNagadName);
            this.pnlNagad.Controls.Add(this.lblNagadDesc);
            this.picNagad.BackColor = System.Drawing.Color.White;
            this.picNagad.Location = new System.Drawing.Point(60, 12);
            this.picNagad.Size = new System.Drawing.Size(80, 60);
            this.picNagad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNagad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNagadName.BackColor = System.Drawing.Color.Transparent;
            this.lblNagadName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblNagadName.ForeColor = System.Drawing.Color.White;
            this.lblNagadName.Location = new System.Drawing.Point(0, 80);
            this.lblNagadName.Size = new System.Drawing.Size(200, 24);
            this.lblNagadName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNagadName.Text = "Nagad"; this.lblNagadName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNagadDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblNagadDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNagadDesc.ForeColor = System.Drawing.Color.White;
            this.lblNagadDesc.Location = new System.Drawing.Point(0, 110);
            this.lblNagadDesc.Size = new System.Drawing.Size(200, 20);
            this.lblNagadDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNagadDesc.Text = "Mobile Banking"; this.lblNagadDesc.Cursor = System.Windows.Forms.Cursors.Hand;

            // ===== ROCKET CARD (purple) =====
            this.pnlRocket.BackColor = System.Drawing.Color.FromArgb(140, 52, 148);
            this.pnlRocket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlRocket.Location = new System.Drawing.Point(40, 280);
            this.pnlRocket.Size = new System.Drawing.Size(200, 150);
            this.pnlRocket.Controls.Add(this.picRocket);
            this.pnlRocket.Controls.Add(this.lblRocketName);
            this.pnlRocket.Controls.Add(this.lblRocketDesc);
            this.picRocket.BackColor = System.Drawing.Color.White;
            this.picRocket.Location = new System.Drawing.Point(60, 12);
            this.picRocket.Size = new System.Drawing.Size(80, 60);
            this.picRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRocket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRocketName.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblRocketName.ForeColor = System.Drawing.Color.White;
            this.lblRocketName.Location = new System.Drawing.Point(0, 80);
            this.lblRocketName.Size = new System.Drawing.Size(200, 24);
            this.lblRocketName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRocketName.Text = "Rocket"; this.lblRocketName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRocketDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRocketDesc.ForeColor = System.Drawing.Color.White;
            this.lblRocketDesc.Location = new System.Drawing.Point(0, 110);
            this.lblRocketDesc.Size = new System.Drawing.Size(200, 20);
            this.lblRocketDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRocketDesc.Text = "Mobile Banking"; this.lblRocketDesc.Cursor = System.Windows.Forms.Cursors.Hand;

            // ===== VISA CARD (navy) =====
            this.pnlVisa.BackColor = System.Drawing.Color.FromArgb(26, 31, 113);
            this.pnlVisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVisa.Location = new System.Drawing.Point(250, 280);
            this.pnlVisa.Size = new System.Drawing.Size(200, 150);
            this.pnlVisa.Controls.Add(this.picVisa);
            this.pnlVisa.Controls.Add(this.lblVisaName);
            this.pnlVisa.Controls.Add(this.lblVisaDesc);
            this.picVisa.BackColor = System.Drawing.Color.White;
            this.picVisa.Location = new System.Drawing.Point(60, 12);
            this.picVisa.Size = new System.Drawing.Size(80, 60);
            this.picVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVisaName.BackColor = System.Drawing.Color.Transparent;
            this.lblVisaName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblVisaName.ForeColor = System.Drawing.Color.White;
            this.lblVisaName.Location = new System.Drawing.Point(0, 80);
            this.lblVisaName.Size = new System.Drawing.Size(200, 24);
            this.lblVisaName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVisaName.Text = "Visa"; this.lblVisaName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVisaDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblVisaDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVisaDesc.ForeColor = System.Drawing.Color.White;
            this.lblVisaDesc.Location = new System.Drawing.Point(0, 110);
            this.lblVisaDesc.Size = new System.Drawing.Size(200, 20);
            this.lblVisaDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVisaDesc.Text = "Credit / Debit"; this.lblVisaDesc.Cursor = System.Windows.Forms.Cursors.Hand;

            // ===== MASTERCARD CARD (red) =====
            this.pnlMaster.BackColor = System.Drawing.Color.FromArgb(220, 70, 50);
            this.pnlMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMaster.Location = new System.Drawing.Point(460, 280);
            this.pnlMaster.Size = new System.Drawing.Size(200, 150);
            this.pnlMaster.Controls.Add(this.picMaster);
            this.pnlMaster.Controls.Add(this.lblMasterName);
            this.pnlMaster.Controls.Add(this.lblMasterDesc);
            this.picMaster.BackColor = System.Drawing.Color.White;
            this.picMaster.Location = new System.Drawing.Point(60, 12);
            this.picMaster.Size = new System.Drawing.Size(80, 60);
            this.picMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMasterName.BackColor = System.Drawing.Color.Transparent;
            this.lblMasterName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblMasterName.ForeColor = System.Drawing.Color.White;
            this.lblMasterName.Location = new System.Drawing.Point(0, 80);
            this.lblMasterName.Size = new System.Drawing.Size(200, 24);
            this.lblMasterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMasterName.Text = "Mastercard"; this.lblMasterName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMasterDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblMasterDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMasterDesc.ForeColor = System.Drawing.Color.White;
            this.lblMasterDesc.Location = new System.Drawing.Point(0, 110);
            this.lblMasterDesc.Size = new System.Drawing.Size(200, 20);
            this.lblMasterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMasterDesc.Text = "Credit / Debit"; this.lblMasterDesc.Cursor = System.Windows.Forms.Cursors.Hand;

            // Selected indicator
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelected.ForeColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.lblSelected.Location = new System.Drawing.Point(40, 445);
            this.lblSelected.Text = "Selected method: Cash";

            // Pay
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(40, 480);
            this.btnPay.Size = new System.Drawing.Size(640, 55);
            this.btnPay.Text = "PAY NOW";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);

            // Cancel
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(40, 547);
            this.btnCancel.Size = new System.Drawing.Size(640, 38);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add ALL controls to payment area
            this.pnlPaymentArea.Controls.Add(this.lblBookingTitle);
            this.pnlPaymentArea.Controls.Add(this.lblBookingId);
            this.pnlPaymentArea.Controls.Add(this.lblAmountTitle);
            this.pnlPaymentArea.Controls.Add(this.lblAmount);
            this.pnlPaymentArea.Controls.Add(this.lblChooseMethod);
            this.pnlPaymentArea.Controls.Add(this.pnlCash);
            this.pnlPaymentArea.Controls.Add(this.pnlBkash);
            this.pnlPaymentArea.Controls.Add(this.pnlNagad);
            this.pnlPaymentArea.Controls.Add(this.pnlRocket);
            this.pnlPaymentArea.Controls.Add(this.pnlVisa);
            this.pnlPaymentArea.Controls.Add(this.pnlMaster);
            this.pnlPaymentArea.Controls.Add(this.lblSelected);
            this.pnlPaymentArea.Controls.Add(this.btnPay);
            this.pnlPaymentArea.Controls.Add(this.btnCancel);

            // Receipt area
            this.pnlReceiptArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceiptArea.BackColor = System.Drawing.Color.FromArgb(248, 246, 252);
            this.pnlReceiptArea.Visible = false;
            this.lblReceiptHeading.AutoSize = true;
            this.lblReceiptHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblReceiptHeading.ForeColor = System.Drawing.Color.FromArgb(40, 180, 130);
            this.lblReceiptHeading.Location = new System.Drawing.Point(40, 20);
            this.lblReceiptHeading.Text = "Payment Successful!";
            this.lblReceiptSub.AutoSize = true;
            this.lblReceiptSub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblReceiptSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblReceiptSub.Location = new System.Drawing.Point(42, 60);
            this.lblReceiptSub.Text = "Your booking is confirmed. Save the receipt for your records.";
            this.txtReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceipt.BackColor = System.Drawing.Color.White;
            this.txtReceipt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReceipt.Location = new System.Drawing.Point(40, 95);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.WordWrap = false;
            this.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceipt.Size = new System.Drawing.Size(640, 440);
            this.btnSaveReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveReceipt.ForeColor = System.Drawing.Color.White;
            this.btnSaveReceipt.Location = new System.Drawing.Point(40, 550);
            this.btnSaveReceipt.Size = new System.Drawing.Size(310, 45);
            this.btnSaveReceipt.Text = "SAVE RECEIPT";
            this.btnSaveReceipt.Click += new System.EventHandler(this.btnSaveReceipt_Click);
            this.btnCloseReceipt.BackColor = System.Drawing.Color.White;
            this.btnCloseReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.btnCloseReceipt.FlatAppearance.BorderSize = 1;
            this.btnCloseReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCloseReceipt.ForeColor = System.Drawing.Color.FromArgb(134, 87, 220);
            this.btnCloseReceipt.Location = new System.Drawing.Point(370, 550);
            this.btnCloseReceipt.Size = new System.Drawing.Size(310, 45);
            this.btnCloseReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseReceipt.Text = "CLOSE";
            this.btnCloseReceipt.UseVisualStyleBackColor = false;
            this.btnCloseReceipt.Click += new System.EventHandler(this.btnCloseReceipt_Click);
            this.pnlReceiptArea.Controls.Add(this.lblReceiptHeading);
            this.pnlReceiptArea.Controls.Add(this.lblReceiptSub);
            this.pnlReceiptArea.Controls.Add(this.txtReceipt);
            this.pnlReceiptArea.Controls.Add(this.btnSaveReceipt);
            this.pnlReceiptArea.Controls.Add(this.btnCloseReceipt);

            // PaymentForm
            this.BackColor = System.Drawing.Color.FromArgb(248, 246, 252);
            this.ClientSize = new System.Drawing.Size(720, 700);
            this.Controls.Add(this.pnlReceiptArea);
            this.Controls.Add(this.pnlPaymentArea);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.picCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBkash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNagad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaster)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlPaymentArea;
        private System.Windows.Forms.Label lblBookingTitle;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.Label lblAmountTitle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblChooseMethod;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.PictureBox picCash;
        private System.Windows.Forms.Label lblCashName;
        private System.Windows.Forms.Label lblCashDesc;
        private System.Windows.Forms.Panel pnlBkash;
        private System.Windows.Forms.PictureBox picBkash;
        private System.Windows.Forms.Label lblBkashName;
        private System.Windows.Forms.Label lblBkashDesc;
        private System.Windows.Forms.Panel pnlNagad;
        private System.Windows.Forms.PictureBox picNagad;
        private System.Windows.Forms.Label lblNagadName;
        private System.Windows.Forms.Label lblNagadDesc;
        private System.Windows.Forms.Panel pnlRocket;
        private System.Windows.Forms.PictureBox picRocket;
        private System.Windows.Forms.Label lblRocketName;
        private System.Windows.Forms.Label lblRocketDesc;
        private System.Windows.Forms.Panel pnlVisa;
        private System.Windows.Forms.PictureBox picVisa;
        private System.Windows.Forms.Label lblVisaName;
        private System.Windows.Forms.Label lblVisaDesc;
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.PictureBox picMaster;
        private System.Windows.Forms.Label lblMasterName;
        private System.Windows.Forms.Label lblMasterDesc;
        private System.Windows.Forms.Label lblSelected;
        private EventManagementSystem.GradientButton btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlReceiptArea;
        private System.Windows.Forms.Label lblReceiptHeading;
        private System.Windows.Forms.Label lblReceiptSub;
        private System.Windows.Forms.TextBox txtReceipt;
        private EventManagementSystem.GradientButton btnSaveReceipt;
        private System.Windows.Forms.Button btnCloseReceipt;
    }
}