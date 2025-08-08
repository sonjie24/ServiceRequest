using System;
using System.ComponentModel.DataAnnotations;
using AccountManagement.Framework.Models;

//namespace AccountManagement.MicroService.Controllers 
//{
//    public class TopupRouteModel
//    {
//        [Required]
//        public  string amount { get; set; }
//        public  string WalletId  { get; set; }
//        public EStatus Status { get; set; }
//        public TopupRouteModel()
//        {
//            Status = EStatus.Pending;
//        }
//    }

public class Wallet
{
    [Required]
    public string Name { get; set; }
    public string ImagePath { get; set; }
}

//}
