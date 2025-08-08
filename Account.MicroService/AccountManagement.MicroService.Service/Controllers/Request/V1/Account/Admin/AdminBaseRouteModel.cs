using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers
{
    public class AdminBaseRouteModel
    {
        [Required]
        public string StaffId { get; set; }
        [Required]
        [Display(Name = "Username")]
        [MinLength(3)]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Email is too long.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Mobile No")]
        public string MobileNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Display(Name = "Job Position")]
        [DefaultValue("")]
        public string JobPosition { get; set; }

        public bool SetEffectivity { get; set; } 
        public DateTime ValidUntil { get; set; }
        public string RoleId  { get; set; }
    }
}
