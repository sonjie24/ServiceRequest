using System;
using AccountManagement.Framework.Models;

namespace AccountManagement.FrameWork.Models.Models.Accounts.Admin
{

    public class AdminEmployeeEntity : BaseData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobDescription { get; set; }
        public string ContactNo { get; set; }
        public DateTime EffectivityDate { get; set; }
        public bool WithEffectivity { get; set; }
        public  bool Status { get; set; }

    }
}
