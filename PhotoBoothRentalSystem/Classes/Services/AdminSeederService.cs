using System;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Security;

namespace PhotoBoothRentalSystem.Classes.Services
{
    /// <summary>
    /// Checks on startup if any admin account exists.
    /// If none found, creates default admin accounts automatically.
    /// Run: AdminSeederService.SeedIfEmpty() in Program.cs or frmLogin_Load.
    /// </summary>
    public static class AdminSeederService
    {
        private static readonly (string Name, string Email, string Password, string Phone)[] DefaultAdmins =
        {
            ("Admin One", "admin1@zass.com", "Admin@1234", "+639000000001"),
            ("Admin Two", "admin2@zass.com", "Admin@5678", "+639000000002"),
        };

        public static bool AdminExists()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = "SELECT COUNT(*) FROM users WHERE role = 'admin'";
                    using (var cmd = new MySqlCommand(q, conn))
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch { return true; } // assume exists on error to avoid accidental seeding
        }

        /// <summary>
        /// Call this once on app startup. Only seeds if NO admin exists yet.
        /// </summary>
        public static void SeedIfEmpty()
        {
            if (AdminExists()) return;

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = @"INSERT INTO users
                        (full_name, email, password_hash, phone_number, role, is_verified, status)
                        VALUES (@name, @email, @hash, @phone, 'admin', 1, 'active')";

                    foreach (var admin in DefaultAdmins)
                    {
                        string hash = PasswordHasher.HashPassword(admin.Password);
                        using (var cmd = new MySqlCommand(q, conn))
                        {
                            cmd.Parameters.AddWithValue("@name",  admin.Name);
                            cmd.Parameters.AddWithValue("@email", admin.Email);
                            cmd.Parameters.AddWithValue("@hash",  hash);
                            cmd.Parameters.AddWithValue("@phone", admin.Phone);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Warning: Could not seed admin accounts.\n" + ex.Message,
                    "Setup Warning",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
    }
}
