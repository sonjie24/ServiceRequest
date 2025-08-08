using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.MicroService.RouteModels
{
    public class UpdateDeviceDetails :CreateDeviceDetails
    {
        public int Id { get; set; }
    }
}
