namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmClientPackages
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.flowPackages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Thistle;
            this.panelHeader.Controls.Add(this.lblPageTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.panelHeader.Size = new System.Drawing.Size(900, 80);
            this.panelHeader.TabIndex = 2;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.Black;
            this.lblPageTitle.Location = new System.Drawing.Point(16, 10);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(217, 32);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "📦  Our Packages";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblSubtitle.Location = new System.Drawing.Point(18, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(254, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Choose a package that fits your event perfectly";
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.LightPink;
            this.panelToolbar.Controls.Add(this.lblSearchIcon);
            this.panelToolbar.Controls.Add(this.txtSearch);
            this.panelToolbar.Controls.Add(this.lblFilter);
            this.panelToolbar.Controls.Add(this.cboFilter);
            this.panelToolbar.Controls.Add(this.lblSort);
            this.panelToolbar.Controls.Add(this.cboSort);
            this.panelToolbar.Controls.Add(this.btnRefresh);
            this.panelToolbar.Controls.Add(this.lblCount);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 80);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelToolbar.Size = new System.Drawing.Size(900, 50);
            this.panelToolbar.TabIndex = 1;
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearchIcon.Location = new System.Drawing.Point(14, 14);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(30, 20);
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "🔍";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(50, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilter.ForeColor = System.Drawing.Color.Gray;
            this.lblFilter.Location = new System.Drawing.Point(256, 17);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(34, 15);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Type:";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFilter.Items.AddRange(new object[] {
            "All Types",
            "Basic",
            "Standard",
            "Premium",
            "Deluxe",
            "Wedding",
            "Mini"});
            this.cboFilter.Location = new System.Drawing.Point(296, 12);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(130, 23);
            this.cboFilter.TabIndex = 3;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSort.ForeColor = System.Drawing.Color.Gray;
            this.lblSort.Location = new System.Drawing.Point(428, 16);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(31, 15);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Sort:";
            // 
            // cboSort
            // 
            this.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboSort.Items.AddRange(new object[] {
            "Price: Low to High",
            "Price: High to Low",
            "Name: A-Z",
            "Hours: Most"});
            this.cboSort.Location = new System.Drawing.Point(462, 12);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(170, 23);
            this.cboSort.TabIndex = 5;
            this.cboSort.SelectedIndexChanged += new System.EventHandler(this.cboSort_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(644, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 30);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "↺";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCount.Location = new System.Drawing.Point(690, 18);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 15);
            this.lblCount.TabIndex = 7;
            // 
            // flowPackages
            // 
            this.flowPackages.AutoScroll = true;
            this.flowPackages.BackColor = System.Drawing.Color.Pink;
            this.flowPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPackages.Location = new System.Drawing.Point(0, 130);
            this.flowPackages.Name = "flowPackages";
            this.flowPackages.Padding = new System.Windows.Forms.Padding(8);
            this.flowPackages.Size = new System.Drawing.Size(900, 470);
            this.flowPackages.TabIndex = 0;
            // 
            // frmClientPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.flowPackages);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmClientPackages";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.frmClientPackages_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel          panelHeader;
        private System.Windows.Forms.Label          lblPageTitle, lblSubtitle;
        private System.Windows.Forms.Panel          panelToolbar;
        private System.Windows.Forms.Label          lblSearchIcon, lblFilter, lblSort, lblCount;
        private System.Windows.Forms.TextBox        txtSearch;
        private System.Windows.Forms.ComboBox       cboFilter, cboSort;
        private System.Windows.Forms.Button         btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowPackages;
    }
}
