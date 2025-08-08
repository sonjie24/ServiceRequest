using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers
{
    public class DocumentRequirementRouteModel
    {
        [Required]
        public string DocumentName  { get; set; }
        [Required]
        public string ImagePath  { get; set; }
    }
}
