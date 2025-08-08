using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AccountManagement.Framework.Models;

namespace AccountManagement.MicroService.Controllers
{
    public class AddBranchMerchantStoreBaseRouteModel: MerchantStoreBaseRouteModel
    {
        [Required]
        public string BranchGroup { get; set; }
    }

    public class MerchantStoreBaseRouteModel : AddressBaseModel
    {
        [Required]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)] 
        public string Company { get; set; }
        public string MainBranchId { get; set; }
        public string LandMark { get; set; }
        public List<CategoryModel> CategoryIds  { get; set; }
        public int NoOfEmployees { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Email is too long.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        [Display(Name = "Email" )]
        public string Email { get; set; }

        public bool isAllowedAdvanceOrder { get; set; }
        public bool isAllowedPickUp { get; set; }
       
    }
    public class CategoryModel
    {
        public string CategoryId { get; set; }
    }
}
