using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.MicroService.RouteModels
{
    public class CreateDeviceDetails
    {
        public string Brand { get; set; }
        public string Model   { get; set; }
    }
}
