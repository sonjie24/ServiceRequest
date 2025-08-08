using System;
namespace AccountManagement.MicroService.Controllers.Publisher
{
  
    public class RiderAccount 
    {
        public string RiderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }

    }
    public class MerchantAccount 
    {
        public string StoreId { get; set; }
        public string Company { get; set; }
        public bool AutoAccept { get; set; }
        public bool Prepaid { get; set; }
    }
}
