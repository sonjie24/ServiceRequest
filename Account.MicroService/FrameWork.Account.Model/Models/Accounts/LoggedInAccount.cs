using AccountManagement.Framework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.FrameWork.Models.Models
{
    public class LoggedInAccount :  BaseEntity
    {
        public string ConnectionId { get; set; }
        public string UserId  { get; set; }
        public string UserType  { get; set; }
        public string UserName  { get; set; }
        public string Room  { get; set; }
        public string Status { get; set; }//online offline
    }
}
