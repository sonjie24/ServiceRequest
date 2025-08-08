using System;
using System.Text.RegularExpressions;

namespace AccountManagement.MicroService.Controllers.validation
{
    public class EmailValidation : Ivalidate<string>
    { 
        public bool validate(string param)
        {
            return Regex.IsMatch(param.ToString(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
    }
}
