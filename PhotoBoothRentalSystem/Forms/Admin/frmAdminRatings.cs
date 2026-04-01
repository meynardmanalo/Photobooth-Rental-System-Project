using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using PhotoBoothRentalSystem.Classes.Services;

namespace PhotoBoothRentalSystem.Forms.Admin
{
    public partial class frmAdminRatings : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE
        public frmAdminRatings()
        {
            InitializeComponent();
        }

        private void frmAdminRatings_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadRatings();
        }

        private void SetupDataGridView()
        {
            dgvRatings.AutoGenerateColumns = false;
            dgvRatings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRatings.AllowUserToAddRows = false;
            dgvRatings.ReadOnly = true;
            dgvRatings.RowHeadersVisible = false;
            dgvRatings.BackgroundColor = Color.White;
            dgvRatings.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRatings.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvRatings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvRatings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRatings.EnableHeadersVisualStyles = false;
            dgvRatings.RowTemplate.Height = 50;

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderId",
                Name = "OrderId",
                HeaderText = "Order ID",
                Width = 100
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserFullName",
                Name = "UserFullName",
                HeaderText = "Customer",
                Width = 200
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RatingValue",
                Name = "RatingValue",
                HeaderText = "Rating",
                Width = 120
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Feedback",
                Name = "Feedback",
                HeaderText = "Feedback",
                Width = 400
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                Name = "CreatedAt",
                HeaderText = "Date",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" }
            });

            dgvRatings.CellFormatting += DgvRatings_CellFormatting;
        }

        private void DgvRatings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRatings.Columns[e.ColumnIndex].Name == "RatingValue" && e.Value != null)
            {
                int rating = Convert.ToInt32(e.Value);
                e.Value = new string('⭐', rating);
                e.FormattingApplied = true;
            }
        }

        private void LoadRatings()
        {
            try
            {
                List<Rating> ratings = RatingService.GetAllRatings();

                dgvRatings.DataSource = ratings;

                // Update stats
                lblTotalValue.Text = ratings.Count.ToString();

                if (ratings.Count > 0)
                {
                    double average = RatingService.GetAverageRating();
                    int fullStars = (int)average;
                    lblAverageValue.Text = $"{average:F2} {new string('⭐', fullStars)}";
                }
                else
                {
                    lblAverageValue.Text = "No ratings yet";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ratings: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRatings();
        }

        private void dgvRatings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}