using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Models;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Controls
{
    /// <summary>
    /// Beautiful package booking card. Visible in VS Designer — just right-click > View Designer.
    /// Call LoadPackage(package) at runtime to populate.
    /// Fires ViewDetailsClicked when the Book button is clicked.
    /// </summary>
    public partial class PackageCardControl : UserControl
    {
        public event EventHandler<int> ViewDetailsClicked;

        private int    _packageId;
        private Color  _typeColor = Color.FromArgb(231, 76, 60);
        private bool   _isHovered = false;

        public PackageCardControl()
        {
            InitializeComponent();
            SetupHover();
        }

        // ── Load data at runtime ──────────────────────────────
        public void LoadPackage(Package pkg)
        {
            if (pkg == null) return;
            _packageId = pkg.PackageId;
            _typeColor  = ThemeManager.GetPackageTypeColor(pkg.PackageType);

            lblName.Text  = pkg.PackageName;
            lblType.Text  = pkg.PackageType.ToUpper();
            lblPrice.Text = "₱ " + pkg.Price.ToString("N0");
            lblHours.Text = "⏱  " + pkg.Hours + " Hour" + (pkg.Hours != 1 ? "s" : "");

            // Rating
            double avg = RatingService.GetAverageRatingByPackage(pkg.PackageId);
            if (avg > 0)
            {
                int full = (int)Math.Round(avg);
                lblRating.Text      = new string('★', full) + new string('☆', 5 - full)
                                      + "  " + avg.ToString("F1");
                lblRating.ForeColor = Color.FromArgb(243, 156, 18);
            }
            else
            {
                lblRating.Text      = "☆☆☆☆☆  New";
                lblRating.ForeColor = Color.Silver;
            }

            // Description preview
            if (!string.IsNullOrWhiteSpace(pkg.Description))
            {
                lblDesc.Text = pkg.Description.Length > 80
                    ? pkg.Description.Substring(0, 77) + "..."
                    : pkg.Description;
            }
            else lblDesc.Text = "Premium photobooth experience.";

            // Top bar color
            panelTopBar.BackColor = _typeColor;
            lblType.BackColor     = _typeColor;

            // Try load first media image
            try
            {
                var media = PackageMediaService.GetImagesByPackage(pkg.PackageId);
                if (media != null && media.Count > 0)
                {
                    string path = PackageMediaService.GetFullPath(media[0].FilePath);
                    if (File.Exists(path))
                    {
                        using (var tmp = new Bitmap(path))
                            picPreview.Image = new Bitmap(tmp);
                        picPreview.BackColor = Color.Black;
                        return;
                    }
                }
            }
            catch { }

            // No image — show decorative placeholder
            picPreview.Image     = null;
            picPreview.BackColor = Color.FromArgb(240, 240, 245);
            lblNoPhoto.Visible   = true;
        }

        // ── Hover effect ─────────────────────────────────────
        private void SetupHover()
        {
            MouseEnter += OnHoverEnter;
            MouseLeave += OnHoverLeave;
            foreach (Control c in Controls)
            {
                c.MouseEnter += OnHoverEnter;
                c.MouseLeave += OnHoverLeave;
            }
        }

        private void OnHoverEnter(object s, EventArgs e)
        {
            _isHovered = true;
            this.BackColor = Color.FromArgb(252, 252, 255);
            btnBook.BackColor = Color.FromArgb(200, 60, 45);
            Invalidate();
        }

        private void OnHoverLeave(object s, EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(MousePosition))) return;
            _isHovered = false;
            this.BackColor = Color.White;
            btnBook.BackColor = _typeColor;
            Invalidate();
        }

        // ── Custom paint: shadow border ───────────────────────
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_isHovered)
            {
                using (var pen = new Pen(_typeColor, 2))
                    e.Graphics.DrawRectangle(pen, 1, 1, Width - 3, Height - 3);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
            => ViewDetailsClicked?.Invoke(this, _packageId);
    }
}
