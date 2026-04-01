
namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminPackages
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
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnToggleStatus = new System.Windows.Forms.Button();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Controls.Add(this.btnAddPackage);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1284, 70);
            this.panelActions.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(175, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackage.Location = new System.Drawing.Point(27, 20);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(129, 28);
            this.btnAddPackage.TabIndex = 0;
            this.btnAddPackage.Text = "ADD PACKAGE";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(665, 336);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(253, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnToggleStatus
            // 
            this.btnToggleStatus.BackColor = System.Drawing.Color.Black;
            this.btnToggleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToggleStatus.ForeColor = System.Drawing.Color.White;
            this.btnToggleStatus.Location = new System.Drawing.Point(369, 21);
            this.btnToggleStatus.Name = "btnToggleStatus";
            this.btnToggleStatus.Size = new System.Drawing.Size(110, 35);
            this.btnToggleStatus.TabIndex = 4;
            this.btnToggleStatus.Text = "TOGGLE STATUS";
            this.btnToggleStatus.UseVisualStyleBackColor = false;
            this.btnToggleStatus.Click += new System.EventHandler(this.btnToggleStatus_Click);
            // 
            // dgvPackages
            // 
            this.dgvPackages.BackgroundColor = System.Drawing.Color.White;
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackages.Location = new System.Drawing.Point(0, 70);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.Size = new System.Drawing.Size(1284, 705);
            this.dgvPackages.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnToggleStatus);
            this.panel1.Controls.Add(this.btnViewDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 695);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 80);
            this.panel1.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(140, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.Black;
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(485, 21);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(110, 35);
            this.btnViewDetails.TabIndex = 5;
            this.btnViewDetails.Text = "VIEW DETAILS";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // frmAdminPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 775);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelActions);
            this.Name = "frmAdminPackages";
            this.Text = "Package Management";
            this.Load += new System.EventHandler(this.frmAdminPackages_Load);
            this.panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnToggleStatus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnViewDetails;
    }
}