using System;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Utilities;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Forms.Auth;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminDashboard : Form
    {
        private Form currentChildForm;
        private Timer _badgeTimer;

        public frmAdminDashboard() { InitializeComponent(); }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn() || !SessionManager.IsAdmin())
            {
                MessageBox.Show("Access denied. Admin privileges required.");
                new frmLogin().Show();
                this.Close();
                return;
            }
            LoadAdminInfo();
            UpdateBadges();
            LoadDashboardHome();

            // Auto-refresh badges every 10 seconds
            _badgeTimer = new Timer { Interval = 15000 }; // 15s
            _badgeTimer.Tick += (s, ev) => UpdateBadges();
            _badgeTimer.Start();
        }

        private void LoadAdminInfo()
        {
            lblAdminName.Text = SessionManager.CurrentUser.FullName;
            lblAdminRole.Text = "Administrator";
        }

        private void UpdateBadges()
        {
            try
            {
                int userId = SessionManager.CurrentUser.UserId;

                int unreadNotif = NotificationService.GetUnreadCount(userId);
                lblNotificationBadge.Text    = unreadNotif > 99 ? "99+" : unreadNotif.ToString();
                lblNotificationBadge.Visible = unreadNotif > 0;

                int unreadMsg   = MessageService.GetUnreadMessageCount(userId);
                int pendingReq  = MessageService.GetPendingRequestCount();
                int totalMsg    = unreadMsg + pendingReq;
                lblMessageBadge.Text    = totalMsg > 99 ? "99+" : totalMsg.ToString();
                lblMessageBadge.Visible = totalMsg > 0;
            }
            catch { }
        }

        private void OpenChildForm(Form childForm, string pageTitle)
        {
            currentChildForm?.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            lblPageTitle.Text = pageTitle;
            childForm.Show();
        }

        private void LoadDashboardHome() => OpenChildForm(new frmAdminHome(), "Dashboard Overview");

        private void btnDashboard_Click(object sender, EventArgs e)     => LoadDashboardHome();
        private void btnOrders_Click(object sender, EventArgs e)        => OpenChildForm(new frmAdminOrders(), "Order Management");
        private void btnUsers_Click(object sender, EventArgs e)         => OpenChildForm(new frmAdminUsers(), "User Management");
        private void btnPackages_Click(object sender, EventArgs e)      => OpenChildForm(new frmAdminPackages(), "Package Management");
        private void btnReports_Click(object sender, EventArgs e)       => OpenChildForm(new frmAdminReports(), "Reports & Analytics");
        private void btnRatings_Click(object sender, EventArgs e)       => OpenChildForm(new frmAdminRatings(), "Customer Ratings");

        private void btnChat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdminChat(), "Messages");
            UpdateBadges();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            // FIX: was opening frmAdminSettings — now opens proper notifications form
            OpenChildForm(new frmAdminNotifications(), "Notifications");
            UpdateBadges();
        }

        private void btnSettings_Click(object sender, EventArgs e)     => OpenChildForm(new frmAdminSettings(), "Settings");

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Are you sure you want to logout?",
                "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                _badgeTimer?.Stop();
                SessionManager.Logout();
                new frmAuthSelector().Show();
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateBadges();
            if (currentChildForm is frmAdminHome)        LoadDashboardHome();
            else if (currentChildForm is frmAdminOrders) btnOrders_Click(sender, e);
            else if (currentChildForm is frmAdminUsers)  btnUsers_Click(sender, e);
        }

        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            _badgeTimer?.Stop();
            _badgeTimer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
