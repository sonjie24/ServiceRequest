using System;
namespace Framework.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
          IRepository  Repository { get; set; }
          int SaveChanges(); 
    }
}
