
namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmClientRatings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.lblTotalRatings = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.btnViewRating = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvRatings = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.lblAverageRating);
            this.panel1.Controls.Add(this.lblAverageValue);
            this.panel1.Controls.Add(this.lblTotalRatings);
            this.panel1.Controls.Add(this.lblTotalValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.AutoSize = true;
            this.lblAverageRating.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageRating.Location = new System.Drawing.Point(41, 18);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(167, 21);
            this.lblAverageRating.TabIndex = 0;
            this.lblAverageRating.Text = "Your Average Rating:";
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.AutoSize = true;
            this.lblAverageValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageValue.Location = new System.Drawing.Point(225, 18);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(50, 21);
            this.lblAverageValue.TabIndex = 3;
            this.lblAverageValue.Text = "Value";
            // 
            // lblTotalRatings
            // 
            this.lblTotalRatings.AutoSize = true;
            this.lblTotalRatings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRatings.Location = new System.Drawing.Point(95, 62);
            this.lblTotalRatings.Name = "lblTotalRatings";
            this.lblTotalRatings.Size = new System.Drawing.Size(113, 21);
            this.lblTotalRatings.TabIndex = 1;
            this.lblTotalRatings.Text = "Total Ratings:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(222, 62);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(53, 21);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "0";
            // 
            // btnViewRating
            // 
            this.btnViewRating.BackColor = System.Drawing.Color.Plum;
            this.btnViewRating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRating.Location = new System.Drawing.Point(45, 15);
            this.btnViewRating.Name = "btnViewRating";
            this.btnViewRating.Size = new System.Drawing.Size(129, 41);
            this.btnViewRating.TabIndex = 4;
            this.btnViewRating.Text = "View Ratings";
            this.btnViewRating.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Plum;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(639, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 41);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvRatings
            // 
            this.dgvRatings.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRatings.Location = new System.Drawing.Point(0, 100);
            this.dgvRatings.Name = "dgvRatings";
            this.dgvRatings.Size = new System.Drawing.Size(800, 387);
            this.dgvRatings.TabIndex = 1;            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.LightPink;
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Controls.Add(this.btnViewRating);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 419);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(800, 68);
            this.panelActions.TabIndex = 2;
            // 
            // frmClientRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.dgvRatings);
            this.Controls.Add(this.panel1);
            this.Name = "frmClientRatings";
            this.Text = "My Reviews";
            this.Load += new System.EventHandler(this.frmClientRatings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAverageRating;
        private System.Windows.Forms.Label lblAverageValue;
        private System.Windows.Forms.Label lblTotalRatings;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Button btnViewRating;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvRatings;
        private System.Windows.Forms.Panel panelActions;
    }
}