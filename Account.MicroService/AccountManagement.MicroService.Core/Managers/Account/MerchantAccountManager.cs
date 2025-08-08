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
    public class MerchantAccountManager : IMerchantAccountManager<MerchantAccountEntity>
    {
        private readonly Database db;
        private readonly IMerchantTokenManager<MerchantAccountEntity> tokenManager;

        public MerchantAccountManager( 
            Database db, IMerchantTokenManager<MerchantAccountEntity> tokenManager
        )
        {
            this.db = db;
            this.tokenManager = tokenManager;
        } 
         
        public async Task<ResultViewModel> Register(MerchantAccountEntity model)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {

                    //db.context.MerchantStores.Update(model.Merchant);
                    model.Password = PasswordHasher.HashPassword(model.Password, PasswordHasher.GenerateSalt());
                    await db.context.MerchantAccounts.AddAsync(model);
                    await db.context.SaveChangesAsync ();
                   
                    db.context.PasswordMerchants.Add(new PasswordMerchant()
                    {
                        Password = model.Password,
                        UserId = model.GUID,
                    });

                    await db.context.SaveChangesAsync(); 
                    var tokenres = await  tokenManager.GenerateAuthenticationAsync(model);
                    if (tokenres == null)
                    {
                        command.Rollback();
                        return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_TOKEN_ERROR };
                    }

                    IMessage<Mail> message = new VerificationEmailService();
                    string body = $"";

                    var iSsuccess = await message.send(new Mail()
                    {
                            body = body,
                            header = "Confirm your Account",
                            subject = "Account Confirmation",
                            receipientEmail = model.EmailAddress,
                            receipientName = model.FirstName, 
                            linkUrl = $"https://pf-account-service-staging.azurewebsites.net/api/v1/m-verify-account/{model.GUID}"
                    },tokenres.AccessToken); 

                            //linkUrl = $"https://pf-account-service-staging.azurewebsites.net/api/v1/m-verify-account/{model.GUID}"

                    if (iSsuccess)
                    {
                        command.Commit();
                        var returnModel = new TokenModel()
                        {
                            AccessToken = tokenres.AccessToken,
                            RefreshToken = tokenres.RefreshToken,
                            UserId = model.GUID 
                        };
                        return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };
                    }
                    else
                    {
                        command.Rollback();
                        return new ResultViewModel() { ResultObject = true, ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST };
                    }
 
                }
                catch (Exception ex)
                {
                    command.Rollback();
                    return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
                }
            }
        }

        public async Task<ResultViewModel> Login(MerchantAccountEntity model)
        {
            try
            {
                var userAccount =  new MerchantAccountEntity();
                if (model.IsSocial)
                    userAccount = await db.context.MerchantAccounts.FirstOrDefaultAsync(u => u.SocialId == model.SocialId);
                else
                    userAccount = await db.context.MerchantAccounts.FirstOrDefaultAsync(u => u.EmailAddress == model.EmailAddress );

                if (userAccount == null) return new ResultViewModel() { ResultObject = false, ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS };
                var checkStore = await db.context.MerchantStores.SingleOrDefaultAsync(x => x.Id == userAccount.MerchantId);
                if (checkStore.Status==EStatus.Cancelled) return new ResultViewModel() { ResultObject = false, ResultMessage = "Mechant is currently not activated."};
                //if (checkStore.Status!=EStatus.Active) return new ResultViewModel() { ResultObject = false, ResultMessage = "Mechant is currently not activated."};
                //if (userAccount.Status !=  EStatus.Active) return new ResultViewModel() { ResultObject = false, ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_ACTIVE};
                bool IsPasswordValid = PasswordHasher.Verify(model.Password, userAccount.Password);
                if (!IsPasswordValid) return new ResultViewModel() { ResultObject = false, ResultMessage = Constants.MESSAGE_INVALID_PASSWORD};

                var userGuid = userAccount.GUID;
                var tokenres = await tokenManager.GenerateAuthenticationAsync ( userAccount);
                if (tokenres == null)
                    return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_TOKEN_ERROR };

                var returnModel = new TokenModel()
                {
                    AccessToken = tokenres.AccessToken,
                    RefreshToken = tokenres.RefreshToken,
                    UserId =  userGuid
                };
                return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
            }
        }

        public async Task<bool> Update(MerchantAccountEntity model)
        {
            try
            {
                //db.context.MerchantStores.Update(model.Merchant);
                db.context.MerchantAccounts.Update(model);
                await db.context.SaveChangesAsync();
                return  true;
            }
            catch ( Exception  )
            {
                return   false;
            }
        }

        public async Task<MerchantAccountEntity> FindOne(string Id)
        {
            try
            {
                var model = await db.context.MerchantAccounts
                    .Include(m=>m.Merchant)
                    .SingleOrDefaultAsync(x=>x.GUID==Id);
                return model ?? null;
            }
            catch (Exception)
            {
                return null;
            }     
        }

        public async Task<IQueryable<MerchantAccountEntity>> Where(Expression<Func<MerchantAccountEntity, bool>> expression)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var models = db.context.MerchantAccounts
                    .Include(m=>m.Merchant )
                    .Where(expression);
                    return models;
                });
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IQueryable<MerchantAccountEntity>> All()
        {
            try
            {
                return await Task.Run(() =>
                {
                    var models = db.context.MerchantAccounts
                    .Include(m=>m.Merchant);
                    return models;
                });
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> Delete(string Id)
        {
            using(var command=db.context.Database.BeginTransaction())
            {
                try
                {
                    var account = await db.context.MerchantAccounts.SingleOrDefaultAsync(x => x.GUID == Id);
                    db.context.MerchantAccounts.Remove(account);
                    db.context.SaveChanges();


                    var tokens = db.context.RefreshTokenMerchants.Where(x => x.userGuid == Id);
                    foreach (var item in tokens)
                    {
                        item.Invalidated = true;
                        db.context.RefreshTokenMerchants.Update(item);
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

        public async Task<bool> ActivateAccount(string guid)
        {
            //verification for store-admin user
            var model =await db.context.MerchantAccounts 
                .SingleOrDefaultAsync(x => x.GUID == guid);

            if (model == null) return false;
            if (model.Status != EStatus.Pending) return true;

            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    model.IsAccountConfirmed =  true;
                    model.Status = EStatus.Active;
                    db.context.MerchantAccounts.Update(model);
                    db.context.SaveChanges();
                    await command.CommitAsync();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task< PasswordMerchant> OldPassword(PasswordMerchant model)
        {
            return await db.context.PasswordMerchants.Where(x => x.Password == model.Password).SingleOrDefaultAsync();
        }

        public bool IsOldPasswordUsed(string UserId, string newPassword)
        {
            try
            {
                var oldPass = db.context.PasswordMerchants.Where(pass => pass.UserId == UserId );
                if (oldPass.Count() == 0) return false;
                else
                {
                    //record exists, verify if new pass==old pass
                    foreach (var x in oldPass)
                    {
                        var IsPasswordValid = PasswordHasher.Verify(newPassword, x.Password);
                        if (IsPasswordValid) return  true;//used
                    }
                    return false;//not use
                }
            }
            catch (Exception)
            {
                return false;//used
            }
        }

        public async Task<bool> SendResetEmail(string EmailAddress,string userGuid,string baseUrl)
        {
            //send email to reset password
            var user = await db.context.MerchantAccounts.FirstOrDefaultAsync(x => x.EmailAddress == EmailAddress);
            if (user == null) return false;
            var tokenres = await tokenManager.GenerateAuthenticationAsync(user);

            IMessage<Mail> message = new ResetAccountMailService();
            string body = $"";
            var items = EmailAddress.Split("@");
            
            var iSsuccess = await message.send(new Mail()
            {
                body = body,
                header = "",
                subject = "Reset Account",
                receipientEmail = EmailAddress,
                receipientName = items[0] ?? "Valued Customer",
                linkUrl = $"{baseUrl}/reset-password?e={EmailAddress}&t={tokenres.AccessToken}"
            },tokenres.AccessToken);
            return iSsuccess;
        }

        public async Task<ResultViewModel> RefreshToken(string AccessToken, string RefreshToken)
        {
            return await tokenManager.RefreshTokenAsync(AccessToken, RefreshToken);
        }


        public async Task<bool> ChangePassword(MerchantAccountEntity model)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    model.Password = PasswordHasher.HashPassword(model.Password, PasswordHasher.GenerateSalt());
                    db.context.MerchantAccounts.Update(model);
                    await db.context.PasswordMerchants.AddAsync(new PasswordMerchant() { Password = model.Password , UserId = model.GUID });
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

        public async Task<ResultViewModel> ResetPassword(MerchantAccountEntity model)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    model.Password = PasswordHasher.HashPassword(model.Password, PasswordHasher.GenerateSalt());
                    db.context.MerchantAccounts.Update(model);
                    await db.context.PasswordMerchants.AddAsync(new PasswordMerchant() { Password = model.Password , UserId = model.GUID });
                    db.context.SaveChanges();

                    var tokenres = await  tokenManager.GenerateAuthenticationAsync( model);
                    if (tokenres == null)
                    {
                        command.Rollback(); 
                        return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST };

                    }

                    await command.CommitAsync();
                    var returnModel = new TokenModel()
                    {
                        AccessToken = tokenres.AccessToken,
                        RefreshToken = tokenres.RefreshToken,
                        UserId = model.GUID.ToString()
                    };
                    return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };
                }
                catch (Exception ex)
                {
                    command.Rollback();
                    return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) };
                }
            }
        }

        public bool VerifyPassword(string PlainPassword, string encryptedPassword)
        {
            return PasswordHasher.Verify(PlainPassword, encryptedPassword);
        }


        public async  Task<ResultViewModel> GetRoleForms( string roleId)
        {


            var roles = db.context.RouteModelRoles.Where(x => x.RoleId == roleId);
            var returnModel =  await( from i in db.context.RouteModels
                              join r in roles on i.RoutePath equals r.RoutePath into ps
                              from ix in ps.DefaultIfEmpty()
                              where ix==null ? true: ix.Action==i.Action
                              select new
                                     {
                                         Selected =  ix == null ? "0" : "1",
                                         RouteName = i.RouteName,
                                         RouteModelId = i.GUID,
                                         RoutePath = i.RoutePath,
                                         Action = i.Action,
                                     } ).ToListAsync();

            return new ResultSuccess(returnModel);
             
        }

        public  async Task<ResultViewModel> GetUserRoles(string userId)
        {

            var data = await (from i in db.context.RouteModelRoles
                               join r in db.context.UserRoles on i.RoleId equals r.RoleId
                               where r.UserId==userId
                               select new { i, r }).ToListAsync();

            var returnModel = data.GroupBy(x => x.r.UserId)
                .Select(x => new { UserId = x.Key, RoleIds = x.Select(xx => xx.r.RoleId).Distinct() });


            return  new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };

        }


        public async Task<ResultViewModel> GetUserRolesForms(string userId)
        {

            var returnModel =  await( from rr in db.context.RouteModelRoles
                                     join ur in db.context.UserRoles on rr.RoleId equals ur.RoleId
                                     join rmm in db.context.RouteModels on  rr.RouteModelId equals rmm.GUID
                                     where ur.UserId==userId
                                     select new
                                     {
                                         RoleId=ur.RoleId,
                                         RouteName = rmm.RouteName,
                                         RoutePath = rr.RoutePath,
                                         RouteModelId = rr.RouteModelId,
                                         Action = rr.Action,
                                     }).ToListAsync();

            return new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS };
        }

    }
}
