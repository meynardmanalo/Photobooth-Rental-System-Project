using System;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Security;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Classes.Security
{
    public class AuthService
    {
        public static User Login(string email, string password)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE email = @email AND status = 'active'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["password_hash"].ToString();

                                if (PasswordHasher.VerifyPassword(password, storedHash))
                                {
                                    bool isVerified = Convert.ToBoolean(reader["is_verified"]);
                                    if (!isVerified)
                                    {
                                        return null; // Not verified
                                    }

                                    var user = new User
                                    {
                                        UserId      = Convert.ToInt32(reader["user_id"]),
                                        FullName    = reader["full_name"].ToString(),
                                        Email       = reader["email"].ToString(),
                                        PhoneNumber = reader["phone_number"].ToString(),
                                        Role        = reader["role"].ToString(),
                                        IsVerified  = isVerified,
                                        Status      = reader["status"].ToString(),
                                        CreatedAt   = Convert.ToDateTime(reader["created_at"])
                                    };
                                    try { user.Gender     = reader["gender"]      != System.DBNull.Value ? reader["gender"].ToString()      : null; } catch { }
                                    try { user.Birthday   = reader["birthday"]    != System.DBNull.Value ? (System.DateTime?)Convert.ToDateTime(reader["birthday"]) : null; } catch { }
                                    try { user.Location   = reader["location"]    != System.DBNull.Value ? reader["location"].ToString()    : null; } catch { }
                                    try { user.Bio        = reader["bio"]         != System.DBNull.Value ? reader["bio"].ToString()         : null; } catch { }
                                    try { user.ProfilePic = reader["profile_pic"] != System.DBNull.Value ? reader["profile_pic"].ToString() : null; } catch { }
                                    return user;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Login error: " + ex.Message);
            }

            return null;
        }

        public static bool Register(string fullName, string email, string password, string phone)
        {
            try
            {
                // Check if email exists
                if (EmailExists(email))
                    return false;

                string passwordHash = PasswordHasher.HashPassword(password);

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO users (full_name, email, password_hash, phone_number, role, is_verified, status) " +
                                   "VALUES (@name, @email, @hash, @phone, 'client', TRUE, 'active')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", fullName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@hash", passwordHash);
                        cmd.Parameters.AddWithValue("@phone", phone);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool EmailExists(string email)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool PhoneExists(string phone)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE phone_number = @phone";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@phone", phone);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}