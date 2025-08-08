using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountManagement.MicroService.Controllers
{
    public class  RiderCreateAccountRouteModel  
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(100)]
         public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(100)]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Email is too long.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [MinLength(8)]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [MinLength(8)]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Mobile No")]
        [StringLength(12, ErrorMessage = "{0} must be a {2} digit number.", MinimumLength = 12)]
        public string MobileNumber { get; set; }

    } 
}
