namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminNotifications
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUnreadCount = new System.Windows.Forms.Label();
            this.btnMarkAllRead = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.flowNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblUnreadCount);
            this.panelTop.Controls.Add(this.btnMarkAllRead);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Notifications";
            // 
            // lblUnreadCount
            // 
            this.lblUnreadCount.AutoSize = true;
            this.lblUnreadCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnreadCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblUnreadCount.Location = new System.Drawing.Point(160, 18);
            this.lblUnreadCount.Name = "lblUnreadCount";
            this.lblUnreadCount.Size = new System.Drawing.Size(66, 19);
            this.lblUnreadCount.TabIndex = 1;
            this.lblUnreadCount.Text = "0 Unread";
            // 
            // btnMarkAllRead
            // 
            this.btnMarkAllRead.BackColor = System.Drawing.Color.White;
            this.btnMarkAllRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkAllRead.FlatAppearance.BorderSize = 0;
            this.btnMarkAllRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAllRead.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarkAllRead.ForeColor = System.Drawing.Color.Black;
            this.btnMarkAllRead.Location = new System.Drawing.Point(560, 14);
            this.btnMarkAllRead.Name = "btnMarkAllRead";
            this.btnMarkAllRead.Size = new System.Drawing.Size(110, 32);
            this.btnMarkAllRead.TabIndex = 2;
            this.btnMarkAllRead.Text = "Mark All Read";
            this.btnMarkAllRead.UseVisualStyleBackColor = false;
            this.btnMarkAllRead.Click += new System.EventHandler(this.btnMarkAllRead_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(680, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // flowNotifications
            // 
            this.flowNotifications.AutoScroll = true;
            this.flowNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.flowNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNotifications.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNotifications.Location = new System.Drawing.Point(0, 60);
            this.flowNotifications.Name = "flowNotifications";
            this.flowNotifications.Padding = new System.Windows.Forms.Padding(10);
            this.flowNotifications.Size = new System.Drawing.Size(800, 440);
            this.flowNotifications.TabIndex = 0;
            this.flowNotifications.WrapContents = false;
            // 
            // frmAdminNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.flowNotifications);
            this.Controls.Add(this.panelTop);
            this.Name = "frmAdminNotifications";
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.frmAdminNotifications_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel           panelTop;
        private System.Windows.Forms.Label           lblTitle;
        private System.Windows.Forms.Label           lblUnreadCount;
        private System.Windows.Forms.Button          btnMarkAllRead;
        private System.Windows.Forms.Button          btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowNotifications;
    }
}
