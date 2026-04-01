using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;  // ← ADD THIS

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmOrderDetails : Form
    {
        private int orderId;
        private Order order;
        private Package package;

        public frmOrderDetails(int orderIdParam)
        {
            InitializeComponent();
            orderId = orderIdParam;
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            try
            {
                order = OrderService.GetOrderById(orderId);
                if (order == null)
                {
                    MessageBox.Show("Order not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                package = PackageService.GetPackageById(order.PackageId);

                // Populate fields
                lblOrderIdValue.Text = $"#{order.OrderId}";
                lblStatusValue.Text = order.Status;
                lblOrderDateValue.Text = order.CreatedAt.ToString("MMMM dd, yyyy hh:mm tt");

                // Color code status
                switch (order.Status)
                {
                    case "Pending":
                        lblStatusValue.ForeColor = Color.FromArgb(241, 196, 15);
                        break;
                    case "Confirmed":
                        lblStatusValue.ForeColor = Color.FromArgb(52, 152, 219);
                        break;
                    case "Completed":
                        lblStatusValue.ForeColor = Color.FromArgb(46, 204, 113);
                        break;
                    case "Cancelled":
                        lblStatusValue.ForeColor = Color.FromArgb(231, 76, 60);
                        break;
                }

                // Package info
                if (package != null)
                {
                    lblPackageValue.Text = package.PackageName;
                    lblPriceValue.Text = $"₱{package.Price:N2}";
                    lblHoursValue.Text = $"{package.Hours} Hours";
                }

                // Event info
                lblEventDateValue.Text = order.EventDate.ToString("MMMM dd, yyyy");
                lblLocationValue.Text = order.EventLocation;
                lblEventTypeValue.Text = order.EventType;
                lblThemeValue.Text = string.IsNullOrWhiteSpace(order.PartyTheme) ? "N/A" : order.PartyTheme;
                lblCelebrantValue.Text = string.IsNullOrWhiteSpace(order.CelebrantName) ? "N/A" : order.CelebrantName;
                lblContactValue.Text = order.ContactPerson;
                lblTimeValue.Text = $"{order.BoothStartTime:hh\\:mm} - {order.BoothEndTime:hh\\:mm}";

                // Payment info
                lblTotalValue.Text = $"₱{order.TotalAmount:N2}";
                lblDownValue.Text = $"₱{order.DownPayment:N2}";
                lblBalanceValue.Text = $"₱{order.Balance:N2}";

                // File status
                bool hasCelebrantPhoto = FileUploadService.HasFile(orderId, "celebrant_photo");
                bool hasInvitation = FileUploadService.HasFile(orderId, "invitation");

                lblCelebrantPhotoStatus.Text = hasCelebrantPhoto ? "✓ Uploaded" : "✗ Not uploaded";
                lblCelebrantPhotoStatus.ForeColor = hasCelebrantPhoto ? Color.Green : Color.Red;
                btnViewPhoto.Enabled = hasCelebrantPhoto;

                lblInvitationStatus.Text = hasInvitation ? "✓ Uploaded" : "✗ Not uploaded";
                lblInvitationStatus.ForeColor = hasInvitation ? Color.Green : Color.Red;
                btnViewInvitation.Enabled = hasInvitation;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order details: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewPhoto_Click(object sender, EventArgs e)
        {
            ViewFile("celebrant_photo");
        }

        private void btnViewInvitation_Click(object sender, EventArgs e)
        {
            ViewFile("invitation");
        }

        private void ViewFile(string fileType)
        {
            try
            {
                string filePath = FileUploadService.GetOrderFilePath(orderId, fileType);
                if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
                {
                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("File not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}