using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PhotoBoothRentalSystem.Classes.Services;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmUploadFiles : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        private int orderId;

        public frmUploadFiles(int orderIdParam)
        {
            InitializeComponent();
            orderId = orderIdParam;
        }

        private void frmUploadFiles_Load(object sender, EventArgs e)
        {
            lblOrderId.Text = $"Order #{orderId}";
            LoadFileStatus();
        }

        private void LoadFileStatus()
        {
            // Celebrant Photo
            bool hasPhoto = FileUploadService.HasFile(orderId, "celebrant_photo");
            lblPhotoStatus.Text = hasPhoto ? "✓ Uploaded" : "No file uploaded";
            lblPhotoStatus.ForeColor = hasPhoto ? Color.Green : Color.Gray;
            btnRemovePhoto.Enabled = hasPhoto;

            if (hasPhoto)
            {
                string photoPath = FileUploadService.GetOrderFilePath(orderId, "celebrant_photo");
                if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                {
                    try
                    {
                        picPreviewPhoto.Image = Image.FromFile(photoPath);
                    }
                    catch { }
                }
            }
            else
            {
                picPreviewPhoto.Image = null;
            }

            // Invitation
            bool hasInvitation = FileUploadService.HasFile(orderId, "invitation");
            lblInvitationStatus.Text = hasInvitation ? "✓ Uploaded" : "No file uploaded";
            lblInvitationStatus.ForeColor = hasInvitation ? Color.Green : Color.Gray;
            btnRemoveInvitation.Enabled = hasInvitation;

            if (hasInvitation)
            {
                string invitationPath = FileUploadService.GetOrderFilePath(orderId, "invitation");
                if (!string.IsNullOrEmpty(invitationPath) && File.Exists(invitationPath))
                {
                    try
                    {
                        picPreviewInvitation.Image = Image.FromFile(invitationPath);
                    }
                    catch { }
                }
            }
            else
            {
                picPreviewInvitation.Image = null;
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            UploadFile("celebrant_photo", "Celebrant Photo");
        }

        private void btnUploadInvitation_Click(object sender, EventArgs e)
        {
            UploadFile("invitation", "Invitation");
        }

        private void UploadFile(string fileType, string displayName)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = $"Select {displayName}"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Check file size (max 5MB)
                    FileInfo fileInfo = new FileInfo(ofd.FileName);
                    if (fileInfo.Length > 5 * 1024 * 1024)
                    {
                        MessageBox.Show("File size must be less than 5MB.", "File Too Large",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Remove existing file if any
                    if (FileUploadService.HasFile(orderId, fileType))
                    {
                        FileUploadService.DeleteOrderFile(orderId, fileType);
                    }

                    // Upload new file
                    if (FileUploadService.SaveOrderFile(orderId, fileType, ofd.FileName))
                    {
                        MessageBox.Show($"{displayName} uploaded successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFileStatus();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to upload {displayName}.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading file: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            RemoveFile("celebrant_photo", "Celebrant Photo");
        }

        private void btnRemoveInvitation_Click(object sender, EventArgs e)
        {
            RemoveFile("invitation", "Invitation");
        }

        private void RemoveFile(string fileType, string displayName)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove the {displayName}?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (FileUploadService.DeleteOrderFile(orderId, fileType))
                    {
                        MessageBox.Show($"{displayName} removed successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFileStatus();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to remove {displayName}.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing file: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}