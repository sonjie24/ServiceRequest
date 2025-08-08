using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers
{
    public class ChangePasswordEmailRouteModel
    {
        [Required]
        public string EmailAddress  { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [MinLength(8)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("Password", ErrorMessage = "The new password and confirmation new password do not match.")]
        [MinLength(8)]
        public string ConfirmNewPassword { get; set; }
    }
}
