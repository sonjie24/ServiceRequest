using AccountManagement.Framework.Core.Interfaces;
using Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core.Managers
{
    public class GenericQueryManager : IGenericQueryManager
    {
        private IUnitOfWork service;
        public GenericQueryManager(IUnitOfWork service)
        {
            this.service = service;
        }
        public async Task<IQueryable<T>> All<T>() where T : class, IEntity, new()
        {
            return (await service.Repository.FindAll<T>()).AsQueryable();
        }

        public async Task<bool> Delete<T>(T model) where T : class, IEntity, new()
        {
            return await service.Repository.Remove(model);
        }
        public async Task<T> FindOne<T>(string  guid) where T : class, IEntity, new()
        {
            return await service.Repository.FindOne<T>(guid);
        } 

        public async Task<IQueryable<T>> Where<T>(Expression<Func<T, bool>> expression) where T : class, IEntity, new()
        {
            return await service.Repository.Where<T>(expression);
        }

       public async  Task<T> AddOrUpdate<T>(T model) where T : class, IEntity, new()
        {
            try
            {
                return await service.Repository.AddOrUpdate(model);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public  async  Task<int> CommitChanges()
        {
           return await Task.Run(() => service.SaveChanges());
        }

        async Task<T> IGenericQueryManager.FindOneWhere<T>(Expression<Func<T, bool>> expression)
        {
            return await service.Repository.FindOneWhere<T>(expression);
        }
    }
}
