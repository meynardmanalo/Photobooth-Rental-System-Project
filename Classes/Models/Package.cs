using System;

namespace PhotoBoothRentalSystem.Classes.Models
{
    public class Package
    {
        public int     PackageId   { get; set; }
        public string  PackageName { get; set; }
        public string  Description { get; set; }
        public decimal Price       { get; set; }
        public int     Hours       { get; set; }
        public string  PackageType { get; set; }
        public bool    IsActive    { get; set; }
        public int     MaxPhotos   { get; set; } = 100;
    }
}
