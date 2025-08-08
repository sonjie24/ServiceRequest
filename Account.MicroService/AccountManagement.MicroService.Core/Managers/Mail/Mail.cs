using System;
namespace AccountManagement.Framework.Core
{
    public class Mail
    { 
        public string receipientEmail { get; set; }
        public string receipientName { get; set; }
        public string subject { get; set; }
        public string header { get; set; }
        public string body { get; set; }
        public string linkUrl { get; set; }

    }
}
