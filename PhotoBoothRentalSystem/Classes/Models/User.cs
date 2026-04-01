using System;

namespace PhotoBoothRentalSystem.Classes.Models
{
    public class User
    {
        public int      UserId      { get; set; }
        public string   FullName    { get; set; }
        public string   Email       { get; set; }
        public string   PhoneNumber { get; set; }
        public string   Role        { get; set; }
        public bool     IsVerified  { get; set; }
        public string   Status      { get; set; }
        public DateTime CreatedAt   { get; set; }

        // Extended profile fields
        public string   Gender      { get; set; }
        public DateTime? Birthday   { get; set; }
        public string   Location    { get; set; }
        public string   Bio         { get; set; }
        public string   ProfilePic  { get; set; }

        public bool IsAdmin()  => Role.Equals("admin",  StringComparison.OrdinalIgnoreCase);
        public bool IsActive() => Status.Equals("active", StringComparison.OrdinalIgnoreCase);

        public string Age
        {
            get
            {
                if (!Birthday.HasValue) return "—";
                int age = DateTime.Today.Year - Birthday.Value.Year;
                if (Birthday.Value.Date > DateTime.Today.AddYears(-age)) age--;
                return age.ToString();
            }
        }
    }
}
