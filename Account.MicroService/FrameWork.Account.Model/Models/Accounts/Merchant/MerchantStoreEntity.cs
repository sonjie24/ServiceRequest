using AccountManagement.FrameWork.Models;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Framework.Models
{

    [Table("Merchants")]
    public class MerchantStoreEntity : BaseData
    {
        public int ParentMerchantStoreEntityId { get; set; }
        public   MerchantStoreEntity Parent { get; set; }
        //public   List<MerchantAccountEntity>  Users  { get; set; }
        public string BranchGroup { get; set; }
        [StringLength(255)]
        public string Company { get; set; }
        public string LandMark  { get; set; }
        public   List<MerchantCategoryEntity> Categories  { get; set; }
        public double RiderRating { get; set; }
        public int RiderRatingCount { get; set; }
        public double ConsumerRating { get; set; }
        public int ConsumerRatingCount { get; set; }
        public int NoOfEmployees { get; set; }
        [StringLength(100)]
        public string ContactFirstName { get; set; }
        [StringLength(100)]
        public string ContactLastName { get; set; }
        [StringLength(50)]
        public string ContactNo { get; set; }
        public string Email { get; set; } 
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Point Location   { get; set; }
        [StringLength(255)]
        public string Address1 { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Barangay { get; set; }
        [StringLength(255)]
        public string CityMunicipality { get; set; }
        [StringLength(255)]
        public string Province { get; set; }
        [StringLength(255)]
        public string Region { get; set; }
        [StringLength(20)]
        public string ZipCode { get; set; } 
        public string ImagePath { get; set; }

        public bool Prepaid { get; set; }
        public bool AutoAccept { get; set; }
        public double MerchantKmRange { get; set; }
        public double RiderKmRange { get; set; }
        public bool IsDocsComplied { get; set; }
        public decimal MininumPurchaseAmount  { get; set; }//consumer should purchase equal or above this amount
        public EStatus Status { get; set; }
        public string ClosedReason { get; set; }

        public bool isAllowedPickUp { get; set; }
        public bool isAllowedAdvanceOrder { get; set; }

        public MerchantStoreEntity() :base()
        {
            ClosedReason = "";
            Status = EStatus.Pending;
            MerchantKmRange = 2000;
            RiderKmRange = 500;
            AutoAccept = true;
            BranchGroup= Guid.NewGuid().ToString();
        } 
    }
}
