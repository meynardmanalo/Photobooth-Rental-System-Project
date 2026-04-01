using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class MessageService
    {
        // ════════════════════════════════════════════════════════════
        //  MESSAGES
        // ════════════════════════════════════════════════════════════

        public static bool SendMessage(int senderId, int receiverId, string message)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = "INSERT INTO messages (sender_id, receiver_id, message) VALUES (@s,@r,@m)";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@s", senderId);
                        cmd.Parameters.AddWithValue("@r", receiverId);
                        cmd.Parameters.AddWithValue("@m", message);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        public static List<ChatMessage> GetConversation(int userId, int otherUserId)
        {
            var list = new List<ChatMessage>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = @"SELECT * FROM messages
                        WHERE (sender_id=@u AND receiver_id=@o)
                           OR (sender_id=@o AND receiver_id=@u)
                        ORDER BY sent_at ASC";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", userId);
                        cmd.Parameters.AddWithValue("@o", otherUserId);
                        using (var r = cmd.ExecuteReader())
                            while (r.Read()) list.Add(ReadMsg(r));
                    }
                }
            }
            catch { }
            return list;
        }

        public static List<ChatMessage> GetNewMessages(int userId, int otherUserId, int sinceId)
        {
            var list = new List<ChatMessage>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = @"SELECT * FROM messages
                        WHERE ((sender_id=@u AND receiver_id=@o)
                            OR (sender_id=@o AND receiver_id=@u))
                          AND message_id > @since
                        ORDER BY sent_at ASC";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", userId);
                        cmd.Parameters.AddWithValue("@o", otherUserId);
                        cmd.Parameters.AddWithValue("@since", sinceId);
                        using (var r = cmd.ExecuteReader())
                            while (r.Read()) list.Add(ReadMsg(r));
                    }
                }
            }
            catch { }
            return list;
        }

        public static bool MarkMessagesAsRead(int receiverId, int senderId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = "UPDATE messages SET is_read=TRUE WHERE receiver_id=@r AND sender_id=@s";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@r", receiverId);
                        cmd.Parameters.AddWithValue("@s", senderId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        public static int GetUnreadMessageCount(int userId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = "SELECT COUNT(*) FROM messages WHERE receiver_id=@u AND is_read=FALSE";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", userId);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }

        // ════════════════════════════════════════════════════════════
        //  CHAT REQUESTS  (Inbox / Accept system)
        // ════════════════════════════════════════════════════════════

        /// <summary>Client calls this when sending their FIRST message to create an inbox entry.</summary>
        public static void EnsureChatRequest(int clientId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Only insert if no existing request for this client
                    const string q = @"INSERT INTO chat_requests (client_id)
                        SELECT @c FROM DUAL
                        WHERE NOT EXISTS (SELECT 1 FROM chat_requests WHERE client_id=@c)";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@c", clientId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        /// <summary>Returns all PENDING chat requests. All admins can see these.</summary>
        public static List<ChatRequest> GetPendingRequests()
        {
            var list = new List<ChatRequest>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = @"SELECT cr.request_id, cr.client_id, u.full_name, u.email,
                            cr.created_at,
                            (SELECT m.message FROM messages m
                             WHERE m.sender_id = cr.client_id
                             ORDER BY m.sent_at ASC LIMIT 1) AS first_message
                        FROM chat_requests cr
                        INNER JOIN users u ON u.user_id = cr.client_id
                        WHERE cr.status = 'pending'
                        ORDER BY cr.created_at ASC";
                    using (var cmd = new MySqlCommand(q, conn))
                    using (var r = cmd.ExecuteReader())
                        while (r.Read())
                            list.Add(new ChatRequest
                            {
                                RequestId    = Convert.ToInt32(r["request_id"]),
                                ClientId     = Convert.ToInt32(r["client_id"]),
                                ClientName   = r["full_name"].ToString(),
                                ClientEmail  = r["email"].ToString(),
                                FirstMessage = r["first_message"]?.ToString() ?? "",
                                CreatedAt    = Convert.ToDateTime(r["created_at"])
                            });
                }
            }
            catch { }
            return list;
        }

        /// <summary>Returns accepted conversations for a specific admin.</summary>
        public static List<ChatUser> GetMyAcceptedClients(int adminId)
        {
            var list = new List<ChatUser>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = @"SELECT cr.client_id, u.full_name, u.email,
                            (SELECT COUNT(*) FROM messages WHERE sender_id=u.user_id
                             AND receiver_id=@a AND is_read=FALSE) AS unread_count
                        FROM chat_requests cr
                        INNER JOIN users u ON u.user_id = cr.client_id
                        WHERE cr.status='accepted' AND cr.accepted_by=@a
                        ORDER BY u.full_name";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", adminId);
                        using (var r = cmd.ExecuteReader())
                            while (r.Read())
                                list.Add(new ChatUser
                                {
                                    UserId      = Convert.ToInt32(r["client_id"]),
                                    FullName    = r["full_name"].ToString(),
                                    Email       = r["email"].ToString(),
                                    UnreadCount = Convert.ToInt32(r["unread_count"])
                                });
                    }
                }
            }
            catch { }
            return list;
        }

        /// <summary>Admin accepts a pending chat request.</summary>
        public static bool AcceptChatRequest(int clientId, int adminId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = @"UPDATE chat_requests
                        SET status='accepted', accepted_by=@a
                        WHERE client_id=@c AND status='pending'";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", adminId);
                        cmd.Parameters.AddWithValue("@c", clientId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }

        /// <summary>Returns the admin assigned to this client, or 0 if pending/none.</summary>
        public static int GetAcceptedAdminForClient(int clientId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = @"SELECT accepted_by FROM chat_requests
                        WHERE client_id=@c AND status='accepted' LIMIT 1";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@c", clientId);
                        var r = cmd.ExecuteScalar();
                        return r != null && r != DBNull.Value ? Convert.ToInt32(r) : 0;
                    }
                }
            }
            catch { return 0; }
        }

        /// <summary>Returns true if client already has a pending or accepted request.</summary>
        public static bool HasChatRequest(int clientId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = "SELECT COUNT(*) FROM chat_requests WHERE client_id=@c";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@c", clientId);
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch { return false; }
        }

        /// <summary>Count of pending requests — used for admin message badge.</summary>
        public static int GetPendingRequestCount()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = "SELECT COUNT(*) FROM chat_requests WHERE status='pending'";
                    using (var cmd = new MySqlCommand(q, conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        // ════════════════════════════════════════════════════════════
        //  HELPERS
        // ════════════════════════════════════════════════════════════

        public static int GetAdminUserId()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string q = "SELECT user_id FROM users WHERE role='admin' LIMIT 1";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        var r = cmd.ExecuteScalar();
                        return r != null ? Convert.ToInt32(r) : 0;
                    }
                }
            }
            catch { return 0; }
        }

        // Legacy — still used by client dashboard badge
        public static List<ChatUser> GetChatUsers(int currentUserId, bool isAdmin)
        {
            var list = new List<ChatUser>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string q = isAdmin
                        ? @"SELECT DISTINCT u.user_id, u.full_name, u.email,
                              (SELECT COUNT(*) FROM messages WHERE sender_id=u.user_id
                               AND receiver_id=@c AND is_read=FALSE) AS unread_count
                            FROM users u
                            INNER JOIN messages m ON (m.sender_id=u.user_id OR m.receiver_id=u.user_id)
                            WHERE u.user_id!=@c AND u.role='client' ORDER BY u.full_name"
                        : @"SELECT u.user_id, u.full_name, u.email,
                              (SELECT COUNT(*) FROM messages WHERE sender_id=u.user_id
                               AND receiver_id=@c AND is_read=FALSE) AS unread_count
                            FROM users u WHERE u.role='admin' LIMIT 1";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@c", currentUserId);
                        using (var r = cmd.ExecuteReader())
                            while (r.Read())
                                list.Add(new ChatUser
                                {
                                    UserId      = Convert.ToInt32(r["user_id"]),
                                    FullName    = r["full_name"].ToString(),
                                    Email       = r["email"].ToString(),
                                    UnreadCount = Convert.ToInt32(r["unread_count"])
                                });
                    }
                }
            }
            catch { }
            return list;
        }

        private static ChatMessage ReadMsg(MySqlDataReader r) => new ChatMessage
        {
            MessageId   = Convert.ToInt32(r["message_id"]),
            SenderId    = Convert.ToInt32(r["sender_id"]),
            ReceiverId  = Convert.ToInt32(r["receiver_id"]),
            MessageText = r["message"].ToString(),
            IsRead      = Convert.ToBoolean(r["is_read"]),
            SentAt      = Convert.ToDateTime(r["sent_at"])
        };
    }

    // ════════════════════════════════════════════════════════════
    //  MODELS
    // ════════════════════════════════════════════════════════════

    public class ChatMessage
    {
        public int    MessageId   { get; set; }
        public int    SenderId    { get; set; }
        public int    ReceiverId  { get; set; }
        public string MessageText { get; set; }
        public bool   IsRead      { get; set; }
        public DateTime SentAt   { get; set; }
    }

    public class ChatUser
    {
        public int    UserId      { get; set; }
        public string FullName    { get; set; }
        public string Email       { get; set; }
        public int    UnreadCount { get; set; }
    }

    public class ChatRequest
    {
        public int      RequestId    { get; set; }
        public int      ClientId     { get; set; }
        public string   ClientName   { get; set; }
        public string   ClientEmail  { get; set; }
        public string   FirstMessage { get; set; }
        public DateTime CreatedAt    { get; set; }
    }
}
