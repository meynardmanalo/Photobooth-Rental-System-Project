
namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFilters = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblPeriodValue = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rbYearly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpOrderStatus = new System.Windows.Forms.GroupBox();
            this.dgvStatusBreakdown = new System.Windows.Forms.DataGridView();
            this.grpPackageStats = new System.Windows.Forms.GroupBox();
            this.dgvPackageStats = new System.Windows.Forms.DataGridView();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDownPaymentsValue = new System.Windows.Forms.Label();
            this.lblDownPayments = new System.Windows.Forms.Label();
            this.lblTotalIncomeValue = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.panelFilters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpOrderStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusBreakdown)).BeginInit();
            this.grpPackageStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageStats)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.Olive;
            this.panelFilters.Controls.Add(this.groupBox1);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(800, 100);
            this.panelFilters.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.lblPeriod);
            this.groupBox1.Controls.Add(this.lblPeriodValue);
            this.groupBox1.Controls.Add(this.cboYear);
            this.groupBox1.Controls.Add(this.cboMonth);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.rbYearly);
            this.groupBox1.Controls.Add(this.rbMonthly);
            this.groupBox1.Controls.Add(this.rbWeekly);
            this.groupBox1.Controls.Add(this.rbDaily);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpReportType";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(484, 17);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 28);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(620, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 28);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPeriod.ForeColor = System.Drawing.Color.Gray;
            this.lblPeriod.Location = new System.Drawing.Point(482, 59);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(44, 15);
            this.lblPeriod.TabIndex = 9;
            this.lblPeriod.Text = "Period:";
            // 
            // lblPeriodValue
            // 
            this.lblPeriodValue.AutoSize = true;
            this.lblPeriodValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPeriodValue.Location = new System.Drawing.Point(785, 22);
            this.lblPeriodValue.Name = "lblPeriodValue";
            this.lblPeriodValue.Size = new System.Drawing.Size(19, 15);
            this.lblPeriodValue.TabIndex = 10;
            this.lblPeriodValue.Text = "—";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(324, 53);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 6;
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(197, 53);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(121, 21);
            this.cboMonth.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(197, 23);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // rbYearly
            // 
            this.rbYearly.AutoSize = true;
            this.rbYearly.Location = new System.Drawing.Point(106, 46);
            this.rbYearly.Name = "rbYearly";
            this.rbYearly.Size = new System.Drawing.Size(85, 17);
            this.rbYearly.TabIndex = 3;
            this.rbYearly.TabStop = true;
            this.rbYearly.Text = "Yearly";
            this.rbYearly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(106, 23);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(85, 17);
            this.rbMonthly.TabIndex = 2;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(15, 46);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(85, 17);
            this.rbWeekly.TabIndex = 1;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(15, 23);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(85, 17);
            this.rbDaily.TabIndex = 0;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.grpOrderStatus);
            this.panel1.Controls.Add(this.grpPackageStats);
            this.panel1.Controls.Add(this.grpSummary);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 350);
            this.panel1.TabIndex = 1;
            // 
            // grpOrderStatus
            // 
            this.grpOrderStatus.Controls.Add(this.dgvStatusBreakdown);
            this.grpOrderStatus.Location = new System.Drawing.Point(575, 18);
            this.grpOrderStatus.Name = "grpOrderStatus";
            this.grpOrderStatus.Size = new System.Drawing.Size(198, 252);
            this.grpOrderStatus.TabIndex = 2;
            this.grpOrderStatus.TabStop = false;
            this.grpOrderStatus.Text = "Order Status Breakdown";
            // 
            // dgvStatusBreakdown
            // 
            this.dgvStatusBreakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusBreakdown.Location = new System.Drawing.Point(6, 28);
            this.dgvStatusBreakdown.Name = "dgvStatusBreakdown";
            this.dgvStatusBreakdown.Size = new System.Drawing.Size(176, 198);
            this.dgvStatusBreakdown.TabIndex = 0;
            // 
            // grpPackageStats
            // 
            this.grpPackageStats.Controls.Add(this.dgvPackageStats);
            this.grpPackageStats.Location = new System.Drawing.Point(356, 18);
            this.grpPackageStats.Name = "grpPackageStats";
            this.grpPackageStats.Size = new System.Drawing.Size(198, 252);
            this.grpPackageStats.TabIndex = 1;
            this.grpPackageStats.TabStop = false;
            this.grpPackageStats.Text = "Package Statistics";
            // 
            // dgvPackageStats
            // 
            this.dgvPackageStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackageStats.Location = new System.Drawing.Point(6, 28);
            this.dgvPackageStats.Name = "dgvPackageStats";
            this.dgvPackageStats.Size = new System.Drawing.Size(176, 198);
            this.dgvPackageStats.TabIndex = 0;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblTotalOrdersValue);
            this.grpSummary.Controls.Add(this.lblTotalOrders);
            this.grpSummary.Controls.Add(this.lblBalanceValue);
            this.grpSummary.Controls.Add(this.lblBalance);
            this.grpSummary.Controls.Add(this.lblDownPaymentsValue);
            this.grpSummary.Controls.Add(this.lblDownPayments);
            this.grpSummary.Controls.Add(this.lblTotalIncomeValue);
            this.grpSummary.Controls.Add(this.lblTotalIncome);
            this.grpSummary.Location = new System.Drawing.Point(27, 18);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(303, 280);
            this.grpSummary.TabIndex = 0;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Report Summary";
            // 
            // lblTotalOrdersValue
            // 
            this.lblTotalOrdersValue.AutoSize = true;
            this.lblTotalOrdersValue.Location = new System.Drawing.Point(162, 28);
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            this.lblTotalOrdersValue.Size = new System.Drawing.Size(41, 13);
            this.lblTotalOrdersValue.TabIndex = 11;
            this.lblTotalOrdersValue.Text = "0";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Location = new System.Drawing.Point(26, 28);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(41, 13);
            this.lblTotalOrders.TabIndex = 10;
            this.lblTotalOrders.Text = "Total Orders:";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Location = new System.Drawing.Point(168, 146);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(35, 13);
            this.lblBalanceValue.TabIndex = 5;
            this.lblBalanceValue.Text = "P0.00";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(32, 146);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 13);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance:";
            // 
            // lblDownPaymentsValue
            // 
            this.lblDownPaymentsValue.AutoSize = true;
            this.lblDownPaymentsValue.Location = new System.Drawing.Point(168, 104);
            this.lblDownPaymentsValue.Name = "lblDownPaymentsValue";
            this.lblDownPaymentsValue.Size = new System.Drawing.Size(35, 13);
            this.lblDownPaymentsValue.TabIndex = 3;
            this.lblDownPaymentsValue.Text = "P0.00";
            // 
            // lblDownPayments
            // 
            this.lblDownPayments.AutoSize = true;
            this.lblDownPayments.Location = new System.Drawing.Point(32, 104);
            this.lblDownPayments.Name = "lblDownPayments";
            this.lblDownPayments.Size = new System.Drawing.Size(35, 13);
            this.lblDownPayments.TabIndex = 2;
            this.lblDownPayments.Text = "Down Payments:";
            // 
            // lblTotalIncomeValue
            // 
            this.lblTotalIncomeValue.AutoSize = true;
            this.lblTotalIncomeValue.Location = new System.Drawing.Point(168, 62);
            this.lblTotalIncomeValue.Name = "lblTotalIncomeValue";
            this.lblTotalIncomeValue.Size = new System.Drawing.Size(35, 13);
            this.lblTotalIncomeValue.TabIndex = 1;
            this.lblTotalIncomeValue.Text = "P0.00";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(32, 62);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(35, 13);
            this.lblTotalIncome.TabIndex = 0;
            this.lblTotalIncome.Text = "Total Income:";
            // 
            // frmAdminReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFilters);
            this.Name = "frmAdminReports";
            this.Text = "Reports & Analytics";
            this.Load += new System.EventHandler(this.frmAdminReports_Load);
            this.panelFilters.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpOrderStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusBreakdown)).EndInit();
            this.grpPackageStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageStats)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblPeriod;
        public  System.Windows.Forms.Label lblPeriodValue;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbYearly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpOrderStatus;
        private System.Windows.Forms.DataGridView dgvStatusBreakdown;
        private System.Windows.Forms.GroupBox grpPackageStats;
        private System.Windows.Forms.DataGridView dgvPackageStats;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblTotalOrdersValue;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDownPaymentsValue;
        private System.Windows.Forms.Label lblDownPayments;
        private System.Windows.Forms.Label lblTotalIncomeValue;
        private System.Windows.Forms.Label lblTotalIncome;
    }
}