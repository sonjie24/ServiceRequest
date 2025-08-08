using Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Framework.Models
{
    public class CategoryEntity : BaseEntity
    {
        public CategoryEntity Parent { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Remarks { get; set; } 

    }
}
