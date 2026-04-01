
namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminHome
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
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelPendingOrders = new System.Windows.Forms.Panel();
            this.lblPendingOrdersIcon = new System.Windows.Forms.Label();
            this.lblPendingOrdersValue = new System.Windows.Forms.Label();
            this.lblPendingOrdersTitle = new System.Windows.Forms.Label();
            this.panelTotalUsers = new System.Windows.Forms.Panel();
            this.lblTotalUsersIcon = new System.Windows.Forms.Label();
            this.lblTotalUsersValue = new System.Windows.Forms.Label();
            this.lblTotalUsersTitle = new System.Windows.Forms.Label();
            this.panelTotalIncome = new System.Windows.Forms.Panel();
            this.lblTotalIncomeIcon = new System.Windows.Forms.Label();
            this.lblTotalIncomeValue = new System.Windows.Forms.Label();
            this.lblTotalIncomeTitle = new System.Windows.Forms.Label();
            this.panelTotalOrders = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalOrdersIcon = new System.Windows.Forms.Label();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.lblTotalOrdersTitle = new System.Windows.Forms.Label();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.grpUpcomingEvents = new System.Windows.Forms.GroupBox();
            this.dgvUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.grpRecentOrders = new System.Windows.Forms.GroupBox();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.panelStats.SuspendLayout();
            this.panelPendingOrders.SuspendLayout();
            this.panelTotalUsers.SuspendLayout();
            this.panelTotalIncome.SuspendLayout();
            this.panelTotalOrders.SuspendLayout();
            this.panelCharts.SuspendLayout();
            this.grpUpcomingEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).BeginInit();
            this.grpRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.Wheat;
            this.panelStats.Controls.Add(this.panelPendingOrders);
            this.panelStats.Controls.Add(this.panelTotalUsers);
            this.panelStats.Controls.Add(this.panelTotalIncome);
            this.panelStats.Controls.Add(this.panelTotalOrders);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1300, 252);
            this.panelStats.TabIndex = 0;
            // 
            // panelPendingOrders
            // 
            this.panelPendingOrders.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panelPendingOrders.Controls.Add(this.lblPendingOrdersIcon);
            this.panelPendingOrders.Controls.Add(this.lblPendingOrdersValue);
            this.panelPendingOrders.Controls.Add(this.lblPendingOrdersTitle);
            this.panelPendingOrders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPendingOrders.Location = new System.Drawing.Point(707, 71);
            this.panelPendingOrders.Name = "panelPendingOrders";
            this.panelPendingOrders.Size = new System.Drawing.Size(206, 150);
            this.panelPendingOrders.TabIndex = 5;
            // 
            // lblPendingOrdersIcon
            // 
            this.lblPendingOrdersIcon.AutoSize = true;
            this.lblPendingOrdersIcon.Location = new System.Drawing.Point(151, 61);
            this.lblPendingOrdersIcon.Name = "lblPendingOrdersIcon";
            this.lblPendingOrdersIcon.Size = new System.Drawing.Size(22, 19);
            this.lblPendingOrdersIcon.TabIndex = 2;
            this.lblPendingOrdersIcon.Text = "⏳";
            // 
            // lblPendingOrdersValue
            // 
            this.lblPendingOrdersValue.AutoSize = true;
            this.lblPendingOrdersValue.Location = new System.Drawing.Point(122, 61);
            this.lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            this.lblPendingOrdersValue.Size = new System.Drawing.Size(17, 19);
            this.lblPendingOrdersValue.TabIndex = 1;
            this.lblPendingOrdersValue.Text = "0";
            // 
            // lblPendingOrdersTitle
            // 
            this.lblPendingOrdersTitle.AutoSize = true;
            this.lblPendingOrdersTitle.Location = new System.Drawing.Point(3, 61);
            this.lblPendingOrdersTitle.Name = "lblPendingOrdersTitle";
            this.lblPendingOrdersTitle.Size = new System.Drawing.Size(113, 19);
            this.lblPendingOrdersTitle.TabIndex = 0;
            this.lblPendingOrdersTitle.Text = "Pending Orders";
            // 
            // panelTotalUsers
            // 
            this.panelTotalUsers.BackColor = System.Drawing.Color.MistyRose;
            this.panelTotalUsers.Controls.Add(this.lblTotalUsersIcon);
            this.panelTotalUsers.Controls.Add(this.lblTotalUsersValue);
            this.panelTotalUsers.Controls.Add(this.lblTotalUsersTitle);
            this.panelTotalUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTotalUsers.Location = new System.Drawing.Point(495, 71);
            this.panelTotalUsers.Name = "panelTotalUsers";
            this.panelTotalUsers.Size = new System.Drawing.Size(206, 150);
            this.panelTotalUsers.TabIndex = 4;
            // 
            // lblTotalUsersIcon
            // 
            this.lblTotalUsersIcon.AutoSize = true;
            this.lblTotalUsersIcon.Location = new System.Drawing.Point(152, 64);
            this.lblTotalUsersIcon.Name = "lblTotalUsersIcon";
            this.lblTotalUsersIcon.Size = new System.Drawing.Size(26, 19);
            this.lblTotalUsersIcon.TabIndex = 2;
            this.lblTotalUsersIcon.Text = "👥";
            // 
            // lblTotalUsersValue
            // 
            this.lblTotalUsersValue.AutoSize = true;
            this.lblTotalUsersValue.Location = new System.Drawing.Point(100, 64);
            this.lblTotalUsersValue.Name = "lblTotalUsersValue";
            this.lblTotalUsersValue.Size = new System.Drawing.Size(17, 19);
            this.lblTotalUsersValue.TabIndex = 1;
            this.lblTotalUsersValue.Text = "0";
            // 
            // lblTotalUsersTitle
            // 
            this.lblTotalUsersTitle.AutoSize = true;
            this.lblTotalUsersTitle.Location = new System.Drawing.Point(3, 64);
            this.lblTotalUsersTitle.Name = "lblTotalUsersTitle";
            this.lblTotalUsersTitle.Size = new System.Drawing.Size(91, 19);
            this.lblTotalUsersTitle.TabIndex = 0;
            this.lblTotalUsersTitle.Text = "Total Users:";
            // 
            // panelTotalIncome
            // 
            this.panelTotalIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelTotalIncome.Controls.Add(this.lblTotalIncomeIcon);
            this.panelTotalIncome.Controls.Add(this.lblTotalIncomeValue);
            this.panelTotalIncome.Controls.Add(this.lblTotalIncomeTitle);
            this.panelTotalIncome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTotalIncome.Location = new System.Drawing.Point(283, 71);
            this.panelTotalIncome.Name = "panelTotalIncome";
            this.panelTotalIncome.Size = new System.Drawing.Size(206, 150);
            this.panelTotalIncome.TabIndex = 3;
            // 
            // lblTotalIncomeIcon
            // 
            this.lblTotalIncomeIcon.AutoSize = true;
            this.lblTotalIncomeIcon.Location = new System.Drawing.Point(161, 61);
            this.lblTotalIncomeIcon.Name = "lblTotalIncomeIcon";
            this.lblTotalIncomeIcon.Size = new System.Drawing.Size(24, 19);
            this.lblTotalIncomeIcon.TabIndex = 2;
            this.lblTotalIncomeIcon.Text = "💰";
            // 
            // lblTotalIncomeValue
            // 
            this.lblTotalIncomeValue.AutoSize = true;
            this.lblTotalIncomeValue.Location = new System.Drawing.Point(110, 61);
            this.lblTotalIncomeValue.Name = "lblTotalIncomeValue";
            this.lblTotalIncomeValue.Size = new System.Drawing.Size(26, 19);
            this.lblTotalIncomeValue.TabIndex = 1;
            this.lblTotalIncomeValue.Text = "P0";
            // 
            // lblTotalIncomeTitle
            // 
            this.lblTotalIncomeTitle.AutoSize = true;
            this.lblTotalIncomeTitle.Location = new System.Drawing.Point(3, 61);
            this.lblTotalIncomeTitle.Name = "lblTotalIncomeTitle";
            this.lblTotalIncomeTitle.Size = new System.Drawing.Size(101, 19);
            this.lblTotalIncomeTitle.TabIndex = 0;
            this.lblTotalIncomeTitle.Text = "Total Income:";
            // 
            // panelTotalOrders
            // 
            this.panelTotalOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTotalOrders.Controls.Add(this.panel1);
            this.panelTotalOrders.Controls.Add(this.lblTotalOrdersIcon);
            this.panelTotalOrders.Controls.Add(this.lblTotalOrdersValue);
            this.panelTotalOrders.Controls.Add(this.lblTotalOrdersTitle);
            this.panelTotalOrders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTotalOrders.Location = new System.Drawing.Point(70, 71);
            this.panelTotalOrders.Name = "panelTotalOrders";
            this.panelTotalOrders.Size = new System.Drawing.Size(202, 150);
            this.panelTotalOrders.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(237, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // lblTotalOrdersIcon
            // 
            this.lblTotalOrdersIcon.AutoSize = true;
            this.lblTotalOrdersIcon.Location = new System.Drawing.Point(161, 61);
            this.lblTotalOrdersIcon.Name = "lblTotalOrdersIcon";
            this.lblTotalOrdersIcon.Size = new System.Drawing.Size(26, 19);
            this.lblTotalOrdersIcon.TabIndex = 2;
            this.lblTotalOrdersIcon.Text = "📦";
            // 
            // lblTotalOrdersValue
            // 
            this.lblTotalOrdersValue.AutoSize = true;
            this.lblTotalOrdersValue.Location = new System.Drawing.Point(113, 61);
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            this.lblTotalOrdersValue.Size = new System.Drawing.Size(17, 19);
            this.lblTotalOrdersValue.TabIndex = 1;
            this.lblTotalOrdersValue.Text = "0";
            // 
            // lblTotalOrdersTitle
            // 
            this.lblTotalOrdersTitle.AutoSize = true;
            this.lblTotalOrdersTitle.Location = new System.Drawing.Point(4, 61);
            this.lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            this.lblTotalOrdersTitle.Size = new System.Drawing.Size(103, 19);
            this.lblTotalOrdersTitle.TabIndex = 0;
            this.lblTotalOrdersTitle.Text = "Total Orders: ";
            // 
            // panelCharts
            // 
            this.panelCharts.BackColor = System.Drawing.Color.Wheat;
            this.panelCharts.Controls.Add(this.grpUpcomingEvents);
            this.panelCharts.Controls.Add(this.grpRecentOrders);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCharts.Location = new System.Drawing.Point(0, 252);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(1300, 573);
            this.panelCharts.TabIndex = 1;
            // 
            // grpUpcomingEvents
            // 
            this.grpUpcomingEvents.BackColor = System.Drawing.Color.White;
            this.grpUpcomingEvents.Controls.Add(this.dgvUpcomingEvents);
            this.grpUpcomingEvents.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpcomingEvents.Location = new System.Drawing.Point(362, 10);
            this.grpUpcomingEvents.Name = "grpUpcomingEvents";
            this.grpUpcomingEvents.Size = new System.Drawing.Size(334, 270);
            this.grpUpcomingEvents.TabIndex = 2;
            this.grpUpcomingEvents.TabStop = false;
            this.grpUpcomingEvents.Text = "UPCOMING EVENTS";
            // 
            // dgvUpcomingEvents
            // 
            this.dgvUpcomingEvents.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvUpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingEvents.Location = new System.Drawing.Point(22, 21);
            this.dgvUpcomingEvents.Name = "dgvUpcomingEvents";
            this.dgvUpcomingEvents.Size = new System.Drawing.Size(289, 207);
            this.dgvUpcomingEvents.TabIndex = 1;
            // 
            // grpRecentOrders
            // 
            this.grpRecentOrders.BackColor = System.Drawing.Color.White;
            this.grpRecentOrders.Controls.Add(this.dgvRecentOrders);
            this.grpRecentOrders.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecentOrders.Location = new System.Drawing.Point(22, 10);
            this.grpRecentOrders.Name = "grpRecentOrders";
            this.grpRecentOrders.Size = new System.Drawing.Size(334, 270);
            this.grpRecentOrders.TabIndex = 0;
            this.grpRecentOrders.TabStop = false;
            this.grpRecentOrders.Text = "RECENT ORDERS";
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentOrders.GridColor = System.Drawing.Color.White;
            this.dgvRecentOrders.Location = new System.Drawing.Point(23, 21);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.Size = new System.Drawing.Size(277, 219);
            this.dgvRecentOrders.TabIndex = 1;
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminHome";
            this.Text = "Dashboard";
            this.panelStats.ResumeLayout(false);
            this.panelPendingOrders.ResumeLayout(false);
            this.panelPendingOrders.PerformLayout();
            this.panelTotalUsers.ResumeLayout(false);
            this.panelTotalUsers.PerformLayout();
            this.panelTotalIncome.ResumeLayout(false);
            this.panelTotalIncome.PerformLayout();
            this.panelTotalOrders.ResumeLayout(false);
            this.panelTotalOrders.PerformLayout();
            this.panelCharts.ResumeLayout(false);
            this.grpUpcomingEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).EndInit();
            this.grpRecentOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelPendingOrders;
        private System.Windows.Forms.Label lblPendingOrdersIcon;
        private System.Windows.Forms.Label lblPendingOrdersValue;
        private System.Windows.Forms.Label lblPendingOrdersTitle;
        private System.Windows.Forms.Panel panelTotalUsers;
        private System.Windows.Forms.Label lblTotalUsersIcon;
        private System.Windows.Forms.Label lblTotalUsersValue;
        private System.Windows.Forms.Label lblTotalUsersTitle;
        private System.Windows.Forms.Panel panelTotalIncome;
        private System.Windows.Forms.Label lblTotalIncomeIcon;
        private System.Windows.Forms.Label lblTotalIncomeValue;
        private System.Windows.Forms.Label lblTotalIncomeTitle;
        private System.Windows.Forms.Panel panelTotalOrders;
        private System.Windows.Forms.Label lblTotalOrdersIcon;
        private System.Windows.Forms.Label lblTotalOrdersValue;
        private System.Windows.Forms.Label lblTotalOrdersTitle;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.GroupBox grpUpcomingEvents;
        private System.Windows.Forms.DataGridView dgvUpcomingEvents;
        private System.Windows.Forms.GroupBox grpRecentOrders;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Panel panel1;
    }
}