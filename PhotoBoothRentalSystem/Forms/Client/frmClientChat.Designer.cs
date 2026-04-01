namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmClientChat
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
            this.components = new System.ComponentModel.Container();
            this.panelChatHeader = new System.Windows.Forms.Panel();
            this.lblOnlineStatus = new System.Windows.Forms.Label();
            this.lblChatWith = new System.Windows.Forms.Label();
            this.rtbConversation = new System.Windows.Forms.RichTextBox();
            this.panelPending = new System.Windows.Forms.Panel();
            this.lblPendingIcon = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingDesc = new System.Windows.Forms.Label();
            this.panelMessageInput = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.panelChatHeader.SuspendLayout();
            this.panelPending.SuspendLayout();
            this.panelMessageInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChatHeader
            // 
            this.panelChatHeader.BackColor = System.Drawing.Color.Black;
            this.panelChatHeader.Controls.Add(this.lblOnlineStatus);
            this.panelChatHeader.Controls.Add(this.lblChatWith);
            this.panelChatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatHeader.Location = new System.Drawing.Point(0, 0);
            this.panelChatHeader.Name = "panelChatHeader";
            this.panelChatHeader.Size = new System.Drawing.Size(800, 54);
            this.panelChatHeader.TabIndex = 0;
            // 
            // lblOnlineStatus
            // 
            this.lblOnlineStatus.AutoSize = true;
            this.lblOnlineStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOnlineStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblOnlineStatus.Location = new System.Drawing.Point(18, 32);
            this.lblOnlineStatus.Name = "lblOnlineStatus";
            this.lblOnlineStatus.Size = new System.Drawing.Size(49, 15);
            this.lblOnlineStatus.TabIndex = 1;
            this.lblOnlineStatus.Text = "● Ready";
            // 
            // lblChatWith
            // 
            this.lblChatWith.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChatWith.ForeColor = System.Drawing.Color.White;
            this.lblChatWith.Location = new System.Drawing.Point(16, 8);
            this.lblChatWith.Name = "lblChatWith";
            this.lblChatWith.Size = new System.Drawing.Size(320, 22);
            this.lblChatWith.TabIndex = 0;
            this.lblChatWith.Text = "Chat with Admin Support";
            // 
            // rtbConversation
            // 
            this.rtbConversation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.rtbConversation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbConversation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConversation.Location = new System.Drawing.Point(0, 54);
            this.rtbConversation.Name = "rtbConversation";
            this.rtbConversation.ReadOnly = true;
            this.rtbConversation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbConversation.Size = new System.Drawing.Size(800, 466);
            this.rtbConversation.TabIndex = 1;
            this.rtbConversation.Text = "";
            // 
            // panelPending
            // 
            this.panelPending.BackColor = System.Drawing.Color.Pink;
            this.panelPending.Controls.Add(this.lblPendingIcon);
            this.panelPending.Controls.Add(this.lblPendingTitle);
            this.panelPending.Controls.Add(this.lblPendingDesc);
            this.panelPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPending.Location = new System.Drawing.Point(0, 54);
            this.panelPending.Name = "panelPending";
            this.panelPending.Size = new System.Drawing.Size(800, 466);
            this.panelPending.TabIndex = 3;
            this.panelPending.Visible = false;
            // 
            // lblPendingIcon
            // 
            this.lblPendingIcon.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lblPendingIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblPendingIcon.Location = new System.Drawing.Point(0, 80);
            this.lblPendingIcon.Name = "lblPendingIcon";
            this.lblPendingIcon.Size = new System.Drawing.Size(800, 80);
            this.lblPendingIcon.TabIndex = 0;
            this.lblPendingIcon.Text = "⏳";
            this.lblPendingIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPendingTitle.Location = new System.Drawing.Point(0, 168);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(800, 36);
            this.lblPendingTitle.TabIndex = 1;
            this.lblPendingTitle.Text = "Waiting for Admin to Accept";
            this.lblPendingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingDesc
            // 
            this.lblPendingDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPendingDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblPendingDesc.Location = new System.Drawing.Point(100, 210);
            this.lblPendingDesc.Name = "lblPendingDesc";
            this.lblPendingDesc.Size = new System.Drawing.Size(600, 50);
            this.lblPendingDesc.TabIndex = 2;
            this.lblPendingDesc.Text = "Your message has been received. An admin will accept your chat shortly.\nThis page" +
    " will automatically update when accepted.";
            this.lblPendingDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMessageInput
            // 
            this.panelMessageInput.BackColor = System.Drawing.Color.Thistle;
            this.panelMessageInput.Controls.Add(this.btnSend);
            this.panelMessageInput.Controls.Add(this.txtMessage);
            this.panelMessageInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMessageInput.Location = new System.Drawing.Point(0, 450);
            this.panelMessageInput.Name = "panelMessageInput";
            this.panelMessageInput.Padding = new System.Windows.Forms.Padding(10);
            this.panelMessageInput.Size = new System.Drawing.Size(800, 70);
            this.panelMessageInput.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(670, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 46);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessage.Location = new System.Drawing.Point(10, 12);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(650, 46);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 4000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // frmClientChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panelMessageInput);
            this.Controls.Add(this.panelPending);
            this.Controls.Add(this.rtbConversation);
            this.Controls.Add(this.panelChatHeader);
            this.Name = "frmClientChat";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClientChat_FormClosing);
            this.Load += new System.EventHandler(this.frmClientChat_Load);
            this.panelChatHeader.ResumeLayout(false);
            this.panelChatHeader.PerformLayout();
            this.panelPending.ResumeLayout(false);
            this.panelMessageInput.ResumeLayout(false);
            this.panelMessageInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel      panelChatHeader;
        private System.Windows.Forms.Label      lblChatWith;
        private System.Windows.Forms.Label      lblOnlineStatus;
        private System.Windows.Forms.RichTextBox rtbConversation;
        private System.Windows.Forms.Panel      panelPending;
        private System.Windows.Forms.Label      lblPendingIcon;
        private System.Windows.Forms.Label      lblPendingTitle;
        private System.Windows.Forms.Label      lblPendingDesc;
        private System.Windows.Forms.Panel      panelMessageInput;
        private System.Windows.Forms.Button     btnSend;
        private System.Windows.Forms.TextBox    txtMessage;
        private System.Windows.Forms.Timer      timerRefresh;
    }
}
