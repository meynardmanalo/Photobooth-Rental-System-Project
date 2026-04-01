using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Models;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Shared
{
    public partial class frmPackageDetails : Form
    {
        private readonly Package _package;
        private List<PackageMedia> _mediaList = new List<PackageMedia>();
        private int _selectedThumb = 0;

        public frmPackageDetails(Package package)
        {
            InitializeComponent();
            _package = package;
        }

        private void frmPackageDetails_Load(object sender, EventArgs e)
        {
            LoadHeader();
            LoadGallery();
            LoadInfo();
            LoadRatings();
        }

        private void LoadHeader()
        {
            Color typeColor = ThemeManager.GetPackageTypeColor(_package.PackageType);
            panelHeader.BackColor = typeColor;

            lblPackageName.Text = _package.PackageName;
            lblType.Text        = _package.PackageType.ToUpper();
            lblPrice.Text       = "₱ " + _package.Price.ToString("N2");
            lblHours.Text       = "⏱  " + _package.Hours + " Hour" + (_package.Hours != 1 ? "s" : "");
        }

        private void LoadGallery()
        {
            _mediaList = PackageMediaService.GetImagesByPackage(_package.PackageId);
            flowThumbs.Controls.Clear();

            if (_mediaList.Count == 0)
            {
                picMain.Image     = null;
                picMain.BackColor = Color.FromArgb(235, 235, 240);
                lblNoPhoto.Visible= true;
                lblImageCount.Text= "No photos";
                return;
            }

            lblNoPhoto.Visible = false;

            for (int i = 0; i < _mediaList.Count; i++)
            {
                int idx = i;
                string path = PackageMediaService.GetFullPath(_mediaList[i].FilePath);

                var thumb = new PictureBox
                {
                    Size        = new Size(72, 72),
                    SizeMode    = PictureBoxSizeMode.Zoom,
                    BackColor   = Color.FromArgb(220, 220, 225),
                    Cursor      = Cursors.Hand,
                    Margin      = new Padding(4),
                    BorderStyle = BorderStyle.None
                };

                if (File.Exists(path))
                {
                    try { using (var t = new Bitmap(path)) thumb.Image = new Bitmap(t); }
                    catch { }
                }

                thumb.Click += (s, ev) => SelectImage(idx);
                flowThumbs.Controls.Add(thumb);
            }

            SelectImage(0);
        }

        private void SelectImage(int index)
        {
            if (index < 0 || index >= _mediaList.Count) return;
            _selectedThumb = index;

            string path = PackageMediaService.GetFullPath(_mediaList[index].FilePath);
            picMain.Controls.Clear();
            picMain.Image = null;

            if (File.Exists(path))
            {
                try { using (var t = new Bitmap(path)) picMain.Image = new Bitmap(t); }
                catch { }
            }

            picMain.SizeMode = PictureBoxSizeMode.Zoom;
            lblImageCount.Text = (index + 1) + " / " + _mediaList.Count;

            for (int i = 0; i < flowThumbs.Controls.Count; i++)
            {
                flowThumbs.Controls[i].BackColor = i == index
                    ? ThemeManager.Primary
                    : Color.FromArgb(220, 220, 225);
            }
        }

        private void LoadInfo()
        {
            lblDescription.Text = string.IsNullOrWhiteSpace(_package.Description)
                ? "No description available."
                : _package.Description;

            int bookings = RatingService.GetOrderCountByPackage(_package.PackageId);
            double avg   = RatingService.GetAverageRatingByPackage(_package.PackageId);

            lblOrderCount.Text = bookings + " Booking" + (bookings != 1 ? "s" : "");

            if (avg > 0)
            {
                int full = (int)Math.Round(avg);
                lblStars.Text      = new string('★', full) + new string('☆', 5 - full);
                lblStars.ForeColor = Color.FromArgb(243, 156, 18);
                lblAvgRating.Text  = avg.ToString("F1") + " / 5.0";
            }
            else
            {
                lblStars.Text      = "☆☆☆☆☆";
                lblStars.ForeColor = Color.Silver;
                lblAvgRating.Text  = "No ratings yet";
            }
        }

        private void LoadRatings()
        {
            panelFeedbacks.Controls.Clear();
            List<Rating> ratings = RatingService.GetRatingsByPackage(_package.PackageId);

            if (ratings.Count == 0)
            {
                var lbl = new Label
                {
                    Text      = "No reviews yet. Be the first to book!",
                    Font      = new Font("Segoe UI", 10F),
                    ForeColor = Color.Gray,
                    Dock      = DockStyle.Top,
                    Height    = 40,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding   = new Padding(4, 0, 0, 0)
                };
                panelFeedbacks.Controls.Add(lbl);
                return;
            }

            for (int i = ratings.Count - 1; i >= 0; i--)
                panelFeedbacks.Controls.Add(BuildCard(ratings[i]));
        }

        private Panel BuildCard(Rating r)
        {
            int cardH = string.IsNullOrWhiteSpace(r.Feedback) ? 80 : 110;
            if (r.HasReply) cardH += 52;

            var card = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = cardH,
                BackColor = Color.White,
                Padding   = new Padding(10, 8, 10, 8)
            };

            var lblName = new Label
            {
                Text      = r.UserFullName,
                Font      = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location  = new Point(10, 8),
                AutoSize  = true
            };

            var lblDate = new Label
            {
                Text      = r.CreatedAt.ToString("MMM dd, yyyy"),
                Font      = new Font("Segoe UI", 8F),
                ForeColor = Color.Gray,
                Location  = new Point(220, 10),
                AutoSize  = true
            };

            var lblStars = new Label
            {
                Text      = r.StarDisplay,
                Font      = new Font("Segoe UI", 12F),
                ForeColor = Color.FromArgb(243, 156, 18),
                Location  = new Point(10, 26),
                AutoSize  = true
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblDate);
            card.Controls.Add(lblStars);

            int nextY = 50;

            if (!string.IsNullOrWhiteSpace(r.Feedback))
            {
                var lblFeedback = new Label
                {
                    Text      = r.Feedback,
                    Font      = new Font("Segoe UI", 9.5F),
                    ForeColor = Color.FromArgb(60, 60, 60),
                    Location  = new Point(10, nextY),
                    AutoSize  = false,
                    Size      = new Size(400, 40)
                };
                card.Controls.Add(lblFeedback);
                nextY += 44;
            }

            if (r.HasReply)
            {
                var replyBox = new Panel
                {
                    BackColor   = Color.FromArgb(248, 249, 250),
                    Location    = new Point(10, nextY),
                    Size        = new Size(420, 44),
                    BorderStyle = BorderStyle.None
                };

                var lblReplyTag = new Label
                {
                    Text      = "Admin:",
                    Font      = new Font("Segoe UI", 8F, FontStyle.Bold),
                    ForeColor = ThemeManager.Primary,
                    Location  = new Point(6, 4),
                    AutoSize  = true
                };

                var lblReply = new Label
                {
                    Text      = r.AdminReply,
                    Font      = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(52, 73, 94),
                    Location  = new Point(6, 20),
                    AutoSize  = false,
                    Size      = new Size(408, 20)
                };

                replyBox.Controls.Add(lblReplyTag);
                replyBox.Controls.Add(lblReply);
                card.Controls.Add(replyBox);
            }

            var sep = new Panel
            {
                Dock      = DockStyle.Bottom,
                Height    = 1,
                BackColor = Color.FromArgb(235, 235, 235)
            };
            card.Controls.Add(sep);

            return card;
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Tag          = _package.PackageId;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
