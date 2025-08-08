using System;
namespace AccountManagement.MicroService.Controllers
{
    public class ConsumerAddressRouteModel
    {
        public string AddressType { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Address_Details  { get; set; }
        public string Rider_Instruction  { get; set; }
    }

    public class ConsumerAddressRouteModelUpdate : ConsumerAddressRouteModel
    {
        public string Id { get; set; }
    }
}
