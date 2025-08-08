using Framework.Data.Repository;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeZoneConverter;

namespace AccountManagement.Framework.Models
{
    public class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            GUID = Guid.NewGuid().ToString();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GUID { get; set; }
    }

    public class BaseEntityWithCreated : BaseEntity
    {
        private static DateTime getDateNow()
        {
            var timeZoneInfo = TZConvert.GetTimeZoneInfo("Taipei Standard Time");// TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
        }
        public BaseEntityWithCreated()
        {
            DateCreated = getDateNow();  ;
        }
        public DateTime DateCreated  { get; set; }
    }

}
