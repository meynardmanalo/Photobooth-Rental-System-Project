namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmRateOrder
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.lblStarPrompt = new System.Windows.Forms.Label();
            this.panelStars = new System.Windows.Forms.Panel();
            this.btnStar1 = new System.Windows.Forms.Button();
            this.btnStar2 = new System.Windows.Forms.Button();
            this.btnStar3 = new System.Windows.Forms.Button();
            this.btnStar4 = new System.Windows.Forms.Button();
            this.btnStar5 = new System.Windows.Forms.Button();
            this.lblRatingLabel = new System.Windows.Forms.Label();
            this.lblFeedbackPrompt = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.lblPhotoPrompt = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.btnRemovePhoto = new System.Windows.Forms.Button();
            this.lblPhotoName = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Thistle;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblOrderId);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(680, 70);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rate Your Experience";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblOrderId.Location = new System.Drawing.Point(20, 40);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(57, 19);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "Order #";
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.BackColor = System.Drawing.Color.Pink;
            this.panelBody.Controls.Add(this.lblStarPrompt);
            this.panelBody.Controls.Add(this.panelStars);
            this.panelBody.Controls.Add(this.lblRatingLabel);
            this.panelBody.Controls.Add(this.lblFeedbackPrompt);
            this.panelBody.Controls.Add(this.txtFeedback);
            this.panelBody.Controls.Add(this.lblCharCount);
            this.panelBody.Controls.Add(this.lblPhotoPrompt);
            this.panelBody.Controls.Add(this.btnUploadPhoto);
            this.panelBody.Controls.Add(this.btnRemovePhoto);
            this.panelBody.Controls.Add(this.lblPhotoName);
            this.panelBody.Controls.Add(this.picPreview);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 70);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(24, 16, 24, 0);
            this.panelBody.Size = new System.Drawing.Size(680, 619);
            this.panelBody.TabIndex = 1;
            // 
            // lblStarPrompt
            // 
            this.lblStarPrompt.AutoSize = true;
            this.lblStarPrompt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStarPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStarPrompt.Location = new System.Drawing.Point(24, 16);
            this.lblStarPrompt.Name = "lblStarPrompt";
            this.lblStarPrompt.Size = new System.Drawing.Size(238, 20);
            this.lblStarPrompt.TabIndex = 0;
            this.lblStarPrompt.Text = "How would you rate our service?";
            // 
            // panelStars
            // 
            this.panelStars.BackColor = System.Drawing.Color.LightPink;
            this.panelStars.Controls.Add(this.btnStar1);
            this.panelStars.Controls.Add(this.btnStar2);
            this.panelStars.Controls.Add(this.btnStar3);
            this.panelStars.Controls.Add(this.btnStar4);
            this.panelStars.Controls.Add(this.btnStar5);
            this.panelStars.Location = new System.Drawing.Point(24, 46);
            this.panelStars.Name = "panelStars";
            this.panelStars.Size = new System.Drawing.Size(310, 64);
            this.panelStars.TabIndex = 1;
            // 
            // btnStar1
            // 
            this.btnStar1.BackColor = System.Drawing.Color.Transparent;
            this.btnStar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStar1.FlatAppearance.BorderSize = 0;
            this.btnStar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar1.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.btnStar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnStar1.Location = new System.Drawing.Point(4, 4);
            this.btnStar1.Name = "btnStar1";
            this.btnStar1.Size = new System.Drawing.Size(56, 56);
            this.btnStar1.TabIndex = 0;
            this.btnStar1.Text = "☆";
            this.btnStar1.UseVisualStyleBackColor = false;
            // 
            // btnStar2
            // 
            this.btnStar2.BackColor = System.Drawing.Color.Transparent;
            this.btnStar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStar2.FlatAppearance.BorderSize = 0;
            this.btnStar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar2.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.btnStar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnStar2.Location = new System.Drawing.Point(66, 3);
            this.btnStar2.Name = "btnStar2";
            this.btnStar2.Size = new System.Drawing.Size(56, 56);
            this.btnStar2.TabIndex = 1;
            this.btnStar2.Text = "☆";
            this.btnStar2.UseVisualStyleBackColor = false;
            // 
            // btnStar3
            // 
            this.btnStar3.BackColor = System.Drawing.Color.Transparent;
            this.btnStar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStar3.FlatAppearance.BorderSize = 0;
            this.btnStar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar3.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.btnStar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnStar3.Location = new System.Drawing.Point(128, 4);
            this.btnStar3.Name = "btnStar3";
            this.btnStar3.Size = new System.Drawing.Size(56, 56);
            this.btnStar3.TabIndex = 2;
            this.btnStar3.Text = "☆";
            this.btnStar3.UseVisualStyleBackColor = false;
            // 
            // btnStar4
            // 
            this.btnStar4.BackColor = System.Drawing.Color.Transparent;
            this.btnStar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStar4.FlatAppearance.BorderSize = 0;
            this.btnStar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar4.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.btnStar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnStar4.Location = new System.Drawing.Point(182, 4);
            this.btnStar4.Name = "btnStar4";
            this.btnStar4.Size = new System.Drawing.Size(56, 56);
            this.btnStar4.TabIndex = 3;
            this.btnStar4.Text = "☆";
            this.btnStar4.UseVisualStyleBackColor = false;
            // 
            // btnStar5
            // 
            this.btnStar5.BackColor = System.Drawing.Color.Transparent;
            this.btnStar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStar5.FlatAppearance.BorderSize = 0;
            this.btnStar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar5.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.btnStar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnStar5.Location = new System.Drawing.Point(244, 5);
            this.btnStar5.Name = "btnStar5";
            this.btnStar5.Size = new System.Drawing.Size(56, 56);
            this.btnStar5.TabIndex = 4;
            this.btnStar5.Text = "☆";
            this.btnStar5.UseVisualStyleBackColor = false;
            // 
            // lblRatingLabel
            // 
            this.lblRatingLabel.AutoSize = true;
            this.lblRatingLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRatingLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblRatingLabel.Location = new System.Drawing.Point(24, 118);
            this.lblRatingLabel.Name = "lblRatingLabel";
            this.lblRatingLabel.Size = new System.Drawing.Size(128, 20);
            this.lblRatingLabel.TabIndex = 2;
            this.lblRatingLabel.Text = "Tap a star to rate";
            // 
            // lblFeedbackPrompt
            // 
            this.lblFeedbackPrompt.AutoSize = true;
            this.lblFeedbackPrompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFeedbackPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFeedbackPrompt.Location = new System.Drawing.Point(24, 150);
            this.lblFeedbackPrompt.Name = "lblFeedbackPrompt";
            this.lblFeedbackPrompt.Size = new System.Drawing.Size(234, 19);
            this.lblFeedbackPrompt.TabIndex = 3;
            this.lblFeedbackPrompt.Text = "Share your experience (optional):";
            // 
            // txtFeedback
            // 
            this.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedback.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFeedback.Location = new System.Drawing.Point(24, 176);
            this.txtFeedback.MaxLength = 500;
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeedback.Size = new System.Drawing.Size(600, 110);
            this.txtFeedback.TabIndex = 4;
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCharCount.Location = new System.Drawing.Point(24, 290);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(90, 13);
            this.lblCharCount.TabIndex = 5;
            this.lblCharCount.Text = "0/500 characters";
            // 
            // lblPhotoPrompt
            // 
            this.lblPhotoPrompt.AutoSize = true;
            this.lblPhotoPrompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhotoPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPhotoPrompt.Location = new System.Drawing.Point(24, 318);
            this.lblPhotoPrompt.Name = "lblPhotoPrompt";
            this.lblPhotoPrompt.Size = new System.Drawing.Size(280, 19);
            this.lblPhotoPrompt.TabIndex = 6;
            this.lblPhotoPrompt.Text = "Add a photo from your event (optional):";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.Black;
            this.btnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.Plum;
            this.btnUploadPhoto.Location = new System.Drawing.Point(24, 344);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(150, 34);
            this.btnUploadPhoto.TabIndex = 7;
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // btnRemovePhoto
            // 
            this.btnRemovePhoto.BackColor = System.Drawing.Color.Black;
            this.btnRemovePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePhoto.FlatAppearance.BorderSize = 0;
            this.btnRemovePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePhoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemovePhoto.ForeColor = System.Drawing.Color.Plum;
            this.btnRemovePhoto.Location = new System.Drawing.Point(182, 344);
            this.btnRemovePhoto.Name = "btnRemovePhoto";
            this.btnRemovePhoto.Size = new System.Drawing.Size(90, 34);
            this.btnRemovePhoto.TabIndex = 8;
            this.btnRemovePhoto.Text = "Remove";
            this.btnRemovePhoto.UseVisualStyleBackColor = false;
            this.btnRemovePhoto.Visible = false;
            this.btnRemovePhoto.Click += new System.EventHandler(this.btnRemovePhoto_Click);
            // 
            // lblPhotoName
            // 
            this.lblPhotoName.AutoSize = true;
            this.lblPhotoName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhotoName.ForeColor = System.Drawing.Color.Gray;
            this.lblPhotoName.Location = new System.Drawing.Point(24, 384);
            this.lblPhotoName.Name = "lblPhotoName";
            this.lblPhotoName.Size = new System.Drawing.Size(104, 15);
            this.lblPhotoName.TabIndex = 9;
            this.lblPhotoName.Text = "No photo selected";
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(24, 406);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(200, 140);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 10;
            this.picPreview.TabStop = false;
            this.picPreview.Visible = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Black;
            this.panelFooter.Controls.Add(this.btnSubmit);
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 629);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(680, 60);
            this.panelFooter.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Plum;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(24, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 40);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Review";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Plum;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(194, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 689);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rate Your Experience";
            this.Load += new System.EventHandler(this.frmRateOrder_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelStars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel      panelHeader, panelBody, panelFooter, panelStars;
        private System.Windows.Forms.Label      lblTitle, lblOrderId, lblStarPrompt, lblRatingLabel;
        private System.Windows.Forms.Button     btnStar1, btnStar2, btnStar3, btnStar4, btnStar5;
        private System.Windows.Forms.Label      lblFeedbackPrompt, lblCharCount;
        private System.Windows.Forms.TextBox    txtFeedback;
        private System.Windows.Forms.Label      lblPhotoPrompt, lblPhotoName;
        private System.Windows.Forms.Button     btnUploadPhoto, btnRemovePhoto;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button     btnSubmit, btnCancel;
    }
}
