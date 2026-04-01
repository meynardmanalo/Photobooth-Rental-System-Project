using System;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class OTPService
    {
        public static string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        // Updated to send via EMAIL instead of SMS
        public static bool SendOTP(string email, string otp, string recipientName)
        {
            try
            {
                DateTime expiry = DateTime.Now.AddMinutes(5);

                // Send OTP via EMAIL
                bool emailSent = EmailService.SendOTPEmail(email, otp, recipientName);

                if (!emailSent)
                {
                    return false;
                }

                // Store OTP in database
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Use email instead of phone_number
                    string query = "INSERT INTO otp_verification (email, otp_code, expires_at) " +
               "VALUES (@email, @otp, @expiry)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);  // Reusing phone_number column for email
                        cmd.Parameters.AddWithValue("@otp", otp);
                        cmd.Parameters.AddWithValue("@expiry", expiry);
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("OTP Error: " + ex.Message);
                return false;
            }
        }

        public static bool VerifyOTP(string email, string otp)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM otp_verification " +
               "WHERE email = @email AND otp_code = @otp " +
               "AND expires_at > @now AND is_used = FALSE";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@otp", otp);
                        cmd.Parameters.AddWithValue("@now", DateTime.Now);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Mark as used
                            string updateQuery = "UPDATE otp_verification SET is_used = TRUE " +
                     "WHERE email = @email AND otp_code = @otp";

                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@email", email);
                                updateCmd.Parameters.AddWithValue("@otp", otp);
                                updateCmd.ExecuteNonQuery();
                            }
                            return true;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}