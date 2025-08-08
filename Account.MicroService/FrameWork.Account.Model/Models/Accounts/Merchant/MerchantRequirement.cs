using AccountManagement.Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountManagement.FrameWork.Models 
{
  public  class MerchantRequirement:BaseData
    {
        public string MerchantId { get; set; }
        [StringLength(100)]
        public string DocumentName { get; set; }
        public string ImagePath { get; set; }
    }
}
