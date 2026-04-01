
namespace PhotoBoothRentalSystem.Forms.Admin
{
    partial class frmChangeOrderStatus
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblCurrentStatusValue = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.cboNewStatus = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.chkNotifyCustomer = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHANGE ORDER STATUS";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(170, 9);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(18, 13);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "ID";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(19, 55);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(50, 13);
            this.lblCurrentStatus.TabIndex = 2;
            this.lblCurrentStatus.Text = "STATUS";
            // 
            // lblCurrentStatusValue
            // 
            this.lblCurrentStatusValue.AutoSize = true;
            this.lblCurrentStatusValue.Location = new System.Drawing.Point(75, 55);
            this.lblCurrentStatusValue.Name = "lblCurrentStatusValue";
            this.lblCurrentStatusValue.Size = new System.Drawing.Size(42, 13);
            this.lblCurrentStatusValue.TabIndex = 3;
            this.lblCurrentStatusValue.Text = "-";
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(184, 55);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(52, 13);
            this.lblNewStatus.TabIndex = 4;
            this.lblNewStatus.Text = "CHANGE";
            // 
            // cboNewStatus
            // 
            this.cboNewStatus.FormattingEnabled = true;
            this.cboNewStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed, ",
            "Completed, ",
            "Cancelled"});
            this.cboNewStatus.Location = new System.Drawing.Point(242, 52);
            this.cboNewStatus.Name = "cboNewStatus";
            this.cboNewStatus.Size = new System.Drawing.Size(121, 21);
            this.cboNewStatus.TabIndex = 5;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(19, 86);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(22, 115);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(350, 100);
            this.txtNotes.TabIndex = 7;
            // 
            // chkNotifyCustomer
            // 
            this.chkNotifyCustomer.AutoSize = true;
            this.chkNotifyCustomer.Location = new System.Drawing.Point(22, 221);
            this.chkNotifyCustomer.Name = "chkNotifyCustomer";
            this.chkNotifyCustomer.Size = new System.Drawing.Size(100, 17);
            this.chkNotifyCustomer.TabIndex = 8;
            this.chkNotifyCustomer.Text = "Notify Customer";
            this.chkNotifyCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(225, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(306, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmChangeOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkNotifyCustomer);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cboNewStatus);
            this.Controls.Add(this.lblNewStatus);
            this.Controls.Add(this.lblCurrentStatusValue);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeOrderStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Order Status";
            this.Load += new System.EventHandler(this.frmChangeOrderStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblCurrentStatusValue;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cboNewStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.CheckBox chkNotifyCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}