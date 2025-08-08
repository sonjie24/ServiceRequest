using System;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.MicroService.Controllers
{
    public class MerchantLoginModel
    {
        public string MobileEmailSocialId { get; set; }
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        public bool IsSocial { get; set; }
    }
}
