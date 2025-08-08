
using NetTopologySuite;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AccountManagement.Framework.Models
{
    [Table("Account_Riders")]
    public class RiderAccountEntity  : UserAccountBase 
    {
        [StringLength(12)]
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string MiddleName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }

        public double Rating  { get; set; }
        public int RatingCount { get; set; }

        //last known address 
        public double Latitude { get; set; }
        public double Longitude  { get; set; }
        public Point Location   { get; set; } 

        public RiderStatus Status { get; set; }
        public RiderOnlineOffline  RiderOnlineOffline   { get; set; }
        public RiderDeliveryStat DeliveryStatus   { get; set; }
      
        public   PersonProfile profile { get; set; }
        public string ImagePath { get; set; }
        public DateTime StartTime { get; set; }
        public string TotalTime { get; set; }
        public int TripsCount { get; set; }
        public decimal TotalCredits { get; set; }
        public Decimal TotalEarnings { get; set; }
        public double TotalHours { get; set; }
        public double TotalKms { get; set; }
        //public WalletEntity DefaultWallet  { get; set; }
        public bool IsDocsComplied { get; set; }
        [Column(TypeName = "decimal(26,6)")]
        public decimal LimitAmount  { get; set; }

        public RiderAccountEntity()
        {
            IsAccountConfirmed = false;
            GUID = Guid.NewGuid().ToString();

            DeliveryStatus = RiderDeliveryStat.UnAvailable;
            RiderOnlineOffline = RiderOnlineOffline.Offline;
            Status = RiderStatus.Pending;
            Latitude =  10.296236816739386 ;
            Longitude =  123.88903373164747 ;
            var gf = NtsGeometryServices.Instance.CreateGeometryFactory(4326);
            Location = gf.CreatePoint(new Coordinate(Longitude, Latitude)); 
        }
    }
}
