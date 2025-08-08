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
    public class RiderAccountManager : IRiderAccoutManager<RiderAccountEntity>
    {
        private readonly Database db;

        private readonly IRiderTokenManager<RiderAccountEntity> tokenManager;

        public RiderAccountManager(
            Database db,
            IRiderTokenManager<RiderAccountEntity> tokenManager
        )
        {
            this.db = db;
            this.tokenManager = tokenManager;
        }

        public async Task<ResultViewModel> Register(RiderAccountEntity model)
        {
            try
            {
                using (var command = db.context.Database.BeginTransaction())
                {
                    try
                    {
                        model.Password = PasswordHasher  .HashPassword(model.Password, PasswordHasher.GenerateSalt());
                        await db.context.RiderAccounts.AddAsync(model); //add rider account
                        await db.context.SaveChangesAsync(); //save to get generated Id

                        db.context.PasswordRiders
                            .Add(new PasswordRider()
                            { Password = model.Password, UserId = model.GUID });

                        await db.context.SaveChangesAsync();
                        var tokenres = await tokenManager  .GenerateAuthenticationAsync(model);
                        if (tokenres == null)
                        {
                            command.Rollback();
                            return new ResultViewModel()
                            {
                                ResultEnum = Result.Failed.ToString(),
                                ResultObject = null,
                                ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                            };
                        }

                        await command.CommitAsync(); //commit all changes
                        var returnModel =
                            new TokenModel()
                            {
                                AccessToken = tokenres.AccessToken,
                                RefreshToken = tokenres.RefreshToken,
                                UserId = model.GUID
                            };
                        return new ResultViewModel()
                        {
                            ResultEnum = Result.Success.ToString(),
                            ResultObject = returnModel,
                            ResultMessage = Constants.MESSAGE_SUCCESS
                        };
                    }
                    catch (Exception)
                    {
                        await command.RollbackAsync();
                        return new ResultViewModel()
                        {
                            ResultObject = true,
                            ResultMessage =
                                Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                        };
                    }
                }
            }
            catch (Exception)
            {
                return new ResultViewModel()
                {
                    ResultObject = true,
                    ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                };
            }
        }

        public async Task<ResultViewModel> RegisterV2(RiderAccountEntity model)
        {
            try
            {
                using (var command = db.context.Database.BeginTransaction())
                {
                    try
                    {
                        model.Password = PasswordHasher  .HashPassword(model.Password, PasswordHasher.GenerateSalt());
                        await db.context.RiderAccounts.AddAsync(model); //add rider account
                        await db.context.SaveChangesAsync(); //save to get generated Id

                        db.context.PasswordRiders
                            .Add(new PasswordRider()
                            { Password = model.Password, UserId = model.GUID });

                        await db.context.SaveChangesAsync();
                        var tokenres = await tokenManager  .GenerateAuthenticationAsync(model);
                        if (tokenres == null)
                        {
                            command.Rollback();
                            return new ResultViewModel()
                            {
                                ResultEnum = Result.Failed.ToString(),
                                ResultObject = null,
                                ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                            };
                        }

                        await command.CommitAsync(); //commit all changes

                        var result = new
                        {
                            userId = model.GUID,
                            Email = model?.EmailAddress,
                            MobileNumber = model?.MobileNumber,
                            FirstName = model?.FirstName,
                            MiddleName = model?.MiddleName,
                            LastName = model?.LastName,
                            FullName = Common.GetCompleteName("", model.FirstName, model.MiddleName, model.LastName, "", true),
                            Limit = model.LimitAmount,
                            Rating = model.Rating / model.RatingCount == 0 ? 1 : model.RatingCount,
                            Latitude = model?.Latitude,
                            Longitude = model?.Longitude,

                            Status = model.Status.ToString(),
                            DeliveryStatus = model.DeliveryStatus.ToString(),
                            m_status = model.RiderOnlineOffline.ToString(),

                            IsAccountConfirmed = model.IsAccountConfirmed,
                            IsDocsComplied = model.IsDocsComplied,

                            ImagePath = model.ImagePath,
                            StartTime = DateTime.Today,
                            TotalTime = model.TotalTime,
                            ExistingCredits = model.TotalCredits,
                            TripsCount = model.TripsCount,
                            TotalEarnings = model.TotalEarnings,
                            TotalHours = model.TotalHours,
                            TotalKms = model.TotalKms,
                            Address = model.profile?.Address1,
                            TransportType = model.profile?.TransportType,
                            yearModel = model.profile?.yearModel,
                            Make = model.profile?.Make,
                            Model = model.profile?.Model,
                            PlateNo = model.profile?.PlateNo,
                            Color = model.profile?.Color,

                            AccessToken = tokenres.AccessToken,
                            RefreshToken = tokenres.RefreshToken,
                            UserId = model.GUID
                        };

                        return new ResultViewModel()
                        {
                            ResultEnum = Result.Success.ToString(),
                            ResultObject = result,
                            ResultMessage = Constants.MESSAGE_SUCCESS
                        };
                    }
                    catch (Exception)
                    {
                        await command.RollbackAsync();
                        return new ResultViewModel()
                        {
                            ResultObject = true,
                            ResultMessage =
                                Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                        };
                    }
                }
            }
            catch (Exception)
            {
                return new ResultViewModel()
                {
                    ResultObject = true,
                    ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                };
            }
        }

        public async Task<ResultViewModel> Login(RiderAccountEntity model)
        {
            try
            {
                var userAccount =
                    await db
                        .context
                        .RiderAccounts
                        .Include(p => p.profile)
                        .FirstOrDefaultAsync(u =>
                            u.MobileNumber == model.MobileNumber);

                if (userAccount == null)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS
                    };
                if (
                    userAccount.Status == RiderStatus.Blocked ||
                    userAccount.Status == RiderStatus.Cancelled
                )
                    return new ResultViewModel()
                    {
                        ResultEnum = Result.Failed.ToString(),
                        ResultMessage =
                            "Unable to login your account,Contact administrator"
                    };

                bool IsPasswordValid =  PasswordHasher.Verify(model.Password, userAccount.Password);
                if (!IsPasswordValid)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultMessage = Constants.MESSAGE_INVALID_PASSWORD
                    };

                var userGuid = userAccount.GUID;
                var tokenres =
                    await tokenManager.GenerateAuthenticationAsync(userAccount);
                if (tokenres == null)
                    return new ResultViewModel()
                    {
                        ResultEnum = Result.Failed.ToString(),
                        ResultObject = null,
                        ResultMessage = Constants.MESSAGE_TOKEN_ERROR
                    };

                var returnModel =
                    new TokenModel()
                    {
                        AccessToken = tokenres.AccessToken,
                        RefreshToken = tokenres.RefreshToken,
                        UserId = userGuid
                    };

                return new ResultViewModel()
                {
                    ResultEnum = Result.Success.ToString(),
                    ResultObject = returnModel,
                    ResultMessage = Constants.MESSAGE_SUCCESS
                };
            }
            catch (Exception)
            {
                return new ResultViewModel()
                {
                    ResultObject = false,
                    ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                };
            }
        }
         

        public async Task<ResultViewModel> LoginV2(RiderAccountEntity model)
        {
            try
            {
                var userAccount =
                    await db
                        .context
                        .RiderAccounts
                        .Include(p => p.profile)
                        .FirstOrDefaultAsync(u =>
                            u.MobileNumber == model.MobileNumber);

                if (userAccount == null)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS
                    };
                if (
                    userAccount.Status == RiderStatus.Blocked ||
                    userAccount.Status == RiderStatus.Cancelled
                )
                    return new ResultViewModel()
                    {
                        ResultEnum = Result.Failed.ToString(),
                        ResultMessage =
                            "Unable to login your account,Contact administrator"
                    };

                bool IsPasswordValid = PasswordHasher.Verify(model.Password, userAccount.Password);
                if (!IsPasswordValid)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultMessage = Constants.MESSAGE_INVALID_PASSWORD
                    };

                var userGuid = userAccount.GUID;
                var tokenres =
                    await tokenManager.GenerateAuthenticationAsync(userAccount);
                if (tokenres == null)
                    return new ResultViewModel()
                    {
                        ResultEnum = Result.Failed.ToString(),
                        ResultObject = null,
                        ResultMessage = Constants.MESSAGE_TOKEN_ERROR
                    };

                var result = new
                {
                    userId = model.GUID,
                    Email = model?.EmailAddress,
                    MobileNumber = model?.MobileNumber,
                    FirstName = model?.FirstName,
                    MiddleName = model?.MiddleName,
                    LastName = model?.LastName,
                    FullName = Common.GetCompleteName("", model.FirstName, model.MiddleName, model.LastName, "", true),
                    Limit = model.LimitAmount,
                    Rating = model.Rating / model.RatingCount == 0 ? 1 : model.RatingCount,
                    Latitude = model?.Latitude,
                    Longitude = model?.Longitude,

                    Status = model.Status.ToString(),
                    DeliveryStatus = model.DeliveryStatus.ToString(),
                    m_status = model.RiderOnlineOffline.ToString(),

                    IsAccountConfirmed = model.IsAccountConfirmed,
                    IsDocsComplied = model.IsDocsComplied,

                    ImagePath = model.ImagePath,
                    StartTime = DateTime.Today,
                    TotalTime = model.TotalTime,
                    ExistingCredits = model.TotalCredits,
                    TripsCount = model.TripsCount,
                    TotalEarnings = model.TotalEarnings,
                    TotalHours = model.TotalHours,
                    TotalKms = model.TotalKms,
                    Address = model.profile?.Address1,
                    TransportType = model.profile?.TransportType,
                    yearModel = model.profile?.yearModel,
                    Make = model.profile?.Make,
                    Model = model.profile?.Model,
                    PlateNo = model.profile?.PlateNo,
                    Color = model.profile?.Color,

                    AccessToken = tokenres.AccessToken,
                    RefreshToken = tokenres.RefreshToken,
                    UserId = userGuid,

                 };

                return new ResultViewModel()
                {
                    ResultEnum = Result.Success.ToString(),
                    ResultObject = result,
                    ResultMessage = Constants.MESSAGE_SUCCESS
                };
            }
            catch (Exception)
            {
                return new ResultViewModel()
                {
                    ResultObject = false,
                    ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                };
            }
        }

        public async Task<bool> Update(RiderAccountEntity model)
        {
            try
            {
                //  db.context.PersonProfile.Update(model.profile);
                db.context.RiderAccounts.Update (model);
                await db.context.SaveChangesAsync();
                return true;
            }
            catch (Exception  )
            {
                return false;
            }
        }

        public async Task<RiderAccountEntity> FindOne(string Id)
        {
            try
            {
                var model =
                    await db
                        .context
                        .RiderAccounts
                        .Include(x => x.profile)
                        //.Include(x => x.DefaultWallet)
                        .SingleOrDefaultAsync(x => x.GUID == Id);

                return model ?? null;
            }
            catch (Exception  )
            {
                return null;
            }
        }

        public async Task<IQueryable<RiderAccountEntity>>
        Where(Expression<Func<RiderAccountEntity, bool>> expression)
        {
            try
            {
                return await Task
                    .Run(() =>
                    {
                        var models =
                            db
                                .context
                                .RiderAccounts
                                .Include(p => p.profile)
                                //.Include(p => p.DefaultWallet)
                                .Where(expression);
                        return models;
                    });
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IQueryable<RiderAccountEntity>> All()
        {
            try
            {
                return await Task
                    .Run(() =>
                    {
                        var models =
                            db
                                .context
                                .RiderAccounts
                                .Include(p => p.profile);

                                //.Include(w => w.DefaultWallet);
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
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    var account =
                        await db
                            .context
                            .RiderAccounts
                            .SingleOrDefaultAsync(x => x.GUID == Id);
                    var profile =
                        db.context.PersonProfile.Where(x => x.Rider == account);

                    //remove ratings and topups
                    //var topups =
                    //    db.context.RiderTopups.Where(x => x.Rider == account);
                    //if (topups.Count() > 0)
                    //    db.context.RiderTopups.RemoveRange(topups);

                    //var ratings = db.context.RiderToMerchantRatingEntities.Where(x => x.RiderId == account.GUID);
                    //if(ratings.Count()>0) db.context.RiderToMerchantRatingEntities.RemoveRange(ratings);
                    //invalidate tokens
                    var tokens =
                        db
                            .context
                            .RefreshTokenRiders
                            .Where(x => x.userGuid == Id);
                    foreach (var item in tokens)
                    {
                        item.Invalidated = true;
                        db.context.RefreshTokenRiders.Update (item);
                    }

                    if (profile.Count() > 0)
                        db.context.PersonProfile.RemoveRange(profile);
                    db.context.RiderAccounts.Remove (account);
                    db.context.SaveChanges();
                    command.Commit();
                    return true;
                }
                catch (Exception  )
                {
                    return false;
                }
            }
        }

        public async Task<ResultViewModel>
        RefreshToken(string AccessToken, string RefreshToken)
        {
            return await tokenManager
                .RefreshTokenAsync(AccessToken, RefreshToken);
        }

        public bool IsOldPasswordUsed(string UserId, string newPassword)
        {
            try
            {
                var oldPass =  db .context .PasswordRiders  .Where(pass => pass.UserId == UserId);
                if (oldPass.Count() == 0)
                    return false;
                else
                {
                    //record exists, verify if new pass==old pass
                    foreach (var x in oldPass)
                    {
                        var IsPasswordValid = PasswordHasher.Verify(newPassword, x.Password);
                        if (IsPasswordValid) return true; //used
                    }
                    return false; //not use
                }
            }
            catch (Exception)
            {
                return false; //used
            }
        }

        public async Task<bool> ChangePasswordAsync(RiderAccountEntity model)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    model.Password =  PasswordHasher  .HashPassword(model.Password, PasswordHasher.GenerateSalt());
                    db.context.RiderAccounts.Update (model);
                    await db.context .PasswordRiders  
                        .AddAsync(new PasswordRider()
                        { Password = model.Password, UserId = model.GUID });
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

        public async Task<ResultViewModel> ResetPasswordAsync(RiderAccountEntity model)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    model.Password = PasswordHasher.HashPassword(model.Password,  PasswordHasher.GenerateSalt());
                    db.context.RiderAccounts.Update (model);
                    await db
                        .context
                        .PasswordRiders
                        .AddAsync(new PasswordRider()
                        { Password = model.Password, UserId = model.GUID });

                    var tokenres =  await tokenManager.GenerateAuthenticationAsync(model);
                    if (tokenres == null)
                    {
                        command.Rollback();
                        return new ResultViewModel()
                        {
                            ResultEnum = Result.Failed.ToString(),
                            ResultObject = null,
                            ResultMessage =  Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                        };
                    }

                    db.context.SaveChanges();
                    await command.CommitAsync();
                    var returnModel =
                        new TokenModel()
                        {
                            AccessToken = tokenres.AccessToken,
                            RefreshToken = tokenres.RefreshToken,
                            UserId = model.GUID
                        };

                    return new ResultViewModel()
                    {
                        ResultEnum = Result.Success.ToString(),
                        ResultObject = returnModel,
                        ResultMessage = Constants.MESSAGE_SUCCESS
                    };
                }
                catch (Exception ex)
                {
                    command.Rollback();
                    return new ResultViewModel()
                    {
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage = Constants.GET_ERROR(ex)
                    };
                }
            }
        }

        public bool  VerifyPasswordAsync(string PlainPassword, string encryptedPassword)
        {
            return PasswordHasher.Verify(PlainPassword, encryptedPassword);
        }

        public async Task<bool> VerifyAccountAsync(string emailOrMobile, RiderAccountEntity account,string smsSignature)
        {
            try
            {
                var tokenres = await tokenManager.GenerateAuthenticationAsync(account);
                if (tokenres == null) return false;

                if (emailOrMobile.StartsWith("63"))
                {
                    var message = new SendOTPService();
                    var iSsuccess =  await message.sendWithAppCode(emailOrMobile, smsSignature, tokenres.AccessToken);
                    if (iSsuccess)
                        return true;
                    else
                        return false;
                }
                else
                {
                    IMessage<Mail> message = new EmailOTPService();
                    var items = emailOrMobile.Split("@");
                    var iSsuccess =
                        await message.send(new Mail()
                            {
                                receipientEmail = emailOrMobile,
                                receipientName = items[0] ?? "",
                                linkUrl = ""
                            },
                            tokenres.AccessToken);

                    if (iSsuccess)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> RegisterMobileAsync(string mobile,string smsSignature)
        {
            try
            {
                var message = new SendOTPService();
                var iSsuccess = await message.sendWithAppCode(mobile,smsSignature, "");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
