using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class ReportService
    {
        private static ReportData RunSummary(string whereClause, Action<MySqlCommand> addParams)
        {
            var report = new ReportData();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = $@"SELECT COUNT(*) AS order_count,
                    COALESCE(SUM(total_amount),0)  AS total_income,
                    COALESCE(SUM(down_payment),0)  AS total_down_payment,
                    COALESCE(SUM(balance),0)        AS total_balance
                    FROM orders {whereClause}";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    addParams(cmd);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            report.OrderCount       = Convert.ToInt32(r["order_count"]);
                            report.TotalIncome      = Convert.ToDecimal(r["total_income"]);
                            report.TotalDownPayment = Convert.ToDecimal(r["total_down_payment"]);
                            report.TotalBalance     = Convert.ToDecimal(r["total_balance"]);
                        }
                    }
                }
            }
            return report;
        }

        public static ReportData GetDailyReport(DateTime date) =>
            RunSummary("WHERE DATE(created_at)=@p1",
                cmd => cmd.Parameters.AddWithValue("@p1", date.Date));

        public static ReportData GetWeeklyReport(DateTime start) =>
            RunSummary("WHERE DATE(created_at)>=@p1 AND DATE(created_at)<@p2",
                cmd => {
                    cmd.Parameters.AddWithValue("@p1", start.Date);
                    cmd.Parameters.AddWithValue("@p2", start.Date.AddDays(7));
                });

        public static ReportData GetMonthlyReport(int year, int month) =>
            RunSummary("WHERE YEAR(created_at)=@p1 AND MONTH(created_at)=@p2",
                cmd => {
                    cmd.Parameters.AddWithValue("@p1", year);
                    cmd.Parameters.AddWithValue("@p2", month);
                });

        public static ReportData GetYearlyReport(int year) =>
            RunSummary("WHERE YEAR(created_at)=@p1",
                cmd => cmd.Parameters.AddWithValue("@p1", year));

        public static Dictionary<string, int> GetOrderStatusBreakdown()
        {
            var result = new Dictionary<string, int>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(
                    "SELECT status, COUNT(*) AS cnt FROM orders GROUP BY status", conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        result[r["status"].ToString()] = Convert.ToInt32(r["cnt"]);
            }
            return result;
        }

        public static List<PackagePopularity> GetPopularPackages()
        {
            var list = new List<PackagePopularity>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT p.package_name, p.price,
                    COUNT(o.order_id) AS order_count,
                    COALESCE(SUM(o.total_amount),0) AS total_revenue
                    FROM packages p
                    LEFT JOIN orders o ON p.package_id=o.package_id
                    GROUP BY p.package_id, p.package_name, p.price
                    ORDER BY order_count DESC";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new PackagePopularity
                        {
                            PackageName  = r["package_name"].ToString(),
                            Price        = Convert.ToDecimal(r["price"]),
                            OrderCount   = Convert.ToInt32(r["order_count"]),
                            TotalRevenue = Convert.ToDecimal(r["total_revenue"])
                        });
            }
            return list;
        }

        public static List<MonthlyTrend> GetMonthlyTrends(int year)
        {
            var list = new List<MonthlyTrend>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT MONTH(created_at) AS month,
                    COUNT(*) AS order_count,
                    COALESCE(SUM(total_amount),0) AS total_income
                    FROM orders WHERE YEAR(created_at)=@yr
                    GROUP BY MONTH(created_at) ORDER BY month";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@yr", year);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read())
                            list.Add(new MonthlyTrend
                            {
                                Month      = Convert.ToInt32(r["month"]),
                                OrderCount = Convert.ToInt32(r["order_count"]),
                                TotalIncome= Convert.ToDecimal(r["total_income"])
                            });
                }
            }
            return list;
        }
    }

    public class ReportData
    {
        public int     OrderCount       { get; set; }
        public decimal TotalIncome      { get; set; }
        public decimal TotalDownPayment { get; set; }
        public decimal TotalBalance     { get; set; }
    }

    public class PackagePopularity
    {
        public string  PackageName  { get; set; }
        public decimal Price        { get; set; }
        public int     OrderCount   { get; set; }
        public decimal TotalRevenue { get; set; }
    }

    public class MonthlyTrend
    {
        public int     Month       { get; set; }
        public int     OrderCount  { get; set; }
        public decimal TotalIncome { get; set; }
    }
}
