using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AccountManagement.Framework.Models;
using AccountManagement.MicroService.Controllers.Request.V1.Merchants;

namespace AccountManagement.MicroService.Controllers
{
    public class MerchantUpdateStoreRouteModel : MerchantStoreBaseRouteModel
    {
        public string Latitude { get; set; }
        public string Longitude  { get; set; } 
        public string ImagePath { get; set; }
        public bool Topup { get; set; }
        public bool Prepaid { get; set; }
        public bool AutoAccept { get; set; }
        public double MerchantKmRange { get; set; }
        public double RiderKmRange { get; set; }
        public string baseUrl { get; set; }
        public bool IsDocsComplied { get; set; } = false;
    }

    public class MerchantReturnModel 
    {
        public   MerchantStoreEntity ParentMerchantStoreEntity { get; set; }
        public   MerchantAccountEntity User { get; set; }
        public string Company { get; set; }
        public string LandMark { get; set; }
        public List<CategoryModel> Categories { get; set; }
        public double Rating { get; set; }
        public int RatingCount { get; set; }
        public int NoOfEmployees { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Barangay { get; set; }
        public string CityMunicipality { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public string ZipCode { get; set; }
        public string ImagePath { get; set; }
    }
}
