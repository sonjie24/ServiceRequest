using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using NetTopologySuite.Geometries;

namespace AccountManagement.Framework.Models
{
    [Table("CustomerAddressBook")]
   public  class  ConsumerAddressBookEntity:BaseData
    {
        public int ConsumerId { get; set; }
        [ForeignKey("ConsumerId")]
        public ConsumerAccountEntity  Consumer { get; set; }
        public bool isDefault { get; set; }
        [StringLength(15)]
        public string Type { get; set; } 
        public string Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string AddressDetail  { get; set; }
        public string RiderInstruction   { get; set; }
        public Point Location { get; set; }
    
    }
}
