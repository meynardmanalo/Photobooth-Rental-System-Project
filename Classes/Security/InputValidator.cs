using System;
using System.Text.RegularExpressions;

namespace PhotoBoothRentalSystem.Classes.Security
{
    public static class InputValidator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return false;

            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
        }

        // Added back for backward compatibility
        // Validates Philippine phone numbers in format: +639XXXXXXXXX
        public static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Philippine phone number format: +639XXXXXXXXX (13 characters total)
            var regex = new Regex(@"^\+639\d{9}$");
            return regex.IsMatch(phone);
        }

        public static string SanitizeInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            return input.Trim();
        }
    }
}