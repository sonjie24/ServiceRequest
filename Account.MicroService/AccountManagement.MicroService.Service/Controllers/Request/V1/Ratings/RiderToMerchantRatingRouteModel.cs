using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers
{
    public class  RiderToMerchantRatingRouteModel
    {
        public string BookingId { get; set; }
        public string RiderId  { get; set; }
        public string RiderName{ get; set; }
        public string MerchantId  { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
    }
}
