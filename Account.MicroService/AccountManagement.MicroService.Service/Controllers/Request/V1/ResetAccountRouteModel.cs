using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.MicroService.Controllers
{
   public  class ResetAccountRouteModel
    {
        public string baseUrl  { get; set; }
        public string  emailAddress { get; set; } 
    }
}
