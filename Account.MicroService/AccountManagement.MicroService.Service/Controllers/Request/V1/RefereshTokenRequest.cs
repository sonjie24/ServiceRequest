using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountManagement.MicroService.RouteModels
{
    public class RefereshTokenRequest
    {
        public string RefreshToken { get; set; }

    }
}
