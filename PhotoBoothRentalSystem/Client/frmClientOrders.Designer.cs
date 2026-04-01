
namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmClientOrders
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cboStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnRateOrder = new System.Windows.Forms.Button();
            this.btnUploadFiles = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.Thistle;
            this.panelFilters.Controls.Add(this.btnRefresh);
            this.panelFilters.Controls.Add(this.cboStatusFilter);
            this.panelFilters.Controls.Add(this.lblFilter);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(809, 76);
            this.panelFilters.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Plum;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(313, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 41);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.FormattingEnabled = true;
            this.cboStatusFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Confirmed",
            "Completed",
            "Cancelled"});
            this.cboStatusFilter.Location = new System.Drawing.Point(159, 27);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(121, 21);
            this.cboStatusFilter.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(39, 29);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(108, 19);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter by Status";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 76);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(809, 433);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.LightPink;
            this.panelActions.Controls.Add(this.btnRateOrder);
            this.panelActions.Controls.Add(this.btnUploadFiles);
            this.panelActions.Controls.Add(this.btnViewDetails);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 422);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(809, 87);
            this.panelActions.TabIndex = 2;
            // 
            // btnRateOrder
            // 
            this.btnRateOrder.BackColor = System.Drawing.Color.Plum;
            this.btnRateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRateOrder.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRateOrder.Location = new System.Drawing.Point(370, 20);
            this.btnRateOrder.Name = "btnRateOrder";
            this.btnRateOrder.Size = new System.Drawing.Size(113, 42);
            this.btnRateOrder.TabIndex = 2;
            this.btnRateOrder.Text = "Rate Order";
            this.btnRateOrder.UseVisualStyleBackColor = false;
            // 
            // btnUploadFiles
            // 
            this.btnUploadFiles.BackColor = System.Drawing.Color.Plum;
            this.btnUploadFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFiles.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFiles.Location = new System.Drawing.Point(219, 20);
            this.btnUploadFiles.Name = "btnUploadFiles";
            this.btnUploadFiles.Size = new System.Drawing.Size(130, 42);
            this.btnUploadFiles.TabIndex = 1;
            this.btnUploadFiles.Text = "Upload Files";
            this.btnUploadFiles.UseVisualStyleBackColor = false;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.Plum;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(43, 20);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(150, 42);
            this.btnViewDetails.TabIndex = 0;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            // 
            // frmClientOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 509);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panelFilters);
            this.Name = "frmClientOrders";
            this.Text = "My Orders";
            this.Load += new System.EventHandler(this.frmClientOrders_Load);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnRateOrder;
        private System.Windows.Forms.Button btnUploadFiles;
        private System.Windows.Forms.Button btnViewDetails;
    }
}