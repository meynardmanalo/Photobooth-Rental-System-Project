using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class OrderService
    {
        public static int CreateOrder(Order order)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"INSERT INTO orders
                    (user_id, package_id, event_date, event_location, event_type,
                     party_theme, celebrant_name, contact_person, booth_start_time,
                     booth_end_time, down_payment, total_amount, balance, status)
                    VALUES
                    (@userId, @pkgId, @date, @loc, @type,
                     @theme, @celebrant, @contact, @start, @end,
                     @down, @total, @balance, 'Pending')";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userId",   order.UserId);
                    cmd.Parameters.AddWithValue("@pkgId",    order.PackageId);
                    cmd.Parameters.AddWithValue("@date",     order.EventDate);
                    cmd.Parameters.AddWithValue("@loc",      order.EventLocation ?? "");
                    cmd.Parameters.AddWithValue("@type",     order.EventType ?? "");
                    cmd.Parameters.AddWithValue("@theme",    order.PartyTheme ?? "");
                    cmd.Parameters.AddWithValue("@celebrant",order.CelebrantName ?? "");
                    cmd.Parameters.AddWithValue("@contact",  order.ContactPerson ?? "");
                    cmd.Parameters.AddWithValue("@start",    order.BoothStartTime);
                    cmd.Parameters.AddWithValue("@end",      order.BoothEndTime);
                    cmd.Parameters.AddWithValue("@down",     order.DownPayment);
                    cmd.Parameters.AddWithValue("@total",    order.TotalAmount);
                    cmd.Parameters.AddWithValue("@balance",  order.Balance);
                    cmd.ExecuteNonQuery();
                    int newId = (int)cmd.LastInsertedId;

                    if (!string.IsNullOrWhiteSpace(order.SpecialRequests))
                    {
                        try
                        {
                            using (var cmd2 = new MySqlCommand(
                                "UPDATE orders SET special_requests=@sr WHERE order_id=@id", conn))
                            {
                                cmd2.Parameters.AddWithValue("@sr", order.SpecialRequests);
                                cmd2.Parameters.AddWithValue("@id", newId);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        catch { }
                    }

                    return newId;
                }
            }
        }

        public static List<Order> GetAllOrders()
        {
            var list = new List<Order>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM orders ORDER BY created_at DESC", conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(Map(r));
            }
            return list;
        }

        public static List<Order> GetOrdersByUserId(int userId)
        {
            var list = new List<Order>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM orders WHERE user_id=@id ORDER BY created_at DESC", conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(Map(r));
                }
            }
            return list;
        }

        public static Order GetOrderById(int orderId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM orders WHERE order_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", orderId);
                        using (var r = cmd.ExecuteReader())
                            if (r.Read()) return Map(r);
                    }
                }
            }
            catch { }
            return null;
        }

        public static bool UpdateOrderStatus(int orderId, string status)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("UPDATE orders SET status=@status WHERE order_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", orderId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }

        public static bool UpdateOrder(Order order)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    const string sql = @"UPDATE orders SET
                        event_date=@date, event_location=@loc, event_type=@type,
                        party_theme=@theme, celebrant_name=@celebrant, contact_person=@contact,
                        booth_start_time=@start, booth_end_time=@end
                        WHERE order_id=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date",     order.EventDate);
                        cmd.Parameters.AddWithValue("@loc",      order.EventLocation);
                        cmd.Parameters.AddWithValue("@type",     order.EventType);
                        cmd.Parameters.AddWithValue("@theme",    order.PartyTheme);
                        cmd.Parameters.AddWithValue("@celebrant",order.CelebrantName);
                        cmd.Parameters.AddWithValue("@contact",  order.ContactPerson);
                        cmd.Parameters.AddWithValue("@start",    order.BoothStartTime);
                        cmd.Parameters.AddWithValue("@end",      order.BoothEndTime);
                        cmd.Parameters.AddWithValue("@id",       order.OrderId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }

        private static Order Map(MySqlDataReader r)
        {
            var o = new Order
            {
                OrderId        = Convert.ToInt32(r["order_id"]),
                UserId         = Convert.ToInt32(r["user_id"]),
                PackageId      = Convert.ToInt32(r["package_id"]),
                EventDate      = Convert.ToDateTime(r["event_date"]),
                EventLocation  = r["event_location"].ToString(),
                EventType      = r["event_type"].ToString(),
                PartyTheme     = r["party_theme"].ToString(),
                CelebrantName  = r["celebrant_name"].ToString(),
                ContactPerson  = r["contact_person"].ToString(),
                BoothStartTime = (TimeSpan)r["booth_start_time"],
                BoothEndTime   = (TimeSpan)r["booth_end_time"],
                DownPayment    = Convert.ToDecimal(r["down_payment"]),
                TotalAmount    = Convert.ToDecimal(r["total_amount"]),
                Balance        = Convert.ToDecimal(r["balance"]),
                Status         = r["status"].ToString(),
                CreatedAt      = Convert.ToDateTime(r["created_at"])
            };
            try { o.SpecialRequests = r["special_requests"] != DBNull.Value ? r["special_requests"].ToString() : null; }
            catch { }
            return o;
        }
    }
}
