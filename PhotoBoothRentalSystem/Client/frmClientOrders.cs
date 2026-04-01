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
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmClientOrders : Form
    {
        // DESIGN COMPONENTS LISTED ABOVE

        public frmClientOrders()
        {
            InitializeComponent();
        }

        private void frmClientOrders_Load(object sender, EventArgs e)
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
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgvOrders.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvOrders.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.RowTemplate.Height = 40;

            // Define columns
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderId",
                Name = "OrderId",
                HeaderText = "Order ID",
                Width = 100
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PackageName",
                Name = "PackageName",
                HeaderText = "Package",
                Width = 200
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventDate",
                Name = "EventDate",
                HeaderText = "Event Date",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" }
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventLocation",
                Name = "EventLocation",
                HeaderText = "Location",
                Width = 250
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                Name = "Status",
                HeaderText = "Status",
                Width = 120
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                Name = "TotalAmount",
                HeaderText = "Total",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "₱#,##0.00" }
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Balance",
                Name = "Balance",
                HeaderText = "Balance",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "₱#,##0.00" }
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                Name = "CreatedAt",
                HeaderText = "Order Date",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy hh:mm tt" }
            });

            // Color code status
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
            cboStatusFilter.SelectedIndexChanged += (s, e) => LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                List<Order> orders = OrderService.GetOrdersByUserId(SessionManager.CurrentUser.UserId);

                // Apply filter
                string filter = cboStatusFilter.SelectedItem?.ToString() ?? "All";
                if (filter != "All")
                {
                    orders = orders.FindAll(o => o.Status == filter);
                }

                // Enhance with package names
                List<OrderDisplay> displayOrders = new List<OrderDisplay>();
                foreach (Order order in orders)
                {
                    Package package = PackageService.GetPackageById(order.PackageId);
                    displayOrders.Add(new OrderDisplay
                    {
                        OrderId = order.OrderId,
                        PackageId = order.PackageId,
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

                // Update package column
                dgvOrders.Columns["PackageName"].DataPropertyName = "PackageName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to view details.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
            frmOrderDetails detailsForm = new frmOrderDetails(orderId);
            detailsForm.ShowDialog();
            LoadOrders(); // Refresh after viewing
        }

        private void btnUploadFiles_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to upload files.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
            frmUploadFiles uploadForm = new frmUploadFiles(orderId);
            uploadForm.ShowDialog();
        }

        private void btnRateOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to rate.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string status = dgvOrders.SelectedRows[0].Cells["Status"].Value.ToString();
            if (status != "Completed")
            {
                MessageBox.Show("You can only rate completed orders.",
                    "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
            frmRateOrder rateForm = new frmRateOrder(orderId);
            rateForm.ShowDialog();
        }

        // Helper class for display
        private class OrderDisplay
        {
            public int OrderId { get; set; }
            public int PackageId { get; set; }
            public string PackageName { get; set; }
            public DateTime EventDate { get; set; }
            public string EventLocation { get; set; }
            public string Status { get; set; }
            public decimal TotalAmount { get; set; }
            public decimal Balance { get; set; }
            public DateTime CreatedAt { get; set; }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}