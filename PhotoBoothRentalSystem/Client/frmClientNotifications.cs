using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmClientNotifications : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        public frmClientNotifications()
        {
            InitializeComponent();
        }

        private void frmClientNotifications_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            flowNotifications.Controls.Clear();

            try
            {
                List<Notification> notifications = NotificationService.GetUserNotifications(
                    SessionManager.CurrentUser.UserId
                );

                int unreadCount = notifications.FindAll(n => !n.IsRead).Count;
                lblUnreadCount.Text = $"{unreadCount} Unread";

                if (notifications.Count == 0)
                {
                    Label lblEmpty = new Label
                    {
                        Text = "No notifications yet.",
                        Font = new Font("Segoe UI", 14),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Padding = new Padding(20)
                    };
                    flowNotifications.Controls.Add(lblEmpty);
                    return;
                }

                foreach (Notification notification in notifications)
                {
                    Panel notifCard = CreateNotificationCard(notification);
                    flowNotifications.Controls.Add(notifCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateNotificationCard(Notification notification)
        {
            Panel card = new Panel
            {
                Size = new Size(flowNotifications.Width - 40, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = notification.IsRead ? Color.White : Color.FromArgb(240, 248, 255),
                Margin = new Padding(10),
                Padding = new Padding(15)
            };

            // Notification type icon
            Label lblIcon = new Label
            {
                Text = GetNotificationIcon(notification.NotificationType),
                Font = new Font("Segoe UI", 20),
                AutoSize = true,
                Location = new Point(10, 30)
            };
            card.Controls.Add(lblIcon);

            // Message
            Label lblMessage = new Label
            {
                Text = notification.Message,
                Font = new Font("Segoe UI", 11, notification.IsRead ? FontStyle.Regular : FontStyle.Bold),
                Location = new Point(60, 15),
                Size = new Size(card.Width - 150, 50),
                ForeColor = Color.FromArgb(52, 73, 94)
            };
            card.Controls.Add(lblMessage);

            // Time
            Label lblTime = new Label
            {
                Text = GetTimeAgo(notification.CreatedAt),
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(60, 70),
                AutoSize = true
            };
            card.Controls.Add(lblTime);

            // Mark as read button (if unread)
            if (!notification.IsRead)
            {
                Button btnMarkRead = new Button
                {
                    Text = "✓",
                    Size = new Size(40, 40),
                    Location = new Point(card.Width - 60, 30),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(46, 204, 113),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Tag = notification.NotificationId
                };
                btnMarkRead.FlatAppearance.BorderSize = 0;
                btnMarkRead.Click += BtnMarkRead_Click;
                card.Controls.Add(btnMarkRead);
            }

            return card;
        }

        private string GetNotificationIcon(string notificationType)
        {
            switch (notificationType?.ToLower())
            {
                case "new_order":
                case "order_submitted":
                    return "📦";
                case "order_confirmed":
                    return "✅";
                case "order_completed":
                    return "🎉";
                case "new_message":
                    return "💬";
                case "payment_reminder":
                    return "💰";
                default:
                    return "🔔";
            }
        }

        private string GetTimeAgo(DateTime dateTime)
        {
            TimeSpan timeAgo = DateTime.Now - dateTime;

            if (timeAgo.TotalMinutes < 1)
                return "Just now";
            if (timeAgo.TotalMinutes < 60)
                return $"{(int)timeAgo.TotalMinutes} minutes ago";
            if (timeAgo.TotalHours < 24)
                return $"{(int)timeAgo.TotalHours} hours ago";
            if (timeAgo.TotalDays < 7)
                return $"{(int)timeAgo.TotalDays} days ago";

            return dateTime.ToString("MMM dd, yyyy");
        }

        private void BtnMarkRead_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int notificationId = (int)btn.Tag;

            if (NotificationService.MarkAsRead(notificationId))
            {
                LoadNotifications();
            }
        }

        private void btnMarkAllRead_Click(object sender, EventArgs e)
        {
            if (NotificationService.MarkAllAsRead(SessionManager.CurrentUser.UserId))
            {
                MessageBox.Show("All notifications marked as read.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNotifications();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNotifications();
        }
    }
}