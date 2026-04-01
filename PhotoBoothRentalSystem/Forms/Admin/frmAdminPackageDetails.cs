using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Models;
using PhotoBoothRentalSystem.Classes.Services;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminPackageDetails : Form
    {
        private readonly Package _package;
        private List<PackageMedia> _allMedia = new List<PackageMedia>();
        private int _selectedMediaId = -1;

        public frmAdminPackageDetails(Package package)
        {
            InitializeComponent();
            _package = package;
        }

        private void frmAdminPackageDetails_Load(object sender, EventArgs e)
        {
            LoadHeader();
            LoadMediaTab();
            LoadRatingsTab();
            LoadOrdersTab();
        }

        // ─────────────────────── HEADER ───────────────────────

        private void LoadHeader()
        {
            lblHeaderName.Text = _package.PackageName;
            lblHeaderSub.Text = _package.PackageType + "  |  ₱" + _package.Price.ToString("N2") + "  |  " + _package.Hours + " hrs";
            lblHeaderStatus.Text = _package.IsActive ? "ACTIVE" : "INACTIVE";
            lblHeaderStatus.ForeColor = _package.IsActive ? Color.FromArgb(39, 174, 96) : Color.FromArgb(231, 76, 60);
        }

        // ─────────────────────── MEDIA TAB ───────────────────────

        private void LoadMediaTab()
        {
            _allMedia = PackageMediaService.GetMediaByPackage(_package.PackageId);
            RebuildMediaGrid();
        }

        private void RebuildMediaGrid()
        {
            flowMedia.Controls.Clear();
            _selectedMediaId = -1;
            UpdateMediaButtons();

            if (_allMedia.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No media uploaded yet.\nUse the buttons below to add images, videos, or stickers.",
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.Gray,
                    AutoSize = false,
                    Size = new Size(400, 60),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                flowMedia.Controls.Add(lbl);
                return;
            }

            foreach (PackageMedia media in _allMedia)
            {
                Panel tile = BuildMediaTile(media);
                flowMedia.Controls.Add(tile);
            }
        }

        private Panel BuildMediaTile(PackageMedia media)
        {
            Panel tile = new Panel
            {
                Size = new Size(140, 160),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(6),
                Cursor = Cursors.Hand,
                Tag = media.MediaId
            };

            PictureBox pic = new PictureBox
            {
                Size = new Size(138, 110),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            if (media.IsImage || media.IsSticker)
            {
                string fullPath = PackageMediaService.GetFullPath(media.FilePath);
                if (File.Exists(fullPath))
                {
                    try { pic.Image = Image.FromFile(fullPath); }
                    catch { }
                }
            }
            else if (media.IsVideo)
            {
                pic.BackColor = Color.FromArgb(30, 30, 30);
                Label videoIcon = new Label
                {
                    Text = "▶ VIDEO",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = false,
                    Size = pic.Size,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                pic.Controls.Add(videoIcon);
            }

            // Type badge
            Label badgeType = new Label
            {
                Text = media.MediaType.ToUpper(),
                Font = new Font("Segoe UI", 7, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = GetBadgeColor(media.MediaType),
                AutoSize = false,
                Size = new Size(50, 16),
                Location = new Point(0, 0),
                TextAlign = ContentAlignment.MiddleCenter
            };
            pic.Controls.Add(badgeType);

            Label lblName = new Label
            {
                Text = string.IsNullOrEmpty(media.DisplayName) ? Path.GetFileNameWithoutExtension(media.FilePath) : media.DisplayName,
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.FromArgb(60, 60, 60),
                AutoSize = false,
                Size = new Size(136, 32),
                Location = new Point(2, 112),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblOrder = new Label
            {
                Text = "#" + (media.DisplayOrder + 1),
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(2, 144)
            };

            tile.Controls.Add(pic);
            tile.Controls.Add(lblName);
            tile.Controls.Add(lblOrder);

            // Click to select
            Action selectTile = () =>
            {
                _selectedMediaId = media.MediaId;
                foreach (Control c in flowMedia.Controls)
                {
                    if (c is Panel p)
                        p.BackColor = Color.White;
                }
                tile.BackColor = Color.FromArgb(255, 235, 230);
                UpdateMediaButtons();
            };

            tile.Click += (s, e) => selectTile();
            pic.Click += (s, e) => selectTile();
            lblName.Click += (s, e) => selectTile();

            return tile;
        }

        private Color GetBadgeColor(string type)
        {
            switch (type)
            {
                case "image": return Color.FromArgb(52, 152, 219);
                case "video": return Color.FromArgb(155, 89, 182);
                case "sticker": return Color.FromArgb(46, 204, 113);
                default: return Color.Gray;
            }
        }

        private void UpdateMediaButtons()
        {
            btnDeleteMedia.Enabled = _selectedMediaId != -1;
            btnMoveUp.Enabled = _selectedMediaId != -1;
            btnMoveDown.Enabled = _selectedMediaId != -1;
        }

        private void btnAddImage_Click(object sender, EventArgs e) => UploadMedia("image",
            "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif");

        private void btnAddVideo_Click(object sender, EventArgs e) => UploadMedia("video",
            "Video Files (*.mp4;*.avi;*.mov;*.wmv)|*.mp4;*.avi;*.mov;*.wmv");

        private void btnAddSticker_Click(object sender, EventArgs e) => UploadMedia("sticker",
            "Sticker/PNG Files (*.png;*.gif)|*.png;*.gif");

        private void UploadMedia(string mediaType, string filter)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select " + mediaType;
                dlg.Filter = filter + "|All Files (*.*)|*.*";
                dlg.Multiselect = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    int success = 0, fail = 0;
                    foreach (string file in dlg.FileNames)
                    {
                        if (PackageMediaService.AddMedia(_package.PackageId, file, mediaType))
                            success++;
                        else
                            fail++;
                    }

                    string msg = $"{success} file(s) uploaded successfully.";
                    if (fail > 0) msg += $"\n{fail} file(s) failed.";
                    MessageBox.Show(msg, "Upload Result", MessageBoxButtons.OK,
                        fail > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);

                    LoadMediaTab();
                }
            }
        }

        private void btnDeleteMedia_Click(object sender, EventArgs e)
        {
            if (_selectedMediaId == -1) return;

            DialogResult result = MessageBox.Show(
                "Delete this media file? This cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                PackageMediaService.DeleteMedia(_selectedMediaId);
                LoadMediaTab();
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (_selectedMediaId == -1) return;
            int idx = _allMedia.FindIndex(m => m.MediaId == _selectedMediaId);
            if (idx > 0)
            {
                PackageMediaService.UpdateDisplayOrder(_allMedia[idx].MediaId, idx - 1);
                PackageMediaService.UpdateDisplayOrder(_allMedia[idx - 1].MediaId, idx);
                LoadMediaTab();
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (_selectedMediaId == -1) return;
            int idx = _allMedia.FindIndex(m => m.MediaId == _selectedMediaId);
            if (idx >= 0 && idx < _allMedia.Count - 1)
            {
                PackageMediaService.UpdateDisplayOrder(_allMedia[idx].MediaId, idx + 1);
                PackageMediaService.UpdateDisplayOrder(_allMedia[idx + 1].MediaId, idx);
                LoadMediaTab();
            }
        }

        // ─────────────────────── RATINGS TAB ───────────────────────

        private void LoadRatingsTab()
        {
            List<Rating> ratings = RatingService.GetRatingsByPackage(_package.PackageId);

            dgvRatings.Rows.Clear();

            foreach (Rating r in ratings)
            {
                dgvRatings.Rows.Add(
                    r.RatingId,
                    r.UserFullName,
                    r.StarDisplay,
                    r.Feedback,
                    r.HasReply ? r.AdminReply : "(no reply yet)",
                    r.CreatedAt.ToString("MM/dd/yyyy")
                );

                // Color replied rows
                var row = dgvRatings.Rows[dgvRatings.Rows.Count - 1];
                row.DefaultCellStyle.ForeColor = r.HasReply ? Color.FromArgb(39, 174, 96) : Color.FromArgb(50, 50, 50);
                row.Tag = r.RatingId;
            }

            lblRatingSummary.Text = ratings.Count > 0
                ? $"Total: {ratings.Count} review(s)  |  Average: {RatingService.GetAverageRatingByPackage(_package.PackageId):F1} / 5.0"
                : "No reviews for this package yet.";
        }

        private void btnReplyRating_Click(object sender, EventArgs e)
        {
            if (dgvRatings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a rating to reply to.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int ratingId = Convert.ToInt32(dgvRatings.SelectedRows[0].Tag);
            string existingReply = dgvRatings.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
            if (existingReply == "(no reply yet)") existingReply = "";

            using (Form replyForm = new Form())
            {
                replyForm.Text = "Reply to Review";
                replyForm.Size = new Size(500, 200);
                replyForm.StartPosition = FormStartPosition.CenterParent;
                replyForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                replyForm.MaximizeBox = false;

                Label lbl = new Label
                {
                    Text = "Your reply:",
                    Location = new Point(12, 12),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10)
                };

                TextBox txt = new TextBox
                {
                    Location = new Point(12, 34),
                    Size = new Size(460, 60),
                    Multiline = true,
                    Font = new Font("Segoe UI", 10),
                    Text = existingReply
                };

                Button btnSave = new Button
                {
                    Text = "Save Reply",
                    Location = new Point(12, 106),
                    Size = new Size(110, 34),
                    BackColor = Color.FromArgb(52, 152, 219),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10)
                };
                btnSave.FlatAppearance.BorderSize = 0;

                Button btnCancel = new Button
                {
                    Text = "Cancel",
                    Location = new Point(134, 106),
                    Size = new Size(80, 34),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10)
                };

                btnSave.Click += (s2, e2) =>
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        MessageBox.Show("Please enter a reply.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (RatingService.ReplyToRating(ratingId, txt.Text.Trim()))
                    {
                        replyForm.DialogResult = DialogResult.OK;
                        replyForm.Close();
                    }
                };
                btnCancel.Click += (s2, e2) => { replyForm.Close(); };

                replyForm.Controls.AddRange(new Control[] { lbl, txt, btnSave, btnCancel });

                if (replyForm.ShowDialog() == DialogResult.OK)
                {
                    LoadRatingsTab();
                    MessageBox.Show("Reply saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHideRating_Click(object sender, EventArgs e)
        {
            if (dgvRatings.SelectedRows.Count == 0) return;
            int ratingId = Convert.ToInt32(dgvRatings.SelectedRows[0].Tag);

            DialogResult res = MessageBox.Show(
                "Hide this review from clients?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                RatingService.SetRatingVisibility(ratingId, false);
                LoadRatingsTab();
            }
        }

        // ─────────────────────── ORDERS TAB ───────────────────────

        private void LoadOrdersTab()
        {
            try
            {
                List<Order> orders = GetOrdersByPackage(_package.PackageId);

                dgvOrders.Rows.Clear();

                foreach (Order o in orders)
                {
                    dgvOrders.Rows.Add(
                        o.OrderId,
                        o.EventDate.ToString("MM/dd/yyyy"),
                        o.EventLocation,
                        o.EventType,
                        o.CelebrantName,
                        "₱" + o.TotalAmount.ToString("N2"),
                        o.Status
                    );

                    var row = dgvOrders.Rows[dgvOrders.Rows.Count - 1];
                    row.DefaultCellStyle.ForeColor = GetStatusColor(o.Status);
                }

                lblOrderSummary.Text = $"Total: {orders.Count} order(s) for this package";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Order> GetOrdersByPackage(int packageId)
        {
            var orders = new List<Order>();
            try
            {
                using (var conn = Classes.Database.DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM orders WHERE package_id = @pid ORDER BY event_date DESC";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", packageId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orders.Add(new Order
                                {
                                    OrderId = Convert.ToInt32(reader["order_id"]),
                                    UserId = Convert.ToInt32(reader["user_id"]),
                                    PackageId = Convert.ToInt32(reader["package_id"]),
                                    EventDate = Convert.ToDateTime(reader["event_date"]),
                                    EventLocation = reader["event_location"].ToString(),
                                    EventType = reader["event_type"].ToString(),
                                    CelebrantName = reader["celebrant_name"].ToString(),
                                    TotalAmount = Convert.ToDecimal(reader["total_amount"]),
                                    Status = reader["status"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch { }
            return orders;
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Confirmed": return Color.FromArgb(39, 174, 96);
                case "Completed": return Color.FromArgb(52, 152, 219);
                case "Cancelled": return Color.FromArgb(231, 76, 60);
                default: return Color.FromArgb(230, 126, 34);
            }
        }

        // ─────────────────────── EDIT PACKAGE ───────────────────────

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            frmAddEditPackage editForm = new frmAddEditPackage(_package.PackageId);
            editForm.ShowDialog();
            // Reload header info after edit
            Package updated = PackageService.GetPackageById(_package.PackageId);
            if (updated != null)
            {
                _package.PackageName = updated.PackageName;
                _package.PackageType = updated.PackageType;
                _package.Price = updated.Price;
                _package.Hours = updated.Hours;
                _package.Description = updated.Description;
                _package.IsActive = updated.IsActive;
                LoadHeader();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRatings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
