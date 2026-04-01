
namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmAdminRatings
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
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.lblTotalRatings = new System.Windows.Forms.Label();
            this.dgvRatings = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.Black;
            this.panelStats.Controls.Add(this.lblTotalValue);
            this.panelStats.Controls.Add(this.lblAverageRating);
            this.panelStats.Controls.Add(this.lblAverageValue);
            this.panelStats.Controls.Add(this.lblTotalRatings);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.ForeColor = System.Drawing.Color.White;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1284, 120);
            this.panelStats.TabIndex = 0;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(146, 45);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(90, 15);
            this.lblTotalValue.TabIndex = 5;
            this.lblTotalValue.Text = "TOTAL VALUE";
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.AutoSize = true;
            this.lblAverageRating.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageRating.Location = new System.Drawing.Point(28, 19);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(114, 15);
            this.lblAverageRating.TabIndex = 4;
            this.lblAverageRating.Text = "AVERAGE RATING";
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.AutoSize = true;
            this.lblAverageValue.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageValue.Location = new System.Drawing.Point(146, 19);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(106, 15);
            this.lblAverageValue.TabIndex = 3;
            this.lblAverageValue.Text = "AVERAGE VALUE";
            // 
            // lblTotalRatings
            // 
            this.lblTotalRatings.AutoSize = true;
            this.lblTotalRatings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRatings.Location = new System.Drawing.Point(28, 45);
            this.lblTotalRatings.Name = "lblTotalRatings";
            this.lblTotalRatings.Size = new System.Drawing.Size(106, 15);
            this.lblTotalRatings.TabIndex = 1;
            this.lblTotalRatings.Text = "TOTAL RATINGS";
            // 
            // dgvRatings
            // 
            this.dgvRatings.BackgroundColor = System.Drawing.Color.White;
            this.dgvRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRatings.Location = new System.Drawing.Point(0, 120);
            this.dgvRatings.Name = "dgvRatings";
            this.dgvRatings.Size = new System.Drawing.Size(1284, 667);
            this.dgvRatings.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(0, 764);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(1284, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "REFRISH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmAdminRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 787);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvRatings);
            this.Controls.Add(this.panelStats);
            this.Name = "frmAdminRatings";
            this.Text = "Customer Ratings";
            this.Load += new System.EventHandler(this.frmAdminRatings_Load);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblAverageRating;
        private System.Windows.Forms.Label lblAverageValue;
        private System.Windows.Forms.Label lblTotalRatings;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.DataGridView dgvRatings;
        private System.Windows.Forms.Button btnRefresh;
    }
}