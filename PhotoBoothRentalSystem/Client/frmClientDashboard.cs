using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Utilities;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Forms.Auth;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmClientDashboard : Form
    {


        private Form currentChildForm;

        public frmClientDashboard()
        {
            InitializeComponent();
        }

        private void frmClientDashboard_Load(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Please login first.");
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
                return;
            }

            LoadUserInfo();
            UpdateNotificationBadge();
            LoadPackages(); // Default view
        }
        public void ShowProfileForm()
        {
            OpenChildForm(new frmClientProfile(), "My Profile");
        }
        private void LoadUserInfo()
        {
            lblUserName.Text = SessionManager.CurrentUser.FullName;
            lblUserEmail.Text = SessionManager.CurrentUser.Email;
        }

        private void UpdateNotificationBadge()
        {
            int unreadCount = NotificationService.GetUnreadCount(SessionManager.CurrentUser.UserId);

            if (unreadCount > 0)
            {
                lblNotificationBadge.Text = unreadCount > 99 ? "99+" : unreadCount.ToString();
                lblNotificationBadge.Visible = true;
            }
            else
            {
                lblNotificationBadge.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm, string pageTitle)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            lblPageTitle.Text = pageTitle;
            childForm.Show();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            LoadPackages();
        }

        private void LoadPackages()
        {
            OpenChildForm(new frmClientPackages(), "Available Packages");
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientOrders(), "My Orders");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientProfile(), "My Profile");
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientRatings(), "Rate Our Service");
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientChat(), "Chat with Admin");
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientNotifications(), "Notifications");
            UpdateNotificationBadge();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientSettings(), "Settings");
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                SessionManager.Logout();
                frmAuthSelector auth = new frmAuthSelector();
                auth.Show();
                this.Close();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateNotificationBadge();
            if (currentChildForm is frmClientPackages)
            {
                LoadPackages();
            }
            else if (currentChildForm is frmClientOrders)
            {
                btnMyOrders_Click(sender, e);
            }
            else if (currentChildForm is frmClientNotifications)
            {
                btnNotifications_Click(sender, e);
            }
        }
    }
}