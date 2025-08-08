using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AccountManagement.Framework.Models;
using TimeZoneConverter;

namespace AccountManagement.FrameWork.Models 
{
    public class RiderTripsLog:BaseEntityWithCreated  
    {
        public string BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
        public string RiderGUID { get; set; }
         
    }
}
