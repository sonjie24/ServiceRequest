//using AccountManagement.Framework.Core.Interfaces;
//using AccountManagement.Framework.Core.Messaging;
//using AccountManagement.Framework.Data;
//using AccountManagement.Framework.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace AccountManagement.Framework.Core.Managers
//{
//    public class RiderTopUpManager : IRiderTopUpManager<RiderTopupEntity>
//    {
//        private readonly Database db;
//        private readonly IRiderTokenManager<RiderAccountEntity> tokenManager;
//        private readonly IPublisher publisher  ;

//        public RiderTopUpManager(Database db,
//            IRiderTokenManager<RiderAccountEntity> tokenManager,
//            IPublisher publisher
//        )
//        {
//            this.db = db;
//            this.tokenManager = tokenManager;
//            this.publisher = publisher;
//        }

//        public async Task<bool> AddTopup(RiderAccountEntity model, RiderTopupEntity topup)
//        {
//            using (var command = db.context.Database.BeginTransaction())
//            {
//                try
//                {
//                    //var balance = db.context.RiderTopups.Where(x => x.Status == EStatus.Active && x.RiderId==model.Id).Sum(x => x.Amount);
//                    //if (topup.Status== EStatus.Active)
//                    //{
//                    //    balance += topup.Amount;
//                    //}
//                    //model.TotalCredits = balance;
//                    db.context.RiderAccounts.Update(model);
//                    await db.context.RiderTopups.AddAsync(topup);
//                    await db.context.SaveChangesAsync();
//                    command.Commit();
//                    return true;
//                }
//                catch (Exception ex)
//                {
//                    command.Rollback();
//                    return false;
//                }
//            }
//        }

//        public async Task<IQueryable<RiderTopupEntity>> All()
//        {
//            try
//            {
//                var models = await db.context.RiderTopups
//                    .Include(w=>w.Rider)
//                    .Include(w=>w.Wallet)
//                    .OrderByDescending(x=>x.Id)
//                    .ToListAsync();
//                return models.AsQueryable();
//            }
//            catch (Exception)
//            {
//                return null;
//            }
//        }

//        public async Task<bool> Delete(string Id)
//        {
//            using (var command = db.context.Database.BeginTransaction())
//            {
//                try
//                {
//                    var item = await db.context.RiderTopups
//                      .FirstOrDefaultAsync(x => x.GUID == Id);
//                    if (item == null) return false;
//                    if (item.Status==EStatus.Active)
//                    {
//                        item.Rider.TotalCredits -= item.Amount;
//                    }
//                    db.context.RiderAccounts.Update(item.Rider);
//                    db.context.RiderTopups.Remove(item);
//                    db.context.SaveChanges();
//                    command.Commit();
//                    return true;
//                }
//                catch (Exception ex)
//                {
//                    command.Rollback();
//                    return false;
//                }
//            }
//        }

//        public async Task<RiderTopupEntity> FindOne(string Id)
//        {
//            try
//            {
//                var model = await db.context .RiderTopups
//                    .Include(w => w.Rider)
//                    .Include(w => w.Wallet)
//                    .SingleOrDefaultAsync(x => x.GUID == Id);
//                return model ?? null;
//            }
//            catch (Exception)
//            {
//                return null;
//            }
//        } 
//        public async Task<ResultViewModel> GetBalance(RiderAccountEntity account, WalletEntity  wallet )
//        {
//            try
//            {
//                     var topup = await db.context.RiderTopups
//                     .Where(x => x.WalletId == wallet.Id
//                       && x.RiderId == account.Id
//                       && (x.Status == EStatus.Active || x.Status == EStatus.Pending))
//                      .ToListAsync();

//                var model = new
//                {
//                    Current = topup.Where(x=>x.Status==EStatus.Active).Sum(x=>x.Amount),
//                    Pending = topup.Where(x=>x.Status==EStatus.Pending).Sum(x => x.Amount),
//                }; 

//                return new ResultViewModel { ResultObject= model, ResultEnum =Result.Success.ToString(), ResultMessage= "Success" };
//            }
//            catch (Exception ex)
//            {
//                return new ResultViewModel {  ResultEnum = Result.Failed.ToString(), ResultMessage = "Failed" };
//            }
//        }
    
//        public Task<bool> Update(RiderTopupEntity model)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> UpdateTopUpStatus(RiderTopupEntity topupModel)
//        {
//            using (var command = db.context.Database.BeginTransaction())
//            {
//                try
//                {
//                    //db.context.RiderAccounts.Update(model);
//                    db.context.RiderTopups.Update(topupModel);
//                    await db.context.SaveChangesAsync();
//                    var account = await db.context.RiderAccounts.FindAsync(topupModel.RiderId);
//                    var balance = db.context.RiderTopups.Where(x => x.Status == EStatus.Active && x.RiderId == topupModel.RiderId).Sum(x => x.Amount);
//                    account.TotalCredits = balance;
//                    db.context.RiderAccounts.Update(account);
//                    await db.context.SaveChangesAsync();
//                    command.Commit();
//                    return true;
//                }
//                catch (Exception ex)
//                {
//                    command.Rollback();
//                    return false;
//                }
//            }
//        }

//        public async Task<IQueryable<RiderTopupEntity>> Where(Expression<Func<RiderTopupEntity, bool>> expression)
//        {
//            try
//            {
//                return await Task.Run(() =>
//                {
//                    var models = db.context.RiderTopups
//                     .Include(w => w.Rider)
//                     .Include(w => w.Wallet)
//                     .Where(expression);
//                    return models;
//                });
//            }
//            catch (Exception)
//            {
//                return null;
//            }
//        } 
//    }
//}
