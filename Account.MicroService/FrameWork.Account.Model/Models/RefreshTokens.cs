using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Framework.Models
{
    public abstract class RefreshTokens
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string userGuid { get; set; }
        [StringLength(100)]
        public string JwtId { get; set; }
        public string Token { get; set; } 
        public DateTime Creation { get; set; }
        public DateTime Expirydate { get; set; }
        public bool Used { get; set; }
        public bool Invalidated { get; set; }
    }
    public class RefreshTokenAdmin : RefreshTokens
    {
      
    }
    public class RefreshTokenConsumer : RefreshTokens
    {
    }
    public class RefreshTokenRider : RefreshTokens
    { 
    }
    public class RefreshTokenMerchant : RefreshTokens
    {
    }
}
