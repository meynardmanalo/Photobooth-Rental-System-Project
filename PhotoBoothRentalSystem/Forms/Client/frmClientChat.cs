using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmClientChat : Form
    {
        private int  _adminId     = 0;
        private int  _lastMsgId   = 0;
        private bool _isBusy      = false;
        private bool _isFirstLoad = true;
        private bool _isPending   = false;
        private bool _stateChecked = false;

        private readonly Font  _fontTime  = new Font("Segoe UI", 8,  FontStyle.Italic);
        private readonly Font  _fontMsg   = new Font("Segoe UI", 10);
        private readonly Color _colorMe   = Color.FromArgb(41, 128, 185);
        private readonly Color _colorOther= Color.FromArgb(52,  73,  94);
        private readonly Color _colorTime = Color.Gray;

        public frmClientChat() { InitializeComponent(); }

        private void frmClientChat_Load(object sender, EventArgs e)
        {
            timerRefresh.Interval = 5000; // 5s — reduces lag on slow remote DB
            CheckChatState();
            timerRefresh.Start();
        }

        // ── Determine chat state ─────────────────────────────
        private void CheckChatState()
        {
            int myId = SessionManager.CurrentUser.UserId;

            Task.Run(() =>
            {
                int  acceptedAdmin = MessageService.GetAcceptedAdminForClient(myId);
                bool hasPending    = acceptedAdmin == 0 && MessageService.HasChatRequest(myId);
                int  anyAdminId    = MessageService.GetAdminUserId();
                return new { acceptedAdmin, hasPending, anyAdminId };
            })
            .ContinueWith(task =>
            {
                if (task.IsFaulted || this.IsDisposed) return;
                var r = task.Result;

                this.Invoke((Action)(() =>
                {
                    _stateChecked = true;

                    if (r.acceptedAdmin > 0)
                    {
                        _adminId   = r.acceptedAdmin;
                        _isPending = false;
                        ShowChatMode();
                        LoadMessagesAsync();
                    }
                    else if (r.hasPending)
                    {
                        // Still use anyAdminId so first message can be sent
                        _adminId   = r.anyAdminId;
                        _isPending = true;
                        ShowPendingMode();
                    }
                    else
                    {
                        _adminId   = r.anyAdminId;
                        _isPending = false;
                        ShowChatMode();
                    }
                }));
            }, TaskScheduler.Default);
        }

        private void ShowChatMode()
        {
            panelPending.Visible      = false;
            rtbConversation.Visible   = true;
            panelMessageInput.Visible = true;
            lblChatWith.Text          = "Chat with Admin Support";
            lblOnlineStatus.Text      = _adminId > 0 ? "● Ready" : "● Connecting...";
            lblOnlineStatus.ForeColor = _adminId > 0
                ? Color.FromArgb(39, 174, 96)
                : Color.FromArgb(230, 126, 34);
        }

        private void ShowPendingMode()
        {
            panelPending.Visible      = true;
            rtbConversation.Visible   = false;
            panelMessageInput.Visible = false;
            lblChatWith.Text          = "Waiting for Admin";
            lblOnlineStatus.Text      = "● Pending";
            lblOnlineStatus.ForeColor = Color.FromArgb(230, 126, 34);
        }

        // ── Load messages ────────────────────────────────────
        private void LoadMessagesAsync()
        {
            if (_adminId == 0 || _isBusy || this.IsDisposed) return;
            _isBusy = true;

            int myId    = SessionManager.CurrentUser.UserId;
            int adminId = _adminId;
            int sinceId = _lastMsgId;
            bool first  = _isFirstLoad;

            Task.Run(() =>
                first ? MessageService.GetConversation(myId, adminId)
                      : MessageService.GetNewMessages(myId, adminId, sinceId))
            .ContinueWith(task =>
            {
                _isBusy = false;
                if (task.IsFaulted || this.IsDisposed) return;

                var msgs = task.Result;
                if (msgs == null || msgs.Count == 0)
                {
                    this.Invoke((Action)(() => _isFirstLoad = false));
                    return;
                }

                MessageService.MarkMessagesAsRead(myId, adminId);
                this.Invoke((Action)(() =>
                {
                    rtbConversation.SuspendLayout();
                    foreach (var msg in msgs)
                    {
                        AppendMessage(msg);
                        if (msg.MessageId > _lastMsgId) _lastMsgId = msg.MessageId;
                    }
                    rtbConversation.ResumeLayout();
                    rtbConversation.SelectionStart = rtbConversation.Text.Length;
                    rtbConversation.ScrollToCaret();
                    _isFirstLoad = false;
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
                (isMe ? "You" : "Admin") + "   " + msg.SentAt.ToString("hh:mm tt") + "\n");
            rtbConversation.SelectionFont  = _fontMsg;
            rtbConversation.SelectionColor = isMe ? _colorMe : _colorOther;
            rtbConversation.AppendText(msg.MessageText + "\n\n");
        }

        // ── Send ─────────────────────────────────────────────
        private void btnSend_Click(object sender, EventArgs e) => SendMessage();
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift) { e.SuppressKeyPress = true; SendMessage(); }
        }

        private void SendMessage()
        {
            string text = txtMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(text)) return;

            // If state not yet checked or no admin found, retry first
            if (!_stateChecked || _adminId == 0)
            {
                btnSend.Enabled = false;
                btnSend.Text    = "...";
                Task.Run(() => MessageService.GetAdminUserId())
                    .ContinueWith(t =>
                    {
                        if (this.IsDisposed) return;
                        this.Invoke((Action)(() =>
                        {
                            btnSend.Enabled = true;
                            btnSend.Text    = "Send";
                            if (t.Result > 0)
                            {
                                _adminId      = t.Result;
                                _stateChecked = true;
                                ShowChatMode();
                                DoSend(text);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No admin is available right now. Please try again later.",
                                    "No Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }));
                    }, TaskScheduler.Default);
                txtMessage.Clear();
                return;
            }

            txtMessage.Clear();
            DoSend(text);
        }

        private void DoSend(string text)
        {
            btnSend.Enabled = false;

            int myId    = SessionManager.CurrentUser.UserId;
            int target  = _adminId;
            string name = SessionManager.CurrentUser.FullName;
            bool wasFirst = !MessageService.HasChatRequest(myId);

            Task.Run(() =>
            {
                bool sent = MessageService.SendMessage(myId, target, text);
                if (sent && wasFirst)
                {
                    MessageService.EnsureChatRequest(myId);
                    NotificationService.CreateNotification(target,
                        $"New chat request from {name}", "chat_request");
                }
                return sent;
            })
            .ContinueWith(task =>
            {
                if (this.IsDisposed) return;
                this.Invoke((Action)(() =>
                {
                    btnSend.Enabled = true;
                    if (task.Result)
                    {
                        _isFirstLoad = false;
                        LoadMessagesAsync();
                        if (wasFirst)
                        {
                            _isPending = true;
                            ShowPendingMode();
                        }
                    }
                    else
                        MessageBox.Show("Failed to send message.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }, TaskScheduler.Default);
        }

        // ── Timer ─────────────────────────────────────────────
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (_isPending)
            {
                CheckChatState();
                return;
            }
            LoadMessagesAsync();
        }

        private void frmClientChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerRefresh.Stop();
            _fontTime.Dispose();
            _fontMsg.Dispose();
        }
    }
}
