using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers
{
    public class CategoryCreateRouteModel
    {
        public string ParentId { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Remarks  { get; set; }
    }
}
