using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Framework.Models
{
    public class WalletEntity :BaseData
    { 
        [StringLength(150)] 
        public string Name { get; set; }
        public string ImagePath  { get; set; }
        public EStatus Status { get; set; }
        public WalletEntity()
        {
            Status=EStatus.Active;
        }
    }
}

