using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminReports : Form
    {
        public frmAdminReports() { InitializeComponent(); }

        private void frmAdminReports_Load(object sender, EventArgs e)
        {
            SetupFilters();
            SetupDataGridViews();
            rbMonthly.Checked = true;
            btnGenerate_Click(null, null); // auto-generate on load
        }

        private void SetupFilters()
        {
            cboMonth.Items.AddRange(new string[] {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December" });
            cboMonth.SelectedIndex = DateTime.Now.Month - 1;

            int year = DateTime.Now.Year;
            for (int i = year; i >= year - 5; i--) cboYear.Items.Add(i);
            cboYear.SelectedIndex = 0;

            dtpDate.Value = DateTime.Now;

            rbDaily.CheckedChanged   += RadioButton_CheckedChanged;
            rbWeekly.CheckedChanged  += RadioButton_CheckedChanged;
            rbMonthly.CheckedChanged += RadioButton_CheckedChanged;
            rbYearly.CheckedChanged  += RadioButton_CheckedChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled  = rbDaily.Checked || rbWeekly.Checked;
            cboMonth.Enabled = rbMonthly.Checked;
            cboYear.Enabled  = rbMonthly.Checked || rbYearly.Checked;
        }

        private void SetupDataGridViews()
        {
            void StyleGrid(DataGridView g)
            {
                g.AutoGenerateColumns = false;
                g.AllowUserToAddRows = false;
                g.ReadOnly = true;
                g.RowHeadersVisible = false;
                g.BackgroundColor = Color.White;
                g.BorderStyle = BorderStyle.None;
                g.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                g.ColumnHeadersDefaultCellStyle.BackColor = ThemeManager.Dark;
                g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                g.EnableHeadersVisualStyles = false;
                g.RowTemplate.Height = 36;
                g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            }

            StyleGrid(dgvPackageStats);
            dgvPackageStats.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PackageName",  Name = "PackageName",  HeaderText = "Package",   Width = 200 });
            dgvPackageStats.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderCount",   Name = "OrderCount",   HeaderText = "Orders",    Width = 80  });
            dgvPackageStats.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalRevenue", Name = "TotalRevenue", HeaderText = "Revenue",   Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "₱#,##0.00" } });

            StyleGrid(dgvStatusBreakdown);
            dgvStatusBreakdown.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", Name = "Status", HeaderText = "Status", Width = 150 });
            dgvStatusBreakdown.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Count",  Name = "Count",  HeaderText = "Count",  Width = 100 });

            // Color rows in status breakdown
            dgvStatusBreakdown.CellFormatting += (s, e) =>
            {
                if (dgvStatusBreakdown.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
                {
                    switch (e.Value.ToString())
                    {
                        case "Pending":   e.CellStyle.ForeColor = Color.FromArgb(243, 156, 18);  break;
                        case "Confirmed": e.CellStyle.ForeColor = Color.FromArgb(52,  152, 219); break;
                        case "Completed": e.CellStyle.ForeColor = Color.FromArgb(39,  174, 96);  break;
                        case "Cancelled": e.CellStyle.ForeColor = Color.FromArgb(231, 76,  60);  break;
                    }
                    e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
            };
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                ReportData report = null;

                if      (rbDaily.Checked)   report = ReportService.GetDailyReport(dtpDate.Value.Date);
                else if (rbWeekly.Checked)  report = ReportService.GetWeeklyReport(dtpDate.Value.Date);
                else if (rbMonthly.Checked) report = ReportService.GetMonthlyReport(
                    Convert.ToInt32(cboYear.SelectedItem), cboMonth.SelectedIndex + 1);
                else if (rbYearly.Checked)  report = ReportService.GetYearlyReport(
                    Convert.ToInt32(cboYear.SelectedItem));

                if (report == null) return;

                // Summary numbers
                lblTotalOrdersValue.Text   = report.OrderCount.ToString();
                lblTotalIncomeValue.Text   = "₱" + report.TotalIncome.ToString("N2");
                lblDownPaymentsValue.Text  = "₱" + report.TotalDownPayment.ToString("N2");
                lblBalanceValue.Text       = "₱" + report.TotalBalance.ToString("N2");

                // Color code income
                lblTotalIncomeValue.ForeColor = report.TotalIncome > 0
                    ? Color.FromArgb(39, 174, 96) : Color.FromArgb(231, 76, 60);

                // Package stats
                var pkgStats = ReportService.GetPopularPackages();
                dgvPackageStats.DataSource = null;
                dgvPackageStats.DataSource = pkgStats;

                // Status breakdown
                var statusDict = ReportService.GetOrderStatusBreakdown();
                var statusList = new List<StatusCount>();
                foreach (var kv in statusDict)
                    statusList.Add(new StatusCount { Status = kv.Key, Count = kv.Value });
                dgvStatusBreakdown.DataSource = null;
                dgvStatusBreakdown.DataSource = statusList;

                // Period label
                string period = rbDaily.Checked   ? dtpDate.Value.ToString("MMMM dd, yyyy")
                              : rbWeekly.Checked  ? "Week of " + dtpDate.Value.ToString("MMM dd")
                              : rbMonthly.Checked ? cboMonth.SelectedItem + " " + cboYear.SelectedItem
                              : cboYear.SelectedItem?.ToString();
                lblPeriodValue.Text = period;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog
            {
                Title = "Export Report",
                Filter = "CSV Files (*.csv)|*.csv",
                FileName = "report_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("Report Period:," + lblPeriodValue.Text);
                        sw.WriteLine("Total Orders:," + lblTotalOrdersValue.Text);
                        sw.WriteLine("Total Income:," + lblTotalIncomeValue.Text);
                        sw.WriteLine("Down Payments:," + lblDownPaymentsValue.Text);
                        sw.WriteLine("Balance:," + lblBalanceValue.Text);
                        sw.WriteLine();
                        sw.WriteLine("Package,Orders,Revenue");
                        foreach (DataGridViewRow r in dgvPackageStats.Rows)
                            sw.WriteLine($"{r.Cells["PackageName"].Value},{r.Cells["OrderCount"].Value},{r.Cells["TotalRevenue"].Value}");
                        sw.WriteLine();
                        sw.WriteLine("Status,Count");
                        foreach (DataGridViewRow r in dgvStatusBreakdown.Rows)
                            sw.WriteLine($"{r.Cells["Status"].Value},{r.Cells["Count"].Value}");
                    }
                    MessageBox.Show("Report exported successfully!\n" + sfd.FileName,
                        "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private class StatusCount
        {
            public string Status { get; set; }
            public int    Count  { get; set; }
        }
    }
}
