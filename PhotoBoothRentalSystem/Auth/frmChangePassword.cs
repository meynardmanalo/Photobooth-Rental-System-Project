using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Security;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmChangePassword : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            lblRequirements.Text = "Password Requirements:\n" +
                "• At least 8 characters\n" +
                "• 1 uppercase letter\n" +
                "• 1 lowercase letter\n" +
                "• 1 number";
        }

        private void chkShowPasswords_CheckedChanged(object sender, EventArgs e)
        {
            char passChar = chkShowPasswords.Checked ? '\0' : '●';
            txtCurrentPassword.PasswordChar = passChar;
            txtNewPassword.PasswordChar = passChar;
            txtConfirmPassword.PasswordChar = passChar;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(currentPassword))
            {
                MessageBox.Show("Please enter your current password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (!InputValidator.IsValidPassword(newPassword))
            {
                MessageBox.Show("Password does not meet requirements:\n" +
                    "• At least 8 characters\n" +
                    "• 1 uppercase letter\n" +
                    "• 1 lowercase letter\n" +
                    "• 1 number",
                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            if (currentPassword == newPassword)
            {
                MessageBox.Show("New password must be different from current password.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            // Verify current password and update
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Get current password hash
                    string getHashQuery = "SELECT password_hash FROM users WHERE user_id = @userId";
                    string currentHash = "";

                    using (MySqlCommand cmd = new MySqlCommand(getHashQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", SessionManager.CurrentUser.UserId);
                        object result = cmd.ExecuteScalar();
                        currentHash = result?.ToString() ?? "";
                    }

                    // Verify current password
                    if (!PasswordHasher.VerifyPassword(currentPassword, currentHash))
                    {
                        MessageBox.Show("Current password is incorrect.", "Authentication Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentPassword.Clear();
                        txtCurrentPassword.Focus();
                        return;
                    }

                    // Update to new password
                    string newHash = PasswordHasher.HashPassword(newPassword);
                    string updateQuery = "UPDATE users SET password_hash = @newHash WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@newHash", newHash);
                        cmd.Parameters.AddWithValue("@userId", SessionManager.CurrentUser.UserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Password changed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing password: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}