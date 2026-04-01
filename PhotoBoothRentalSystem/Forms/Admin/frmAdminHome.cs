using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;
using PhotoBoothRentalSystem.Classes.Utilities;
using MySql.Data.MySqlClient;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminHome : Form
    {
        public frmAdminHome() { InitializeComponent(); }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            SetupRecentOrdersGrid();
            SetupUpcomingEventsGrid();
            LoadAllData();
        }

        private void LoadAllData()
        {
            try
            {
                var all = OrderService.GetAllOrders();

                lblTotalOrdersValue.Text   = all.Count.ToString();
                lblPendingOrdersValue.Text = all.Count(o => o.Status == "Pending").ToString();
                lblTotalUsersValue.Text    = UserManagementService.GetTotalUserCount().ToString();
                lblTotalIncomeValue.Text   = "P" + all
                    .Where(o => o.Status == "Completed" || o.Status == "Confirmed")
                    .Sum(o => o.TotalAmount).ToString("N0");

                LoadRecentOrders(all);
                LoadUpcomingEvents(all);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupRecentOrdersGrid()
        {
            var g = dgvRecentOrders;
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows  = false;
            g.ReadOnly            = true;
            g.RowHeadersVisible   = false;
            g.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            g.BackgroundColor     = Color.White;
            g.BorderStyle         = BorderStyle.None;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            g.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.BackColor = ThemeManager.Dark;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.EnableHeadersVisualStyles = false;
            g.RowTemplate.Height        = 30;
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderId",      HeaderText = "ID",       Width = 55 });
            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Customer", Width = 150 });
            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EventDate",    HeaderText = "Date",     Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" } });
            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status",       HeaderText = "Status",   Width = 90 });
            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalAmount",  HeaderText = "Amount",   Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "P#,##0.00" } });

            g.CellFormatting += StatusColorFormat;
        }

        private void SetupUpcomingEventsGrid()
        {
            var g = dgvUpcomingEvents;
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows  = false;
            g.ReadOnly            = true;
            g.RowHeadersVisible   = false;
            g.BackgroundColor     = Color.White;
            g.BorderStyle         = BorderStyle.None;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            g.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.BackColor = ThemeManager.Dark;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.EnableHeadersVisualStyles = false;
            g.RowTemplate.Height        = 30;
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EventDate",     HeaderText = "Date",     Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" } });
            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EventType",     HeaderText = "Type",     Width = 110 });
            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName",  HeaderText = "Customer", Width = 150 });
            g.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EventLocation", HeaderText = "Location", Width = 200 });
        }

        private void LoadRecentOrders(List<Order> all)
        {
            dgvRecentOrders.DataSource = null;
            dgvRecentOrders.DataSource = all.Take(10).Select(o => new
            {
                o.OrderId,
                CustomerName = GetName(o.UserId),
                o.EventDate,
                o.Status,
                o.TotalAmount
            }).ToList();
        }

        private void LoadUpcomingEvents(List<Order> all)
        {
            dgvUpcomingEvents.DataSource = null;
            dgvUpcomingEvents.DataSource = all
                .Where(o => o.EventDate >= DateTime.Today &&
                            (o.Status == "Confirmed" || o.Status == "Pending"))
                .OrderBy(o => o.EventDate).Take(10)
                .Select(o => new
                {
                    o.EventDate,
                    o.EventType,
                    CustomerName = GetName(o.UserId),
                    o.EventLocation
                }).ToList();
        }

        private static void StatusColorFormat(object s, DataGridViewCellFormattingEventArgs e)
        {
            var g = (DataGridView)s;
            if (e.ColumnIndex < 0 || g.Columns[e.ColumnIndex].DataPropertyName != "Status" || e.Value == null) return;
            switch (e.Value.ToString())
            {
                case "Pending":   e.CellStyle.ForeColor = Color.FromArgb(243, 156, 18);  break;
                case "Confirmed": e.CellStyle.ForeColor = Color.FromArgb(52,  152, 219); break;
                case "Completed": e.CellStyle.ForeColor = Color.FromArgb(39,  174, 96);  break;
                case "Cancelled": e.CellStyle.ForeColor = Color.FromArgb(231, 76,  60);  break;
            }
            e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private string GetName(int userId)
        {
            try
            {
                using (var conn = Classes.Database.DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT full_name FROM users WHERE user_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        return cmd.ExecuteScalar()?.ToString() ?? "Unknown";
                    }
                }
            }
            catch { return "Unknown"; }
        }
    }
}
