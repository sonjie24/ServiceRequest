using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Framework.Models
{
   public abstract class UserAccountBase : BaseData
    {
        public bool? IsAccountConfirmed { get; set; }
    }
}
