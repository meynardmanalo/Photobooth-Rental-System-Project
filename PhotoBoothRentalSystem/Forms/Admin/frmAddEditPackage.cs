using System;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAddEditPackage : Form
    {
        private int  _packageId;
        private bool _isEdit;

        public frmAddEditPackage(int packageId = 0)
        {
            InitializeComponent();
            _packageId = packageId;
            _isEdit    = packageId > 0;
        }

        private void frmAddEditPackage_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _isEdit ? "EDIT PACKAGE" : "ADD NEW PACKAGE";
            if (_isEdit) LoadPackageData();
            else
            {
                chkIsActive.Checked = true;
                numPrice.Value      = 2500;
                numHours.Value      = 2;
                numMaxPhotos.Value  = 100;
            }
        }

        private void LoadPackageData()
        {
            var pkg = PackageService.GetPackageById(_packageId);
            if (pkg == null)
            {
                MessageBox.Show("Package not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtPackageName.Text = pkg.PackageName;
            txtDescription.Text = pkg.Description;
            txtPackageType.Text = pkg.PackageType;
            chkIsActive.Checked = pkg.IsActive;
            numPrice.Value      = Clamp(pkg.Price,     numPrice.Minimum,     numPrice.Maximum);
            numHours.Value      = Clamp(pkg.Hours,     (int)numHours.Minimum,     (int)numHours.Maximum);
            numMaxPhotos.Value  = Clamp(pkg.MaxPhotos, (int)numMaxPhotos.Minimum, (int)numMaxPhotos.Maximum);
        }

        private decimal Clamp(decimal v, decimal lo, decimal hi) => v < lo ? lo : v > hi ? hi : v;
        private decimal Clamp(int    v, int    lo, int    hi)    => v < lo ? lo : v > hi ? hi : v;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPackageName.Text))
            { MessageBox.Show("Package name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPackageName.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtPackageType.Text))
            { MessageBox.Show("Package type is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPackageType.Focus(); return; }
            if (numPrice.Value <= 0)
            { MessageBox.Show("Enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); numPrice.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            { MessageBox.Show("Description is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDescription.Focus(); return; }

            var pkg = new Package
            {
                PackageId   = _packageId,
                PackageName = txtPackageName.Text.Trim(),
                PackageType = txtPackageType.Text.Trim(),
                Price       = numPrice.Value,
                Hours       = (int)numHours.Value,
                MaxPhotos   = (int)numMaxPhotos.Value,
                Description = txtDescription.Text.Trim(),
                IsActive    = chkIsActive.Checked
            };

            bool ok = _isEdit ? PackageService.UpdatePackage(pkg) : PackageService.AddPackage(pkg);
            if (ok)
            {
                MessageBox.Show(_isEdit ? "Package updated successfully!" : "Package added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show(_isEdit ? "Failed to update package." : "Failed to add package.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
