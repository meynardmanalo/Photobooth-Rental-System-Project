namespace PhotoBoothRentalSystem.Forms.Shared
{
    partial class frmLoading
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components    = new System.ComponentModel.Container();
            this.panelBg       = new System.Windows.Forms.Panel();
            this.lblBrand      = new System.Windows.Forms.Label();
            this.lblTagline    = new System.Windows.Forms.Label();
            this.progressBar   = new System.Windows.Forms.ProgressBar();
            this.lblMessage    = new System.Windows.Forms.Label();
            this.timerDots     = new System.Windows.Forms.Timer(this.components);

            this.panelBg.SuspendLayout();
            this.SuspendLayout();

            // panelBg
            this.panelBg.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.Controls.AddRange(new System.Windows.Forms.Control[]
            { this.lblBrand, this.lblTagline, this.progressBar, this.lblMessage });

            // lblBrand
            this.lblBrand.Text = "ZASS";
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblBrand.AutoSize = false;
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrand.Size = new System.Drawing.Size(400, 80);
            this.lblBrand.Location = new System.Drawing.Point(0, 120);

            // lblTagline
            this.lblTagline.Text = "PhotoBooth Rental System";
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblTagline.AutoSize = false;
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTagline.Size = new System.Drawing.Size(400, 30);
            this.lblTagline.Location = new System.Drawing.Point(0, 205);

            // progressBar
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.MarqueeAnimationSpeed = 25;
            this.progressBar.Location = new System.Drawing.Point(60, 290);
            this.progressBar.Size = new System.Drawing.Size(280, 6);
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);

            // lblMessage
            this.lblMessage.Text = "Loading...";
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblMessage.AutoSize = false;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Size = new System.Drawing.Size(400, 26);
            this.lblMessage.Location = new System.Drawing.Point(0, 308);

            // timerDots
            this.timerDots.Interval = 400;
            this.timerDots.Tick += new System.EventHandler(this.timerDots_Tick);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.panelBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmLoading";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmLoading_Load);

            this.panelBg.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel      panelBg;
        private System.Windows.Forms.Label      lblBrand;
        private System.Windows.Forms.Label      lblTagline;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label      lblMessage;
        private System.Windows.Forms.Timer      timerDots;
    }
}
