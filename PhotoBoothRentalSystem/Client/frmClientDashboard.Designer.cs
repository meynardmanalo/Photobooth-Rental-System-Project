
namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmClientDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientDashboard));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnRatings = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblNotificationBadge = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnNotifications);
            this.panelSidebar.Controls.Add(this.btnChat);
            this.panelSidebar.Controls.Add(this.btnRatings);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnMyOrders);
            this.panelSidebar.Controls.Add(this.btnPackages);
            this.panelSidebar.Controls.Add(this.lblUserEmail);
            this.panelSidebar.Controls.Add(this.lblUserName);
            this.panelSidebar.Controls.Add(this.picUserAvatar);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 703);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(29, 619);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(195, 59);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.LightPink;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(29, 554);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(195, 59);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.LightPink;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNotifications.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.Location = new System.Drawing.Point(29, 495);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(195, 53);
            this.btnNotifications.TabIndex = 8;
            this.btnNotifications.Text = "Notification";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.LightPink;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.Location = new System.Drawing.Point(29, 435);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(195, 53);
            this.btnChat.TabIndex = 7;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnRatings
            // 
            this.btnRatings.BackColor = System.Drawing.Color.LightPink;
            this.btnRatings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRatings.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatings.Location = new System.Drawing.Point(29, 376);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(195, 53);
            this.btnRatings.TabIndex = 6;
            this.btnRatings.Text = "Ratings";
            this.btnRatings.UseVisualStyleBackColor = false;
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.LightPink;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(29, 317);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(195, 53);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.Color.LightPink;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyOrders.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyOrders.Location = new System.Drawing.Point(29, 258);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(195, 53);
            this.btnMyOrders.TabIndex = 4;
            this.btnMyOrders.Text = "My Orders";
            this.btnMyOrders.UseVisualStyleBackColor = false;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.LightPink;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPackages.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.Location = new System.Drawing.Point(29, 199);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(195, 53);
            this.btnPackages.TabIndex = 3;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.Location = new System.Drawing.Point(44, 173);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(42, 15);
            this.lblUserEmail.TabIndex = 2;
            this.lblUserEmail.Text = "EMAIl";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(92, 143);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(39, 15);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "USER";
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUserAvatar.BackgroundImage")));
            this.picUserAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUserAvatar.Location = new System.Drawing.Point(66, 34);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(100, 94);
            this.picUserAvatar.TabIndex = 0;
            this.picUserAvatar.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Thistle;
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.lblNotificationBadge);
            this.panelHeader.Controls.Add(this.lblPageTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(550, 80);
            this.panelHeader.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(444, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 38);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblNotificationBadge
            // 
            this.lblNotificationBadge.AutoSize = true;
            this.lblNotificationBadge.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationBadge.Location = new System.Drawing.Point(304, 34);
            this.lblNotificationBadge.Name = "lblNotificationBadge";
            this.lblNotificationBadge.Size = new System.Drawing.Size(108, 17);
            this.lblNotificationBadge.TabIndex = 1;
            this.lblNotificationBadge.Text = "NOTIFICATION";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(39, 34);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(96, 17);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "DASHBOARD";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Pink;
            this.panelContent.Controls.Add(this.panel4);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(550, 623);
            this.panelContent.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(261, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 8);
            this.panel4.TabIndex = 0;
            // 
            // frmClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "frmClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zass PhotoBooth";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClientDashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnRatings;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblNotificationBadge;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel4;
    }
}