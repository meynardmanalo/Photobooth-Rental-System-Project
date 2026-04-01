using System;

namespace PhotoBoothRentalSystem.Classes.Models
{
    public class Order
    {
        public int      OrderId        { get; set; }
        public int      UserId         { get; set; }
        public int      PackageId      { get; set; }
        public DateTime EventDate      { get; set; }
        public string   EventLocation  { get; set; }
        public string   EventType      { get; set; }
        public string   PartyTheme     { get; set; }
        public string   CelebrantName  { get; set; }
        public string   ContactPerson  { get; set; }
        public TimeSpan BoothStartTime { get; set; }
        public TimeSpan BoothEndTime   { get; set; }
        public decimal  DownPayment    { get; set; }
        public decimal  TotalAmount    { get; set; }
        public decimal  Balance        { get; set; }
        public string   Status         { get; set; }
        public DateTime CreatedAt      { get; set; }
        public string   SpecialRequests { get; set; }
    }
}
