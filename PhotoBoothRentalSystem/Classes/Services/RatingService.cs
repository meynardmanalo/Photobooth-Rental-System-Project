using System;
using System.IO;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class RatingService
    {
        public static bool AddRating(int userId, int orderId, int ratingValue, string feedback, string photoPath = null)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Check if already rated
                    string checkQuery = "SELECT COUNT(*) FROM ratings WHERE user_id = @userId AND order_id = @orderId";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@userId", userId);
                        checkCmd.Parameters.AddWithValue("@orderId", orderId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            return false; // Already rated
                        }
                    }

                    string query = "INSERT INTO ratings (user_id, order_id, rating_value, feedback) " +
                                   "VALUES (@userId, @orderId, @rating, @feedback)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@rating", ratingValue);
                        cmd.Parameters.AddWithValue("@feedback", feedback);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Rating> GetUserRatings(int userId)
        {
            List<Rating> ratings = new List<Rating>();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT r.*, o.event_date, o.event_location
                                     FROM ratings r
                                     INNER JOIN orders o ON r.order_id = o.order_id
                                     WHERE r.user_id = @userId
                                     ORDER BY r.created_at DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ratings.Add(new Rating
                                {
                                    RatingId = Convert.ToInt32(reader["rating_id"]),
                                    UserId = Convert.ToInt32(reader["user_id"]),
                                    OrderId = Convert.ToInt32(reader["order_id"]),
                                    RatingValue = Convert.ToInt32(reader["rating_value"]),
                                    Feedback = reader["feedback"].ToString(),
                                    CreatedAt = Convert.ToDateTime(reader["created_at"]),
                                    EventDate = Convert.ToDateTime(reader["event_date"]),
                                    EventLocation = reader["event_location"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch
            {
                // Handle error
            }

            return ratings;
        }

        public static List<Rating> GetAllRatings()
        {
            List<Rating> ratings = new List<Rating>();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT r.*, u.full_name
                                     FROM ratings r
                                     JOIN users u ON r.user_id = u.user_id
                                     ORDER BY r.created_at DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ratings.Add(new Rating
                                {
                                    RatingId = Convert.ToInt32(reader["rating_id"]),
                                    UserId = Convert.ToInt32(reader["user_id"]),
                                    OrderId = Convert.ToInt32(reader["order_id"]),
                                    RatingValue = Convert.ToInt32(reader["rating_value"]),
                                    Feedback = reader["feedback"].ToString(),
                                    CreatedAt = Convert.ToDateTime(reader["created_at"]),
                                    UserFullName = reader["full_name"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch
            {
                // Handle error
            }

            return ratings;
        }

        public static double GetAverageRating()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT AVG(rating_value) FROM ratings";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToDouble(result) : 0;
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        public static bool HasRatedOrder(int userId, int orderId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM ratings WHERE user_id = @userId AND order_id = @orderId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@orderId", orderId);
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

        public static int GetTotalRatingsCount()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM ratings";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        // Get all ratings for a specific package (joined through orders)
        public static List<Rating> GetRatingsByPackage(int packageId)
        {
            List<Rating> ratings = new List<Rating>();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT r.*, u.full_name,
                                            o.event_date, o.event_location
                                     FROM ratings r
                                     JOIN users u ON r.user_id = u.user_id
                                     JOIN orders o ON r.order_id = o.order_id
                                     WHERE o.package_id = @packageId
                                       AND (r.is_visible IS NULL OR r.is_visible = 1)
                                     ORDER BY r.created_at DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@packageId", packageId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ratings.Add(new Rating
                                {
                                    RatingId = Convert.ToInt32(reader["rating_id"]),
                                    UserId = Convert.ToInt32(reader["user_id"]),
                                    OrderId = Convert.ToInt32(reader["order_id"]),
                                    RatingValue = Convert.ToInt32(reader["rating_value"]),
                                    Feedback = reader["feedback"].ToString(),
                                    CreatedAt = Convert.ToDateTime(reader["created_at"]),
                                    UserFullName = reader["full_name"].ToString(),
                                    EventDate = Convert.ToDateTime(reader["event_date"]),
                                    EventLocation = reader["event_location"].ToString(),
                                    AdminReply = reader["admin_reply"] != DBNull.Value ? reader["admin_reply"].ToString() : null,
                                    RepliedAt = reader["replied_at"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["replied_at"]) : null
                                });
                            }
                        }
                    }
                }
            }
            catch { }

            return ratings;
        }

        public static double GetAverageRatingByPackage(int packageId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT AVG(r.rating_value)
                                     FROM ratings r
                                     JOIN orders o ON r.order_id = o.order_id
                                     WHERE o.package_id = @packageId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@packageId", packageId);
                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToDouble(result) : 0;
                    }
                }
            }
            catch { return 0; }
        }

        public static int GetOrderCountByPackage(int packageId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM orders WHERE package_id = @packageId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@packageId", packageId);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }

        public static bool ReplyToRating(int ratingId, string reply)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE ratings
                                     SET admin_reply = @reply, replied_at = NOW()
                                     WHERE rating_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@reply", reply);
                        cmd.Parameters.AddWithValue("@id", ratingId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }

        public static string SaveRatingPhoto(int userId, int orderId, string sourcePath)
        {
            try
            {
                string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "RatingPhotos");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                string ext  = Path.GetExtension(sourcePath);
                string dest = Path.Combine(folder, $"rating_{userId}_{orderId}_{DateTime.Now:yyyyMMddHHmmss}{ext}");
                File.Copy(sourcePath, dest, overwrite: true);
                return dest;
            }
            catch { return null; }
        }

        public static bool SetRatingVisibility(int ratingId, bool visible)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE ratings SET is_visible = @vis WHERE rating_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@vis", visible ? 1 : 0);
                        cmd.Parameters.AddWithValue("@id", ratingId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }
    }

    public class Rating
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public int RatingValue { get; set; }
        public string Feedback { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserFullName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string AdminReply { get; set; }
        public DateTime? RepliedAt { get; set; }

        public string PhotoPath { get; set; }
        public bool HasReply => !string.IsNullOrWhiteSpace(AdminReply);
        public bool HasPhoto  => !string.IsNullOrWhiteSpace(PhotoPath) && File.Exists(PhotoPath);
        public string StarDisplay => new string('★', RatingValue) + new string('☆', 5 - RatingValue);
    }
}