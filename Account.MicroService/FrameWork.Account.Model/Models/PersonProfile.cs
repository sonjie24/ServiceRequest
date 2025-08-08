using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Framework.Models
{
    public partial class PersonProfile: BaseData
    {
        public int? RiderId  { get; set; }
        [ForeignKey("RiderId")]
        public   RiderAccountEntity Rider { get; set; }
        [StringLength(10)]
        public string Prefix { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]

        public string MiddleName { get; set; }
        [StringLength(100)]

        public string LastName { get; set; }
        [StringLength(10)]
        public string Suffix { get; set; }
        [StringLength(100)]
        public string Nationality { get; set; }
        [StringLength(100)]
        public string CivilStatus { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
        public DateTime? DateBirth { get; set; }
        [StringLength(255)]
        public string PlaceBirth { get; set; }
        [StringLength(12)]
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        [StringLength(20)]
        public string TelNo { get; set; }
        [StringLength(255)]
        public string Address1 { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Barangay { get; set; }
        [StringLength(255)]
        public string CityMunicipality { get; set; }
        [StringLength(255)]
        public string Province { get; set; }
        [StringLength(255)]
        public string Region { get; set; }
        [StringLength(15)]
        public string ZipCode { get; set; }
        public string ImagePath { get; set; }
        public string AboutMe { get; set; }

        [StringLength(50)]
        public string TransportType { get; set; }
        [StringLength(4)]
        public string yearModel { get; set; }
        [StringLength(50)]
        public string Make { get; set; }
        [StringLength(50)]
        public string Model { get; set; }
        [StringLength(50)]
        public string PlateNo { get; set; }
        [StringLength(50)]
        public string Color { get; set; }
        public List<PersonWorkExperience> Experiences  { get; set; }
 
    }
}
