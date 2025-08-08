using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Framework.Models
{
    public class MerchantStaff:BaseEntity
    {
        public string MerchantId  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string JobDescription { get; set; }
        public bool SetEffectivity { get; set; }
        public DateTime EffectivityDate { get; set; }
        public bool Status { get; set; }

        public MerchantStaff()
        {
            SetEffectivity = false;
            Status = true;
        }
    }
}
