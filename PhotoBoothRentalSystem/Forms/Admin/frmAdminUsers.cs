using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminUsers : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        public frmAdminUsers()
        {
            InitializeComponent();
        }

        private void frmAdminUsers_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadFilters();
            LoadUsers();
        }

        private void SetupDataGridView()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.RowTemplate.Height = 40;

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserId",
                Name = "UserId",
                HeaderText = "User ID",
                Width = 80
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                Name = "FullName",
                HeaderText = "Full Name",
                Width = 200
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                Name = "Email",
                HeaderText = "Email",
                Width = 250
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PhoneNumber",
                Name = "PhoneNumber",
                HeaderText = "Phone Number",
                Width = 150
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Role",
                Name = "Role",
                HeaderText = "Role",
                Width = 100
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                Name = "Status",
                HeaderText = "Status",
                Width = 100
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                Name = "CreatedAt",
                HeaderText = "Registered",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" }
            });

            dgvUsers.CellFormatting += DgvUsers_CellFormatting;
        }

        private void DgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                e.CellStyle.ForeColor = status == "active" ? Color.Green : Color.Red;
                e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }

            if (dgvUsers.Columns[e.ColumnIndex].Name == "Role" && e.Value != null)
            {
                string role = e.Value.ToString();
                e.CellStyle.ForeColor = role == "admin" ? Color.Purple : Color.Blue;
            }
        }

        private void LoadFilters()
        {
            cboStatusFilter.Items.AddRange(new string[] { "All", "Active", "Blocked" });
            cboStatusFilter.SelectedIndex = 0;
            cboStatusFilter.SelectedIndexChanged += (s, e) => LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                List<User> users = UserManagementService.GetAllUsers();

                // Apply status filter
                string statusFilter = cboStatusFilter.SelectedItem?.ToString() ?? "All";
                if (statusFilter == "Active")
                {
                    users = users.Where(u => u.Status == "active").ToList();
                }
                else if (statusFilter == "Blocked")
                {
                    users = users.Where(u => u.Status == "blocked").ToList();
                }

                // Apply search filter
                string searchTerm = txtSearch.Text.Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    users = users.Where(u =>
                        u.FullName.ToLower().Contains(searchTerm) ||
                        u.Email.ToLower().Contains(searchTerm) ||
                        u.PhoneNumber.Contains(searchTerm)
                    ).ToList();
                }

                dgvUsers.DataSource = null;
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadUsers();
            }
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            frmViewUser viewForm = new frmViewUser(userId);
            viewForm.ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string role = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();

            if (role == "admin")
            {
                MessageBox.Show("Cannot edit admin users.", "Restriction",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmEditUser editForm = new frmEditUser(userId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnBlockUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string currentStatus = dgvUsers.SelectedRows[0].Cells["Status"].Value.ToString();
            string role = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();

            if (role == "admin")
            {
                MessageBox.Show("Cannot block admin users.", "Restriction",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = currentStatus == "active" ? "blocked" : "active";
            string action = newStatus == "blocked" ? "block" : "unblock";

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to {action} this user?",
                $"Confirm {action}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                if (UserManagementService.UpdateUserStatus(userId, newStatus))
                {
                    MessageBox.Show($"User {action}ed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show($"Failed to {action} user.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string role = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();
            string userName = dgvUsers.SelectedRows[0].Cells["FullName"].Value.ToString();

            if (role == "admin")
            {
                MessageBox.Show("Cannot delete admin users.", "Restriction",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete user '{userName}'?\n\n" +
                "WARNING: This will also delete all their orders and related data.\n" +
                "This action cannot be undone!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (UserManagementService.DeleteUser(userId))
                {
                    MessageBox.Show("User deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Users can only register through the signup form.\n" +
                "This ensures proper OTP verification and security.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}