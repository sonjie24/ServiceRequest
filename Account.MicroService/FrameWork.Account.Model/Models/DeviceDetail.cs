using Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Framework.Models 
{ 
    public class RiderDevice  : DeviceDetail
    {
    }
    public class DeviceDetail  :IEntity
    {
        public DeviceDetail()
        {
            GUID = Guid.NewGuid().ToString();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GUID { get; set; }
        [ForeignKey("RiderId")]
        public RiderAccountEntity Rider { get; set; }
        public int RiderId { get; set; }
        [StringLength(100)]
        public string Brand { get; set; }
        [StringLength(100)]
        public string Model  { get; set; }
    }
}
