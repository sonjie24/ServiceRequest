using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService
{
    public class JwtInformation
    {
        public string Tittle { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }

        public string TermsOfService { get; set; }

        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string LicenseName { get; set; }

        public string LicenseUrl { get; set; }

    }
}
