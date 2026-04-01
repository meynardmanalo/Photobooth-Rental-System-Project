using System;
using MySql.Data.MySqlClient;

namespace PhotoBoothRentalSystem.Classes.Database
{
    public class DatabaseConnection
    {
        private static readonly string _connectionString =
            "Server=og8vwg.h.filess.io;" +
            "Database=Meynardconnection_spentbadly;" +
            "Uid=Meynardconnection_spentbadly;" +
            "Pwd=9dd5d9a0238dff8e6249a4c1f438ca715b3cce06;" +
            "Port=61002;" +
            "CharSet=utf8mb4;" +
            "SslMode=Required;" +
            "Connection Timeout=8;" +
            "Default Command Timeout=10;" +
            "Pooling=true;" +
            "Min Pool Size=2;" +
            "Max Pool Size=10;" +
            "Connection Lifetime=300;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }
            catch { return false; }
        }
    }
}
