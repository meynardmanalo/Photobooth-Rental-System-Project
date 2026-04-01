using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoBoothRentalSystem.Classes.Models;

namespace PhotoBoothRentalSystem.Classes.Utilities
{
    public static class SessionManager
    {
        public static User CurrentUser { get; set; }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static bool IsAdmin()
        {
            return IsLoggedIn() && CurrentUser.IsAdmin();
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}