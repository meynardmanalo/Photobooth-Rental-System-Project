namespace PhotoBoothRentalSystem.Controls
{
    partial class PackageCardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.lblNoPhoto = new System.Windows.Forms.Label();
            this.lblCamIcon = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.Black;
            this.panelTopBar.Controls.Add(this.lblType);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(280, 34);
            this.panelTopBar.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Plum;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(-2, 12);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(80, 22);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "STANDARD";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.LightPink;
            this.picPreview.Location = new System.Drawing.Point(0, 8);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(280, 140);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 1;
            this.picPreview.TabStop = false;
            // 
            // lblNoPhoto
            // 
            this.lblNoPhoto.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lblNoPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.lblNoPhoto.Location = new System.Drawing.Point(0, 8);
            this.lblNoPhoto.Name = "lblNoPhoto";
            this.lblNoPhoto.Size = new System.Drawing.Size(280, 140);
            this.lblNoPhoto.TabIndex = 2;
            this.lblNoPhoto.Text = "📸";
            this.lblNoPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoPhoto.Visible = false;
            // 
            // lblCamIcon
            // 
            this.lblCamIcon.AutoSize = true;
            this.lblCamIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblCamIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCamIcon.ForeColor = System.Drawing.Color.White;
            this.lblCamIcon.Location = new System.Drawing.Point(248, 116);
            this.lblCamIcon.Name = "lblCamIcon";
            this.lblCamIcon.Size = new System.Drawing.Size(19, 15);
            this.lblCamIcon.TabIndex = 3;
            this.lblCamIcon.Text = "📷";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblName.Location = new System.Drawing.Point(12, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(256, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Package Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblPrice.Location = new System.Drawing.Point(10, 186);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 30);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "₱ 0";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblHours.Location = new System.Drawing.Point(12, 218);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(65, 15);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "⏱  2 Hours";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblRating.Location = new System.Drawing.Point(150, 218);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(94, 15);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "☆☆☆☆☆  New";
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblDesc.Location = new System.Drawing.Point(12, 248);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(256, 36);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Package description goes here...";
            // 
            // panelDivider
            // 
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelDivider.Location = new System.Drawing.Point(12, 240);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(256, 1);
            this.panelDivider.TabIndex = 8;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Black;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBook.ForeColor = System.Drawing.Color.Pink;
            this.btnBook.Location = new System.Drawing.Point(12, 292);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(256, 38);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "View Details & Book  →";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // PackageCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lblNoPhoto);
            this.Controls.Add(this.lblCamIcon);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.panelDivider);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnBook);
            this.Name = "PackageCardControl";
            this.Size = new System.Drawing.Size(280, 340);
            this.panelTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel       panelTopBar;
        public  System.Windows.Forms.Label       lblType;
        private System.Windows.Forms.PictureBox  picPreview;
        private System.Windows.Forms.Label       lblNoPhoto;
        private System.Windows.Forms.Label       lblCamIcon;
        public  System.Windows.Forms.Label       lblName;
        public  System.Windows.Forms.Label       lblPrice;
        public  System.Windows.Forms.Label       lblHours;
        public  System.Windows.Forms.Label       lblRating;
        private System.Windows.Forms.Panel       panelDivider;
        public  System.Windows.Forms.Label       lblDesc;
        public  System.Windows.Forms.Button      btnBook;
    }
}
