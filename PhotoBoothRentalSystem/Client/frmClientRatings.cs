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
using PhotoBoothRentalSystem.Classes.Utilities;

namespace PhotoBoothRentalSystem.Forms.Client
{
    public partial class frmClientRatings : Form
    {
        // DESIGN ALL COMPONENTS LISTED ABOVE

        public frmClientRatings()
        {
            InitializeComponent();
        }

        private void frmClientRatings_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadRatings();
        }

        private void SetupDataGridView()
        {
            dgvRatings.AutoGenerateColumns = false;
            dgvRatings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRatings.MultiSelect = false;
            dgvRatings.AllowUserToResizeRows = false;
            dgvRatings.RowHeadersVisible = false;
            dgvRatings.BackgroundColor = Color.White;
            dgvRatings.BorderStyle = BorderStyle.None;
            dgvRatings.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRatings.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvRatings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvRatings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRatings.EnableHeadersVisualStyles = false;
            dgvRatings.RowTemplate.Height = 50;

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RatingId",
                Name = "RatingId",
                HeaderText = "Rating ID",
                Width = 100,
                Visible = false
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderId",
                Name = "OrderId",
                HeaderText = "Order ID",
                Width = 100
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventDate",
                Name = "EventDate",
                HeaderText = "Event Date",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" }
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventLocation",
                Name = "EventLocation",
                HeaderText = "Event Location",
                Width = 250
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RatingValue",
                Name = "RatingValue",
                HeaderText = "Rating",
                Width = 100
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Feedback",
                Name = "Feedback",
                HeaderText = "Feedback",
                Width = 300
            });

            dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                Name = "CreatedAt",
                HeaderText = "Date Rated",
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
                List<Rating> ratings = RatingService.GetUserRatings(SessionManager.CurrentUser.UserId);

                dgvRatings.DataSource = null;
                dgvRatings.DataSource = ratings;

                // Update stats
                lblTotalValue.Text = ratings.Count.ToString();

                if (ratings.Count > 0)
                {
                    double average = ratings.Average(r => r.RatingValue);
                    lblAverageValue.Text = $"{average:F2} ⭐";
                }
                else
                {
                    lblAverageValue.Text = "No ratings yet";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ratings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewRating_Click(object sender, EventArgs e)
        {
            if (dgvRatings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a rating to view.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int orderId = Convert.ToInt32(dgvRatings.SelectedRows[0].Cells["OrderId"].Value);
            frmOrderDetails detailsForm = new frmOrderDetails(orderId);
            detailsForm.ShowDialog();
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