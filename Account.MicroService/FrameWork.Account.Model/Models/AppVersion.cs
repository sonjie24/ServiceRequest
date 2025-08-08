using System;
using AccountManagement.Framework.Models;

namespace AccountManagement.Framework.Models
{
    public class AppVersion: BaseEntity
    {
        public string AppName { get; set; }
        public string PackageName { get; set; }
        public string MinimumVersion { get; set; }
        public string Version { get; set; } 
    }

    public class MaintanceMode:BaseEntity
    {
        public string AppName { get; set; }
        public bool IsMaintenanceMode { get; set; }
    }

    public class AppOsMonitoring: BaseEntity
    {
        public string DeviceType { get; set; }
        public string AppVersion { get; set; }
        public string AppType { get; set; }
        public string UserId { get; set; }
        public string UserType { get; set; }
        public string OsVersion { get; set; }
        public string DeviceModel { get; set; }
        public string Manufacturer { get; set; }

    }
}
