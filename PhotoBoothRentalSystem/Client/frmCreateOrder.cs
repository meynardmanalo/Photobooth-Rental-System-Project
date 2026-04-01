using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;
using PhotoBoothRentalSystem.Classes.Utilities;
using PhotoBoothRentalSystem.Forms.Shared;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmCreateOrder : Form
    {
        private int     _packageId;
        private Package _package;
        private string  _celebrantPhotoPath = "";
        private string  _invitationPath     = "";

        public frmCreateOrder(int packageId)
        {
            InitializeComponent();
            _packageId = packageId;
        }

        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            LoadPackageDetails();
            LoadEventTypes();
            dtpEventDate.MinDate = DateTime.Now.Date.AddDays(1);
            timeStart.Format     = DateTimePickerFormat.Time;
            timeEnd.Format       = DateTimePickerFormat.Time;
            timeStart.ShowUpDown = true;
            timeEnd.ShowUpDown   = true;
            chkAgreeTerms.Text   = "I agree: P500 non-refundable down payment. No cancellations once confirmed. Balance due on event date.";
        }

        private void LoadPackageDetails()
        {
            _package = PackageService.GetPackageById(_packageId);
            if (_package == null)
            {
                MessageBox.Show("Package not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblPackageName.Text  = _package.PackageName;
            lblPackageType.Text  = _package.PackageType;
            lblPackagePrice.Text = "P " + _package.Price.ToString("N2");
            lblPackageHours.Text = _package.Hours + " hr" + (_package.Hours != 1 ? "s" : "");
            if (lblPackagePhotos != null) lblPackagePhotos.Text = _package.MaxPhotos + " prints";
            lblTotalValue.Text   = "P " + _package.Price.ToString("N2");
            lblDownValue.Text    = "P 500.00";
            lblBalanceValue.Text = "P " + (_package.Price - 500).ToString("N2");
        }

        private void LoadEventTypes()
        {
            cboEventType.Items.AddRange(new string[]
            { "Birthday", "Wedding", "Christening", "Anniversary",
              "Corporate Event", "Graduation", "Other" });
        }

        private void btnPickLocation_Click(object sender, EventArgs e)
        {
            using (var picker = new frmLocationPicker(txtLocation.Text))
                if (picker.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(picker.SelectedAddress))
                    txtLocation.Text = picker.SelectedAddress;
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp", Title = "Select Celebrant Photo" })
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                _celebrantPhotoPath    = ofd.FileName;
                lblPhotoPath.Text      = Path.GetFileName(_celebrantPhotoPath);
                lblPhotoPath.ForeColor = Color.FromArgb(39, 174, 96);
            }
        }

        private void btnUploadInvitation_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp", Title = "Select Invitation" })
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                _invitationPath             = ofd.FileName;
                lblInvitationPath.Text      = Path.GetFileName(_invitationPath);
                lblInvitationPath.ForeColor = Color.FromArgb(39, 174, 96);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            if (!chkAgreeTerms.Checked)
            {
                MessageBox.Show("Please agree to the terms and conditions.",
                    "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SubmitOrder();
        }

        private bool ValidateForm()
        {
            if (dtpEventDate.Value.Date <= DateTime.Now.Date)
            { MessageBox.Show("Event date must be at least 1 day from today.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            { MessageBox.Show("Please enter or pick the event location.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtLocation.Focus(); return false; }
            if (cboEventType.SelectedIndex == -1)
            { MessageBox.Show("Please select an event type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); cboEventType.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtContactPerson.Text))
            { MessageBox.Show("Please enter a contact person.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtContactPerson.Focus(); return false; }
            if (timeEnd.Value.TimeOfDay <= timeStart.Value.TimeOfDay)
            { MessageBox.Show("End time must be after start time.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        private void SubmitOrder()
        {
            btnSubmit.Enabled = false;
            btnSubmit.Text    = "Submitting...";
            try
            {
                var order = new Order
                {
                    UserId          = SessionManager.CurrentUser.UserId,
                    PackageId       = _packageId,
                    EventDate       = dtpEventDate.Value.Date,
                    EventLocation   = txtLocation.Text.Trim(),
                    EventType       = cboEventType.SelectedItem.ToString(),
                    PartyTheme      = txtTheme.Text.Trim(),
                    CelebrantName   = txtCelebrantName.Text.Trim(),
                    ContactPerson   = txtContactPerson.Text.Trim(),
                    BoothStartTime  = timeStart.Value.TimeOfDay,
                    BoothEndTime    = timeEnd.Value.TimeOfDay,
                    DownPayment     = 500,
                    TotalAmount     = _package.Price,
                    Balance         = _package.Price - 500,
                    SpecialRequests = txtSpecialRequests.Text.Trim()
                };

                int orderId = OrderService.CreateOrder(order);
                if (orderId <= 0) throw new Exception("Failed to create order — no ID returned.");

                if (!string.IsNullOrEmpty(_celebrantPhotoPath))
                    FileUploadService.SaveOrderFile(orderId, "celebrant_photo", _celebrantPhotoPath);
                if (!string.IsNullOrEmpty(_invitationPath))
                    FileUploadService.SaveOrderFile(orderId, "invitation", _invitationPath);

                int adminId = MessageService.GetAdminUserId();
                if (adminId > 0)
                    NotificationService.CreateNotification(adminId,
                        "New order #" + orderId + " from " + SessionManager.CurrentUser.FullName,
                        "new_order");

                NotificationService.CreateNotification(
                    SessionManager.CurrentUser.UserId,
                    "Order #" + orderId + " submitted. Please complete your down payment to confirm.",
                    "order_submitted");

                this.Hide();
                using (var gw = new frmPaymentGateway(orderId, _package.PackageName, order.EventDate, order.TotalAmount))
                    gw.ShowDialog();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting order: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSubmit.Enabled = true;
                btnSubmit.Text    = "Submit Order";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
