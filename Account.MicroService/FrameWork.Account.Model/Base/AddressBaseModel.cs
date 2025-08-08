using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Framework.Models
{
    public abstract class AddressBaseModel
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Barangay { get; set; }
        public string CityMunicipality { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public string ZipCode { get; set; }
    }
}
