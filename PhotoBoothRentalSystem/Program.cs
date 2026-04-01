using System;
using System.Windows.Forms;
using PhotoBoothRentalSystem.Forms.Auth;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Services;

namespace PhotoBoothRentalSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Test DB connection first
            try
            {
                if (!DatabaseConnection.TestConnection())
                {
                    MessageBox.Show(
                        "Failed to connect to the database.\n\n" +
                        "Please check:\n" +
                        "1. Internet connection\n" +
                        "2. Database credentials in DatabaseConnection.cs\n" +
                        "3. Database server is running\n\n" +
                        "Application will now exit.",
                        "Database Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection error:\n\n" + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Auto-seed all accounts if database is empty
            // Creates: meynard, john, ryza, sheila (admin) + client accounts
            DatabaseSeeder.SeedIfEmpty();

            Application.Run(new frmAuthSelector());
        }
    }
}
