//using FrameWork.Account.Model.Base;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AccountManagement.MicroService.RouteModels
//{
//    public abstract class AccountBasicInfoRouteModel: AddressBaseModel
//    {
//        [Required]
//        [Display(Name = "First Name")]
//        [StringLength(100)]
//        public string FirstName { get; set; }

//        [Display(Name = "Middle Name")]
//        [StringLength(100)]
//        public string MiddleName { get; set; }
//        [Display(Name = "Last Name")]
//        [StringLength(100)]
//        public string LastName { get; set; }

//        [Required]
//        [Display(Name = "Mobile No")]
//        [StringLength(12, ErrorMessage = "{0} must be a {2} digit number.", MinimumLength = 12)]
//        public string MobileNumber { get; set; }

//        [Required]
//        [StringLength(255, ErrorMessage = "Email is too long.")]
//        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
//        [Display(Name = "Email")]
//        public string Email { get; set; }

//        [Required]
//        [Display(Name = "UserName")]
//        [StringLength(100)]
//        public string UserName { get; set; }

//        [Required]
//        [Display(Name = "Password")]
//        [StringLength(100)]
//        public string Password { get; set; }

//        [Required]
//        [Display(Name = "Confirm Password")]
//        [StringLength(100)]
//        public string ConfirmPassword { get; set; }

//        [Required]
//        [Display(Name = "Role")]
//        public int RoleId { get; set; }
//    }
//}
