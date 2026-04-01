
namespace PhotoBoothRentalSystem.Forms.Client
{
    partial class frmUploadFiles
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
            this.grpCelebrantPhoto = new System.Windows.Forms.GroupBox();
            this.picPreviewPhoto = new System.Windows.Forms.PictureBox();
            this.btnRemovePhoto = new System.Windows.Forms.Button();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.lblPhotoStatus = new System.Windows.Forms.Label();
            this.CLOSE = new System.Windows.Forms.Button();
            this.grpInvitation = new System.Windows.Forms.GroupBox();
            this.picPreviewInvitation = new System.Windows.Forms.PictureBox();
            this.btnRemoveInvitation = new System.Windows.Forms.Button();
            this.lblInvitationStatus = new System.Windows.Forms.Label();
            this.btnUploadInvitation = new System.Windows.Forms.Button();
            this.grpCelebrantPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewPhoto)).BeginInit();
            this.grpInvitation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewInvitation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "UPLOAD FILES";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(109, 9);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(18, 13);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "ID";
            // 
            // grpCelebrantPhoto
            // 
            this.grpCelebrantPhoto.BackColor = System.Drawing.Color.LightPink;
            this.grpCelebrantPhoto.Controls.Add(this.picPreviewPhoto);
            this.grpCelebrantPhoto.Controls.Add(this.btnRemovePhoto);
            this.grpCelebrantPhoto.Controls.Add(this.btnUploadPhoto);
            this.grpCelebrantPhoto.Controls.Add(this.lblPhotoStatus);
            this.grpCelebrantPhoto.Location = new System.Drawing.Point(12, 69);
            this.grpCelebrantPhoto.Name = "grpCelebrantPhoto";
            this.grpCelebrantPhoto.Size = new System.Drawing.Size(192, 226);
            this.grpCelebrantPhoto.TabIndex = 2;
            this.grpCelebrantPhoto.TabStop = false;
            this.grpCelebrantPhoto.Text = "Group Celebrant Photo";
            // 
            // picPreviewPhoto
            // 
            this.picPreviewPhoto.Location = new System.Drawing.Point(6, 49);
            this.picPreviewPhoto.Name = "picPreviewPhoto";
            this.picPreviewPhoto.Size = new System.Drawing.Size(150, 150);
            this.picPreviewPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreviewPhoto.TabIndex = 5;
            this.picPreviewPhoto.TabStop = false;
            // 
            // btnRemovePhoto
            // 
            this.btnRemovePhoto.BackColor = System.Drawing.Color.Plum;
            this.btnRemovePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePhoto.Location = new System.Drawing.Point(162, 20);
            this.btnRemovePhoto.Name = "btnRemovePhoto";
            this.btnRemovePhoto.Size = new System.Drawing.Size(22, 23);
            this.btnRemovePhoto.TabIndex = 2;
            this.btnRemovePhoto.Text = "X";
            this.btnRemovePhoto.UseVisualStyleBackColor = false;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.Plum;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Location = new System.Drawing.Point(6, 20);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(150, 23);
            this.btnUploadPhoto.TabIndex = 1;
            this.btnUploadPhoto.Text = "Upload Photo ";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            // 
            // lblPhotoStatus
            // 
            this.lblPhotoStatus.AutoSize = true;
            this.lblPhotoStatus.Location = new System.Drawing.Point(147, 0);
            this.lblPhotoStatus.Name = "lblPhotoStatus";
            this.lblPhotoStatus.Size = new System.Drawing.Size(37, 13);
            this.lblPhotoStatus.TabIndex = 0;
            this.lblPhotoStatus.Text = "Status";
            // 
            // CLOSE
            // 
            this.CLOSE.BackColor = System.Drawing.Color.Plum;
            this.CLOSE.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLOSE.Location = new System.Drawing.Point(278, 314);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(141, 23);
            this.CLOSE.TabIndex = 5;
            this.CLOSE.Text = "CLOSE";
            this.CLOSE.UseVisualStyleBackColor = false;
            // 
            // grpInvitation
            // 
            this.grpInvitation.BackColor = System.Drawing.Color.LightPink;
            this.grpInvitation.Controls.Add(this.picPreviewInvitation);
            this.grpInvitation.Controls.Add(this.btnRemoveInvitation);
            this.grpInvitation.Controls.Add(this.lblInvitationStatus);
            this.grpInvitation.Controls.Add(this.btnUploadInvitation);
            this.grpInvitation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpInvitation.Location = new System.Drawing.Point(224, 69);
            this.grpInvitation.Name = "grpInvitation";
            this.grpInvitation.Size = new System.Drawing.Size(195, 226);
            this.grpInvitation.TabIndex = 6;
            this.grpInvitation.TabStop = false;
            this.grpInvitation.Text = "Invitation";
            // 
            // picPreviewInvitation
            // 
            this.picPreviewInvitation.Location = new System.Drawing.Point(9, 49);
            this.picPreviewInvitation.Name = "picPreviewInvitation";
            this.picPreviewInvitation.Size = new System.Drawing.Size(150, 150);
            this.picPreviewInvitation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreviewInvitation.TabIndex = 8;
            this.picPreviewInvitation.TabStop = false;
            // 
            // btnRemoveInvitation
            // 
            this.btnRemoveInvitation.BackColor = System.Drawing.Color.Plum;
            this.btnRemoveInvitation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveInvitation.Location = new System.Drawing.Point(165, 20);
            this.btnRemoveInvitation.Name = "btnRemoveInvitation";
            this.btnRemoveInvitation.Size = new System.Drawing.Size(22, 23);
            this.btnRemoveInvitation.TabIndex = 7;
            this.btnRemoveInvitation.Text = "X";
            this.btnRemoveInvitation.UseVisualStyleBackColor = false;
            // 
            // lblInvitationStatus
            // 
            this.lblInvitationStatus.AutoSize = true;
            this.lblInvitationStatus.Location = new System.Drawing.Point(122, 0);
            this.lblInvitationStatus.Name = "lblInvitationStatus";
            this.lblInvitationStatus.Size = new System.Drawing.Size(37, 13);
            this.lblInvitationStatus.TabIndex = 6;
            this.lblInvitationStatus.Text = "Status";
            // 
            // btnUploadInvitation
            // 
            this.btnUploadInvitation.BackColor = System.Drawing.Color.Plum;
            this.btnUploadInvitation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadInvitation.Location = new System.Drawing.Point(9, 20);
            this.btnUploadInvitation.Name = "btnUploadInvitation";
            this.btnUploadInvitation.Size = new System.Drawing.Size(150, 23);
            this.btnUploadInvitation.TabIndex = 6;
            this.btnUploadInvitation.Text = "Upload Photo ";
            this.btnUploadInvitation.UseVisualStyleBackColor = false;
            // 
            // frmUploadFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(430, 351);
            this.Controls.Add(this.grpInvitation);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.grpCelebrantPhoto);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUploadFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Files";
            this.Load += new System.EventHandler(this.frmUploadFiles_Load);
            this.grpCelebrantPhoto.ResumeLayout(false);
            this.grpCelebrantPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewPhoto)).EndInit();
            this.grpInvitation.ResumeLayout(false);
            this.grpInvitation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewInvitation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.GroupBox grpCelebrantPhoto;
        private System.Windows.Forms.PictureBox picPreviewPhoto;
        private System.Windows.Forms.Button btnRemovePhoto;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Label lblPhotoStatus;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.GroupBox grpInvitation;
        private System.Windows.Forms.PictureBox picPreviewInvitation;
        private System.Windows.Forms.Button btnRemoveInvitation;
        private System.Windows.Forms.Label lblInvitationStatus;
        private System.Windows.Forms.Button btnUploadInvitation;
    }
}