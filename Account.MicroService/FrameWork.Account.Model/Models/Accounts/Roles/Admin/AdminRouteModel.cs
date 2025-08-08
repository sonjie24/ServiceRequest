using System;
using AccountManagement.Framework.Models;

namespace AccountManagement.FrameWork.Models
{
    public class AdminRouteModel :  BaseEntity
    {
        public string Module { get; set; }
        public string Grouping { get; set; }
        public string RouteName { get; set; }
        public string RoutePath { get; set; }
        public string Action  { get; set; }
        public bool Global { get; set; }

    }

    public class AdminRole : BaseEntity
    {
        public string RoleName { get; set; }
        public bool Status { get; set; }
        public AdminRole()
        {
            Status = true;
        }
    }

    public class AdminRouteModelRole:BaseEntity
    {
        public string RoleId { get; set; }
        public string RouteModelId  { get; set; }
        public string RoutePath { get; set; }
        public string Action { get; set; }
    }

    public class AdminUserRole:BaseEntity
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}
