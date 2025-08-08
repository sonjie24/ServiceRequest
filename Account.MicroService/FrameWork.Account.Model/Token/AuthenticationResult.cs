using AccountManagement.Framework.Models;
using System.Collections.Generic;

namespace AccountManagement.Framework.Models
{
    public class AuthenticationResult
    {
        public AuthenticationResult()
        {
            ResultEnum = Result.None;
        }
        public Result ResultEnum { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }       
        public IEnumerable<string> Errors { get; set; }
        public bool Success { get; set; }
    } 
 
}
