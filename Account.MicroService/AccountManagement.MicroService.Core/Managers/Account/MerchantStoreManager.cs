using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Data;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core.Managers
{
    public class MerchantStoreManager : IMerchantStoreManager<MerchantStoreEntity>
    {
        protected readonly Database db;
        private readonly IMerchantTokenManager<MerchantAccountEntity> tokenManager;

        public MerchantStoreManager( Database db, IMerchantTokenManager<MerchantAccountEntity> tokenManager)
        {
            this.db = db;
            this.tokenManager = tokenManager; 
        }


        //public async Task <bool> EmailNewStoreStaff(string Email,string firsName,string StaffGUID,string token)
        //{
        //    IMessage<Mail> message = new VerificationEmailService();
        //    var iSsuccess = await message.send(new Mail()
        //    {
        //        body = "Account Confirmation",
        //        header = "Confirm your Account",
        //        subject = "Account Confirmation",
        //        receipientEmail = Email,
        //        receipientName = firsName,
        //        linkUrl = $"https://pf-account-service-staging.azurewebsites.net/api/v1/m-verify-account/{StaffGUID}"
        //    }, token);
        //    return true;
        //}

        public async Task<ResultViewModel> Register(MerchantStoreEntity model,MerchantAccountEntity adminUser)
        {
            try
            {
                using (var command=db.context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in model.Categories)
                        {
                            db.context.StoreCategories.Update(item.Category);
                        }

                        adminUser.Password = PasswordHasher.HashPassword(adminUser.Password, PasswordHasher.GenerateSalt());
                        await db.context.MerchantStores.AddAsync(model);
                        await db.context.SaveChangesAsync();
                        adminUser.Merchant = model;
                        await db.context.MerchantAccounts.AddAsync(adminUser);
                        await db.context.SaveChangesAsync();

                        //save default store schedule
                        var openings = new List<MerchantOpeningHour>();
                        openings.Add(new MerchantOpeningHour { Day = "Mon", MerchantId = model.GUID, IsOn = "true", FromTime = "08:00", ToTime = "22:00" });
                        openings.Add(new MerchantOpeningHour { Day = "Tue", MerchantId = model.GUID, IsOn = "true", FromTime = "08:00", ToTime = "22:00" });
                        openings.Add(new MerchantOpeningHour { Day = "Wed", MerchantId = model.GUID, IsOn = "true", FromTime = "08:00", ToTime = "22:00" });
                        openings.Add(new MerchantOpeningHour { Day = "Thu", MerchantId = model.GUID, IsOn = "true", FromTime = "08:00", ToTime = "22:00" });
                        openings.Add(new MerchantOpeningHour { Day = "Fri", MerchantId = model.GUID, IsOn = "true", FromTime = "08:00", ToTime = "22:00" });
                        openings.Add(new MerchantOpeningHour { Day = "Sat", MerchantId = model.GUID, IsOn = "true", FromTime = "08:00", ToTime = "22:00" });
                        openings.Add(new MerchantOpeningHour { Day = "Sun", MerchantId = model.GUID, IsOn = "true", FromTime = "08:00", ToTime = "22:00" });
                        foreach (var openning in openings)
                        {
                            await db.context.MerchantOpeningHours.AddRangeAsync(openning);
                        }
                        await db.context.SaveChangesAsync();

                        var tokenres = await tokenManager.GenerateAuthenticationAsync(adminUser);
                        if (tokenres == null)
                        {
                            command.Rollback();
                            return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_TOKEN_ERROR };
                        }

                        var data = new
                        {
                            merchantGUID = model.GUID,
                            topUpType = "Percentage",
                            value = 0,
                            type = "Top-up"
                        };

                        using (var client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("https://pf-product-service.azurewebsites.net/");
                            client.DefaultRequestHeaders.Clear();
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenres.AccessToken);
                            string json = JsonConvert.SerializeObject(data);
                            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                            var Res = await client.PostAsync($"api/v1/top-up-merchant", httpContent);
                            var Response = Res.Content.ReadAsStringAsync().Result;
                        }

                        //send email service
                        IMessage<Mail> message = new  VerificationEmailService();
                        var iSsuccess = await message.send(new Mail() {
                                                                 receipientEmail = model.Email,
                                                                 receipientName = model.ContactFirstName,
                                                                 linkUrl = $"https://register.passafood.co/#/activation?t={tokenres.AccessToken}&c={model.GUID}"

                    },tokenres.AccessToken);

                        //return token
                        if (iSsuccess)
                        {

                            await command.CommitAsync();
                            var returnModel = new
                            {
                                AccessToken = tokenres.AccessToken,
                                ResfreshToken = tokenres.RefreshToken,
                                userId = adminUser.GUID ,
                                merchantId = model.GUID
                            };
                            return new ResultViewModel() { ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() };
                        }
                        else
                        {
                            await command.RollbackAsync();
                            return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_EMAIL_NOT_SENT };
                        } 
                    }
                    catch (Exception ex)
                    {
                        command.Rollback();
                        return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
                    }
                }
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultMessage =  ex.Message, ResultEnum = Result.Error.ToString() };
            }
        }

        public async Task<ResultViewModel> AddRelatedBranch(MerchantStoreEntity model)
        {
            try
            {
                using (var command = db.context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in model.Categories)
                        {
                            db.context.StoreCategories.Update(item.Category);
                        }
                        await db.context.MerchantStores.AddAsync(model);
                        await db.context.SaveChangesAsync();
                        command.Commit();
                        return new ResultViewModel() {  ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() };
                    }
                    catch (Exception ex)
                    {
                        command.Rollback();
                        return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
                    }
                }
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultMessage = ex.Message, ResultEnum = Result.Error.ToString() };
            }
        }


        public async Task<bool> UpdateModel(MerchantStoreEntity model, MerchantAccountEntity adminUser, List<MerchantCategoryEntity> newItems
            ,bool IsNewEmail,string token,string baseUrl)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    var items = db.context.MerchantCategories
                        .Where(x => x.MerchantStoreId == model.Id);

                    if (items.Count() > 0) db.context.MerchantCategories.RemoveRange(items);
                    await db.context.SaveChangesAsync();

                    foreach (var item in newItems)
                    {
                        item.MerchantStore = model;
                        db.context.MerchantCategories.Add(item);
                    }

                    db.context.MerchantStores.Update(model);
                    await db.context.SaveChangesAsync();

                    if (adminUser!=null)
                    {
                        db.context.MerchantAccounts.Update(adminUser);
                        await db.context.SaveChangesAsync();
                    }
                    command.Commit();

                    if (!string.IsNullOrWhiteSpace(baseUrl) && !string.IsNullOrWhiteSpace(model.Email) )
                    {
                        IMessage<Mail> message = new VerificationEmailService();
                        var iSsuccess = await message.send(new Mail()
                        {
                            receipientEmail = model.Email,
                            receipientName = model.Company,
                            linkUrl = $"{baseUrl}/email-changed?e={model.Email}&t={token}"
                        }, token);
                     }

                    return true;
                }
                catch (Exception  )
                {
                    command.Rollback();
                    return false;
                }
            }
        } 

        public async Task<bool> Update(MerchantStoreEntity model)
        {
            try
            {
                db.context.Entry(model).State = EntityState.Modified;
                await db.context.SaveChangesAsync();
                return true;
            }
            catch (Exception  )
            {
                return false;
            }
        }

        public async Task<List<MerchantCategoryEntity>> FindMerchantCategories(string  merchantId )
        {
            try
            {
                var categories = await db.context.MerchantCategories
               .Include(x => x.Category)
               .Where(x => x.MerchantStore.GUID == merchantId)
                .ToListAsync();
                return categories;
            }
            catch (Exception  )
            {
                return null;
            }
        }

 
        public async Task<MerchantStoreEntity> FindOne(string Id)
        {
            try
            {
                var model = await db.context.MerchantStores
                    .Include(p=>p.Parent)
                    .Include(c=>c.Categories)
                    .FirstOrDefaultAsync(x=>x.GUID==Id);

                return model;
            }
            catch (Exception  )
            {
                return  null;
            }
        }
        public async  Task<IQueryable<MerchantStoreEntity>> Where(Expression<Func<MerchantStoreEntity, bool>> expression)
        {
            return await Task.Run(()=> {
                return db.context.MerchantStores
                .Include(p=>p.Parent)
                .Include(c => c.Categories)
                .Where(expression);
            });
        }

        public async Task<IQueryable<MerchantStoreEntity>> All()
        {

 
            var models= await Task.Run(() => {
                return db.context.MerchantStores
                .Include(u => u.Categories)
                .Include(p => p.Parent);
            }); 
            return models;
        }

        public async Task<bool> Delete(string Id)
        {
            using(var command=db.context.Database.BeginTransaction())
            {
                try
                {
                    var store = await db.context.MerchantStores
                        .SingleOrDefaultAsync(x => x.GUID == Id);
                    if (store == null) return false; 

                    var accounts = db.context.MerchantAccounts
                        .Where(x => x.Merchant == store);

                    var categories = db.context.MerchantCategories
                       .Where(x => x.MerchantStore == store);

                    //remove ratings
                    //var ratings = db.context.MerchantRatings.Where(x => x.MerchantId == store.GUID);
                    //if (ratings.Count()>0) db.context.MerchantRatings.RemoveRange(ratings); 
                    if (categories.Count()>0) db.context.MerchantCategories.RemoveRange(categories); 

                    //invalid tokens
                    foreach (var user in accounts)
                    {
                        var tokens = db.context.RefreshTokenMerchants.Where(x => x.userGuid ==  user.GUID);
                        foreach (var item in tokens)
                        {
                            item.Invalidated = true;
                            db.context.RefreshTokenMerchants.Update(item);
                        }
                        db.context.MerchantAccounts.Remove(user);
                    }

                    db.context.MerchantStores.Remove(store);
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
        public async Task<bool> VerifyEmail(string  guid )
        {
            try
            {
                //verification for store-admin user
                var merchantAccount = await (db.context.MerchantAccounts
                    .Where(x => x.GUID == guid))
                    .SingleOrDefaultAsync();

                if (merchantAccount == null) return false;
                if (merchantAccount.IsAccountConfirmed == true) return  true;

                using (var command = db.context.Database.BeginTransaction())
                {
                    try
                    {
                        merchantAccount.IsAccountConfirmed = true;
                        db.context.Update(merchantAccount);
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
            catch (Exception)
            {
                return false;
            }
                
        }

        //public async Task<bool> UpdateRate(MerchantStoreEntity model, MerchantRatingEntity  ratingEntity)
        //{ 
        //    using (var command = db.context.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            model.RatingCount += 1;
        //            db.context.MerchantStores.Update(model);
        //            await  db.context.MerchantRatings.AddAsync(ratingEntity);
        //            db.context.SaveChanges();
        //            await command.CommitAsync();
        //            return true;
        //        }
        //        catch (Exception)
        //        {
        //            return false;
        //        }
        //    }
        //}

        public async Task<Tuple<bool, object>> GetNearest(Point storeLocation,double RiderDistance, int skip, int take)
        {
            try
            {
                var stores = (await db.context.RiderAccounts
                    .Where(x => x.Status == RiderStatus.Active && x.Location.IsWithinDistance(storeLocation, RiderDistance))
                    .Select(m => new {
                        riderId = m.GUID,
                        Distance = m.Location.Distance(storeLocation),
                        Longitude = m.Longitude,
                        Latitude = m.Latitude ,
                        Duration = m.Location.Distance(storeLocation) / 1000 / Constants.TRAVEL_TIME,
                        Rating = m.Rating/(m.RatingCount <= 0 ? 1 : m.RatingCount),
                        m.ImagePath,
                    }).ToListAsync()).Skip(skip).Take(take);

                return new Tuple<bool, object>(true, stores);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, object>(false, Constants.GET_ERROR(ex));
            }
        }

        public async Task<bool> UpdateLongLat(MerchantStoreEntity model)
        {
            try
            {
                db.context.MerchantStores.Update(model);
                await db.context.SaveChangesAsync();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
         
    }
}
