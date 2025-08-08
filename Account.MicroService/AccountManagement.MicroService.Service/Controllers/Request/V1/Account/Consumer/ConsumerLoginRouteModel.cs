using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers
{
    public class  ConsumerLoginRouteModel
    {
        public string mobileNoEmailOrSocialId { get; set; }
        [DefaultValue(false)]
        public bool isSocial { get; set; }
        public string AppCode  { get; set; }
    }   
}
