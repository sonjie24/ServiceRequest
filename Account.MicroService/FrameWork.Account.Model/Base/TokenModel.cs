using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Framework.Models
{
  public  class TokenModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string UserId { get; set; }
    }
}
