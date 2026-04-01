using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmViewUser : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        private int userId;

        public frmViewUser(int userIdParam)
        {
            InitializeComponent();
            userId = userIdParam;
        }

        private void frmViewUser_Load(object sender, EventArgs e)
        {
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            try
            {
                // Get user data
                User user = GetUserById(userId);
                if (user == null)
                {
                    MessageBox.Show("User not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Populate fields
                lblUserIdValue.Text = user.UserId.ToString();
                lblFullNameValue.Text = user.FullName;
                lblEmailValue.Text = user.Email;
                lblPhoneValue.Text = user.PhoneNumber;
                lblRoleValue.Text = user.Role.ToUpper();
                lblStatusValue.Text = user.Status.ToUpper();
                lblRegisteredValue.Text = user.CreatedAt.ToString("MMMM dd, yyyy");

                // Color code status
                lblStatusValue.ForeColor = user.Status == "active" ? Color.Green : Color.Red;
                lblRoleValue.ForeColor = user.Role == "admin" ? Color.Purple : Color.Blue;

                // Load statistics
                List<Order> userOrders = OrderService.GetOrdersByUserId(userId);
                lblTotalOrdersValue.Text = userOrders.Count.ToString();

                int completedOrders = userOrders.Count(o => o.Status == "Completed");
                lblCompletedOrdersValue.Text = completedOrders.ToString();

                decimal totalSpent = userOrders
                    .Where(o => o.Status == "Completed")
                    .Sum(o => o.TotalAmount);
                lblTotalSpentValue.Text = $"₱{totalSpent:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user details: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private User GetUserById(int userId)
        {
            try
            {
                using (var conn = Classes.Database.DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE user_id = @userId";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = Convert.ToInt32(reader["user_id"]),
                                    FullName = reader["full_name"].ToString(),
                                    Email = reader["email"].ToString(),
                                    PhoneNumber = reader["phone_number"].ToString(),
                                    Role = reader["role"].ToString(),
                                    Status = reader["status"].ToString(),
                                    CreatedAt = Convert.ToDateTime(reader["created_at"])
                                };
                            }
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}