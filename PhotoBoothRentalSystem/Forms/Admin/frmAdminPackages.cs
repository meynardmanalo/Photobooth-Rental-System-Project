using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminPackages : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        public frmAdminPackages()
        {
            InitializeComponent();
        }

        private void frmAdminPackages_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadPackages();
        }

        private void SetupDataGridView()
        {
            dgvPackages.AutoGenerateColumns = false;
            dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackages.MultiSelect = false;
            dgvPackages.AllowUserToAddRows = false;
            dgvPackages.ReadOnly = true;
            dgvPackages.RowHeadersVisible = false;
            dgvPackages.BackgroundColor = Color.White;
            dgvPackages.BorderStyle = BorderStyle.None;
            dgvPackages.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvPackages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPackages.EnableHeadersVisualStyles = false;
            dgvPackages.RowTemplate.Height = 40;

            dgvPackages.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PackageId",
                Name = "PackageId",
                HeaderText = "ID",
                Width = 60
            });

            dgvPackages.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PackageName",
                Name = "PackageName",
                HeaderText = "Package Name",
                Width = 250
            });

            dgvPackages.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PackageType",
                Name = "PackageType",
                HeaderText = "Type",
                Width = 150
            });

            dgvPackages.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                Name = "Price",
                HeaderText = "Price",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "₱#,##0.00" }
            });

            dgvPackages.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Hours",
                Name = "Hours",
                HeaderText = "Hours",
                Width = 80
            });

            dgvPackages.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IsActive",
                Name = "IsActive",
                HeaderText = "Status",
                Width = 100
            });

            dgvPackages.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                Name = "Description",
                HeaderText = "Description",
                Width = 400
            });

            dgvPackages.CellFormatting += DgvPackages_CellFormatting;
        }

        private void DgvPackages_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPackages.Columns[e.ColumnIndex].Name == "IsActive" && e.Value != null)
            {
                bool isActive = Convert.ToBoolean(e.Value);
                e.Value = isActive ? "ACTIVE" : "INACTIVE";
                e.CellStyle.ForeColor = isActive ? Color.Green : Color.Red;
                e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }

        private void LoadPackages()
        {
            try
            {
                // Load all packages (not just active)
                List<Package> packages = new List<Package>();

                using (var conn = Classes.Database.DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM packages ORDER BY package_id ASC";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                packages.Add(new Package
                                {
                                    PackageId = Convert.ToInt32(reader["package_id"]),
                                    PackageName = reader["package_name"].ToString(),
                                    Description = reader["description"].ToString(),
                                    Price = Convert.ToDecimal(reader["price"]),
                                    Hours = Convert.ToInt32(reader["hours"]),
                                    PackageType = reader["package_type"].ToString(),
                                    IsActive = Convert.ToBoolean(reader["is_active"])
                                });
                            }
                        }
                    }
                }

                dgvPackages.DataSource = null;
                dgvPackages.DataSource = packages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading packages: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddEditPackage addForm = new frmAddEditPackage(0); // 0 = Add mode
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadPackages();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a package.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int packageId = Convert.ToInt32(dgvPackages.SelectedRows[0].Cells["PackageId"].Value);

            frmAddEditPackage editForm = new frmAddEditPackage(packageId);
            if (editForm.ShowDialog() == DialogResult.OK)
                LoadPackages();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a package.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int packageId = Convert.ToInt32(dgvPackages.SelectedRows[0].Cells["PackageId"].Value);
            Package package = PackageService.GetPackageById(packageId);

            if (package != null)
            {
                frmAdminPackageDetails detailsForm = new frmAdminPackageDetails(package);
                detailsForm.ShowDialog();
                LoadPackages();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a package.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string packageName = dgvPackages.SelectedRows[0].Cells["PackageName"].Value.ToString();
            int packageId = Convert.ToInt32(dgvPackages.SelectedRows[0].Cells["PackageId"].Value);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete package '{packageName}'?\n\n" +
                "WARNING: This action cannot be undone!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (PackageService.DeletePackage(packageId))
                {
                    MessageBox.Show("Package deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPackages();
                }
                else
                {
                    MessageBox.Show("Failed to delete package.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnToggleStatus_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a package.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int packageId = Convert.ToInt32(dgvPackages.SelectedRows[0].Cells["PackageId"].Value);
            bool currentStatus = Convert.ToBoolean(dgvPackages.SelectedRows[0].Cells["IsActive"].Value);
            string packageName = dgvPackages.SelectedRows[0].Cells["PackageName"].Value.ToString();

            string action = currentStatus ? "deactivate" : "activate";

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to {action} package '{packageName}'?",
                $"Confirm {action}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    Package package = PackageService.GetPackageById(packageId);
                    if (package != null)
                    {
                        package.IsActive = !currentStatus;
                        if (PackageService.UpdatePackage(package))
                        {
                            MessageBox.Show($"Package {action}d successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPackages();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating package: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPackages();
        }
    }
}