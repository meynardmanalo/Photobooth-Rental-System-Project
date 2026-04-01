using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminNotifications : Form
    {
        public frmAdminNotifications() { InitializeComponent(); }

        private void frmAdminNotifications_Load(object sender, EventArgs e) => LoadNotifications();

        private void LoadNotifications()
        {
            flowNotifications.Controls.Clear();
            try
            {
                var notifications = NotificationService.GetUserNotifications(SessionManager.CurrentUser.UserId);
                int unread = notifications.FindAll(n => !n.IsRead).Count;
                lblUnreadCount.Text = unread > 0 ? $"{unread} Unread" : "All caught up!";
                lblUnreadCount.ForeColor = unread > 0 ? Color.FromArgb(231, 76, 60) : Color.FromArgb(39, 174, 96);

                if (notifications.Count == 0)
                {
                    flowNotifications.Controls.Add(new Label
                    {
                        Text      = "No notifications yet.",
                        Font      = new Font("Segoe UI", 12),
                        ForeColor = Color.Gray,
                        AutoSize  = true,
                        Padding   = new Padding(20)
                    });
                    return;
                }
                foreach (var n in notifications)
                    flowNotifications.Controls.Add(CreateCard(n));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message);
            }
        }

        private Panel CreateCard(Notification n)
        {
            var card = new Panel
            {
                Size      = new Size(flowNotifications.Width - 40, 90),
                BackColor = n.IsRead ? Color.White : Color.FromArgb(240, 248, 255),
                BorderStyle = BorderStyle.FixedSingle,
                Margin    = new Padding(10, 5, 10, 5)
            };

            card.Controls.Add(new Label
            {
                Text     = GetIcon(n.NotificationType),
                Font     = new Font("Segoe UI", 18),
                AutoSize = true,
                Location = new Point(12, 28)
            });
            card.Controls.Add(new Label
            {
                Text      = n.Message,
                Font      = new Font("Segoe UI", 10, n.IsRead ? FontStyle.Regular : FontStyle.Bold),
                Location  = new Point(55, 14),
                Size      = new Size(card.Width - 110, 40),
                ForeColor = Color.FromArgb(52, 73, 94)
            });
            card.Controls.Add(new Label
            {
                Text      = GetTimeAgo(n.CreatedAt),
                Font      = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location  = new Point(55, 60),
                AutoSize  = true
            });

            if (!n.IsRead)
            {
                var btn = new Button
                {
                    Text      = "✓",
                    Size      = new Size(36, 36),
                    Location  = new Point(card.Width - 50, 27),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(46, 204, 113),
                    ForeColor = Color.White,
                    Font      = new Font("Segoe UI", 12, FontStyle.Bold),
                    Cursor    = Cursors.Hand,
                    Tag       = n.NotificationId
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += (s, e) =>
                {
                    NotificationService.MarkAsRead((int)((Button)s).Tag);
                    LoadNotifications();
                };
                card.Controls.Add(btn);
            }
            return card;
        }

        private string GetIcon(string type)
        {
            switch (type?.ToLower())
            {
                case "new_order":        return "📦";
                case "new_message":      return "💬";
                case "chat_request":     return "📨";
                case "chat_accepted":    return "✅";
                case "order_confirmed":  return "✅";
                case "payment_submitted":return "💳";
                default:                 return "🔔";
            }
        }

        private string GetTimeAgo(DateTime dt)
        {
            var t = DateTime.Now - dt;
            if (t.TotalMinutes < 1)  return "Just now";
            if (t.TotalMinutes < 60) return $"{(int)t.TotalMinutes}m ago";
            if (t.TotalHours < 24)   return $"{(int)t.TotalHours}h ago";
            if (t.TotalDays < 7)     return $"{(int)t.TotalDays}d ago";
            return dt.ToString("MMM dd, yyyy");
        }

        private void btnMarkAllRead_Click(object sender, EventArgs e)
        {
            NotificationService.MarkAllAsRead(SessionManager.CurrentUser.UserId);
            LoadNotifications();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadNotifications();
    }
}
