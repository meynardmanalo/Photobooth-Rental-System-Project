using System;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Security;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmEditUser : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        private int userId;

        public frmEditUser(int userIdParam)
        {
            InitializeComponent();
            userId = userIdParam;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            lblUserId.Text = $"User ID: {userId}";
            lblPhone.Text = "Phone (Optional)";
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (var conn = Classes.Database.DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT full_name, email, phone_number FROM users WHERE user_id = @userId";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["full_name"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPhone.Text = reader["phone_number"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = InputValidator.SanitizeInput(txtFullName.Text);
            string email = InputValidator.SanitizeInput(txtEmail.Text);
            string phone = InputValidator.SanitizeInput(txtPhone.Text);

            // Validate
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (!InputValidator.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Phone is optional — only validate if user actually entered something
            if (!string.IsNullOrWhiteSpace(phone) && phone != "+63")
            {
                if (!InputValidator.IsValidPhoneNumber(phone))
                {
                    MessageBox.Show("Invalid phone number. Format: +639123456789",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }
            }
            else
            {
                phone = "+639000000000";
            }

            try
            {
                if (UserManagementService.UpdateUser(userId, fullName, email, phone))
                {
                    MessageBox.Show("User updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update user.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}