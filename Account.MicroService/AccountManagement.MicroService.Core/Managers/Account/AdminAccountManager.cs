using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Data;
using AccountManagement.Framework.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Framework.Core.Managers
{
    public class AdminAccountManager : IAdminAccountManager<AdminAccountEntity>
    {
        protected readonly Database db;
        private readonly IAdminTokenManager<AdminAccountEntity> tokenManager;
        public AdminAccountManager(Database db,
            IAdminTokenManager<AdminAccountEntity> tokenManager )
        {
            this.db = db;
            this.tokenManager = tokenManager;
        }


       public async Task<ResultViewModel> Register(AdminAccountEntity model)
        {
               using(var command=db.context.Database.BeginTransaction())
                {
                try
                {
                    model.Password = PasswordHasher.HashPassword(model.Password, PasswordHasher.GenerateSalt());
                    await db.context.AdminAccounts.AddAsync(model);
                    await db.context.SaveChangesAsync(); 
                 
                   db.context.PasswordAdmins.Add(new PasswordAdmin()
                    {
                          Password=model.Password,
                          UserId=model.GUID,
                    });

                    await  db.context.SaveChangesAsync();

                    var tokenres = await tokenManager.GenerateAuthenticationAsync(model);
                    if (tokenres == null)
                    {
                        await command.RollbackAsync();
                        return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST };
                    }

                    await command.CommitAsync();

                   //await publisher.Publish("admin_account", "admin_account", new
                   // {
                   //     Id = model.GUID,
                   //     Status = "Active"
                   // });  

                    var returnModel = new   
                    {
                        AccessToken = tokenres.AccessToken,
                        RefreshToken = tokenres.RefreshToken,
                        UserId = model.GUID 
                    };

                    return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };
                }
                catch (Exception ex)
                {
                    command.Rollback();
                    return new ResultViewModel() { ResultEnum =  Result.Error.ToString(), ResultMessage = ex.Message };
                }
            }
        }

        public async Task<ResultViewModel> Login(AdminAccountEntity model)
        {
            try
            {
                var userAccount = await db.context.AdminAccounts.FirstOrDefaultAsync(u => u.EmailAddress == model.EmailAddress || u.Username == model.Username);
                if (userAccount == null) return new ResultViewModel() { ResultObject = false, ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS };
                if (userAccount.Status!= EStatus.Active) return new ResultViewModel() { ResultObject = false, ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_ACTIVE };
                bool IsPasswordValid = PasswordHasher.Verify(model.Password, userAccount.Password);
                if (!IsPasswordValid) return new ResultViewModel() { ResultObject = false, ResultMessage = Constants.MESSAGE_INVALID_PASSWORD };
                var userGuid = userAccount.GUID;
                var tokenres = await tokenManager.GenerateAuthenticationAsync(userAccount);
                if (tokenres == null) return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_TOKEN_ERROR };
                var returnModel = new TokenModel()
                {
                    AccessToken = tokenres.AccessToken,
                    RefreshToken = tokenres.RefreshToken,
                    UserId = userGuid
                }; 
                return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };
          
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) };
            }
        }

        public async Task<bool> Update(AdminAccountEntity model)
        {
            try
            {
                db.context.AdminAccounts.Update(model);
                await db.context.SaveChangesAsync();
                return true;
            }
            catch (Exception  )
            {
                return false;
            }
        }

        public async Task<AdminAccountEntity> FindOne(string Id)
        {
            try
            {
                var model = await db.context.AdminAccounts .SingleOrDefaultAsync(x=>x.GUID==Id);
                return model ?? null;
            }
            catch ( Exception  )
            {
                return null;
            }
        }

        public async Task<IQueryable<AdminAccountEntity>> Where(Expression<Func<AdminAccountEntity, bool>> expression)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var models = db.context.AdminAccounts.Where(expression);
                    return models;
                });
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IQueryable<AdminAccountEntity>> All()
        {
            try
            {
                return await Task.Run(() =>
                {
                    var models = db.context.AdminAccounts.ToList().AsQueryable();
                    return models;
                });
            }
            catch (Exception)
            {
                return null;
            }
        }  

        async Task<bool> IActions<AdminAccountEntity>.Delete(string Id)
        {
            using(var command=db.context.Database.BeginTransaction())
            {
                try
                {
                    var account = await db.context.AdminAccounts.SingleOrDefaultAsync(x => x.GUID == Id);
                     

                    db.context.AdminAccounts.Remove(account);
                    db.context.SaveChanges();

                    var tokens = db.context.RefreshTokenAdmins.Where(x => x.userGuid == Id);
                    foreach (var item in tokens)
                    {
                        item.Invalidated = true;
                        db.context.RefreshTokenAdmins.Update(item);
                    }

                    command.Commit();
                    return true;
                }
                catch (Exception  )
                {
                    command.Rollback();
                    return false;
                }
            }
          
        }

        public bool IsOldPasswordUsed(string UserId, string newPassword )
        {
            try
            {
                var oldPass = db.context.PasswordAdmins.Where(pass => pass.UserId == UserId);
                if (oldPass.Count() == 0) return  false;
                else
                {
                    //record exists, verify if new pass==old pass
                    foreach (var x in oldPass)
                    {
                        var IsMatch = PasswordHasher.Verify(newPassword, x.Password);
                        if (IsMatch) return  true;//used
                    }
                    return  false;//not use
                }
            }
            catch (Exception)
            {
                return true;//used
            }
        }

        public async Task<bool> SendResetEmail(string EmailAddress,string userGuid,string baseUrl )
        {
            try
            {
                //send email to reset password
                var user = await db.context.AdminAccounts.FirstOrDefaultAsync(x => x.EmailAddress == EmailAddress);
                if (user == null) return false;
                var tokenres = await tokenManager.GenerateAuthenticationAsync(user);

                IMessage<Mail> message = new ResetAccountMailService();
                var items = EmailAddress.Split("@");
                var iSsuccess = await message.send(new Mail()
                {
                    receipientEmail = EmailAddress,
                    receipientName = items[0] ?? "Admin User",
                    linkUrl = $"{baseUrl}/reset-password?e={EmailAddress}&t={tokenres.AccessToken}"
                }, tokenres.AccessToken);
                return iSsuccess;
            }
            catch (Exception  )
            {
                return false;
            }

        }

        public async Task<ResultViewModel> RefreshToken(string AccessToken, string RefreshToken)
        {
            return await tokenManager.RefreshTokenAsync(AccessToken, RefreshToken);
        }

        public async Task<bool> ChangePassword(AdminAccountEntity model)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    model.Password = PasswordHasher.HashPassword(model.Password, PasswordHasher.GenerateSalt());
                    db.context.AdminAccounts.Update(model);
                    await db.context.PasswordAdmins.AddAsync(new PasswordAdmin() { Password = model.Password, UserId = model.GUID });
                    db.context.SaveChanges();
                    command.Commit();
                    return true;
                }
                catch (Exception  )
                {
                    command.Rollback();
                    return false;
                }
            }
        }

        public async Task<ResultViewModel> ResetPassword(AdminAccountEntity model)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    model.Password = PasswordHasher.HashPassword(model.Password, PasswordHasher.GenerateSalt());
                    db.context.AdminAccounts.Update(model);
                    db.context.SaveChanges();

                    await db.context.PasswordAdmins.AddAsync(new PasswordAdmin() { Password = model.Password,  UserId = model.GUID });
                    //generate token

                    var tokenres = await tokenManager.GenerateAuthenticationAsync(model);
                    if (tokenres == null)
                    {
                        await command.RollbackAsync();
                        return new ResultViewModel() { ResultEnum = Result.Failed.ToString(),  ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST };
                    }
                    await command.CommitAsync();
                    var returnModel = new TokenModel()
                    {
                        AccessToken = tokenres.AccessToken,
                        RefreshToken = tokenres.RefreshToken,
                        UserId = model.GUID
                    };
                   return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };
               }
                catch (Exception ex)
                {
                    command.Rollback();
                    return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage =  Constants.GET_ERROR(ex) };
                }
            }
        }

        public bool VerifyPassword(string PlainPassword, string encryptedPassword)
        {
            return PasswordHasher.Verify(PlainPassword, encryptedPassword);
        }

        public async Task<ResultViewModel> GetRoleForms(string roleId)
        {

            var roles = db.context.AdminRouteModelRoles.Where(x => x.RoleId == roleId);
            var returnModel = await (from i in db.context.AdminRouteModels
                                     join r in roles on i.RoutePath equals r.RoutePath into ps
                                     from ix in ps.DefaultIfEmpty()
                                     where ix == null ? true : ix.Action == i.Action
                                     select new
                                     {
                                         Selected = ix == null ? "0" : "1",
                                         RouteName = i.RouteName,
                                         RouteModelId = i.GUID,
                                         RoutePath = i.RoutePath,
                                         Action = i.Action,
                                     }).ToListAsync();

            return new ResultSuccess(returnModel);
        }

      


        public async Task<ResultViewModel> GetUserRoles(string userId)
        {

            var data = await (from i in db.context.RouteModelRoles
                              join r in db.context.UserRoles on i.RoleId equals r.RoleId
                              where r.UserId == userId
                              select new { i, r }).ToListAsync();

            var returnModel = data.GroupBy(x => x.r.UserId)
                .Select(x => new { UserId = x.Key, RoleIds = x.Select(xx => xx.r.RoleId).Distinct() });


            return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };

        }

        public async Task<ResultViewModel> GetUserRolesForms(string userId)
        {

            var returnModel = await (from rr in db.context.AdminRouteModelRoles
                                     join ur in db.context.AdminUserRoles on rr.RoleId equals ur.RoleId
                                     join rmm in db.context.AdminRouteModels on rr.RouteModelId equals rmm.GUID
                                     select new
                                     {
                                         RoleId = ur.RoleId,
                                         RouteName = rmm.RouteName,
                                         RoutePath = rr.RoutePath,
                                         RouteModelId = rr.RouteModelId,
                                         Action = rr.Action,
                                     }).ToListAsync();

            return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };
        }

    }
}
