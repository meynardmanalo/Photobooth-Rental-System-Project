using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class PackageService
    {
        private static Package Map(MySqlDataReader r)
        {
            var p = new Package
            {
                PackageId   = Convert.ToInt32(r["package_id"]),
                PackageName = r["package_name"].ToString(),
                Description = r["description"].ToString(),
                Price       = Convert.ToDecimal(r["price"]),
                Hours       = Convert.ToInt32(r["hours"]),
                PackageType = r["package_type"].ToString(),
                IsActive    = Convert.ToBoolean(r["is_active"])
            };
            try { p.MaxPhotos = r["max_photos"] != DBNull.Value ? Convert.ToInt32(r["max_photos"]) : 100; }
            catch { p.MaxPhotos = 100; }
            return p;
        }

        public static List<Package> GetAllActivePackages()
        {
            var list = new List<Package>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM packages WHERE is_active=TRUE ORDER BY price ASC", conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(Map(r));
            }
            return list;
        }

        public static List<Package> GetAllPackages()
        {
            var list = new List<Package>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM packages ORDER BY package_id ASC", conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(Map(r));
            }
            return list;
        }

        public static Package GetPackageById(int packageId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM packages WHERE package_id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", packageId);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) return Map(r);
                }
            }
            return null;
        }

        public static bool AddPackage(Package p)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "INSERT INTO packages (package_name,description,price,hours,package_type,is_active,max_photos) VALUES (@name,@desc,@price,@hours,@type,@active,@photos)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name",   p.PackageName);
                        cmd.Parameters.AddWithValue("@desc",   p.Description);
                        cmd.Parameters.AddWithValue("@price",  p.Price);
                        cmd.Parameters.AddWithValue("@hours",  p.Hours);
                        cmd.Parameters.AddWithValue("@type",   p.PackageType);
                        cmd.Parameters.AddWithValue("@active", p.IsActive);
                        cmd.Parameters.AddWithValue("@photos", p.MaxPhotos);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "INSERT INTO packages (package_name,description,price,hours,package_type,is_active) VALUES (@name,@desc,@price,@hours,@type,@active)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name",   p.PackageName);
                        cmd.Parameters.AddWithValue("@desc",   p.Description);
                        cmd.Parameters.AddWithValue("@price",  p.Price);
                        cmd.Parameters.AddWithValue("@hours",  p.Hours);
                        cmd.Parameters.AddWithValue("@type",   p.PackageType);
                        cmd.Parameters.AddWithValue("@active", p.IsActive);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public static bool UpdatePackage(Package p)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "UPDATE packages SET package_name=@name,description=@desc,price=@price,hours=@hours,package_type=@type,is_active=@active,max_photos=@photos WHERE package_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@name",   p.PackageName);
                        cmd.Parameters.AddWithValue("@desc",   p.Description);
                        cmd.Parameters.AddWithValue("@price",  p.Price);
                        cmd.Parameters.AddWithValue("@hours",  p.Hours);
                        cmd.Parameters.AddWithValue("@type",   p.PackageType);
                        cmd.Parameters.AddWithValue("@active", p.IsActive);
                        cmd.Parameters.AddWithValue("@photos", p.MaxPhotos);
                        cmd.Parameters.AddWithValue("@id",     p.PackageId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "UPDATE packages SET package_name=@name,description=@desc,price=@price,hours=@hours,package_type=@type,is_active=@active WHERE package_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@name",   p.PackageName);
                        cmd.Parameters.AddWithValue("@desc",   p.Description);
                        cmd.Parameters.AddWithValue("@price",  p.Price);
                        cmd.Parameters.AddWithValue("@hours",  p.Hours);
                        cmd.Parameters.AddWithValue("@type",   p.PackageType);
                        cmd.Parameters.AddWithValue("@active", p.IsActive);
                        cmd.Parameters.AddWithValue("@id",     p.PackageId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public static bool DeletePackage(int packageId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM packages WHERE package_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", packageId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }
    }
}
