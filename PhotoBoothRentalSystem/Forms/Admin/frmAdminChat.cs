using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminChat : Form
    {
        private int  _selectedUserId = 0;
        private int  _lastMessageId  = 0;
        private bool _isMsgBusy      = false;
        private bool _isListBusy     = false;
        private bool _firstMsgLoad   = true;
        private int  _tickCount      = 0;

        private readonly Font  _fontTime  = new Font("Segoe UI", 8,  FontStyle.Italic);
        private readonly Font  _fontMsg   = new Font("Segoe UI", 10);
        private readonly Font  _fontName  = new Font("Segoe UI", 10, FontStyle.Bold);
        private readonly Color _colorMe   = Color.FromArgb(41, 128, 185);
        private readonly Color _colorThem = Color.FromArgb(52,  73,  94);
        private readonly Color _colorTime = Color.Gray;

        public frmAdminChat() { InitializeComponent(); }

        private void frmAdminChat_Load(object sender, EventArgs e)
        {
            timerRefresh.Interval = 6000; // 6s — reduces lag on remote DB
            // Reposition btnViewProfile to right side of header on load & resize
            panelChatHeader.Resize += (s, ev) => PositionViewProfileButton();
            PositionViewProfileButton();
            // Resize txtMessage when panel changes width
            splitMain.SplitterMoved += (s, ev) => ResizeInputPanel();
            ResizeInputPanel();

            LoadPendingAsync();
            LoadMyChatsAsync();
            timerRefresh.Start();
        }

        private void PositionViewProfileButton()
        {
            btnViewProfile.Location = new Point(panelChatHeader.Width - btnViewProfile.Width - 10, 9);
        }

        private void ResizeInputPanel()
        {
            int panelW = splitMain.Panel2.Width;
            int btnW   = 90;
            int margin = 10;
            txtMessage.Size    = new Size(panelW - btnW - margin * 3, 46);
            btnSend.Location   = new Point(margin + txtMessage.Width + margin, 12);
        }

        // ── PENDING REQUESTS ──────────────────────────────────────

        private void LoadPendingAsync()
        {
            Task.Run(() => MessageService.GetPendingRequests())
                .ContinueWith(task =>
                {
                    if (task.IsFaulted || this.IsDisposed) return;
                    var requests = task.Result;
                    this.Invoke((Action)(() =>
                    {
                        panelPendingList.SuspendLayout();
                        panelPendingList.Controls.Clear();

                        if (requests.Count == 0)
                        {
                            panelPendingList.Controls.Add(new Label
                            {
                                Text      = "No pending requests",
                                ForeColor = Color.Gray,
                                Font      = new Font("Segoe UI", 9, FontStyle.Italic),
                                AutoSize  = false,
                                Dock      = DockStyle.Top,
                                Height    = 40,
                                TextAlign = ContentAlignment.MiddleCenter
                            });
                        }
                        else
                        {
                            for (int i = requests.Count - 1; i >= 0; i--)
                                panelPendingList.Controls.Add(BuildRequestRow(requests[i]));
                        }

                        tabPending.Text = requests.Count > 0
                            ? $"  Pending ({requests.Count})  "
                            : "  Pending  ";

                        panelPendingList.ResumeLayout();
                    }));
                }, TaskScheduler.Default);
        }

        private Panel BuildRequestRow(ChatRequest req)
        {
            var row = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = 80,
                BackColor = Color.White,
                Padding   = new Padding(10, 8, 10, 4)
            };
            row.Paint += (s, e) =>
                e.Graphics.DrawLine(new Pen(Color.FromArgb(230, 230, 230)),
                    0, row.Height - 1, row.Width, row.Height - 1);

            var lblName = new Label
            {
                Text      = req.ClientName,
                Font      = _fontName,
                ForeColor = Color.FromArgb(30, 30, 30),
                AutoSize  = false,
                Location  = new Point(10, 8),
                Size      = new Size(180, 18)
            };
            var lblEmail = new Label
            {
                Text      = req.ClientEmail,
                Font      = new Font("Segoe UI", 8),
                ForeColor = Color.Gray,
                AutoSize  = false,
                Location  = new Point(10, 28),
                Size      = new Size(180, 14)
            };
            var lblPreview = new Label
            {
                Text      = req.FirstMessage?.Length > 45
                            ? req.FirstMessage.Substring(0, 45) + "…"
                            : req.FirstMessage ?? "",
                Font      = new Font("Segoe UI", 8),
                ForeColor = Color.DarkGray,
                AutoSize  = false,
                Location  = new Point(10, 44),
                Size      = new Size(180, 14)
            };
            var lblTime = new Label
            {
                Text      = req.CreatedAt.ToString("MMM dd hh:mm tt"),
                Font      = new Font("Segoe UI", 7),
                ForeColor = Color.LightGray,
                AutoSize  = false,
                Location  = new Point(10, 60),
                Size      = new Size(130, 12)
            };
            var btnAccept = new Button
            {
                Text      = "Accept",
                Size      = new Size(70, 28),
                Location  = new Point(200, 26),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(39, 174, 96),
                ForeColor = Color.White,
                Font      = new Font("Segoe UI", 8, FontStyle.Bold),
                Cursor    = Cursors.Hand
            };
            btnAccept.FlatAppearance.BorderSize = 0;

            int clientId  = req.ClientId;
            string clName = req.ClientName;
            btnAccept.Click += (s, e) => AcceptRequest(clientId, clName, btnAccept);

            row.Controls.AddRange(new Control[] { lblName, lblEmail, lblPreview, lblTime, btnAccept });
            return row;
        }

        private void AcceptRequest(int clientId, string clientName, Button btn)
        {
            btn.Enabled = false;
            btn.Text    = "...";

            int adminId    = SessionManager.CurrentUser.UserId;
            string myName  = SessionManager.CurrentUser.FullName;

            Task.Run(() =>
            {
                bool ok = MessageService.AcceptChatRequest(clientId, adminId);
                if (ok)
                {
                    MessageService.SendMessage(adminId, clientId,
                        $"Hi! I'm {myName} and I'll be handling your inquiry. How can I help you?");
                    NotificationService.CreateNotification(clientId,
                        $"Admin {myName} has accepted your chat request!", "chat_accepted");
                }
                return ok;
            })
            .ContinueWith(task =>
            {
                if (this.IsDisposed) return;
                this.Invoke((Action)(() =>
                {
                    if (task.Result)
                    {
                        tabControl.SelectedTab = tabMyChats;
                        LoadMyChatsAsync();
                        SelectUser(clientId, clientName);
                        LoadPendingAsync();
                    }
                    else
                    {
                        btn.Enabled = true;
                        btn.Text    = "Accept";
                        MessageBox.Show("Could not accept — another admin may have already accepted.",
                            "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }));
            }, TaskScheduler.Default);
        }

        // ── MY CONVERSATIONS ──────────────────────────────────────

        private void LoadMyChatsAsync()
        {
            if (_isListBusy || this.IsDisposed) return;
            _isListBusy = true;

            int adminId      = SessionManager.CurrentUser.UserId;
            int prevSelected = _selectedUserId;

            Task.Run(() => MessageService.GetMyAcceptedClients(adminId))
                .ContinueWith(task =>
                {
                    _isListBusy = false;
                    if (task.IsFaulted || this.IsDisposed) return;
                    var users = task.Result;

                    this.Invoke((Action)(() =>
                    {
                        lstMyChats.SelectedIndexChanged -= lstMyChats_SelectedIndexChanged;
                        lstMyChats.BeginUpdate();
                        lstMyChats.Items.Clear();
                        foreach (var u in users)
                        {
                            string display = u.FullName + (u.UnreadCount > 0 ? $" ({u.UnreadCount})" : "");
                            lstMyChats.Items.Add(new ListBoxItem { Text = display, Value = u.UserId });
                        }
                        if (prevSelected != 0)
                            for (int i = 0; i < lstMyChats.Items.Count; i++)
                                if (((ListBoxItem)lstMyChats.Items[i]).Value == prevSelected)
                                { lstMyChats.SelectedIndex = i; break; }
                        lstMyChats.EndUpdate();
                        lstMyChats.SelectedIndexChanged += lstMyChats_SelectedIndexChanged;

                        tabMyChats.Text = users.Count > 0
                            ? $"  My Chats ({users.Count})  "
                            : "  My Chats  ";
                    }));
                }, TaskScheduler.Default);
        }

        private void lstMyChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMyChats.SelectedItem == null) return;
            var item = (ListBoxItem)lstMyChats.SelectedItem;
            SelectUser(item.Value, item.Text.Split('(')[0].Trim());
        }

        private void SelectUser(int userId, string name)
        {
            _selectedUserId = userId;
            lblChatWith.Text = name;
            _lastMessageId   = 0;
            _firstMsgLoad    = true;
            rtbConversation.Clear();
            panelNoSelection.Visible = false;
            btnViewProfile.Visible   = true;
            PositionViewProfileButton();
            LoadMessagesAsync();
        }

        // ── VIEW PROFILE ─────────────────────────────────────────

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0) return;
            frmViewUser viewForm = new frmViewUser(_selectedUserId);
            viewForm.ShowDialog();
        }

        // ── CONVERSATION ──────────────────────────────────────────

        private void LoadMessagesAsync()
        {
            if (_selectedUserId == 0 || _isMsgBusy || this.IsDisposed) return;
            _isMsgBusy = true;

            int myId    = SessionManager.CurrentUser.UserId;
            int userId  = _selectedUserId;
            int sinceId = _lastMessageId;
            bool first  = _firstMsgLoad;

            Task.Run(() =>
                first ? MessageService.GetConversation(myId, userId)
                      : MessageService.GetNewMessages(myId, userId, sinceId))
            .ContinueWith(task =>
            {
                _isMsgBusy = false;
                if (task.IsFaulted || task.Result == null || task.Result.Count == 0) return;
                var msgs = task.Result;
                MessageService.MarkMessagesAsRead(myId, userId);
                if (this.IsDisposed) return;
                this.Invoke((Action)(() =>
                {
                    if (_selectedUserId != userId) return;
                    rtbConversation.SuspendLayout();
                    foreach (var msg in msgs)
                    {
                        AppendMessage(msg);
                        if (msg.MessageId > _lastMessageId) _lastMessageId = msg.MessageId;
                    }
                    rtbConversation.ResumeLayout();
                    rtbConversation.SelectionStart = rtbConversation.Text.Length;
                    rtbConversation.ScrollToCaret();
                    _firstMsgLoad = false;
                }));
            }, TaskScheduler.Default);
        }

        private void AppendMessage(ChatMessage msg)
        {
            bool isMe = msg.SenderId == SessionManager.CurrentUser.UserId;
            rtbConversation.SelectionAlignment = isMe ? HorizontalAlignment.Right : HorizontalAlignment.Left;
            rtbConversation.SelectionFont  = _fontTime;
            rtbConversation.SelectionColor = _colorTime;
            rtbConversation.AppendText(
                (isMe ? "You" : lblChatWith.Text) + "   " + msg.SentAt.ToString("hh:mm tt") + "\n");
            rtbConversation.SelectionFont  = _fontMsg;
            rtbConversation.SelectionColor = isMe ? _colorMe : _colorThem;
            rtbConversation.AppendText(msg.MessageText + "\n\n");
        }

        // ── SEND ──────────────────────────────────────────────────

        private void btnSend_Click(object sender, EventArgs e) => SendMessage();
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift) { e.SuppressKeyPress = true; SendMessage(); }
        }

        private void SendMessage()
        {
            if (_selectedUserId == 0)
            { MessageBox.Show("Please select a conversation first.", "No Selection"); return; }

            string text = txtMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(text)) return;

            txtMessage.Clear();
            btnSend.Enabled = false;
            int myId   = SessionManager.CurrentUser.UserId;
            int userId = _selectedUserId;

            Task.Run(() => MessageService.SendMessage(myId, userId, text))
                .ContinueWith(task =>
                {
                    if (this.IsDisposed) return;
                    this.Invoke((Action)(() =>
                    {
                        btnSend.Enabled = true;
                        if (task.Result)
                        {
                            _firstMsgLoad = false;
                            LoadMessagesAsync();
                            NotificationService.CreateNotification(userId,
                                "New message from Admin", "new_message");
                        }
                        else
                            MessageBox.Show("Failed to send.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }, TaskScheduler.Default);
        }

        // ── TIMER ────────────────────────────────────────────────

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            _tickCount++;
            if (_selectedUserId != 0) LoadMessagesAsync();
            if (_tickCount % 10 == 0)  // ~every 60s
            {
                LoadPendingAsync();
                LoadMyChatsAsync();
            }
        }

        private void frmAdminChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerRefresh.Stop();
            _fontTime.Dispose();
            _fontMsg.Dispose();
            _fontName.Dispose();
        }

        private class ListBoxItem
        {
            public string Text  { get; set; }
            public int    Value { get; set; }
            public override string ToString() => Text;
        }
    }
}
