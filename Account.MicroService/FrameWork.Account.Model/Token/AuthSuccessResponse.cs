using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Models
{
    public class AuthSuccessResponse
    {
        public string AccessToken { get; set; }

        public string ResfreshToken { get; set; }
    }
}
