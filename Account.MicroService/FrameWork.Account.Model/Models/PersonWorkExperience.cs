using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Framework.Models
{
    public partial class PersonWorkExperience : BaseData
    {
        [ForeignKey("PersonProfile")]
        public int PersonId { get; set; }
        public PersonProfile profile { get; set; }
        [StringLength(25)]
        public string MonthYearFrom { get; set; }
        [StringLength(25)]
        public string MonthYearTo { get; set; }
        [StringLength(255)]
        public string Company { get; set; }
        [StringLength(255)]
        public string CompanyLocation { get; set; }
        [StringLength(255)]
        public string Role { get; set; }
        [StringLength(255)]
        public string Salary { get; set; }
        [StringLength(255)]
        public string JobDescription { get; set; }
        [StringLength(255)]
        public string Remarks { get; set; }
    }
}
