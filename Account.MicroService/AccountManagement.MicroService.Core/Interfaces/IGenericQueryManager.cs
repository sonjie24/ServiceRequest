using Framework.Data.Repository;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core.Interfaces
{
    public interface IGenericQueryManager
    {
        Task<int> CommitChanges();
        Task<IQueryable<T>> All<T>() where T : class, IEntity, new();
        Task<bool> Delete<T>(T model) where T : class, IEntity, new();
        Task<T> FindOne<T>(string  guid) where T : class, IEntity, new();
        Task<T> AddOrUpdate<T>(T model) where T : class, IEntity, new();
        Task<IQueryable<T>> Where<T>(Expression<Func<T, bool>> expression) where T : class, IEntity, new();
        Task<T> FindOneWhere<T>(Expression<Func<T, bool>> expression) where T : class, IEntity, new();
    }
}