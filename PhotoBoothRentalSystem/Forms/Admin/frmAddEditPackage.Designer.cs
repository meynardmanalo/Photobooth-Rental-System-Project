namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAddEditPackage
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle       = new System.Windows.Forms.Label();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblPackageType = new System.Windows.Forms.Label();
            this.txtPackageType = new System.Windows.Forms.TextBox();
            this.lblPrice       = new System.Windows.Forms.Label();
            this.numPrice       = new System.Windows.Forms.NumericUpDown();
            this.lblHours       = new System.Windows.Forms.Label();
            this.numHours       = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPhotos   = new System.Windows.Forms.Label();
            this.numMaxPhotos   = new System.Windows.Forms.NumericUpDown();
            this.lblPhotosHint  = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkIsActive    = new System.Windows.Forms.CheckBox();
            this.btnSave        = new System.Windows.Forms.Button();
            this.btnCancel      = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPhotos)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.Location = new System.Drawing.Point(52, 20);
            this.lblTitle.Text = "ADD EDIT";

            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblPackageName.Location = new System.Drawing.Point(20, 68);
            this.lblPackageName.Text = "Package Name:";

            this.txtPackageName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPackageName.Location = new System.Drawing.Point(180, 64);
            this.txtPackageName.Size = new System.Drawing.Size(280, 26);

            this.lblPackageType.AutoSize = true;
            this.lblPackageType.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblPackageType.Location = new System.Drawing.Point(20, 108);
            this.lblPackageType.Text = "Package Type:";

            this.txtPackageType.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPackageType.Location = new System.Drawing.Point(180, 104);
            this.txtPackageType.Size = new System.Drawing.Size(280, 26);

            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblPrice.Location = new System.Drawing.Point(20, 148);
            this.lblPrice.Text = "Price (PHP):";

            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.numPrice.Location = new System.Drawing.Point(180, 144);
            this.numPrice.Size = new System.Drawing.Size(200, 26);
            this.numPrice.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            this.numPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPrice.Value   = new decimal(new int[] { 2500, 0, 0, 0 });

            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblHours.Location = new System.Drawing.Point(20, 188);
            this.lblHours.Text = "Duration (hrs):";

            this.numHours.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.numHours.Location = new System.Drawing.Point(180, 184);
            this.numHours.Size = new System.Drawing.Size(100, 26);
            this.numHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            this.numHours.Value   = new decimal(new int[] { 2, 0, 0, 0 });

            this.lblMaxPhotos.AutoSize = true;
            this.lblMaxPhotos.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblMaxPhotos.Location = new System.Drawing.Point(20, 228);
            this.lblMaxPhotos.Text = "Max Prints:";

            this.numMaxPhotos.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.numMaxPhotos.Location = new System.Drawing.Point(180, 224);
            this.numMaxPhotos.Size = new System.Drawing.Size(100, 26);
            this.numMaxPhotos.Minimum  = new decimal(new int[] { 10, 0, 0, 0 });
            this.numMaxPhotos.Maximum  = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numMaxPhotos.Value    = new decimal(new int[] { 100, 0, 0, 0 });
            this.numMaxPhotos.Increment= new decimal(new int[] { 10, 0, 0, 0 });

            this.lblPhotosHint.AutoSize = true;
            this.lblPhotosHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPhotosHint.ForeColor = System.Drawing.Color.Gray;
            this.lblPhotosHint.Location = new System.Drawing.Point(290, 230);
            this.lblPhotosHint.Text = "photo prints included";

            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblDescription.Location = new System.Drawing.Point(20, 268);
            this.lblDescription.Text = "Description:";

            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDescription.Location = new System.Drawing.Point(147, 264);
            this.txtDescription.Multiline = true;
            this.txtDescription.Size = new System.Drawing.Size(316, 120);
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkIsActive.Location = new System.Drawing.Point(147, 394);
            this.chkIsActive.Text = "Active (visible to clients)";
            this.chkIsActive.Checked = true;

            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(147, 428);
            this.btnSave.Size = new System.Drawing.Size(95, 38);
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(277, 428);
            this.btnCancel.Size = new System.Drawing.Size(95, 38);
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(499, 484);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Package";
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            { this.lblTitle, this.lblPackageName, this.txtPackageName,
              this.lblPackageType, this.txtPackageType, this.lblPrice, this.numPrice,
              this.lblHours, this.numHours, this.lblMaxPhotos, this.numMaxPhotos, this.lblPhotosHint,
              this.lblDescription, this.txtDescription, this.chkIsActive,
              this.btnSave, this.btnCancel });
            this.Load += new System.EventHandler(this.frmAddEditPackage_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPhotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label         lblTitle;
        private System.Windows.Forms.Label         lblPackageName;
        private System.Windows.Forms.TextBox       txtPackageName;
        private System.Windows.Forms.Label         lblPackageType;
        public  System.Windows.Forms.TextBox       txtPackageType;
        private System.Windows.Forms.Label         lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label         lblHours;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label         lblMaxPhotos;
        private System.Windows.Forms.NumericUpDown numMaxPhotos;
        private System.Windows.Forms.Label         lblPhotosHint;
        private System.Windows.Forms.Label         lblDescription;
        private System.Windows.Forms.TextBox       txtDescription;
        private System.Windows.Forms.CheckBox      chkIsActive;
        private System.Windows.Forms.Button        btnSave;
        private System.Windows.Forms.Button        btnCancel;
    }
}
