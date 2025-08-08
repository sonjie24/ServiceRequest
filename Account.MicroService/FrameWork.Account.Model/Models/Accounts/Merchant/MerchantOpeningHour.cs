using System;
using System.ComponentModel.DataAnnotations.Schema;
using AccountManagement.Framework.Models;

namespace AccountManagement.FrameWork.Models
{
    public class MerchantOpeningHour:BaseEntity
    {
        public string MerchantId { get; set; }
        public string Day { get; set; }
        public string IsOn { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public MerchantOpeningHour()
        {
            FromTime =  "00:00:00";
            ToTime = "00:00:00";
        }
    }
}
