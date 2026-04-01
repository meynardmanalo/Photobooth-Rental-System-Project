using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PhotoBoothRentalSystem.Classes.Utilities;
using PhotoBoothRentalSystem.Forms.Auth;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmClientSettings : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        public frmClientSettings()
        {
            InitializeComponent();
        }

        private void frmClientSettings_Load(object sender, EventArgs e)
        {
            // Center panel
            panelSettings.Location = new Point(
                (this.Width - panelSettings.Width) / 2,
                (this.Height - panelSettings.Height) / 2
            );
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword changePasswordForm = new frmChangePassword();
            changePasswordForm.ShowDialog();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            // Switch to profile view
            Form parentForm = this.ParentForm;
            if (parentForm is frmClientDashboard)
            {
                ((frmClientDashboard)parentForm).ShowProfileForm();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "ZASS Photobooth Rental System\n\n" +
                "Version 1.0.0\n\n" +
                "A comprehensive photo booth rental management system.\n\n" +
                "© 2024 ZASS Photobooth\n" +
                "All rights reserved.",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "HELP & SUPPORT\n\n" +
                "For assistance, please contact:\n\n" +
                "📞 Phone: 0919-478-8556\n" +
                "📧 Email: admin@zass.com\n" +
                "💬 Use the Chat feature to message admin directly\n\n" +
                "Operating Hours:\n" +
                "Monday - Sunday: 9:00 AM - 8:00 PM",
                "Help & Support",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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

                frmAuthSelector authSelector = new frmAuthSelector();
                authSelector.Show();

                // Close dashboard
                Form dashboard = this.ParentForm;
                while (dashboard != null && !(dashboard is frmClientDashboard))
                {
                    dashboard = dashboard.ParentForm;
                }
                dashboard?.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}