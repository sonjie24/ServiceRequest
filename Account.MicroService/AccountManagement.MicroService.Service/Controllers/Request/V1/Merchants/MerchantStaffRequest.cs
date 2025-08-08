using System;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.MicroService.Controllers.Request.V1.Merchants
{
    public class MerchantStaffRequest
    {
        [Required]
        public string MerchantId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string ContactNo { get; set; }
        public string JobDescription { get; set; }
        public bool SetEffectivity { get; set; }
        public DateTime EffectivityDate { get; set; }
        public bool Status { get; set; }
    }
}
