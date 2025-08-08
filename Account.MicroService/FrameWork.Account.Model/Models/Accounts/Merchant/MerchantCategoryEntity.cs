using Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountManagement.Framework.Models
{
    public class MerchantCategoryEntity : IEntity
    {
        public MerchantCategoryEntity()
        {
            GUID = Guid.NewGuid().ToString();
            Status = EStatus.Active;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GUID { get; set; }
        public EStatus Status { get; set; }

        public int? MerchantStoreId { get; set; }
        public int? CategoryId  { get; set; }

        [ForeignKey("MerchantStoreId")]
        public   MerchantStoreEntity MerchantStore { get; set; }
        [ForeignKey("CategoryId")]
        public   CategoryEntity   Category   { get; set; }
    
    }
}
