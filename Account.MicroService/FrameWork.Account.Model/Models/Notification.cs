using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Framework.Models
{
    public class Notification
    {
        public int UserId { get; set; }   
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }      

    }
}
