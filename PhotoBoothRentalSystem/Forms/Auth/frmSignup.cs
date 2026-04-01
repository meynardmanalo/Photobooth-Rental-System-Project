using System;
using System.Drawing;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Security;

namespace PhotoBoothRentalSystem.Forms.Auth
{
    public partial class frmSignup : Form
    {
        private string generatedOTP = "";
        private bool otpVerified = false;

        public frmSignup()
        {
            InitializeComponent();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            panelMain.Location = new Point(
                (this.Width - panelMain.Width) / 2, 50
            );

            // Update phone field label to show it's now optional
            lblPhone.Text = "Phone Number (Optional)";
            txtPhoneNumber.Text = "+63";

            chkAgree.Text = "I agree to the Terms and Conditions\n" +
                           "• ₱500 non-refundable down payment\n" +
                           "• No cancellations allowed\n" +
                           "• Balance due on event date";
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            char passChar = chkShowPassword.Checked ? '\0' : '●';
            txtPassword.PasswordChar = passChar;
            txtConfirmPassword.PasswordChar = passChar;
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string email = InputValidator.SanitizeInput(txtEmail.Text);
            string fullName = InputValidator.SanitizeInput(txtFullName.Text);

            // Validate email first
            if (!InputValidator.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address first.",
                    "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Check name
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please enter your full name first.",
                    "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            // Check if email already exists
            if (AuthService.EmailExists(email))
            {
                MessageBox.Show("This email is already registered.",
                    "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Disable button and show progress
            btnSendOTP.Enabled = false;
            btnSendOTP.Text = "Sending...";
            this.Cursor = Cursors.WaitCursor;

            try
            {
                generatedOTP = OTPService.GenerateOTP();

                if (OTPService.SendOTP(email, generatedOTP, fullName))
                {
                    MessageBox.Show(
                        $"Verification code has been sent to:\n{email}\n\n" +
                        "Please check your inbox (and spam folder).\n" +
                        "Code is valid for 5 minutes.",
                        "OTP Sent",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    txtOTP.Enabled = true;
                    btnVerifyOTP.Enabled = true;
                    txtEmail.ReadOnly = true;

                    // Don't re-enable the Send OTP button on success
                    // User should use "Resend" if they need another codes
                }
                else
                {
                    MessageBox.Show(
                        "Failed to send verification email.\n\n" +
                        "Please check:\n" +
                        "• Your email address is correct\n" +
                        "• Your internet connection\n" +
                        "• Try again in a moment",
                        "Email Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    // Re-enable button on failure
                    btnSendOTP.Enabled = true;
                    btnSendOTP.Text = "Send OTP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Re-enable button on error
                btnSendOTP.Enabled = true;
                btnSendOTP.Text = "Send OTP";
            }
            finally
            {
                // Always reset cursor
                this.Cursor = Cursors.Default;
            }
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            string enteredOTP = txtOTP.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(enteredOTP))
            {
                MessageBox.Show("Please enter the OTP code.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (OTPService.VerifyOTP(email, enteredOTP))
                {
                    otpVerified = true;
                    MessageBox.Show("✓ Email verified successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtOTP.Enabled = false;
                    btnVerifyOTP.Enabled = false;
                    btnCreateAccount.Enabled = true;

                    // Visual feedback
                    txtOTP.BackColor = Color.LightGreen;
                }
                else
                {
                    MessageBox.Show(
                        "Invalid or expired verification code.\n\n" +
                        "Please check:\n" +
                        "• Code was entered correctly\n" +
                        "• Code hasn't expired (5 minutes)\n" +
                        "• Using the most recent code",
                        "Verification Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    txtOTP.Clear();
                    txtOTP.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error verifying OTP: " + ex.Message + "\n\n" +
                    "Please try again or request a new code.",
                    "Verification Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string fullName = InputValidator.SanitizeInput(txtFullName.Text);
            string email = InputValidator.SanitizeInput(txtEmail.Text);
            string phone = InputValidator.SanitizeInput(txtPhoneNumber.Text);
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!InputValidator.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!InputValidator.IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters with:\n" +
                    "• 1 uppercase letter\n• 1 lowercase letter\n• 1 number",
                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            if (!otpVerified)
            {
                MessageBox.Show("Please verify your email first.", "Verification Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkAgree.Checked)
            {
                MessageBox.Show("Please agree to the terms and conditions.", "Agreement Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If phone is empty, use default
            if (string.IsNullOrWhiteSpace(phone) || phone == "+63")
            {
                phone = "+639000000000"; // Default placeholder
            }

            btnCreateAccount.Enabled = false;
            btnCreateAccount.Text = "Creating...";

            try
            {
                if (AuthService.Register(fullName, email, password, phone))
                {
                    MessageBox.Show(
                        "✓ Account created successfully!\n\n" +
                        "You can now login with your credentials.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    frmLogin loginForm = new frmLogin();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed. Email may already exist.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCreateAccount.Enabled = true;
                btnCreateAccount.Text = "CREATE ACCOUNT";
            }
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Any entered data will be lost.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}