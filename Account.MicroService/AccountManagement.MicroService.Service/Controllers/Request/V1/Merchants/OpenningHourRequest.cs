using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers.Request.V1.Merchants
{
    public class OpenningHourRequest
    {
        [Required]
        public string Day { get; set; }
        public string IsOn { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
    }
}
