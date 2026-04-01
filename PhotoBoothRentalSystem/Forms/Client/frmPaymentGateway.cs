using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmPaymentGateway : Form
    {
        private readonly int      _orderId;
        private readonly string   _packageName;
        private readonly DateTime _eventDate;
        private readonly decimal  _totalAmount;
        private string _proofFilePath = "";

        // Placeholder tracking
        private const string PLACEHOLDER_GCASH = "Enter GCash Reference Number";
        private const string PLACEHOLDER_BANK  = "Enter Bank Reference / Transaction Number";

        public frmPaymentGateway(int orderId, string packageName, DateTime eventDate, decimal totalAmount)
        {
            InitializeComponent();
            _orderId     = orderId;
            _packageName = packageName;
            _eventDate   = eventDate;
            _totalAmount = totalAmount;
        }

        private void frmPaymentGateway_Load(object sender, EventArgs e)
        {
            lblOrderId.Text      = $"Order #{_orderId}";
            lblPackageVal.Text   = _packageName;
            lblEventDateVal.Text = _eventDate.ToString("MMMM dd, yyyy");
            lblTotalVal.Text     = $"P{_totalAmount:N2}";
            lblDownVal.Text      = "P500.00";
            lblBalanceVal.Text   = $"P{(_totalAmount - 500):N2}";

            // Wire placeholder focus events
            txtRefNumber.GotFocus  += txtRefNumber_GotFocus;
            txtRefNumber.LostFocus += txtRefNumber_LostFocus;
        }

        // ── Placeholder simulation (no PlaceholderText in .NET Framework) ──

        private void txtRefNumber_GotFocus(object sender, EventArgs e)
        {
            if (txtRefNumber.Tag != null &&
                (txtRefNumber.Text == PLACEHOLDER_GCASH || txtRefNumber.Text == PLACEHOLDER_BANK))
            {
                txtRefNumber.Text      = "";
                txtRefNumber.ForeColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void txtRefNumber_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRefNumber.Text) && txtRefNumber.Tag != null)
            {
                string ph = txtRefNumber.Tag.ToString() == "gcash" ? PLACEHOLDER_GCASH : PLACEHOLDER_BANK;
                txtRefNumber.Text      = ph;
                txtRefNumber.ForeColor = Color.Gray;
            }
        }

        // ── Upload Proof ──────────────────────────────────────────

        private void btnUploadProof_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Title  = "Select Payment Proof"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _proofFilePath        = ofd.FileName;
                    lblProofFile.Text     = Path.GetFileName(_proofFilePath);
                    lblProofFile.ForeColor= Color.FromArgb(39, 174, 96);
                    btnUploadProof.Text   = "Change Proof";
                }
            }
        }

        // ── Confirm Payment ───────────────────────────────────────

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (!rbGcash.Checked && !rbBank.Checked && !rbCash.Checked)
            {
                MessageBox.Show("Please select a payment method.", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string paymentMethod = rbGcash.Checked ? "GCash"
                                 : rbBank.Checked  ? "Bank Transfer"
                                 : "Cash on Confirmation";

            // Get real ref number (not placeholder)
            string refNumber = txtRefNumber.Text.Trim();
            if (refNumber == PLACEHOLDER_GCASH || refNumber == PLACEHOLDER_BANK)
                refNumber = "";

            var confirm = MessageBox.Show(
                $"Confirm payment submission?\n\n" +
                $"Order #: {_orderId}\nPackage: {_packageName}\n" +
                $"Down Payment: P500.00\nMethod: {paymentMethod}\n" +
                (string.IsNullOrEmpty(refNumber) ? "" : $"Reference #: {refNumber}\n"),
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            btnConfirmPayment.Enabled = false;
            btnConfirmPayment.Text    = "Sending...";

            if (!string.IsNullOrEmpty(_proofFilePath))
            {
                try { FileUploadService.SaveOrderFile(_orderId, "payment_proof", _proofFilePath); }
                catch { }
            }

            string chatMsg =
                $"PAYMENT SUBMISSION - Order #{_orderId}\n" +
                $"Package   : {_packageName}\n" +
                $"Event Date: {_eventDate:MMMM dd, yyyy}\n" +
                $"Total     : P{_totalAmount:N2}\n\n" +
                $"DOWN PAYMENT : P500.00\n" +
                $"Method       : {paymentMethod}\n" +
                (string.IsNullOrEmpty(refNumber) ? "" : $"Reference #  : {refNumber}\n") +
                (!string.IsNullOrEmpty(_proofFilePath) ? "Proof        : [screenshot attached]\n" : "") +
                "\nPlease confirm payment to activate this booking.";

            int myId   = SessionManager.CurrentUser.UserId;
            string name= SessionManager.CurrentUser.FullName;

            Task.Run(() =>
            {
                int adminId = MessageService.GetAdminUserId();
                if (adminId > 0)
                {
                    MessageService.SendMessage(myId, adminId, chatMsg);
                    MessageService.EnsureChatRequest(myId);
                    NotificationService.CreateNotification(adminId,
                        $"Payment submitted for Order #{_orderId} by {name}", "payment_submitted");
                }
                NotificationService.CreateNotification(myId,
                    $"Your payment for Order #{_orderId} has been submitted.", "payment_submitted");
            })
            .ContinueWith(task =>
            {
                if (this.IsDisposed) return;
                this.Invoke((Action)(() =>
                {
                    btnConfirmPayment.Enabled = true;
                    btnConfirmPayment.Text    = "Confirm Payment Sent";
                    MessageBox.Show(
                        $"Payment submitted!\n\nOrder #{_orderId} is now pending admin approval.\nCheck My Orders for status updates.",
                        "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }));
            }, TaskScheduler.Default);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Order #{_orderId} saved.\n\nSend payment proof via Chat when ready.",
                "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void rbGcash_CheckedChanged(object sender, EventArgs e) => UpdatePaymentDetails();
        private void rbBank_CheckedChanged(object sender, EventArgs e)  => UpdatePaymentDetails();
        private void rbCash_CheckedChanged(object sender, EventArgs e)  => UpdatePaymentDetails();

        private void UpdatePaymentDetails()
        {
            if (rbGcash.Checked)
            {
                lblPaymentDetail.Text  = "GCash Number: 0919-478-8556\nAccount Name: PhotoBooth Rentals";
                txtRefNumber.Tag       = "gcash";
                txtRefNumber.Text      = PLACEHOLDER_GCASH;
                txtRefNumber.ForeColor = Color.Gray;
                txtRefNumber.Enabled   = true;
            }
            else if (rbBank.Checked)
            {
                lblPaymentDetail.Text  = "BDO Account: 1234-5678-90\nAccount Name: PhotoBooth Rentals\nBranch: Main";
                txtRefNumber.Tag       = "bank";
                txtRefNumber.Text      = PLACEHOLDER_BANK;
                txtRefNumber.ForeColor = Color.Gray;
                txtRefNumber.Enabled   = true;
            }
            else if (rbCash.Checked)
            {
                lblPaymentDetail.Text  = "You will pay P500 cash upon meeting with admin.\nAdmin will confirm booking after cash receipt.";
                txtRefNumber.Tag       = null;
                txtRefNumber.Text      = "";
                txtRefNumber.Enabled   = false;
            }
        }
    }
}
