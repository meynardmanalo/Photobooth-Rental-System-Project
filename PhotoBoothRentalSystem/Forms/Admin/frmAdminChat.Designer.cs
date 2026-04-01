namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminChat
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMyChats = new System.Windows.Forms.TabPage();
            this.lstMyChats = new System.Windows.Forms.ListBox();
            this.tabPending = new System.Windows.Forms.TabPage();
            this.panelPendingList = new System.Windows.Forms.Panel();
            this.panelChatArea = new System.Windows.Forms.Panel();
            this.panelNoSelection = new System.Windows.Forms.Panel();
            this.lblNoSelection = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbConversation = new System.Windows.Forms.RichTextBox();
            this.panelChatHeader = new System.Windows.Forms.Panel();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.lblChatWith = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMyChats.SuspendLayout();
            this.tabPending.SuspendLayout();
            this.panelChatArea.SuspendLayout();
            this.panelNoSelection.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelChatHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.splitMain.Panel1.Controls.Add(this.tabControl);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelChatArea);
            this.splitMain.Size = new System.Drawing.Size(900, 600);
            this.splitMain.SplitterDistance = 235;
            this.splitMain.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMyChats);
            this.tabControl.Controls.Add(this.tabPending);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(235, 600);
            this.tabControl.TabIndex = 0;
            // 
            // tabMyChats
            // 
            this.tabMyChats.BackColor = System.Drawing.Color.White;
            this.tabMyChats.Controls.Add(this.lstMyChats);
            this.tabMyChats.Location = new System.Drawing.Point(4, 24);
            this.tabMyChats.Name = "tabMyChats";
            this.tabMyChats.Size = new System.Drawing.Size(227, 572);
            this.tabMyChats.TabIndex = 1;
            this.tabMyChats.Text = "  My Chats  ";
            // 
            // lstMyChats
            // 
            this.lstMyChats.BackColor = System.Drawing.Color.Wheat;
            this.lstMyChats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMyChats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMyChats.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstMyChats.ForeColor = System.Drawing.SystemColors.Info;
            this.lstMyChats.FormattingEnabled = true;
            this.lstMyChats.ItemHeight = 17;
            this.lstMyChats.Location = new System.Drawing.Point(0, 0);
            this.lstMyChats.Name = "lstMyChats";
            this.lstMyChats.Size = new System.Drawing.Size(227, 572);
            this.lstMyChats.TabIndex = 0;
            this.lstMyChats.SelectedIndexChanged += new System.EventHandler(this.lstMyChats_SelectedIndexChanged);
            // 
            // tabPending
            // 
            this.tabPending.BackColor = System.Drawing.Color.White;
            this.tabPending.Controls.Add(this.panelPendingList);
            this.tabPending.Location = new System.Drawing.Point(4, 24);
            this.tabPending.Name = "tabPending";
            this.tabPending.Size = new System.Drawing.Size(227, 572);
            this.tabPending.TabIndex = 0;
            this.tabPending.Text = "  Pending  ";
            // 
            // panelPendingList
            // 
            this.panelPendingList.AutoScroll = true;
            this.panelPendingList.BackColor = System.Drawing.Color.Wheat;
            this.panelPendingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPendingList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPendingList.Location = new System.Drawing.Point(0, 0);
            this.panelPendingList.Name = "panelPendingList";
            this.panelPendingList.Size = new System.Drawing.Size(227, 572);
            this.panelPendingList.TabIndex = 0;
            // 
            // panelChatArea
            // 
            this.panelChatArea.Controls.Add(this.panelNoSelection);
            this.panelChatArea.Controls.Add(this.panelInput);
            this.panelChatArea.Controls.Add(this.rtbConversation);
            this.panelChatArea.Controls.Add(this.panelChatHeader);
            this.panelChatArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatArea.Location = new System.Drawing.Point(0, 0);
            this.panelChatArea.Name = "panelChatArea";
            this.panelChatArea.Size = new System.Drawing.Size(661, 600);
            this.panelChatArea.TabIndex = 0;
            // 
            // panelNoSelection
            // 
            this.panelNoSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelNoSelection.Controls.Add(this.lblNoSelection);
            this.panelNoSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoSelection.Location = new System.Drawing.Point(0, 50);
            this.panelNoSelection.Name = "panelNoSelection";
            this.panelNoSelection.Size = new System.Drawing.Size(661, 480);
            this.panelNoSelection.TabIndex = 0;
            // 
            // lblNoSelection
            // 
            this.lblNoSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoSelection.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNoSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblNoSelection.Location = new System.Drawing.Point(0, 0);
            this.lblNoSelection.Name = "lblNoSelection";
            this.lblNoSelection.Size = new System.Drawing.Size(661, 480);
            this.lblNoSelection.TabIndex = 0;
            this.lblNoSelection.Text = "Select a conversation or accept a request to start chatting";
            this.lblNoSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.Wheat;
            this.panelInput.Controls.Add(this.txtMessage);
            this.panelInput.Controls.Add(this.btnSend);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 530);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(10);
            this.panelInput.Size = new System.Drawing.Size(661, 70);
            this.panelInput.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessage.Location = new System.Drawing.Point(4, 13);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(549, 46);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(559, 13);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 46);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbConversation
            // 
            this.rtbConversation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.rtbConversation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbConversation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConversation.Location = new System.Drawing.Point(0, 50);
            this.rtbConversation.Name = "rtbConversation";
            this.rtbConversation.ReadOnly = true;
            this.rtbConversation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbConversation.Size = new System.Drawing.Size(661, 550);
            this.rtbConversation.TabIndex = 1;
            this.rtbConversation.Text = "";
            // 
            // panelChatHeader
            // 
            this.panelChatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelChatHeader.Controls.Add(this.btnViewProfile);
            this.panelChatHeader.Controls.Add(this.lblChatWith);
            this.panelChatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatHeader.Location = new System.Drawing.Point(0, 0);
            this.panelChatHeader.Name = "panelChatHeader";
            this.panelChatHeader.Size = new System.Drawing.Size(661, 50);
            this.panelChatHeader.TabIndex = 0;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProfile.BackColor = System.Drawing.Color.PeachPuff;
            this.btnViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProfile.FlatAppearance.BorderSize = 0;
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewProfile.ForeColor = System.Drawing.Color.Black;
            this.btnViewProfile.Location = new System.Drawing.Point(558, 9);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(100, 32);
            this.btnViewProfile.TabIndex = 0;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Visible = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // lblChatWith
            // 
            this.lblChatWith.BackColor = System.Drawing.Color.Black;
            this.lblChatWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChatWith.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChatWith.ForeColor = System.Drawing.Color.White;
            this.lblChatWith.Location = new System.Drawing.Point(0, 0);
            this.lblChatWith.Name = "lblChatWith";
            this.lblChatWith.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblChatWith.Size = new System.Drawing.Size(661, 50);
            this.lblChatWith.TabIndex = 1;
            this.lblChatWith.Text = "Chat";
            this.lblChatWith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 4000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // frmAdminChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.splitMain);
            this.Name = "frmAdminChat";
            this.Text = "Admin Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminChat_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminChat_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMyChats.ResumeLayout(false);
            this.tabPending.ResumeLayout(false);
            this.panelChatArea.ResumeLayout(false);
            this.panelNoSelection.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelChatHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl     tabControl;
        private System.Windows.Forms.TabPage        tabPending;
        private System.Windows.Forms.Panel          panelPendingList;
        private System.Windows.Forms.TabPage        tabMyChats;
        private System.Windows.Forms.ListBox        lstMyChats;
        private System.Windows.Forms.Panel          panelChatArea;
        private System.Windows.Forms.Panel          panelNoSelection;
        private System.Windows.Forms.Label          lblNoSelection;
        private System.Windows.Forms.Panel          panelChatHeader;
        private System.Windows.Forms.Button         btnViewProfile;
        private System.Windows.Forms.Label          lblChatWith;
        private System.Windows.Forms.RichTextBox    rtbConversation;
        private System.Windows.Forms.Panel          panelInput;
        private System.Windows.Forms.TextBox        txtMessage;
        private System.Windows.Forms.Button         btnSend;
        private System.Windows.Forms.Timer          timerRefresh;
    }
}
