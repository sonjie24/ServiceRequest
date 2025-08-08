using System;
using AccountManagement.Framework.Models;

namespace AccountManagement.FrameWork.Models
{
    public class RouteModel :  BaseEntity
    {
        public string Module { get; set; }
        public string Grouping { get; set; }
        public string RouteName { get; set; }
        public string RoutePath { get; set; }
        public string Action  { get; set; }
        public bool Global { get; set; }
    }

 
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public bool Status { get; set; }
        public Role()
        {
            Status = true;
        }
    }

    public class RouteModelRole:BaseEntity
    {
        public string RoleId { get; set; }
        public string RouteModelId  { get; set; }
        public string RoutePath { get; set; }
        public string Action { get; set; }
    }

    public class UserRole:BaseEntity
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}
