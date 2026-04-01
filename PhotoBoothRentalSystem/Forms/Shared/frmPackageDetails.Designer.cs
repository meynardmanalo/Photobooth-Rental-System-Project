namespace PhotoBoothRentalSystem.Forms.Shared
{
    partial class frmPackageDetails
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelFeedbacks = new System.Windows.Forms.Panel();
            this.lblFeedbackTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescTitle = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblOrderCountLabel = new System.Windows.Forms.Label();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.lblRatingLabel = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblAvgRating = new System.Windows.Forms.Label();
            this.panelGallery = new System.Windows.Forms.Panel();
            this.flowThumbs = new System.Windows.Forms.FlowLayoutPanel();
            this.lblImageCount = new System.Windows.Forms.Label();
            this.lblNoPhoto = new System.Windows.Forms.Label();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Thistle;
            this.panelHeader.Controls.Add(this.lblPackageName);
            this.panelHeader.Controls.Add(this.lblType);
            this.panelHeader.Controls.Add(this.lblPrice);
            this.panelHeader.Controls.Add(this.lblHours);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.Black;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.panelHeader.Size = new System.Drawing.Size(900, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPackageName.ForeColor = System.Drawing.Color.Black;
            this.lblPackageName.Location = new System.Drawing.Point(20, 12);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(182, 32);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Package Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(22, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 15);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "STANDARD";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(20, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "P 0.00";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.lblHours.Location = new System.Drawing.Point(220, 72);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(58, 19);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "0 Hours";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelContent.Controls.Add(this.panelInfo);
            this.panelContent.Controls.Add(this.panelGallery);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(900, 418);
            this.panelContent.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.BackColor = System.Drawing.Color.Pink;
            this.panelInfo.Controls.Add(this.panelFeedbacks);
            this.panelInfo.Controls.Add(this.lblFeedbackTitle);
            this.panelInfo.Controls.Add(this.lblDescription);
            this.panelInfo.Controls.Add(this.lblDescTitle);
            this.panelInfo.Controls.Add(this.panelStats);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(460, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.panelInfo.Size = new System.Drawing.Size(440, 418);
            this.panelInfo.TabIndex = 0;
            // 
            // panelFeedbacks
            // 
            this.panelFeedbacks.AutoScroll = true;
            this.panelFeedbacks.BackColor = System.Drawing.Color.LightPink;
            this.panelFeedbacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeedbacks.Location = new System.Drawing.Point(14, 202);
            this.panelFeedbacks.Name = "panelFeedbacks";
            this.panelFeedbacks.Padding = new System.Windows.Forms.Padding(4);
            this.panelFeedbacks.Size = new System.Drawing.Size(412, 206);
            this.panelFeedbacks.TabIndex = 0;
            // 
            // lblFeedbackTitle
            // 
            this.lblFeedbackTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFeedbackTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFeedbackTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFeedbackTitle.Location = new System.Drawing.Point(14, 170);
            this.lblFeedbackTitle.Name = "lblFeedbackTitle";
            this.lblFeedbackTitle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblFeedbackTitle.Size = new System.Drawing.Size(412, 32);
            this.lblFeedbackTitle.TabIndex = 1;
            this.lblFeedbackTitle.Text = "Customer Reviews";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Pink;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDescription.Location = new System.Drawing.Point(14, 110);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(412, 60);
            this.lblDescription.TabIndex = 2;
            // 
            // lblDescTitle
            // 
            this.lblDescTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDescTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDescTitle.Location = new System.Drawing.Point(14, 80);
            this.lblDescTitle.Name = "lblDescTitle";
            this.lblDescTitle.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblDescTitle.Size = new System.Drawing.Size(412, 30);
            this.lblDescTitle.TabIndex = 3;
            this.lblDescTitle.Text = "About this Package";
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.LightPink;
            this.panelStats.Controls.Add(this.lblOrderCountLabel);
            this.panelStats.Controls.Add(this.lblOrderCount);
            this.panelStats.Controls.Add(this.lblRatingLabel);
            this.panelStats.Controls.Add(this.lblStars);
            this.panelStats.Controls.Add(this.lblAvgRating);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(14, 10);
            this.panelStats.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelStats.Size = new System.Drawing.Size(412, 70);
            this.panelStats.TabIndex = 4;
            // 
            // lblOrderCountLabel
            // 
            this.lblOrderCountLabel.AutoSize = true;
            this.lblOrderCountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblOrderCountLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblOrderCountLabel.Location = new System.Drawing.Point(10, 8);
            this.lblOrderCountLabel.Name = "lblOrderCountLabel";
            this.lblOrderCountLabel.Size = new System.Drawing.Size(83, 13);
            this.lblOrderCountLabel.TabIndex = 0;
            this.lblOrderCountLabel.Text = "Total Bookings";
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblOrderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblOrderCount.Location = new System.Drawing.Point(10, 22);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(24, 28);
            this.lblOrderCount.TabIndex = 1;
            this.lblOrderCount.Text = "0";
            // 
            // lblRatingLabel
            // 
            this.lblRatingLabel.AutoSize = true;
            this.lblRatingLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRatingLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblRatingLabel.Location = new System.Drawing.Point(160, 8);
            this.lblRatingLabel.Name = "lblRatingLabel";
            this.lblRatingLabel.Size = new System.Drawing.Size(85, 13);
            this.lblRatingLabel.TabIndex = 2;
            this.lblRatingLabel.Text = "Average Rating";
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblStars.ForeColor = System.Drawing.Color.Silver;
            this.lblStars.Location = new System.Drawing.Point(160, 22);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(97, 28);
            this.lblStars.TabIndex = 3;
            this.lblStars.Text = "☆☆☆☆☆";
            // 
            // lblAvgRating
            // 
            this.lblAvgRating.AutoSize = true;
            this.lblAvgRating.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAvgRating.ForeColor = System.Drawing.Color.Gray;
            this.lblAvgRating.Location = new System.Drawing.Point(330, 30);
            this.lblAvgRating.Name = "lblAvgRating";
            this.lblAvgRating.Size = new System.Drawing.Size(79, 13);
            this.lblAvgRating.TabIndex = 4;
            this.lblAvgRating.Text = "No ratings yet";
            // 
            // panelGallery
            // 
            this.panelGallery.BackColor = System.Drawing.Color.Pink;
            this.panelGallery.Controls.Add(this.flowThumbs);
            this.panelGallery.Controls.Add(this.lblImageCount);
            this.panelGallery.Controls.Add(this.lblNoPhoto);
            this.panelGallery.Controls.Add(this.picMain);
            this.panelGallery.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGallery.Location = new System.Drawing.Point(0, 0);
            this.panelGallery.Name = "panelGallery";
            this.panelGallery.Padding = new System.Windows.Forms.Padding(10);
            this.panelGallery.Size = new System.Drawing.Size(460, 418);
            this.panelGallery.TabIndex = 1;
            // 
            // flowThumbs
            // 
            this.flowThumbs.AutoScroll = true;
            this.flowThumbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.flowThumbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowThumbs.Location = new System.Drawing.Point(10, 322);
            this.flowThumbs.Name = "flowThumbs";
            this.flowThumbs.Padding = new System.Windows.Forms.Padding(4);
            this.flowThumbs.Size = new System.Drawing.Size(440, 86);
            this.flowThumbs.TabIndex = 0;
            // 
            // lblImageCount
            // 
            this.lblImageCount.BackColor = System.Drawing.Color.Pink;
            this.lblImageCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImageCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblImageCount.ForeColor = System.Drawing.Color.Gray;
            this.lblImageCount.Location = new System.Drawing.Point(10, 300);
            this.lblImageCount.Name = "lblImageCount";
            this.lblImageCount.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblImageCount.Size = new System.Drawing.Size(440, 22);
            this.lblImageCount.TabIndex = 1;
            this.lblImageCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNoPhoto
            // 
            this.lblNoPhoto.BackColor = System.Drawing.Color.LightPink;
            this.lblNoPhoto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNoPhoto.ForeColor = System.Drawing.Color.Silver;
            this.lblNoPhoto.Location = new System.Drawing.Point(10, 10);
            this.lblNoPhoto.Name = "lblNoPhoto";
            this.lblNoPhoto.Size = new System.Drawing.Size(440, 290);
            this.lblNoPhoto.TabIndex = 2;
            this.lblNoPhoto.Text = "No sample photos";
            this.lblNoPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoPhoto.Visible = false;
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.picMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.picMain.Location = new System.Drawing.Point(10, 10);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(440, 290);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 3;
            this.picMain.TabStop = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.Controls.Add(this.btnBookNow);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 518);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.panelBottom.Size = new System.Drawing.Size(900, 62);
            this.panelBottom.TabIndex = 2;
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.Plum;
            this.btnBookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookNow.FlatAppearance.BorderSize = 0;
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookNow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBookNow.ForeColor = System.Drawing.Color.Black;
            this.btnBookNow.Location = new System.Drawing.Point(16, 10);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(160, 42);
            this.btnBookNow.TabIndex = 0;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.Location = new System.Drawing.Point(186, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPackageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelBottom);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmPackageDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package Details";
            this.Load += new System.EventHandler(this.frmPackageDetails_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panelGallery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel          panelHeader;
        private System.Windows.Forms.Label          lblPackageName, lblType, lblPrice, lblHours;
        private System.Windows.Forms.Panel          panelContent;
        private System.Windows.Forms.Panel          panelGallery;
        private System.Windows.Forms.PictureBox     picMain;
        private System.Windows.Forms.Label          lblNoPhoto;
        private System.Windows.Forms.Label          lblImageCount;
        private System.Windows.Forms.FlowLayoutPanel flowThumbs;
        private System.Windows.Forms.Panel          panelInfo;
        private System.Windows.Forms.Panel          panelStats;
        private System.Windows.Forms.Label          lblOrderCountLabel, lblOrderCount;
        private System.Windows.Forms.Label          lblRatingLabel, lblStars, lblAvgRating;
        private System.Windows.Forms.Label          lblDescTitle, lblDescription;
        private System.Windows.Forms.Label          lblFeedbackTitle;
        private System.Windows.Forms.Panel          panelFeedbacks;
        private System.Windows.Forms.Panel          panelBottom;
        private System.Windows.Forms.Button         btnBookNow, btnClose;
    }
}
