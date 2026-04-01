using System;
using System.Collections.Generic;
using System.IO;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class UserManagementService
    {
        // ── Helper: map reader to User (handles missing columns gracefully) ──
        private static User MapUser(MySqlDataReader r)
        {
            var u = new User
            {
                UserId      = Convert.ToInt32(r["user_id"]),
                FullName    = r["full_name"].ToString(),
                Email       = r["email"].ToString(),
                PhoneNumber = r["phone_number"].ToString(),
                Role        = r["role"].ToString(),
                IsVerified  = Convert.ToBoolean(r["is_verified"]),
                Status      = r["status"].ToString(),
                CreatedAt   = Convert.ToDateTime(r["created_at"]),
            };
            try { u.Gender     = r["gender"]      != DBNull.Value ? r["gender"].ToString()     : null; } catch { }
            try { u.Birthday   = r["birthday"]    != DBNull.Value ? (DateTime?)Convert.ToDateTime(r["birthday"]) : null; } catch { }
            try { u.Location   = r["location"]    != DBNull.Value ? r["location"].ToString()   : null; } catch { }
            try { u.Bio        = r["bio"]         != DBNull.Value ? r["bio"].ToString()        : null; } catch { }
            try { u.ProfilePic = r["profile_pic"] != DBNull.Value ? r["profile_pic"].ToString(): null; } catch { }
            return u;
        }

        public static List<User> GetAllUsers()
        {
            var users = new List<User>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM users ORDER BY created_at DESC", conn))
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) users.Add(MapUser(r));
                }
            }
            catch { }
            return users;
        }

        public static User GetUserById(int userId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM users WHERE user_id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        using (var r = cmd.ExecuteReader())
                            if (r.Read()) return MapUser(r);
                    }
                }
            }
            catch { }
            return null;
        }

        // Basic update (name, email, phone)
        public static bool UpdateUser(int userId, string fullName, string email, string phone)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string q = "UPDATE users SET full_name=@name, email=@email, phone_number=@phone WHERE user_id=@id";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@name",  fullName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@id",    userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        // Extended update — all profile fields
        public static bool UpdateUserProfile(int userId, string fullName, string email,
            string phone, string gender, DateTime? birthday, string location,
            string bio, string profilePicPath)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string q = @"UPDATE users SET
                        full_name    = @name,
                        email        = @email,
                        phone_number = @phone,
                        gender       = @gender,
                        birthday     = @birthday,
                        location     = @location,
                        bio          = @bio,
                        profile_pic  = @pic
                        WHERE user_id = @id";

                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@name",     fullName);
                        cmd.Parameters.AddWithValue("@email",    email);
                        cmd.Parameters.AddWithValue("@phone",    phone);
                        cmd.Parameters.AddWithValue("@gender",   (object)gender   ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@birthday", birthday.HasValue ? (object)birthday.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@location", (object)location ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@bio",      (object)bio      ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@pic",      (object)profilePicPath ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@id",       userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        // Save profile picture to local folder, return stored path
        public static string SaveProfilePicture(int userId, string sourcePath)
        {
            try
            {
                string folder = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "Assets", "ProfilePics");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                string ext  = Path.GetExtension(sourcePath);
                string dest = Path.Combine(folder, $"user_{userId}{ext}");
                File.Copy(sourcePath, dest, overwrite: true);
                return dest;
            }
            catch { return null; }
        }

        public static bool UpdateUserStatus(int userId, string status)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "UPDATE users SET status=@s WHERE user_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@s",  status);
                        cmd.Parameters.AddWithValue("@id", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        public static bool DeleteUser(int userId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "DELETE FROM users WHERE user_id=@id AND role != 'admin'", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }

        public static int GetTotalUserCount()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM users WHERE role='client'", conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public static int GetActiveUserCount()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM users WHERE role='client' AND status='active'", conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }
    }
}
