
namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnRatings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblAdminRole = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblMessageBadge = new System.Windows.Forms.Label();
            this.lblNotificationBadge = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnNotifications);
            this.panelSidebar.Controls.Add(this.btnChat);
            this.panelSidebar.Controls.Add(this.btnRatings);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnPackages);
            this.panelSidebar.Controls.Add(this.btnUsers);
            this.panelSidebar.Controls.Add(this.btnOrders);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.lblAdminRole);
            this.panelSidebar.Controls.Add(this.lblAdminName);
            this.panelSidebar.Controls.Add(this.picAdminAvatar);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 603);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 502);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 27);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(0, 469);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(250, 27);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.Location = new System.Drawing.Point(0, 436);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(250, 27);
            this.btnNotifications.TabIndex = 10;
            this.btnNotifications.Text = "NOTIFICATIONS";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnChat
            // 
            this.btnChat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.Location = new System.Drawing.Point(0, 403);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(250, 27);
            this.btnChat.TabIndex = 9;
            this.btnChat.Text = "CHATS";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnRatings
            // 
            this.btnRatings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatings.Location = new System.Drawing.Point(0, 370);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(250, 27);
            this.btnRatings.TabIndex = 8;
            this.btnRatings.Text = "RATINGS";
            this.btnRatings.UseVisualStyleBackColor = true;
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(0, 337);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(250, 27);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.Location = new System.Drawing.Point(0, 304);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(250, 27);
            this.btnPackages.TabIndex = 6;
            this.btnPackages.Text = "PACKAGES";
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(0, 271);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(250, 27);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(0, 238);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(250, 27);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "ORDERS";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(0, 205);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(250, 27);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblAdminRole
            // 
            this.lblAdminRole.AutoSize = true;
            this.lblAdminRole.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRole.Location = new System.Drawing.Point(157, 150);
            this.lblAdminRole.Name = "lblAdminRole";
            this.lblAdminRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAdminRole.Size = new System.Drawing.Size(43, 15);
            this.lblAdminRole.TabIndex = 2;
            this.lblAdminRole.Text = "Admin";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(30, 150);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(38, 15);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "Name";
            // 
            // picAdminAvatar
            // 
            this.picAdminAvatar.BackColor = System.Drawing.Color.White;
            this.picAdminAvatar.Location = new System.Drawing.Point(66, 24);
            this.picAdminAvatar.Name = "picAdminAvatar";
            this.picAdminAvatar.Size = new System.Drawing.Size(100, 97);
            this.picAdminAvatar.TabIndex = 0;
            this.picAdminAvatar.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.lblMessageBadge);
            this.panelHeader.Controls.Add(this.lblNotificationBadge);
            this.panelHeader.Controls.Add(this.lblPageTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1050, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(304, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 27);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblMessageBadge
            // 
            this.lblMessageBadge.BackColor = System.Drawing.Color.Black;
            this.lblMessageBadge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBadge.ForeColor = System.Drawing.Color.White;
            this.lblMessageBadge.Location = new System.Drawing.Point(204, 21);
            this.lblMessageBadge.Name = "lblMessageBadge";
            this.lblMessageBadge.Size = new System.Drawing.Size(28, 20);
            this.lblMessageBadge.TabIndex = 2;
            this.lblMessageBadge.Text = "0";
            this.lblMessageBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessageBadge.Visible = false;
            // 
            // lblNotificationBadge
            // 
            this.lblNotificationBadge.BackColor = System.Drawing.Color.Black;
            this.lblNotificationBadge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationBadge.ForeColor = System.Drawing.Color.White;
            this.lblNotificationBadge.Location = new System.Drawing.Point(170, 21);
            this.lblNotificationBadge.Name = "lblNotificationBadge";
            this.lblNotificationBadge.Size = new System.Drawing.Size(28, 20);
            this.lblNotificationBadge.TabIndex = 1;
            this.lblNotificationBadge.Text = "0";
            this.lblNotificationBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotificationBadge.Visible = false;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(32, 24);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(122, 15);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "ADMININSTRATOR";
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1050, 503);
            this.panelContent.TabIndex = 2;
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 603);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zass PhotoBooth | Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnRatings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblAdminRole;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMessageBadge;
        private System.Windows.Forms.Label lblNotificationBadge;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelContent;
    }
}