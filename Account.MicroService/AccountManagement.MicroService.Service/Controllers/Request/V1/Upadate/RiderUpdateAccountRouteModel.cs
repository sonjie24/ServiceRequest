using System;
using System.ComponentModel.DataAnnotations;
using AccountManagement.Framework.Models;

namespace AccountManagement.MicroService.Controllers
{
    public class RiderUpdateAccountRouteModel 
    {
        public string Prefix { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Nationality { get; set; }
        public string CivilStatus { get; set; }
        public string Gender { get; set; }
        public DateTime? DateBirth { get; set; }
        public string PlaceBirth { get; set; }

        [Required]
        [Display(Name = "Mobile No")]
        [StringLength(12, ErrorMessage = "{0} must be a {2} digit number.", MinimumLength = 12)]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Email is too long.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string TelNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Barangay { get; set; }
        public string CityMunicipality { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public string ZipCode { get; set; } 
        public string ImagePath { get; set; }
        public string AboutMe { get; set; }

        //vehicle

        public string TransportType { get; set; }
        public string yearModel { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string PlateNo { get; set; }
        public string Color { get; set; }


    }
}
