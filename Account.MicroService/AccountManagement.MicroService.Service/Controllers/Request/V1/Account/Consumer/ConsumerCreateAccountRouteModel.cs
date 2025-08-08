using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.MicroService.Controllers
{
    public class ConsumerCreateAccountRouteModel
    {
        [DefaultValue(false)]
        public bool IsSocial { get; set; }
        public string SocialId { get; set; }

        [Display(Name = "Mobile No")]
        [StringLength(12, ErrorMessage = "{0} must be a {2} digit number.", MinimumLength = 12)]
        public string MobileNumber { get; set; }

        [StringLength(255, ErrorMessage = "Email is too long.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }
        public string AppCode  { get; set; }
    }
}
