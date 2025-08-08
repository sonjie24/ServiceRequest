using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AccountManagement.Framework.Models;

namespace AccountManagement.Framework.Core.Interfaces
{
    public interface  IActions<T>
    {
        Task<bool> Update(T model);
        Task<T> FindOne(string Id);
        Task<bool> Delete(string Id);
        Task<IQueryable<T>> Where(Expression<Func<T, bool>> expression);
        Task<IQueryable<T>> All();

    }
}
