using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using PhotoBoothRentalSystem.Classes.Services;
using PhotoBoothRentalSystem.Classes.Models;
using PhotoBoothRentalSystem.Classes.Utilities;
using PhotoBoothRentalSystem.Forms.Shared;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmClientPackages : Form
    {
        private List<Package> _allPackages = new List<Package>();

        public frmClientPackages() { InitializeComponent(); }

        private void frmClientPackages_Load(object sender, EventArgs e)
        {
            LoadPackages();
        }

        private void LoadPackages()
        {
            try
            {
                _allPackages = PackageService.GetAllActivePackages();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading packages: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilter()
        {
            string search = txtSearch.Text.Trim().ToLower();
            string type   = cboFilter.SelectedIndex > 0 ? cboFilter.SelectedItem.ToString() : "";
            string sort   = cboSort.SelectedItem?.ToString() ?? "Price: Low to High";

            var filtered = _allPackages.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
                filtered = filtered.Where(p =>
                    p.PackageName.ToLower().Contains(search) ||
                    p.PackageType.ToLower().Contains(search) ||
                    p.Description.ToLower().Contains(search));

            if (!string.IsNullOrWhiteSpace(type))
                filtered = filtered.Where(p =>
                    p.PackageType.Equals(type, StringComparison.OrdinalIgnoreCase));

            switch (sort)
            {
                case "Price: Low to High":  filtered = filtered.OrderBy(p => p.Price); break;
                case "Price: High to Low":  filtered = filtered.OrderByDescending(p => p.Price); break;
                case "Name: A-Z":           filtered = filtered.OrderBy(p => p.PackageName); break;
                case "Hours: Most":         filtered = filtered.OrderByDescending(p => p.Hours); break;
            }

            var result = filtered.ToList();

            flowPackages.SuspendLayout();
            flowPackages.Controls.Clear();

            if (result.Count == 0)
            {
                var lbl = new Label
                {
                    Text = "😔  No packages found.\nTry adjusting your search or filter.",
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Padding = new Padding(20)
                };
                flowPackages.Controls.Add(lbl);
            }
            else
            {
                foreach (var pkg in result)
                {
                    var card = new PhotoBoothRentalSystem.Controls.PackageCardControl();
                    card.Margin = new Padding(12);
                    card.LoadPackage(pkg);
                    Package captured = pkg;
                    card.ViewDetailsClicked += (s, pkgId) => OpenPackageDetails(captured);
                    flowPackages.Controls.Add(card);
                }
            }

            flowPackages.ResumeLayout();
            lblCount.Text = $"Showing {result.Count} of {_allPackages.Count} package(s)";
        }

        private void OpenPackageDetails(Package pkg)
        {
            var details = new frmPackageDetails(pkg);
            if (details.ShowDialog() == DialogResult.OK)
            {
                int pkgId = (int)details.Tag;
                new frmCreateOrder(pkgId).ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboSort_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadPackages();
    }
}
