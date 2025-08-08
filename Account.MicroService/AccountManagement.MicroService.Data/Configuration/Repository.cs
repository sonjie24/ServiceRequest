using Framework.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Data
{
    public class Repository : IRepository
    {
        private AccountDbContext context;
        public Repository(AccountDbContext context)
        {
            this.context = context;
        }

      async Task<T> IRepository.AddOrUpdate<T>(T model)
        {
             return  await Task.Run(() => {
                 var items = context.Set<T>();
                 if (model.Id == 0)
                 {
                     items.Add(model);
                 }
                 else
                 {
                     items.Update(model);

                     //context.Update(model);
                     //context.Attach(model);
                     //var record = context.Entry(model);
                     //record.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                 }
                 return model;
             });  
        }

        async Task<List<T>> IRepository.FindAll<T>()
        {
            var entities = context.Set<T>();
            return await entities.ToListAsync();
        }
       async  Task<T> IRepository.FindOne<T>(string  guid)
        {
            try
            {
                var entities = context.Set<T>();
                return  await entities.SingleOrDefaultAsync(x => x.GUID ==  guid);
            }
            catch (Exception)
            {
                return null;
            }
        }

       async Task<T> IRepository.FindOneWhere<T>(Expression<Func<T, bool>> expression)
        {
            var entities = context.Set<T>();
            return await entities.FirstOrDefaultAsync(expression);
        }

        async Task<bool> IRepository.Remove<T>(T model)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var entities = context.Set<T>();
                    entities.Remove(model);
                    return true;
                });
            }
            catch (Exception )
            {
                return false; 
            }

        }

        async Task<IQueryable<T>> IRepository.Where<T>(Expression<Func<T, bool>> expression)
        {
            return await Task.Run(() =>
            {
                var entities = context.Set<T>();
                return entities.Where(expression);
            });
        }
    }
}
