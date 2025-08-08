using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Framework.Models
{
    public class UserLocationLog 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public  int UserId { get; set; }
    }
}
