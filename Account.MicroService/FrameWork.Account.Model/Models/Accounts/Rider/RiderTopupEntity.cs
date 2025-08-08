//using System;
//using System.ComponentModel.DataAnnotations.Schema;
//using AccountManagement.Framework.Models;

//namespace AccountManagement.Framework.Models
//{
//    public class RiderTopupEntity:BaseData
//    { 
//        public int RiderId { get; set; }
//        [ForeignKey("RiderId")]
//        public RiderAccountEntity Rider  { get; set; } 
         
//        public int WalletId { get; set; }
//        [ForeignKey("WalletId")]
//        public WalletEntity  Wallet  { get; set; }
//        [Column(TypeName = "decimal(26,6)")]
//        public decimal Amount { get; set; }
//        public EStatus Status { get; set; }
//        public RiderTopupEntity()
//        {
//            Status = EStatus.Active;
//        }
//    }
//}

