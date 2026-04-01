using System;

namespace PhotoBoothRentalSystem.Classes.Models
{
    public class PackageMedia
    {
        public int MediaId { get; set; }
        public int PackageId { get; set; }
        public string MediaType { get; set; }   // "image", "video", "sticker"
        public string FilePath { get; set; }
        public string DisplayName { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime UploadedAt { get; set; }

        public bool IsImage => MediaType == "image";
        public bool IsVideo => MediaType == "video";
        public bool IsSticker => MediaType == "sticker";
    }
}
