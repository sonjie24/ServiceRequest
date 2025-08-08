using System;
using AccountManagement.Framework.Models;

namespace AccountManagement.FrameWork.Models
{
    public class StoreOfflineReasonEntity:BaseEntity
    {
        public string Reason { get; set; }
        public bool Status { get; set; }
    }
}
