using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PhotoBoothRentalSystem.Classes.Database;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class FileUploadService
    {
        private static string uploadDirectory = Path.Combine(Application.StartupPath, "Uploads");

        public static bool SaveOrderFile(int orderId, string fileType, string sourceFilePath)
        {
            try
            {
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }

                string orderFolder = Path.Combine(uploadDirectory, $"Order_{orderId}");
                if (!Directory.Exists(orderFolder))
                {
                    Directory.CreateDirectory(orderFolder);
                }

                string extension = Path.GetExtension(sourceFilePath);
                string newFileName = $"{fileType}_{DateTime.Now.Ticks}{extension}";
                string destinationPath = Path.Combine(orderFolder, newFileName);

                File.Copy(sourceFilePath, destinationPath, true);

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO order_files (order_id, file_type, file_path, file_name) " +
                                   "VALUES (@orderId, @fileType, @filePath, @fileName)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@fileType", fileType);
                        cmd.Parameters.AddWithValue("@filePath", destinationPath);
                        cmd.Parameters.AddWithValue("@fileName", newFileName);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("File upload error: " + ex.Message);
            }
        }

        public static string GetOrderFilePath(int orderId, string fileType)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT file_path FROM order_files " +
                                   "WHERE order_id = @orderId AND file_type = @fileType " +
                                   "ORDER BY uploaded_at DESC LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@fileType", fileType);

                        object result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public static bool DeleteOrderFile(int orderId, string fileType)
        {
            try
            {
                string filePath = GetOrderFilePath(orderId, fileType);

                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM order_files WHERE order_id = @orderId AND file_type = @fileType";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@fileType", fileType);
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

        public static bool HasFile(int orderId, string fileType)
        {
            string filePath = GetOrderFilePath(orderId, fileType);
            return !string.IsNullOrEmpty(filePath) && File.Exists(filePath);
        }
    }
}