using AccountManagement.Framework.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.MicroService.Controllers
{
    public class MerchantCreateStoreRouteModel: MerchantStoreBaseRouteModel
    {
        [Required]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Text)]
        [Display(Name = "Password")]
        public string Password  { get; set; }
        public string ConfirmPassword  { get; set; }
        [DefaultValue(false)]
        public bool IsSocial { get; set; }
        public string SocialId { get; set; }
    }
}
