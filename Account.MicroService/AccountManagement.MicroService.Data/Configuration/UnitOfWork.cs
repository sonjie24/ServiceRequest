using Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Framework.Data
{
   public  class UnitOfWork : IUnitOfWork
    {
        public AccountDbContext context { get; set; }
        public IRepository Repository { get; set; }
        public UnitOfWork(AccountDbContext context )
        {
            this.context = context;
            Repository =  new Repository(context);
        } 
        public void Dispose()
        {
            context.Dispose();
        }
        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
