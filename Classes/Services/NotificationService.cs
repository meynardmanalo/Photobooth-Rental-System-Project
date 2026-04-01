using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class NotificationService
    {
        public static bool CreateNotification(int userId, string message, string notificationType)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO notifications (user_id, message, notification_type) " +
                                   "VALUES (@userId, @message, @type)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@type", notificationType);

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

        public static List<Notification> GetUserNotifications(int userId, bool unreadOnly = false)
        {
            List<Notification> notifications = new List<Notification>();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM notifications WHERE user_id = @userId";

                    if (unreadOnly)
                    {
                        query += " AND is_read = FALSE";
                    }

                    query += " ORDER BY created_at DESC LIMIT 50";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                notifications.Add(new Notification
                                {
                                    NotificationId = Convert.ToInt32(reader["notification_id"]),
                                    UserId = Convert.ToInt32(reader["user_id"]),
                                    Message = reader["message"].ToString(),
                                    NotificationType = reader["notification_type"]?.ToString() ?? "",
                                    IsRead = Convert.ToBoolean(reader["is_read"]),
                                    CreatedAt = Convert.ToDateTime(reader["created_at"])
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

            return notifications;
        }

        public static int GetUnreadCount(int userId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM notifications " +
                                   "WHERE user_id = @userId AND is_read = FALSE";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        public static bool MarkAsRead(int notificationId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE notifications SET is_read = TRUE WHERE notification_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", notificationId);
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

        public static bool MarkAllAsRead(int userId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE notifications SET is_read = TRUE WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
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
    }

    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public string NotificationType { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}