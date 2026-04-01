namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmPaymentGateway
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblPkgLabel = new System.Windows.Forms.Label();
            this.lblPackageVal = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblEventDateVal = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblDownLabel = new System.Windows.Forms.Label();
            this.lblDownVal = new System.Windows.Forms.Label();
            this.lblBalLabel = new System.Windows.Forms.Label();
            this.lblBalanceVal = new System.Windows.Forms.Label();
            this.grpPayMethod = new System.Windows.Forms.GroupBox();
            this.rbGcash = new System.Windows.Forms.RadioButton();
            this.rbBank = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.lblPaymentDetail = new System.Windows.Forms.Label();
            this.lblRefLabel = new System.Windows.Forms.Label();
            this.txtRefNumber = new System.Windows.Forms.TextBox();
            this.grpProof = new System.Windows.Forms.GroupBox();
            this.btnUploadProof = new System.Windows.Forms.Button();
            this.lblProofFile = new System.Windows.Forms.Label();
            this.lblProofNote = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            this.grpPayMethod.SuspendLayout();
            this.grpProof.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Thistle;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(580, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Down Payment Gateway";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblSubtitle.Location = new System.Drawing.Point(22, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(333, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Submit your down payment to confirm your booking";
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.BackColor = System.Drawing.Color.Pink;
            this.panelBody.Controls.Add(this.grpOrderSummary);
            this.panelBody.Controls.Add(this.grpPayMethod);
            this.panelBody.Controls.Add(this.grpProof);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelBody.Location = new System.Drawing.Point(0, 80);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(16);
            this.panelBody.Size = new System.Drawing.Size(580, 536);
            this.panelBody.TabIndex = 0;
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.BackColor = System.Drawing.Color.LightPink;
            this.grpOrderSummary.Controls.Add(this.lblOrderId);
            this.grpOrderSummary.Controls.Add(this.lblPkgLabel);
            this.grpOrderSummary.Controls.Add(this.lblPackageVal);
            this.grpOrderSummary.Controls.Add(this.lblDateLabel);
            this.grpOrderSummary.Controls.Add(this.lblEventDateVal);
            this.grpOrderSummary.Controls.Add(this.lblTotalLabel);
            this.grpOrderSummary.Controls.Add(this.lblTotalVal);
            this.grpOrderSummary.Controls.Add(this.lblDownLabel);
            this.grpOrderSummary.Controls.Add(this.lblDownVal);
            this.grpOrderSummary.Controls.Add(this.lblBalLabel);
            this.grpOrderSummary.Controls.Add(this.lblBalanceVal);
            this.grpOrderSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpOrderSummary.Location = new System.Drawing.Point(16, 10);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(530, 200);
            this.grpOrderSummary.TabIndex = 0;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblOrderId.Location = new System.Drawing.Point(14, 22);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(66, 21);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order #";
            // 
            // lblPkgLabel
            // 
            this.lblPkgLabel.AutoSize = true;
            this.lblPkgLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPkgLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblPkgLabel.Location = new System.Drawing.Point(14, 50);
            this.lblPkgLabel.Name = "lblPkgLabel";
            this.lblPkgLabel.Size = new System.Drawing.Size(51, 15);
            this.lblPkgLabel.TabIndex = 1;
            this.lblPkgLabel.Text = "Package";
            // 
            // lblPackageVal
            // 
            this.lblPackageVal.AutoSize = true;
            this.lblPackageVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPackageVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPackageVal.Location = new System.Drawing.Point(180, 50);
            this.lblPackageVal.Name = "lblPackageVal";
            this.lblPackageVal.Size = new System.Drawing.Size(15, 19);
            this.lblPackageVal.TabIndex = 2;
            this.lblPackageVal.Text = "-";
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblDateLabel.Location = new System.Drawing.Point(14, 78);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(63, 15);
            this.lblDateLabel.TabIndex = 3;
            this.lblDateLabel.Text = "Event Date";
            // 
            // lblEventDateVal
            // 
            this.lblEventDateVal.AutoSize = true;
            this.lblEventDateVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEventDateVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEventDateVal.Location = new System.Drawing.Point(180, 78);
            this.lblEventDateVal.Name = "lblEventDateVal";
            this.lblEventDateVal.Size = new System.Drawing.Size(15, 19);
            this.lblEventDateVal.TabIndex = 4;
            this.lblEventDateVal.Text = "-";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalLabel.Location = new System.Drawing.Point(14, 106);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(79, 15);
            this.lblTotalLabel.TabIndex = 5;
            this.lblTotalLabel.Text = "Total Amount";
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTotalVal.Location = new System.Drawing.Point(180, 106);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(15, 19);
            this.lblTotalVal.TabIndex = 6;
            this.lblTotalVal.Text = "-";
            // 
            // lblDownLabel
            // 
            this.lblDownLabel.AutoSize = true;
            this.lblDownLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDownLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblDownLabel.Location = new System.Drawing.Point(14, 134);
            this.lblDownLabel.Name = "lblDownLabel";
            this.lblDownLabel.Size = new System.Drawing.Size(88, 15);
            this.lblDownLabel.TabIndex = 7;
            this.lblDownLabel.Text = "Down Payment";
            // 
            // lblDownVal
            // 
            this.lblDownVal.AutoSize = true;
            this.lblDownVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDownVal.ForeColor = System.Drawing.Color.Black;
            this.lblDownVal.Location = new System.Drawing.Point(180, 134);
            this.lblDownVal.Name = "lblDownVal";
            this.lblDownVal.Size = new System.Drawing.Size(62, 19);
            this.lblDownVal.TabIndex = 8;
            this.lblDownVal.Text = "P500.00";
            // 
            // lblBalLabel
            // 
            this.lblBalLabel.AutoSize = true;
            this.lblBalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBalLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblBalLabel.Location = new System.Drawing.Point(14, 162);
            this.lblBalLabel.Name = "lblBalLabel";
            this.lblBalLabel.Size = new System.Drawing.Size(48, 15);
            this.lblBalLabel.TabIndex = 9;
            this.lblBalLabel.Text = "Balance";
            // 
            // lblBalanceVal
            // 
            this.lblBalanceVal.AutoSize = true;
            this.lblBalanceVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBalanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBalanceVal.Location = new System.Drawing.Point(180, 162);
            this.lblBalanceVal.Name = "lblBalanceVal";
            this.lblBalanceVal.Size = new System.Drawing.Size(15, 19);
            this.lblBalanceVal.TabIndex = 10;
            this.lblBalanceVal.Text = "-";
            // 
            // grpPayMethod
            // 
            this.grpPayMethod.BackColor = System.Drawing.Color.LightPink;
            this.grpPayMethod.Controls.Add(this.rbGcash);
            this.grpPayMethod.Controls.Add(this.rbBank);
            this.grpPayMethod.Controls.Add(this.rbCash);
            this.grpPayMethod.Controls.Add(this.lblPaymentDetail);
            this.grpPayMethod.Controls.Add(this.lblRefLabel);
            this.grpPayMethod.Controls.Add(this.txtRefNumber);
            this.grpPayMethod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPayMethod.Location = new System.Drawing.Point(16, 220);
            this.grpPayMethod.Name = "grpPayMethod";
            this.grpPayMethod.Size = new System.Drawing.Size(530, 200);
            this.grpPayMethod.TabIndex = 1;
            this.grpPayMethod.TabStop = false;
            this.grpPayMethod.Text = "Choose Payment Method";
            // 
            // rbGcash
            // 
            this.rbGcash.AutoSize = true;
            this.rbGcash.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbGcash.Location = new System.Drawing.Point(20, 28);
            this.rbGcash.Name = "rbGcash";
            this.rbGcash.Size = new System.Drawing.Size(67, 23);
            this.rbGcash.TabIndex = 0;
            this.rbGcash.Text = "GCash";
            this.rbGcash.CheckedChanged += new System.EventHandler(this.rbGcash_CheckedChanged);
            // 
            // rbBank
            // 
            this.rbBank.AutoSize = true;
            this.rbBank.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbBank.Location = new System.Drawing.Point(120, 28);
            this.rbBank.Name = "rbBank";
            this.rbBank.Size = new System.Drawing.Size(109, 23);
            this.rbBank.TabIndex = 1;
            this.rbBank.Text = "Bank Transfer";
            this.rbBank.CheckedChanged += new System.EventHandler(this.rbBank_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCash.Location = new System.Drawing.Point(250, 28);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(132, 23);
            this.rbCash.TabIndex = 2;
            this.rbCash.Text = "Cash on Meeting";
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // lblPaymentDetail
            // 
            this.lblPaymentDetail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaymentDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPaymentDetail.Location = new System.Drawing.Point(14, 62);
            this.lblPaymentDetail.Name = "lblPaymentDetail";
            this.lblPaymentDetail.Size = new System.Drawing.Size(500, 50);
            this.lblPaymentDetail.TabIndex = 3;
            this.lblPaymentDetail.Text = "Select a payment method above to see details.";
            // 
            // lblRefLabel
            // 
            this.lblRefLabel.AutoSize = true;
            this.lblRefLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRefLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblRefLabel.Location = new System.Drawing.Point(14, 120);
            this.lblRefLabel.Name = "lblRefLabel";
            this.lblRefLabel.Size = new System.Drawing.Size(143, 15);
            this.lblRefLabel.TabIndex = 4;
            this.lblRefLabel.Text = "Reference / Transaction #:";
            // 
            // txtRefNumber
            // 
            this.txtRefNumber.Enabled = false;
            this.txtRefNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRefNumber.Location = new System.Drawing.Point(14, 140);
            this.txtRefNumber.Name = "txtRefNumber";
            this.txtRefNumber.Size = new System.Drawing.Size(350, 25);
            this.txtRefNumber.TabIndex = 5;
            // 
            // grpProof
            // 
            this.grpProof.BackColor = System.Drawing.Color.LightPink;
            this.grpProof.Controls.Add(this.btnUploadProof);
            this.grpProof.Controls.Add(this.lblProofFile);
            this.grpProof.Controls.Add(this.lblProofNote);
            this.grpProof.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpProof.Location = new System.Drawing.Point(16, 430);
            this.grpProof.Name = "grpProof";
            this.grpProof.Size = new System.Drawing.Size(530, 110);
            this.grpProof.TabIndex = 2;
            this.grpProof.TabStop = false;
            this.grpProof.Text = "Upload Payment Proof";
            // 
            // btnUploadProof
            // 
            this.btnUploadProof.BackColor = System.Drawing.Color.Plum;
            this.btnUploadProof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadProof.FlatAppearance.BorderSize = 0;
            this.btnUploadProof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadProof.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadProof.ForeColor = System.Drawing.Color.Black;
            this.btnUploadProof.Location = new System.Drawing.Point(14, 28);
            this.btnUploadProof.Name = "btnUploadProof";
            this.btnUploadProof.Size = new System.Drawing.Size(150, 34);
            this.btnUploadProof.TabIndex = 0;
            this.btnUploadProof.Text = "Upload Screenshot";
            this.btnUploadProof.UseVisualStyleBackColor = false;
            this.btnUploadProof.Click += new System.EventHandler(this.btnUploadProof_Click);
            // 
            // lblProofFile
            // 
            this.lblProofFile.AutoSize = true;
            this.lblProofFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProofFile.ForeColor = System.Drawing.Color.Gray;
            this.lblProofFile.Location = new System.Drawing.Point(174, 36);
            this.lblProofFile.Name = "lblProofFile";
            this.lblProofFile.Size = new System.Drawing.Size(88, 15);
            this.lblProofFile.TabIndex = 1;
            this.lblProofFile.Text = "No file selected";
            // 
            // lblProofNote
            // 
            this.lblProofNote.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProofNote.ForeColor = System.Drawing.Color.Gray;
            this.lblProofNote.Location = new System.Drawing.Point(14, 72);
            this.lblProofNote.Name = "lblProofNote";
            this.lblProofNote.Size = new System.Drawing.Size(500, 30);
            this.lblProofNote.TabIndex = 2;
            this.lblProofNote.Text = "GCash/bank screenshot will be sent to admin along with your message.";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnConfirmPayment);
            this.panelBottom.Controls.Add(this.btnSkip);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 616);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(580, 64);
            this.panelBottom.TabIndex = 2;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnConfirmPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPayment.FlatAppearance.BorderSize = 0;
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(16, 10);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(210, 44);
            this.btnConfirmPayment.TabIndex = 0;
            this.btnConfirmPayment.Text = "Confirm Payment Sent";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSkip.Location = new System.Drawing.Point(234, 10);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(190, 44);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Text = "Pay Later (Skip for now)";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // frmPaymentGateway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 680);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 680);
            this.Name = "frmPaymentGateway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Gateway";
            this.Load += new System.EventHandler(this.frmPaymentGateway_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.grpPayMethod.ResumeLayout(false);
            this.grpPayMethod.PerformLayout();
            this.grpProof.ResumeLayout(false);
            this.grpProof.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel        panelHeader;
        private System.Windows.Forms.Label        lblTitle;
        private System.Windows.Forms.Label        lblSubtitle;
        private System.Windows.Forms.Panel        panelBody;
        private System.Windows.Forms.GroupBox     grpOrderSummary;
        private System.Windows.Forms.Label        lblOrderId;
        private System.Windows.Forms.Label        lblPkgLabel;
        private System.Windows.Forms.Label        lblPackageVal;
        private System.Windows.Forms.Label        lblDateLabel;
        private System.Windows.Forms.Label        lblEventDateVal;
        private System.Windows.Forms.Label        lblTotalLabel;
        private System.Windows.Forms.Label        lblTotalVal;
        private System.Windows.Forms.Label        lblDownLabel;
        private System.Windows.Forms.Label        lblDownVal;
        private System.Windows.Forms.Label        lblBalLabel;
        private System.Windows.Forms.Label        lblBalanceVal;
        private System.Windows.Forms.GroupBox     grpPayMethod;
        private System.Windows.Forms.RadioButton  rbGcash;
        private System.Windows.Forms.RadioButton  rbBank;
        private System.Windows.Forms.RadioButton  rbCash;
        private System.Windows.Forms.Label        lblPaymentDetail;
        private System.Windows.Forms.Label        lblRefLabel;
        private System.Windows.Forms.TextBox      txtRefNumber;
        private System.Windows.Forms.GroupBox     grpProof;
        private System.Windows.Forms.Button       btnUploadProof;
        private System.Windows.Forms.Label        lblProofFile;
        private System.Windows.Forms.Label        lblProofNote;
        private System.Windows.Forms.Panel        panelBottom;
        private System.Windows.Forms.Button       btnConfirmPayment;
        private System.Windows.Forms.Button       btnSkip;
    }
}
