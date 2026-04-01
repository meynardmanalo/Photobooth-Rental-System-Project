
namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmClientNotifications
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
            this.panelActions = new System.Windows.Forms.Panel();
            this.lblUnreadCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMarkAllRead = new System.Windows.Forms.Button();
            this.flowNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.Thistle;
            this.panelActions.Controls.Add(this.lblUnreadCount);
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Controls.Add(this.btnMarkAllRead);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(800, 85);
            this.panelActions.TabIndex = 0;
            // 
            // lblUnreadCount
            // 
            this.lblUnreadCount.AutoSize = true;
            this.lblUnreadCount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnreadCount.Location = new System.Drawing.Point(31, 62);
            this.lblUnreadCount.Name = "lblUnreadCount";
            this.lblUnreadCount.Size = new System.Drawing.Size(46, 15);
            this.lblUnreadCount.TabIndex = 2;
            this.lblUnreadCount.Text = "0 unread";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Plum;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(216, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 39);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnMarkAllRead
            // 
            this.btnMarkAllRead.BackColor = System.Drawing.Color.Plum;
            this.btnMarkAllRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarkAllRead.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAllRead.Location = new System.Drawing.Point(28, 15);
            this.btnMarkAllRead.Name = "btnMarkAllRead";
            this.btnMarkAllRead.Size = new System.Drawing.Size(151, 39);
            this.btnMarkAllRead.TabIndex = 0;
            this.btnMarkAllRead.Text = "Mark all as read";
            this.btnMarkAllRead.UseVisualStyleBackColor = false;
            // 
            // flowNotifications
            // 
            this.flowNotifications.AutoScroll = true;
            this.flowNotifications.BackColor = System.Drawing.Color.Pink;
            this.flowNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNotifications.Location = new System.Drawing.Point(0, 85);
            this.flowNotifications.Name = "flowNotifications";
            this.flowNotifications.Size = new System.Drawing.Size(800, 365);
            this.flowNotifications.TabIndex = 1;
            // 
            // frmClientNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowNotifications);
            this.Controls.Add(this.panelActions);
            this.Name = "frmClientNotifications";
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.frmClientNotifications_Load);
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Label lblUnreadCount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMarkAllRead;
        private System.Windows.Forms.FlowLayoutPanel flowNotifications;
    }
}