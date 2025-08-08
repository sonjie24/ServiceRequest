using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.MicroService.Controllers
{
    public class AdminCreateAccountRouteModel :AdminBaseRouteModel
    {
    
        [Required]
        [Display(Name = "Password")]
        [MinLength(8)]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [MinLength(8)]
        public string ConfirmPassword { get; set; }
    }
}
