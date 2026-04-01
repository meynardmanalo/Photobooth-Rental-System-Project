using System;
using System.Drawing;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Security;
using PhotoBoothRentalSystem.Classes.Models;
using PhotoBoothRentalSystem.Classes.Utilities;
using PhotoBoothRentalSystem.Forms.Client;
using PhotoBoothRentalSystem.Forms.Admin;

namespace PhotoBoothRentalSystem.Forms.Auth
{
    public partial class frmLogin : Form
    {
        // Your controls here...

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Your code...
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = InputValidator.SanitizeInput(txtEmail.Text);
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!InputValidator.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Logging in...";

            try
            {
                User user = AuthService.Login(email, password);

                if (user != null)
                {
                    SessionManager.CurrentUser = user;

                    Form nextForm;
                    if (user.IsAdmin())
                    {
                        nextForm = new frmAdminDashboard();
                    }
                    else
                    {
                        nextForm = new frmClientDashboard();
                    }

                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password, or account not verified.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "LOGIN";
            }
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact admin at 0919-478-8556 to reset your password.",
                "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAuthSelector auth = new frmAuthSelector();
            auth.Show();
            this.Close();
        }

        // FIX: Specify full namespace for Message
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}