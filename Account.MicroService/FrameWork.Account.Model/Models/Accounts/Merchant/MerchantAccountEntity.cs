using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountManagement.Framework.Models
{
    [Table("Account_Merchants")]
    public  class  MerchantAccountEntity: UserAccountBase
    {
        public int MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public MerchantStoreEntity  Merchant   { get; set; }
        public string Password { get; set; }
        [StringLength(12)]
        public string MobileNumber { get; set; }
        [StringLength(100)]
        public string EmailAddress { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }

        public string UserType { get; set; }
        public string StaffId  { get; set; }

        public bool   IsSocial { get; set; }
        public string SocialId { get; set; }
        [StringLength(100)]
        public string ImagePath { get; set; }
        public EStatus Status { get; set; }
        public MerchantAccountEntity()
        { 
            IsSocial = false;
            Status = EStatus.Pending;
            IsAccountConfirmed = false;
        }
    }
}
