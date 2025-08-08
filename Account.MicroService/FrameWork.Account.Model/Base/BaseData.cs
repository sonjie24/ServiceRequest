using System;
using TimeZoneConverter;

namespace AccountManagement.Framework.Models
{

    public class BaseData : BaseEntity
    {
        private static DateTime getDateNow()
        {
            var timeZoneInfo = TZConvert.GetTimeZoneInfo("Taipei Standard Time");// TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
        }

        public BaseData()
        {
            DateCreated =   getDateNow(); 
        }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
    }
}
