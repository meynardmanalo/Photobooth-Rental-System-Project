
namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminOrders
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
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilterDate = new System.Windows.Forms.Label();
            this.cboStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewFiles = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.Black;
            this.panelFilters.Controls.Add(this.btnClearFilter);
            this.panelFilters.Controls.Add(this.btnFilter);
            this.panelFilters.Controls.Add(this.dtpEndDate);
            this.panelFilters.Controls.Add(this.label1);
            this.panelFilters.Controls.Add(this.dtpStartDate);
            this.panelFilters.Controls.Add(this.lblFilterDate);
            this.panelFilters.Controls.Add(this.cboStatusFilter);
            this.panelFilters.Controls.Add(this.lblFilterStatus);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.ForeColor = System.Drawing.Color.White;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1284, 70);
            this.panelFilters.TabIndex = 0;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.Location = new System.Drawing.Point(823, 26);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(59, 23);
            this.btnClearFilter.TabIndex = 7;
            this.btnClearFilter.Text = "CLEAR";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(754, 26);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 23);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "APPLY";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(569, 25);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(162, 22);
            this.dtpEndDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "To: ";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(328, 26);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(162, 22);
            this.dtpStartDate.TabIndex = 3;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.AutoSize = true;
            this.lblFilterDate.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterDate.Location = new System.Drawing.Point(230, 28);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(92, 17);
            this.lblFilterDate.TabIndex = 2;
            this.lblFilterDate.Text = "Date Range;";
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.FormattingEnabled = true;
            this.cboStatusFilter.Location = new System.Drawing.Point(93, 27);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(121, 21);
            this.cboStatusFilter.TabIndex = 1;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterStatus.Location = new System.Drawing.Point(23, 30);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(64, 17);
            this.lblFilterStatus.TabIndex = 0;
            this.lblFilterStatus.Text = "STATUS";
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 70);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(1284, 579);
            this.dgvOrders.TabIndex = 1;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.Black;
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Controls.Add(this.btnViewFiles);
            this.panelActions.Controls.Add(this.btnChangeStatus);
            this.panelActions.Controls.Add(this.btnViewDetails);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 555);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1284, 94);
            this.panelActions.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(359, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewFiles
            // 
            this.btnViewFiles.BackColor = System.Drawing.Color.White;
            this.btnViewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFiles.ForeColor = System.Drawing.Color.Black;
            this.btnViewFiles.Location = new System.Drawing.Point(266, 35);
            this.btnViewFiles.Name = "btnViewFiles";
            this.btnViewFiles.Size = new System.Drawing.Size(75, 32);
            this.btnViewFiles.TabIndex = 2;
            this.btnViewFiles.Text = "VIEW FILES";
            this.btnViewFiles.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.BackColor = System.Drawing.Color.White;
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.ForeColor = System.Drawing.Color.Black;
            this.btnChangeStatus.Location = new System.Drawing.Point(158, 35);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(91, 32);
            this.btnChangeStatus.TabIndex = 1;
            this.btnChangeStatus.Text = "CHANGE STATUS";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.White;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.Black;
            this.btnViewDetails.Location = new System.Drawing.Point(58, 35);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(75, 32);
            this.btnViewDetails.TabIndex = 0;
            this.btnViewDetails.Text = "VIEW DETAILS";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // frmAdminOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 649);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panelFilters);
            this.Name = "frmAdminOrders";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.frmAdminOrders_Load);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblFilterDate;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewFiles;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnViewDetails;
    }
}