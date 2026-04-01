using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmRateOrder : Form
    {
        private int    _orderId;
        private int    _selectedRating = 0;
        private string _photoPath      = "";

        public frmRateOrder(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void frmRateOrder_Load(object sender, EventArgs e)
        {
            lblOrderId.Text = "Order #" + _orderId;

            btnStar1.Click += (s, ev) => SelectRating(1);
            btnStar2.Click += (s, ev) => SelectRating(2);
            btnStar3.Click += (s, ev) => SelectRating(3);
            btnStar4.Click += (s, ev) => SelectRating(4);
            btnStar5.Click += (s, ev) => SelectRating(5);

            btnStar1.MouseEnter += (s, ev) => PreviewStars(1);
            btnStar2.MouseEnter += (s, ev) => PreviewStars(2);
            btnStar3.MouseEnter += (s, ev) => PreviewStars(3);
            btnStar4.MouseEnter += (s, ev) => PreviewStars(4);
            btnStar5.MouseEnter += (s, ev) => PreviewStars(5);

            btnStar1.MouseLeave += (s, ev) => DrawStars(_selectedRating);
            btnStar2.MouseLeave += (s, ev) => DrawStars(_selectedRating);
            btnStar3.MouseLeave += (s, ev) => DrawStars(_selectedRating);
            btnStar4.MouseLeave += (s, ev) => DrawStars(_selectedRating);
            btnStar5.MouseLeave += (s, ev) => DrawStars(_selectedRating);

            txtFeedback.TextChanged += (s, ev) =>
                lblCharCount.Text = txtFeedback.Text.Length + "/500 characters";

            if (RatingService.HasRatedOrder(SessionManager.CurrentUser.UserId, _orderId))
            {
                MessageBox.Show("You have already rated this order.", "Already Rated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void SelectRating(int rating)
        {
            _selectedRating = rating;
            DrawStars(rating);
            UpdateRatingLabel(rating);
        }

        private void PreviewStars(int rating)
        {
            DrawStars(rating);
        }

        private void DrawStars(int count)
        {
            var btns = new[] { btnStar1, btnStar2, btnStar3, btnStar4, btnStar5 };
            for (int i = 0; i < 5; i++)
            {
                btns[i].Text      = i < count ? "★" : "☆";
                btns[i].ForeColor = i < count
                    ? Color.FromArgb(243, 156, 18)
                    : Color.FromArgb(180, 180, 180);
            }
        }

        private void UpdateRatingLabel(int rating)
        {
            string[] labels = { "", "Poor", "Fair", "Good", "Very Good", "Excellent" };
            lblRatingLabel.Text      = rating > 0 ? labels[rating] : "Tap a star to rate";
            lblRatingLabel.ForeColor = rating > 0
                ? Color.FromArgb(243, 156, 18)
                : Color.Gray;
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Title  = "Select Event Photo",
                Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp"
            })
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                _photoPath = ofd.FileName;
                lblPhotoName.Text      = Path.GetFileName(_photoPath);
                lblPhotoName.ForeColor = Color.FromArgb(39, 174, 96);
                btnRemovePhoto.Visible = true;

                try
                {
                    using (var t = new Bitmap(_photoPath))
                        picPreview.Image = new Bitmap(t);
                    picPreview.Visible = true;
                }
                catch { }
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            _photoPath             = "";
            picPreview.Image       = null;
            picPreview.Visible     = false;
            lblPhotoName.Text      = "No photo selected";
            lblPhotoName.ForeColor = Color.Gray;
            btnRemovePhoto.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_selectedRating == 0)
            {
                MessageBox.Show("Please select a rating.", "No Rating",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string feedback = txtFeedback.Text.Trim();

            if (string.IsNullOrWhiteSpace(feedback))
            {
                if (MessageBox.Show("Submit without written feedback?", "No Feedback",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            try
            {
                bool ok = RatingService.AddRating(
                    SessionManager.CurrentUser.UserId, _orderId,
                    _selectedRating, feedback);

                if (ok)
                {
                    MessageBox.Show("Thank you for your feedback!", "Submitted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("You have already rated this order.", "Already Rated",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
