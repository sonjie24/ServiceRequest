using AccountManagement.FrameWork.Models;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace AccountManagement.Framework.Models
{
    [Table("Account_Consumer")]
    public class ConsumerAccountEntity:UserAccountBase
    {
        [StringLength(12)]
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        public string DeviceId { get; set; }
        public double Rating { get; set; }
        public int    RatingCount { get; set; }
        public bool   IsSocial { get; set; }
        public string SocialId { get; set; } 
        public string ImagePath { get; set; }
        [NotMapped]
        public string AppCode { get; set; }
        public int OrderCount { get; set; }


        public List<ConsumerAddressBookEntity> Addresses  { get; set; }
        public List<ConsumerFavorites> Favorites  { get; set; }
        public ConsumerStatus Status { get; set; }

        public ConsumerAccountEntity()
        {
            Addresses = new List<ConsumerAddressBookEntity>();
            Favorites = new List<ConsumerFavorites>();
            Status = ConsumerStatus.Pending;
            IsAccountConfirmed = false;
        }
    }
}
