using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmChangeOrderStatus : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        private int orderId;
        private string currentStatus;

        public frmChangeOrderStatus(int orderIdParam, string currentStatusParam)
        {
            InitializeComponent();
            orderId = orderIdParam;
            currentStatus = currentStatusParam;
        }

        private void frmChangeOrderStatus_Load(object sender, EventArgs e)
        {
            lblOrderId.Text = $"Order #{orderId}";
            lblCurrentStatusValue.Text = currentStatus;

            // Set current status color
            switch (currentStatus)
            {
                case "Pending":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
                    break;
                case "Confirmed":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
                    break;
                case "Completed":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
                    break;
                case "Cancelled":
                    lblCurrentStatusValue.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
                    break;
            }

            // Load status options
            cboNewStatus.Items.AddRange(new string[] {
                "Pending", "Confirmed", "Completed", "Cancelled"
            });

            // Select current status by default
            cboNewStatus.SelectedItem = currentStatus;

            chkNotifyCustomer.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboNewStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a new status.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cboNewStatus.SelectedItem.ToString();

            if (newStatus == currentStatus)
            {
                MessageBox.Show("Please select a different status.", "No Change",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to change order status from '{currentStatus}' to '{newStatus}'?",
                "Confirm Status Change",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (OrderService.UpdateOrderStatus(orderId, newStatus))
                    {
                        // Get order details for notification
                        var order = OrderService.GetOrderById(orderId);

                        // Notify customer if checked
                        if (chkNotifyCustomer.Checked && order != null)
                        {
                            string notificationMessage = $"Your order #{orderId} status has been updated to: {newStatus}";

                            if (!string.IsNullOrWhiteSpace(txtNotes.Text))
                            {
                                notificationMessage += $"\nNotes: {txtNotes.Text}";
                            }

                            NotificationService.CreateNotification(
                                order.UserId,
                                notificationMessage,
                                "order_status_update"
                            );
                        }

                        MessageBox.Show("Order status updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update order status.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}