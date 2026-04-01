namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminUsers
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnBlockUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.Black;
            this.panelFilters.Controls.Add(this.lblSearch);
            this.panelFilters.Controls.Add(this.txtSearch);
            this.panelFilters.Controls.Add(this.btnSearch);
            this.panelFilters.Controls.Add(this.cboStatusFilter);
            this.panelFilters.Controls.Add(this.btnAddUser);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(900, 60);
            this.panelFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(12, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(66, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(335, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboStatusFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Blocked"});
            this.cboStatusFilter.Location = new System.Drawing.Point(428, 17);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(110, 23);
            this.cboStatusFilter.TabIndex = 3;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.White;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Location = new System.Drawing.Point(555, 16);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 28);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 60);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(900, 440);
            this.dgvUsers.TabIndex = 1;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.Olive;
            this.panelActions.Controls.Add(this.btnViewUser);
            this.panelActions.Controls.Add(this.btnEditUser);
            this.panelActions.Controls.Add(this.btnBlockUser);
            this.panelActions.Controls.Add(this.btnDeleteUser);
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 440);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(900, 60);
            this.panelActions.TabIndex = 2;
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.Black;
            this.btnViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Location = new System.Drawing.Point(12, 12);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(110, 36);
            this.btnViewUser.TabIndex = 0;
            this.btnViewUser.Text = "View Profile";
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.Black;
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(132, 12);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 36);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnBlockUser
            // 
            this.btnBlockUser.BackColor = System.Drawing.Color.Black;
            this.btnBlockUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockUser.FlatAppearance.BorderSize = 0;
            this.btnBlockUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBlockUser.ForeColor = System.Drawing.Color.White;
            this.btnBlockUser.Location = new System.Drawing.Point(242, 12);
            this.btnBlockUser.Name = "btnBlockUser";
            this.btnBlockUser.Size = new System.Drawing.Size(130, 36);
            this.btnBlockUser.TabIndex = 2;
            this.btnBlockUser.Text = "Block / Unblock";
            this.btnBlockUser.UseVisualStyleBackColor = false;
            this.btnBlockUser.Click += new System.EventHandler(this.btnBlockUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(382, 12);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(110, 36);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(504, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmAdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panelFilters);
            this.Name = "frmAdminUsers";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmAdminUsers_Load);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel            panelFilters;
        private System.Windows.Forms.Label            lblSearch;
        private System.Windows.Forms.TextBox          txtSearch;
        private System.Windows.Forms.Button           btnSearch;
        private System.Windows.Forms.ComboBox         cboStatusFilter;
        private System.Windows.Forms.Button           btnAddUser;
        private System.Windows.Forms.DataGridView     dgvUsers;
        private System.Windows.Forms.Panel            panelActions;
        private System.Windows.Forms.Button           btnViewUser;
        private System.Windows.Forms.Button           btnEditUser;
        private System.Windows.Forms.Button           btnBlockUser;
        private System.Windows.Forms.Button           btnDeleteUser;
        private System.Windows.Forms.Button           btnRefresh;
    }
}
