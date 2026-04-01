using System;
using System.Collections.Generic;
using System.IO;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class PackageMediaService
    {
        // Folder where media files are stored (relative to exe)
        public static string GetMediaFolder()
        {
            string folder = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Assets", "PackageMedia");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            return folder;
        }

        public static List<PackageMedia> GetMediaByPackage(int packageId)
        {
            List<PackageMedia> list = new List<PackageMedia>();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT * FROM package_media
                                     WHERE package_id = @packageId
                                     ORDER BY display_order ASC, uploaded_at ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@packageId", packageId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(MapReader(reader));
                            }
                        }
                    }
                }
            }
            catch { }

            return list;
        }

        public static List<PackageMedia> GetImagesByPackage(int packageId)
        {
            List<PackageMedia> list = new List<PackageMedia>();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT * FROM package_media
                                     WHERE package_id = @packageId AND media_type = 'image'
                                     ORDER BY display_order ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@packageId", packageId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(MapReader(reader));
                            }
                        }
                    }
                }
            }
            catch { }

            return list;
        }

        public static bool AddMedia(int packageId, string sourcePath, string mediaType, string displayName = null)
        {
            try
            {
                // Copy file to media folder with unique name
                string ext = Path.GetExtension(sourcePath);
                string uniqueName = $"pkg{packageId}_{DateTime.Now:yyyyMMddHHmmss}_{Guid.NewGuid().ToString("N").Substring(0, 6)}{ext}";
                string destPath = Path.Combine(GetMediaFolder(), uniqueName);

                File.Copy(sourcePath, destPath, true);

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Get next display order
                    int nextOrder = 0;
                    string orderQuery = "SELECT COALESCE(MAX(display_order), -1) + 1 FROM package_media WHERE package_id = @pid";
                    using (MySqlCommand oCmd = new MySqlCommand(orderQuery, conn))
                    {
                        oCmd.Parameters.AddWithValue("@pid", packageId);
                        nextOrder = Convert.ToInt32(oCmd.ExecuteScalar());
                    }

                    string query = @"INSERT INTO package_media
                                     (package_id, media_type, file_path, display_name, display_order)
                                     VALUES (@packageId, @type, @path, @name, @order)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@packageId", packageId);
                        cmd.Parameters.AddWithValue("@type", mediaType);
                        cmd.Parameters.AddWithValue("@path", uniqueName);
                        cmd.Parameters.AddWithValue("@name", displayName ?? Path.GetFileNameWithoutExtension(sourcePath));
                        cmd.Parameters.AddWithValue("@order", nextOrder);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteMedia(int mediaId)
        {
            try
            {
                string filePath = null;

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string selectQuery = "SELECT file_path FROM package_media WHERE media_id = @id";
                    using (MySqlCommand sCmd = new MySqlCommand(selectQuery, conn))
                    {
                        sCmd.Parameters.AddWithValue("@id", mediaId);
                        object result = sCmd.ExecuteScalar();
                        if (result != null) filePath = result.ToString();
                    }

                    string deleteQuery = "DELETE FROM package_media WHERE media_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", mediaId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Delete the actual file
                if (filePath != null)
                {
                    string fullPath = Path.Combine(GetMediaFolder(), filePath);
                    if (File.Exists(fullPath))
                        File.Delete(fullPath);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateDisplayOrder(int mediaId, int newOrder)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE package_media SET display_order = @order WHERE media_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@order", newOrder);
                        cmd.Parameters.AddWithValue("@id", mediaId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static int GetMediaCount(int packageId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM package_media WHERE package_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", packageId);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }

        public static string GetFullPath(string storedFileName)
        {
            return Path.Combine(GetMediaFolder(), storedFileName);
        }

        private static PackageMedia MapReader(MySqlDataReader reader)
        {
            return new PackageMedia
            {
                MediaId = Convert.ToInt32(reader["media_id"]),
                PackageId = Convert.ToInt32(reader["package_id"]),
                MediaType = reader["media_type"].ToString(),
                FilePath = reader["file_path"].ToString(),
                DisplayName = reader["display_name"] != DBNull.Value ? reader["display_name"].ToString() : "",
                DisplayOrder = Convert.ToInt32(reader["display_order"]),
                UploadedAt = Convert.ToDateTime(reader["uploaded_at"])
            };
        }
    }
}
