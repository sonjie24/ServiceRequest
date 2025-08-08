using System;
namespace Framework.Data.Repository 
{
    public interface IEntity
    {
          int Id { get; set; }
          string GUID { get; set; }
    }
}
