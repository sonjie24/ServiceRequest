using System;
using Framework.Data.Repository;

namespace  AccountManagement.Framework.Models
{
    public class RiderActivityEntity :BaseEntityWithCreated  
    {
        public string RiderId { get; set; }
        public string Reference { get; set; }
        public string Activity { get; set; }
        public DateTime DateTimeLog { get; set; }
        public string Status { get; set; }
    }
}
