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

namespace PhotoBoothRentalSystem.Forms.Auth
{
    public partial class frmAuthSelector : Form
    {
        public frmAuthSelector()
        {
            InitializeComponent();
        }

        private void frmAuthSelector_Load(object sender, EventArgs e)
        {
            panelMain.Location = new Point(
                (this.Width - panelMain.Width) / 2,
                (this.Height - panelMain.Height) / 2
            );

            // Seed database accounts on first run (does nothing if users already exist)
            DatabaseSeeder.SeedIfEmpty();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmAuthSelector_Resize(object sender, EventArgs e)
        {
            panelMain.Location = new Point(
                (this.Width - panelMain.Width) / 2,
                (this.Height - panelMain.Height) / 2
            );
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}