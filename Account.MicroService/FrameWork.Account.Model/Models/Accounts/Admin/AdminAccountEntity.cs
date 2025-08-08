 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace AccountManagement.Framework.Models
{
    [Table("Account_Admin")]
    public   class AdminAccountEntity: UserAccountBase
    {
        public string StaffId { get; set; }
        [StringLength(100)]
        public string Username  { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        [StringLength(12)]
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [StringLength(100)]
        public string JobPosition { get; set; }
        public bool SetEffectivity { get; set; }
        public DateTime ValidUntil { get; set; }

        public RiderDeliveryStat DeliveryStatus  { get; set; }//TODO ??

        public string ImagePath { get; set; }
        public EStatus Status { get; set; }
        public string UserType { get; set; }

        public AdminAccountEntity()
        {
            ValidUntil =  DateTime.UtcNow;
            Status = EStatus.Pending;
            IsAccountConfirmed = false;
        }
    }
}
