using AccountManagement.Framework.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.MicroService.Controllers
{
    public class MerchantCreateAccountRouteModel : AddressBaseModel
    {

        [Required]
        [DefaultValue("")]
        public string MerchantId  { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Email is too long.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Mobile No")]
        [StringLength(12, ErrorMessage = "{0} must be a {2} digit number.", MinimumLength = 12)]
        public string MobileNumber { get; set; }

        [Required]
        [Display(Name = "Password")]
        [MinLength(8)]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [StringLength(100)]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }
     
        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        public string UserType { get; set; }
        public string StaffId { get; set; }
        public string ImagePath { get; set; }
    }
}
