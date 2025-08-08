using AccountManagement.Framework.Models;
using Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountManagement.FrameWork.Models
{
    public class ConsumerFavorites : IEntity
    {
        public ConsumerFavorites()
        {
            GUID = Guid.NewGuid().ToString();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GUID { get; set; }
        public string ConsumerGuid { get; set; }
        public string MerchantGuid { get; set; }

        //public int FavStoreId { get; set; }
        //public int ConsumerId { get; set; }
        //[ForeignKey("FavStoreId")]
        //public MerchantStoreEntity FavStore { get; set; }
        //[ForeignKey("ConsumerId")]
        //public ConsumerAccountEntity Consumer  { get; set; }
    }
}
