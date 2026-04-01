using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Security;

namespace PhotoBoothRentalSystem.Classes.Services
{
    /// <summary>
    /// Run this ONCE to seed the database with admin and sample client accounts.
    /// Call DatabaseSeeder.SeedIfEmpty() from Program.cs or frmAuthSelector_Load.
    /// </summary>
    public static class DatabaseSeeder
    {
        public static void SeedIfEmpty()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Check if any users exist already
                    const string countQ = "SELECT COUNT(*) FROM users";
                    using (var cmd = new MySqlCommand(countQ, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0) return; // already seeded
                    }
                }

                // ── ADMIN ACCOUNTS ──────────────────────────────────
                CreateUser("Meynard",       "meynard@zass.com", "meynard", "+639000000001", "admin");
                CreateUser("John",          "john@zass.com",    "john",    "+639000000002", "admin");
                CreateUser("Ryza",          "ryza@zass.com",    "ryza",    "+639000000003", "admin");
                CreateUser("Sheila",        "sheila@zass.com",  "sheila",  "+639000000004", "admin");

                // ── CLIENT ACCOUNTS ──────────────────────────────────
                CreateUser("Meynard Cutie", "meynardcutie@gmail.com", "meynard", "+639100000001", "client");
                CreateUser("Eliser Pogi",   "eliserpogi@gmail.com",   "eliser",  "+639100000002", "client");
                CreateUser("Ry Sweetie",    "rysweetie@gmail.com",    "ry",      "+639100000003", "client");
                CreateUser("She Pretty",    "shepretty@gmail.com",    "she",     "+639100000004", "client");

                MessageBox.Show(
                    "Database seeded successfully!\n\n" +
                    "Admin accounts created:\n" +
                    "  meynard@zass.com / meynard\n" +
                    "  john@zass.com / john\n" +
                    "  ryza@zass.com / ryza\n" +
                    "  sheila@zass.com / sheila\n\n" +
                    "Client accounts created:\n" +
                    "  meynardcutie@gmail.com / meynard\n" +
                    "  eliserpogi@gmail.com / eliser\n" +
                    "  rysweetie@gmail.com / ry\n" +
                    "  shepretty@gmail.com / she",
                    "Seed Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seeder error: " + ex.Message, "Seed Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CreateUser(string fullName, string email, string password,
                                        string phone, string role)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string hash = PasswordHasher.HashPassword(password);
                    const string q = @"INSERT INTO users
                        (full_name, email, password_hash, phone_number, role, is_verified, status)
                        VALUES (@name, @email, @hash, @phone, @role, 1, 'active')";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@name",  fullName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@hash",  hash);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@role",  role);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { /* skip if duplicate */ }
        }
    }
}
