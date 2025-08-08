using System;
using AccountManagement.Framework.Models;

namespace AccountManagement.FrameWork.Models 
{
    public class AdminUserRestrictionEntity : AdminUserTypeEntity
    {
        public string MerchantUserId { get; set; }
        public string Email { get; set; }
    }

    public class AdminUserTypeEntity : BaseEntity
    {
        public string UserType { get; set; }
        public string RoleName { get; set; }
        public bool IsSave { get; set; }
        public bool IsView { get; set; }
        public bool IsEdit { get; set; }
        public bool IsPrint { get; set; }
    }

}
