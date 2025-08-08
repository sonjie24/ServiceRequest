using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Framework.Data.Repository
{
    public interface IRepository
    {
        Task<T> AddOrUpdate<T>(T model) where T:class,IEntity,new();
        Task<bool> Remove<T>(T model) where T : class, IEntity, new();
        Task<List<T>>   FindAll<T>() where T : class, IEntity, new();
        Task<T> FindOne<T>(string guid ) where T : class, IEntity, new();
        Task<IQueryable<T>>  Where<T>(Expression<Func<T, bool>> expression) where T : class, IEntity, new();
        Task<T>  FindOneWhere<T>(Expression<Func<T, bool>> expression) where T : class, IEntity, new();
    }
}
