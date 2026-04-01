namespace PhotoBoothRentalSystem.Forms.Shared
{
    partial class frmLocationPicker
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
            this.webMap = new System.Windows.Forms.WebBrowser();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnUseLocation = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // webMap
            // 
            this.webMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMap.Location = new System.Drawing.Point(0, 0);
            this.webMap.Name = "webMap";
            this.webMap.ScriptErrorsSuppressed = true;
            this.webMap.Size = new System.Drawing.Size(860, 580);
            this.webMap.TabIndex = 0;
            this.webMap.WebBrowserShortcutsEnabled = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.LightPink;
            this.panelBottom.Controls.Add(this.lblAddressLabel);
            this.panelBottom.Controls.Add(this.txtAddress);
            this.panelBottom.Controls.Add(this.btnUseLocation);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 520);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelBottom.Size = new System.Drawing.Size(860, 60);
            this.panelBottom.TabIndex = 0;
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddressLabel.ForeColor = System.Drawing.Color.Black;
            this.lblAddressLabel.Location = new System.Drawing.Point(10, 20);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(54, 15);
            this.lblAddressLabel.TabIndex = 0;
            this.lblAddressLabel.Text = "Selected:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(72, 15);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(520, 25);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // btnUseLocation
            // 
            this.btnUseLocation.BackColor = System.Drawing.Color.Plum;
            this.btnUseLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUseLocation.FlatAppearance.BorderSize = 0;
            this.btnUseLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUseLocation.ForeColor = System.Drawing.Color.Black;
            this.btnUseLocation.Location = new System.Drawing.Point(602, 12);
            this.btnUseLocation.Name = "btnUseLocation";
            this.btnUseLocation.Size = new System.Drawing.Size(150, 36);
            this.btnUseLocation.TabIndex = 2;
            this.btnUseLocation.Text = "Use This Location";
            this.btnUseLocation.UseVisualStyleBackColor = false;
            this.btnUseLocation.Click += new System.EventHandler(this.btnUseLocation_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(760, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmLocationPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.webMap);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "frmLocationPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick Event Location";
            this.Load += new System.EventHandler(this.frmLocationPicker_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webMap;
        private System.Windows.Forms.Panel      panelBottom;
        private System.Windows.Forms.Label      lblAddressLabel;
        private System.Windows.Forms.TextBox    txtAddress;
        private System.Windows.Forms.Button     btnUseLocation;
        private System.Windows.Forms.Button     btnCancel;
    }
}
