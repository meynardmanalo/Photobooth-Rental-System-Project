using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;
using PhotoBoothRentalSystem.Forms.Client;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminOrders : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        public frmAdminOrders()
        {
            InitializeComponent();
        }

        private void frmAdminOrders_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadFilters();
            LoadOrders();
        }

        private void SetupDataGridView()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgvOrders.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.RowTemplate.Height = 40;

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderId",
                Name = "OrderId",
                HeaderText = "Order ID",
                Width = 80
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                Name = "CustomerName",
                HeaderText = "Customer",
                Width = 150
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PackageName",
                Name = "PackageName",
                HeaderText = "Package",
                Width = 180
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventDate",
                Name = "EventDate",
                HeaderText = "Event Date",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" }
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventLocation",
                Name = "EventLocation",
                HeaderText = "Location",
                Width = 200
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                Name = "Status",
                HeaderText = "Status",
                Width = 100
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                Name = "TotalAmount",
                HeaderText = "Total",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "₱#,##0.00" }
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Balance",
                Name = "Balance",
                HeaderText = "Balance",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "₱#,##0.00" }
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                Name = "CreatedAt",
                HeaderText = "Order Date",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" }
            });

            dgvOrders.CellFormatting += DgvOrders_CellFormatting;
        }

        private void DgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                switch (status)
                {
                    case "Pending":
                        e.CellStyle.BackColor = Color.FromArgb(241, 196, 15);
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "Confirmed":
                        e.CellStyle.BackColor = Color.FromArgb(52, 152, 219);
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "Completed":
                        e.CellStyle.BackColor = Color.FromArgb(46, 204, 113);
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "Cancelled":
                        e.CellStyle.BackColor = Color.FromArgb(231, 76, 60);
                        e.CellStyle.ForeColor = Color.White;
                        break;
                }
            }
        }

        private void LoadFilters()
        {
            cboStatusFilter.Items.AddRange(new string[] {
                "All", "Pending", "Confirmed", "Completed", "Cancelled"
            });
            cboStatusFilter.SelectedIndex = 0;

            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
        }

        private void LoadOrders()
        {
            try
            {
                List<Order> orders = OrderService.GetAllOrders();

                // Apply filters
                string statusFilter = cboStatusFilter.SelectedItem?.ToString() ?? "All";
                if (statusFilter != "All")
                {
                    orders = orders.Where(o => o.Status == statusFilter).ToList();
                }

                // Date filter
                orders = orders.Where(o => o.CreatedAt.Date >= dtpStartDate.Value.Date &&
                                           o.CreatedAt.Date <= dtpEndDate.Value.Date).ToList();

                // Create display list with customer and package names
                List<OrderDisplay> displayOrders = new List<OrderDisplay>();

                foreach (Order order in orders)
                {
                    string customerName = GetCustomerName(order.UserId);
                    Package package = PackageService.GetPackageById(order.PackageId);

                    displayOrders.Add(new OrderDisplay
                    {
                        OrderId = order.OrderId,
                        CustomerName = customerName,
                        PackageName = package?.PackageName ?? "Unknown",
                        EventDate = order.EventDate,
                        EventLocation = order.EventLocation,
                        Status = order.Status,
                        TotalAmount = order.TotalAmount,
                        Balance = order.Balance,
                        CreatedAt = order.CreatedAt
                    });
                }

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = displayOrders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCustomerName(int userId)
        {
            try
            {
                using (var conn = Classes.Database.DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT full_name FROM users WHERE user_id = @userId";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        object result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "Unknown";
                    }
                }
            }
            catch
            {
                return "Unknown";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cboStatusFilter.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
            LoadOrders();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
            frmOrderDetails detailsForm = new frmOrderDetails(orderId);
            detailsForm.ShowDialog();
            LoadOrders();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
            string currentStatus = dgvOrders.SelectedRows[0].Cells["Status"].Value.ToString();

            frmChangeOrderStatus statusForm = new frmChangeOrderStatus(orderId, currentStatus);
            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                LoadOrders();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private class OrderDisplay
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public string PackageName { get; set; }
            public DateTime EventDate { get; set; }
            public string EventLocation { get; set; }
            public string Status { get; set; }
            public decimal TotalAmount { get; set; }
            public decimal Balance { get; set; }
            public DateTime CreatedAt { get; set; }
        }
    }
}