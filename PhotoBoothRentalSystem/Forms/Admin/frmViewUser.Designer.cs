namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmViewUser
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserIdValue = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblRegistered = new System.Windows.Forms.Label();
            this.lblRegisteredValue = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.lblCompletedOrders = new System.Windows.Forms.Label();
            this.lblCompletedOrdersValue = new System.Windows.Forms.Label();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.lblTotalSpentValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(780, 60);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "User Profile";
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.lblUserId);
            this.grpPersonalInfo.Controls.Add(this.lblUserIdValue);
            this.grpPersonalInfo.Controls.Add(this.lblFullName);
            this.grpPersonalInfo.Controls.Add(this.lblFullNameValue);
            this.grpPersonalInfo.Controls.Add(this.lblEmail);
            this.grpPersonalInfo.Controls.Add(this.lblEmailValue);
            this.grpPersonalInfo.Controls.Add(this.lblPhone);
            this.grpPersonalInfo.Controls.Add(this.lblPhoneValue);
            this.grpPersonalInfo.Controls.Add(this.lblRole);
            this.grpPersonalInfo.Controls.Add(this.lblRoleValue);
            this.grpPersonalInfo.Controls.Add(this.lblStatus);
            this.grpPersonalInfo.Controls.Add(this.lblStatusValue);
            this.grpPersonalInfo.Controls.Add(this.lblRegistered);
            this.grpPersonalInfo.Controls.Add(this.lblRegisteredValue);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPersonalInfo.Location = new System.Drawing.Point(20, 76);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(430, 300);
            this.grpPersonalInfo.TabIndex = 2;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserId.ForeColor = System.Drawing.Color.Gray;
            this.lblUserId.Location = new System.Drawing.Point(14, 30);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(47, 15);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User ID:";
            // 
            // lblUserIdValue
            // 
            this.lblUserIdValue.AutoSize = true;
            this.lblUserIdValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblUserIdValue.Location = new System.Drawing.Point(160, 30);
            this.lblUserIdValue.Name = "lblUserIdValue";
            this.lblUserIdValue.Size = new System.Drawing.Size(15, 19);
            this.lblUserIdValue.TabIndex = 1;
            this.lblUserIdValue.Text = "-";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.ForeColor = System.Drawing.Color.Gray;
            this.lblFullName.Location = new System.Drawing.Point(14, 64);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 15);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.lblFullNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblFullNameValue.Location = new System.Drawing.Point(160, 64);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(15, 19);
            this.lblFullNameValue.TabIndex = 3;
            this.lblFullNameValue.Text = "-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(14, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEmailValue.Location = new System.Drawing.Point(160, 98);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(15, 19);
            this.lblEmailValue.TabIndex = 5;
            this.lblEmailValue.Text = "-";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(14, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPhoneValue.Location = new System.Drawing.Point(160, 132);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(15, 19);
            this.lblPhoneValue.TabIndex = 7;
            this.lblPhoneValue.Text = "-";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRole.ForeColor = System.Drawing.Color.Gray;
            this.lblRole.Location = new System.Drawing.Point(14, 166);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(33, 15);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role:";
            // 
            // lblRoleValue
            // 
            this.lblRoleValue.AutoSize = true;
            this.lblRoleValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblRoleValue.Location = new System.Drawing.Point(160, 166);
            this.lblRoleValue.Name = "lblRoleValue";
            this.lblRoleValue.Size = new System.Drawing.Size(15, 19);
            this.lblRoleValue.TabIndex = 9;
            this.lblRoleValue.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(14, 200);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblStatusValue.Location = new System.Drawing.Point(160, 200);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(15, 19);
            this.lblStatusValue.TabIndex = 11;
            this.lblStatusValue.Text = "-";
            // 
            // lblRegistered
            // 
            this.lblRegistered.AutoSize = true;
            this.lblRegistered.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegistered.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistered.Location = new System.Drawing.Point(14, 234);
            this.lblRegistered.Name = "lblRegistered";
            this.lblRegistered.Size = new System.Drawing.Size(65, 15);
            this.lblRegistered.TabIndex = 12;
            this.lblRegistered.Text = "Registered:";
            // 
            // lblRegisteredValue
            // 
            this.lblRegisteredValue.AutoSize = true;
            this.lblRegisteredValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegisteredValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblRegisteredValue.Location = new System.Drawing.Point(160, 234);
            this.lblRegisteredValue.Name = "lblRegisteredValue";
            this.lblRegisteredValue.Size = new System.Drawing.Size(15, 19);
            this.lblRegisteredValue.TabIndex = 13;
            this.lblRegisteredValue.Text = "-";
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblTotalOrders);
            this.grpStats.Controls.Add(this.lblTotalOrdersValue);
            this.grpStats.Controls.Add(this.lblCompletedOrders);
            this.grpStats.Controls.Add(this.lblCompletedOrdersValue);
            this.grpStats.Controls.Add(this.lblTotalSpent);
            this.grpStats.Controls.Add(this.lblTotalSpentValue);
            this.grpStats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpStats.Location = new System.Drawing.Point(470, 76);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(290, 200);
            this.grpStats.TabIndex = 1;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Statistics";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalOrders.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalOrders.Location = new System.Drawing.Point(14, 36);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(73, 15);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "Total Orders:";
            // 
            // lblTotalOrdersValue
            // 
            this.lblTotalOrdersValue.AutoSize = true;
            this.lblTotalOrdersValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrdersValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalOrdersValue.Location = new System.Drawing.Point(160, 30);
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            this.lblTotalOrdersValue.Size = new System.Drawing.Size(23, 25);
            this.lblTotalOrdersValue.TabIndex = 1;
            this.lblTotalOrdersValue.Text = "0";
            // 
            // lblCompletedOrders
            // 
            this.lblCompletedOrders.AutoSize = true;
            this.lblCompletedOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompletedOrders.ForeColor = System.Drawing.Color.Gray;
            this.lblCompletedOrders.Location = new System.Drawing.Point(14, 90);
            this.lblCompletedOrders.Name = "lblCompletedOrders";
            this.lblCompletedOrders.Size = new System.Drawing.Size(69, 15);
            this.lblCompletedOrders.TabIndex = 2;
            this.lblCompletedOrders.Text = "Completed:";
            // 
            // lblCompletedOrdersValue
            // 
            this.lblCompletedOrdersValue.AutoSize = true;
            this.lblCompletedOrdersValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCompletedOrdersValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCompletedOrdersValue.Location = new System.Drawing.Point(160, 84);
            this.lblCompletedOrdersValue.Name = "lblCompletedOrdersValue";
            this.lblCompletedOrdersValue.Size = new System.Drawing.Size(23, 25);
            this.lblCompletedOrdersValue.TabIndex = 3;
            this.lblCompletedOrdersValue.Text = "0";
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.AutoSize = true;
            this.lblTotalSpent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalSpent.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalSpent.Location = new System.Drawing.Point(14, 144);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(68, 15);
            this.lblTotalSpent.TabIndex = 4;
            this.lblTotalSpent.Text = "Total Spent:";
            // 
            // lblTotalSpentValue
            // 
            this.lblTotalSpentValue.AutoSize = true;
            this.lblTotalSpentValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpentValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalSpentValue.Location = new System.Drawing.Point(160, 138);
            this.lblTotalSpentValue.Name = "lblTotalSpentValue";
            this.lblTotalSpentValue.Size = new System.Drawing.Size(58, 25);
            this.lblTotalSpentValue.TabIndex = 5;
            this.lblTotalSpentValue.Text = "P0.00";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(20, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(780, 452);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.grpPersonalInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmViewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.frmViewUser_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel     panelHeader;
        private System.Windows.Forms.Label     lblTitle;
        private System.Windows.Forms.GroupBox  grpPersonalInfo;
        private System.Windows.Forms.Label     lblUserId;
        private System.Windows.Forms.Label     lblUserIdValue;
        private System.Windows.Forms.Label     lblFullName;
        private System.Windows.Forms.Label     lblFullNameValue;
        private System.Windows.Forms.Label     lblEmail;
        private System.Windows.Forms.Label     lblEmailValue;
        private System.Windows.Forms.Label     lblPhone;
        private System.Windows.Forms.Label     lblPhoneValue;
        private System.Windows.Forms.Label     lblRole;
        private System.Windows.Forms.Label     lblRoleValue;
        private System.Windows.Forms.Label     lblStatus;
        private System.Windows.Forms.Label     lblStatusValue;
        private System.Windows.Forms.Label     lblRegistered;
        private System.Windows.Forms.Label     lblRegisteredValue;
        private System.Windows.Forms.GroupBox  grpStats;
        private System.Windows.Forms.Label     lblTotalOrders;
        private System.Windows.Forms.Label     lblTotalOrdersValue;
        private System.Windows.Forms.Label     lblCompletedOrders;
        private System.Windows.Forms.Label     lblCompletedOrdersValue;
        private System.Windows.Forms.Label     lblTotalSpent;
        private System.Windows.Forms.Label     lblTotalSpentValue;
        private System.Windows.Forms.Button    btnClose;
    }
}
