using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Data;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace AccountManagement.Framework.Core.Managers
{
    public class ConsumerAccountManager : IConsumerAccountManager<ConsumerAccountEntity>
    {
        private readonly Database db;
        private readonly IConsumerTokenManager<ConsumerAccountEntity> tokenManager;  

        public ConsumerAccountManager( Database db,
            IConsumerTokenManager<ConsumerAccountEntity> tokenManager )
        {
            this.db = db;
            this.tokenManager = tokenManager;
        }

        public async Task<ResultViewModel> Register(ConsumerAccountEntity model)
        {
                using (var command = db.context.Database.BeginTransaction())
                {
                    try
                    {
                    await db.context.ConsumerAccounts.AddAsync(model);
                    await db.context.SaveChangesAsync();

                    var tokenres = await tokenManager.GenerateAuthenticationAsync( model);
                    if (tokenres == null)
                    {

                        command.Rollback();
                        return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST };
                    }

                    command.Commit();

                    var returnModel = new TokenModel()
                    {
                        AccessToken = tokenres.AccessToken,
                        RefreshToken = tokenres.RefreshToken,
                        UserId = model.GUID
                    };

                    //var message = new SendOTPService();
                    //var iSsuccess = await message.sendWithAppCode(model.MobileNumber, model.AppCode, "");
                    return new ResultSuccess( returnModel);
                }
                catch (Exception ex)
                    {
                   command.Rollback();
                    return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
                    } 
                } 
        }

        public async Task<ResultViewModel> RegisterDevice(ConsumerAccountEntity model)
        {
            using (var command = db.context.Database.BeginTransaction())
            {
                try
                {
                    await db.context.ConsumerAccounts.AddAsync(model);
                    await db.context.SaveChangesAsync();

                    var tokenres = await tokenManager.GenerateAuthenticationAsync(model);
                    if (tokenres == null)
                    {

                        command.Rollback();
                        return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST };
                    }

                    command.Commit();

                    var returnModel = new TokenModel()
                    {
                        AccessToken = tokenres.AccessToken,
                        RefreshToken = tokenres.RefreshToken,
                        UserId = model.GUID
                    };

                    //var message = new SendOTPService();
                    //var iSsuccess = await message.sendWithAppCode(model.MobileNumber, model.AppCode, "");
                    return new ResultSuccess(returnModel);
                }
                catch (Exception ex)
                {
                    command.Rollback();
                    return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
                }
            }
        }


        public async Task<ResultViewModel> Login(ConsumerAccountEntity model)
        {
            try
            {
                ConsumerAccountEntity userAccount = null;
                if (model.IsSocial)
                    userAccount = await db.context.ConsumerAccounts.SingleOrDefaultAsync(u => u.SocialId == model.SocialId);
                else 
                    userAccount = await db.context.ConsumerAccounts.SingleOrDefaultAsync(u => u.MobileNumber == model.MobileNumber || u.EmailAddress==model.EmailAddress);

                if (userAccount == null) return new ResultViewModel() { ResultObject = false, ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS };
                if (userAccount.Status !=  ConsumerStatus.Active) return new ResultViewModel() { ResultObject = false, ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_ACTIVE };

                var userGuid = userAccount.GUID; 
                var tokenres = await  tokenManager.GenerateAuthenticationAsync( userAccount);
                if (tokenres == null)
                {
                    return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultObject = null, ResultMessage = Constants.MESSAGE_TOKEN_ERROR };
                } 

                var message = new SendOTPService();
                var data = await message.sendWithAppCodeReturnOTP(model.MobileNumber, model.AppCode, "");
                var returnModel = new 
                {
                    AccessToken = tokenres.AccessToken,
                    RefreshToken = tokenres.RefreshToken,
                    UserId = userGuid,
                    OTP= data.Item2
                };
                return new ResultSuccess(returnModel);
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
            }
        }

        public async Task<ResultViewModel> LoginByDeviceId(string  deviceId)
        {
            try
            {
                ConsumerAccountEntity userAccount =  await db.context.ConsumerAccounts.SingleOrDefaultAsync(u => u.DeviceId == deviceId);
                if (userAccount == null) return new ResultFailed(  Constants.MESSAGE_ACCOUNT_NOT_EXISTS );
                if (userAccount.Status != ConsumerStatus.Active) return new ResultFailed( Constants.MESSAGE_ACCOUNT_NOT_ACTIVE );
                var userGuid = userAccount.GUID;
                var tokenres = await tokenManager.GenerateAuthenticationAsync(userAccount);
                if (tokenres == null)  return new ResultFailed(  Constants.MESSAGE_TOKEN_ERROR );


                var model = new
                {
                    userId = userAccount.GUID,
                    Email = userAccount?.EmailAddress,
                    MobileNumber = userAccount?.MobileNumber,
                    Rating = userAccount.Rating / userAccount.RatingCount == 0 ? 1 : userAccount.RatingCount,
                    FirstName = userAccount?.FirstName,
                    LastName = userAccount?.LastName,
                    ImagePath = userAccount?.ImagePath,
                    IsSocial = userAccount?.IsSocial,
                    SocialId = userAccount?.SocialId,
                    OrderCount = userAccount.OrderCount,
                    Status = userAccount.Status.ToString(),

                    AccessToken = tokenres.AccessToken,
                    RefreshToken = tokenres.RefreshToken,
                };

                //var returnModel = new
                //{
                //    AccessToken = tokenres.AccessToken,
                //    RefreshToken = tokenres.RefreshToken,
                //    UserId = userGuid,
                //    OTP = ""
                //};
                return new ResultSuccess(model);
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
            }
        }


        public async Task<bool> Update(ConsumerAccountEntity model)
        {
            try
            {
                db.context.ConsumerAccounts.Update(model);
                await db.context.SaveChangesAsync();
                return true;
            }
            catch (Exception  )
            {
                return  false;
            }
        }

        public async Task<ConsumerAccountEntity> FindOne(string Id)
        {
            try
            {
                var model = await db.context
                    .ConsumerAccounts 
                    .SingleOrDefaultAsync(x=>x.GUID==Id);
                return model ?? null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IQueryable<ConsumerAccountEntity>> Where(Expression<Func<ConsumerAccountEntity, bool>> expression)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var models = db.context.ConsumerAccounts.Where(expression);
                    return models;
                });
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IQueryable<ConsumerAccountEntity>> All()
        {
            try
            {
                var models = await db.context.ConsumerAccounts.ToListAsync() ;
                return models.AsQueryable();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public  async Task<bool> Delete(string Id)
        {

            using(var command=db.context.Database.BeginTransaction())
            {
                try
                {
                    var account = await db.context.ConsumerAccounts 
                        .SingleOrDefaultAsync(x => x.GUID == Id);

                    if (account == null) return false;

                    //remove ratings
                    //var r1= db.context.ConsumerToMerchantRatingEntities.Where(x => x.ConsumerId == account.GUID);
                    //var r2 = db.context.ConsumerToRiderRatingEntities.Where(x => x.ConsumerId == account.GUID);
                    //db.context.ConsumerToMerchantRatingEntities.RemoveRange(r1);
                    //db.context.ConsumerToRiderRatingEntities.RemoveRange(r2);

                    //remove addresses
                    var addresses = db.context.ConsumerAddresses.Where(x => x.Consumer == account);
                    if (addresses.Count() > 0)
                    {
                        foreach (var address in addresses) db.context.ConsumerAddresses.Remove(address);
                    }
                    //invalidate token
                    var tokens = db.context.RefreshTokenConsumers.Where(x => x.userGuid == Id);
                    foreach (var item in tokens)
                    {
                        item.Invalidated = true;
                        db.context.RefreshTokenConsumers.Update(item);
                    }

                    db.context.ConsumerAccounts.Remove(account);
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


        public async Task<ResultViewModel> RefreshToken(string AccessToken, string RefreshToken)
        {
            return await tokenManager.RefreshTokenAsync(AccessToken, RefreshToken);
        }

        private int Orderingvalue(NearestModel x)
        {
            if (!x.IsOn)//temp closed
            {
                return 2;
            }
            else if (x.IsOn && x.IsOpen) //open
            {
                return 1;
            }
            else //closed
            {
                return 3;
            }
        }

        public async Task<Tuple<bool, object>> GetNearest(Point consumerLocation, int skip, int take)
        {
            try
            {

                var store = (await (db.context.MerchantStores
                  .Include(p => p.Categories))
                  .Where(x => x.Status == EStatus.Active && x.Location.IsWithinDistance(consumerLocation, x.MerchantKmRange))
                   .Select(m => new 
                   {
                       storeId = m.GUID,
                       Company = m.Company,
                       MerchantContact = m.ContactNo,
                       StoreAddress = m.Address1,
                       LandMark = m.LandMark,
                       Longitude = m.Longitude,
                       Latitude = m.Latitude,
                       Category = m.Categories.Select(x => x.Category.Description),
                       Distance = m.Location.Distance(consumerLocation),
                       Duration = m.Location.Distance(consumerLocation) / 1000 / Constants.TRAVEL_TIME,
                       Rating  =  m.ConsumerRating  / (m.ConsumerRatingCount==0 ? 1 : m.ConsumerRatingCount),
                       StoreImagePath = m.ImagePath,
                       isPrepaid = m.Prepaid,
                       IsAllowedPickUp = m.isAllowedPickUp,
                       IsAllowedAdvanceOrder = m.isAllowedAdvanceOrder,
                       MininumPurchaseAmount = m.MininumPurchaseAmount,
                       CategoryImagePath = m.Categories.Select(x => x.Category.ImagePath),
                   }).ToListAsync())
                   .Skip(skip)
                   .Take(take) ;


                var dnow = Common.getDateNow();

                var stores = store
                  .GroupJoin(db.context.MerchantOpeningHours, m => m.storeId, o => o.MerchantId,
                  (merchant, openning) => new { merchant, openning })
                   .Select(m => new NearestModel
                   {
                       storeId = m.merchant.storeId,
                       Company = m.merchant.Company,
                       MerchantContact = m.merchant.MerchantContact,
                       StoreAddress = m.merchant.StoreAddress,
                       LandMark = m.merchant.LandMark,
                       Longitude = m.merchant.Longitude,
                       Latitude = m.merchant.Latitude,
                       Category = m.merchant.Category,
                       Distance = m.merchant.Distance,
                       Duration = m.merchant.Duration,
                       Rating =  m.merchant.Rating,
                       isPrepaid = m.merchant.isPrepaid,
                       IsAllowedPickUp = m.merchant.IsAllowedPickUp,
                       IsAllowedAdvanceOrder = m.merchant.IsAllowedAdvanceOrder,
                       MininumPurchaseAmount =  m.merchant.MininumPurchaseAmount,
                       StoreImagePath = m.merchant.StoreImagePath,
                       CategoryImagePath = m.merchant.CategoryImagePath,
                       Day = dnow.ToString("ddd"),
                       IsOn = Convert.ToBoolean(m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => x.IsOn).FirstOrDefault()),
                       Openning =m.openning.Where(x=> x.Day == dnow.ToString("ddd")).Select(x=> new DateTime(dnow.Year , dnow.Month, dnow.Day,int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3,2).Trim()), 0)).FirstOrDefault(),
                       Closing = m.openning.Where(x=> x.Day == dnow.ToString("ddd")).Select(x=> new DateTime( dnow.Year , dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3,2)), 0)).FirstOrDefault(),
                       IsOpen = m.openning.Any(x=>  x.Day== dnow.ToString("ddd") && new DateTime( dnow.Year , dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3,2).Trim()), 0) <= dnow &&  new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3,2)), 0) >= dnow),
                   }).OrderBy(x=> Orderingvalue(x))
                   .ThenByDescending(x=>x.Rating);

                return new Tuple<bool, object>(true, stores);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, object>(false, Constants.GET_ERROR(ex));
            }
        }


        public async Task<Tuple<bool, object>> GetNearestCategory(string Category, Point consumerLocation, int skip, int take)
        {
            try
            {

                var store = (await (db.context.MerchantStores
                    .Include(p => p.Categories)) 
                    .Where(x => x.Status == EStatus.Active && x.Categories.Any(xx => xx.Category.Description == Category) && x.Location.IsWithinDistance(consumerLocation, x.MerchantKmRange ))
                    .Select(m => new {
                        storeId = m.GUID,
                        Company = m.Company,
                        MerchantContact = m.ContactNo,
                        StoreAddress = m.Address1,
                        LandMark = m.LandMark,
                        Longitude = m.Longitude,
                        Latitude = m.Latitude,
                        Category = m.Categories.Select(x => x.Category.Description),
                        Distance = m.Location.Distance(consumerLocation),
                        Duration = m.Location.Distance(consumerLocation) / 1000 / Constants.TRAVEL_TIME,
                        Rating = m.ConsumerRating / (m.ConsumerRatingCount == 0 ? 1 : m.ConsumerRatingCount),
                        StoreImagePath = m.ImagePath,
                        isPrepaid = m.Prepaid,
                        IsAllowedPickUp = m.isAllowedPickUp,
                        IsAllowedAdvanceOrder = m.isAllowedAdvanceOrder,
                        MininumPurchaseAmount = m.MininumPurchaseAmount,
                        CategoryImagePath = m.Categories.Select(x => x.Category.ImagePath),
                    }).ToListAsync())
                   .Skip(skip)
                   .Take(take) ;

                var dnow = Common.getDateNow();

                var stores = store.GroupJoin(db.context.MerchantOpeningHours, m => m.storeId, o => o.MerchantId,
                    (merchant, openning) => new { merchant, openning })
                    .Select(m => new NearestModel {
                        storeId = m.merchant.storeId,
                        Company = m.merchant.Company,
                        MerchantContact = m.merchant.MerchantContact,
                        StoreAddress = m.merchant.StoreAddress,
                        LandMark = m.merchant.LandMark,
                        Longitude = m.merchant.Longitude,
                        Latitude = m.merchant.Latitude,
                        Category = m.merchant.Category ,
                        Distance = m.merchant.Distance ,
                        Duration = m.merchant.Duration  ,
                        Rating = m.merchant.Rating,
                        isPrepaid = m.merchant.isPrepaid,
                        IsAllowedPickUp = m.merchant.IsAllowedPickUp,
                        IsAllowedAdvanceOrder = m.merchant.IsAllowedAdvanceOrder,
                        MininumPurchaseAmount = m.merchant.MininumPurchaseAmount,
                        StoreImagePath = m.merchant.StoreImagePath,
                        CategoryImagePath = m.merchant.CategoryImagePath ,
                        Day = dnow.ToString("ddd"),
                        IsOn = Convert.ToBoolean(m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => x.IsOn).FirstOrDefault()),
                        Openning = m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3, 2).Trim()), 0)).FirstOrDefault(),
                        Closing = m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3, 2)), 0)).FirstOrDefault(),
                        IsOpen = m.openning.Any(x => x.Day == dnow.ToString("ddd") && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3, 2).Trim()), 0) >= dnow),
                    }).OrderBy(x => Orderingvalue(x))
                   .ThenByDescending(x => x.Rating);

                return new Tuple<bool, object>(true, stores);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, object>(false, Constants.GET_ERROR(ex));
            }
        }

        

        public async Task<Tuple<bool, object>> GetFavorites(string userId, Point consumerLocation, int skip, int take)
        {
            try
            {

                var store  = (await (db.context.MerchantStores
                 .Include(c => c.Categories)  
                 .Join(db.context.ConsumerFavorites,m=>m.GUID, f=>f.MerchantGuid, (m,f)=>new { m,f}))
                .Where(x => x.m.Status == EStatus.Active && x.f.ConsumerGuid==userId && x.m.Location.IsWithinDistance(consumerLocation, x.m.MerchantKmRange ))
                .Select(m => new {
                    storeId = m.m.GUID,
                    Company = m.m.Company,
                    MerchantContact = m.m.ContactNo,
                    StoreAddress = m.m.Address1,
                    LandMark = m.m.LandMark,
                    Longitude = m.m.Longitude,
                    Latitude = m.m.Latitude,
                    Category = m.m.Categories.Select(x => x.Category.Description),
                    Distance = m.m.Location.Distance(consumerLocation),
                    Duration = m.m.Location.Distance(consumerLocation) / 1000 / Constants.TRAVEL_TIME,
                    Rating =  m.m.ConsumerRating / (m.m.ConsumerRatingCount == 0 ? 1 : m.m.ConsumerRatingCount),
                    StoreImagePath = m.m.ImagePath,
                    isPrepaid = m.m.Prepaid,
                    IsAllowedPickUp = m.m.isAllowedPickUp,
                    IsAllowedAdvanceOrder = m.m.isAllowedAdvanceOrder,
                    MininumPurchaseAmount = m.m.MininumPurchaseAmount,
                    CategoryImagePath = m.m.Categories.Select(x => x.Category.ImagePath),
                }).ToListAsync())
                   .Skip(skip)
                   .Take(take) ;


                var dnow = Common.getDateNow();

                var stores = store 
                 .GroupJoin(db.context.MerchantOpeningHours, m => m.storeId , o => o.MerchantId,
                 (merchant, openning) => new { merchant, openning })
                 .Select(m => new NearestModel
                  {
                    storeId = m.merchant.storeId,
                    Company = m.merchant.Company,
                    MerchantContact = m.merchant.MerchantContact,
                    StoreAddress = m.merchant.StoreAddress,
                    LandMark = m.merchant.LandMark,
                    Longitude = m.merchant.Longitude,
                    Latitude = m.merchant.Latitude,
                    Category = m.merchant.Category  ,
                    Distance = m.merchant.Distance ,
                    Duration = m.merchant.Duration  ,
                    Rating =  m.merchant.Rating  ,
                    isPrepaid = m.merchant.isPrepaid,
                    IsAllowedPickUp = m.merchant.IsAllowedPickUp,
                    IsAllowedAdvanceOrder = m.merchant.IsAllowedAdvanceOrder,
                    MininumPurchaseAmount = m.merchant.MininumPurchaseAmount,
                    StoreImagePath = m.merchant.StoreImagePath ,
                    CategoryImagePath = m.merchant. CategoryImagePath ,
                    Day = dnow.ToString("ddd"),
                    IsOn = Convert.ToBoolean(m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => x.IsOn).FirstOrDefault()),
                     Openning = m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3, 2).Trim()), 0)).FirstOrDefault(),
                     Closing = m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3, 2)), 0)).FirstOrDefault(),
                     IsOpen = m.openning.Any(x => x.Day == dnow.ToString("ddd") && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3, 2).Trim()), 0) >= dnow),
                 }).OrderBy(x => Orderingvalue(x))
                   .ThenByDescending(x => x.Rating);

                return new Tuple<bool, object>(true, stores);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, object>(false, Constants.GET_ERROR(ex));
            }
        }

        private IEnumerable<string> convertToIEnum(string  entity)
        {
            try
            {
                var categ = new List<string>();
                categ.Add(entity);
                var data= categ.Select(x=>x);
                return data;
            }
            catch ( Exception)
            {
                return  null;
            }
        }
        public async Task<Tuple<bool, object>> GetNearestByName(Point consumerLocation, string Name)
        {
            try
            {
                var store = (await (db.context.MerchantCategories
                    .Include(p => p.MerchantStore))
                    .Where(x => x.MerchantStore.Status == EStatus.Active
                    && x.MerchantStore.Company.Contains(Name)
                    && x.MerchantStore.Location.IsWithinDistance(consumerLocation,x.MerchantStore.MerchantKmRange))
                    .Select(m => new {
                        storeId = m.MerchantStore.GUID,
                        Company = m.MerchantStore.Company, 
                        MerchantContact = m.MerchantStore.ContactNo,
                        Category = m.Category,
                        isPrepaid = m.MerchantStore.Prepaid,
                        IsAllowedPickUp = m.MerchantStore.isAllowedPickUp,
                        IsAllowedAdvanceOrder = m.MerchantStore.isAllowedAdvanceOrder,
                        Distance = m.MerchantStore.Location.Distance(consumerLocation),
                        Duration = m.MerchantStore.Location.Distance(consumerLocation) / 1000 / Constants.TRAVEL_TIME,
                        Rating = m.MerchantStore.ConsumerRating / (m.MerchantStore.ConsumerRatingCount == 0 ? 1 : m.MerchantStore.ConsumerRatingCount),
                        StoreImagePath = m.MerchantStore.ImagePath,
                        MininumPurchaseAmount = m.MerchantStore.MininumPurchaseAmount,
                        CategoryImagePath = m.Category.ImagePath,
                    }).ToListAsync())  ;

                var dnow = Common.getDateNow();

                var stores = store
                    .GroupJoin(db.context.MerchantOpeningHours, m => m.storeId, o => o.MerchantId,
                    (merchant, openning) => new { merchant, openning })
                    .Select(m => new NearestModel {
                        storeId = m.merchant.storeId,
                        Company = m.merchant.Company,
                        MerchantContact = m.merchant.MerchantContact,
                        Category = convertToIEnum(m.merchant.Category.Description),
                        Distance = m.merchant.Distance,
                        Duration = m.merchant.Duration,
                        Rating = m.merchant.Rating,
                        isPrepaid = m.merchant.isPrepaid,
                        IsAllowedPickUp = m.merchant.IsAllowedPickUp,
                        IsAllowedAdvanceOrder = m.merchant.IsAllowedAdvanceOrder,
                        MininumPurchaseAmount = m.merchant.MininumPurchaseAmount,
                        StoreImagePath = m.merchant.StoreImagePath,
                        CategoryImagePath = convertToIEnum(m.merchant.CategoryImagePath),
                        Day = dnow.ToString("ddd"),
                        IsOn = Convert.ToBoolean(m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => x.IsOn).FirstOrDefault()),
                        Openning = m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3, 2).Trim()), 0)).FirstOrDefault(),
                        Closing = m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3, 2)), 0)).FirstOrDefault(),
                        IsOpen = m.openning.Any(x => x.Day == dnow.ToString("ddd") && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3, 2).Trim()), 0) >= dnow),
                    }).OrderBy(x => Orderingvalue(x))
                   .ThenByDescending(x => x.Rating);

                return new Tuple<bool, object>(true, stores);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, object>(false, Constants.GET_ERROR(ex));
            }
        }
        public async Task<bool> RegisterMobileAsync(string mobile ,string AppCode)
        {
            try
            {
                var message = new SendOTPService();
                var iSsuccess = await message.sendWithAppCode(mobile, AppCode, "");
                return iSsuccess;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<object> GetMerchantSched(string merchantId, DateTime dateTime)
        {
            try
            {
                var dnow = dateTime;
                var store = await (db.context.MerchantStores
                    .Where(x => x.GUID == merchantId)
                    .Select(m => new { storeId = m.GUID }).ToListAsync());

                var stores = store.GroupJoin(db.context.MerchantOpeningHours, m => m.storeId, o => o.MerchantId,
                    (merchant, openning) => new { merchant, openning })
                    .Select(m => new {
                        date = dnow,
                        openTime = m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(3, 2).Trim()), 0)).FirstOrDefault(),
                        closeTime = m.openning.Where(x => x.Day == dnow.ToString("ddd")).Select(x => new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(3, 2).Trim()), 0)).FirstOrDefault(),
                        status = (m.openning.Any(x => Convert.ToBoolean(x.IsOn) == true && x.Day == dnow.ToString("ddd") && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), int.Parse(x.FromTime.Substring(0, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), int.Parse(x.ToTime.Substring(0, 2).Trim()), 0) >= dnow) ? "Open" : "Closed")
                    });

                return stores;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task<ResultViewModel> CheckSocialId(string socialId,string AppCode)
        {
            try
            {
                var user =  db.context.ConsumerAccounts.Where(x => x.SocialId == socialId && x.IsSocial==true).FirstOrDefault();
                if (user == null) return  new ResultViewModel { ResultEnum = Result.Failed.ToString(), ResultMessage = "Not Found." } ;
                if (user.Status!=ConsumerStatus.Active) return new ResultViewModel { ResultEnum = Result.Failed.ToString(), ResultMessage = "user status is not active" };
                
                var tokenres = await tokenManager.GenerateAuthenticationAsync(user);
                if (tokenres == null)
                {
                    return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_TOKEN_ERROR };
                }

                var returnModel = new
                {
                    userId = user.GUID,
                    Email = user?.EmailAddress,
                    MobileNumber = user?.MobileNumber,
                    AccessToken = tokenres.AccessToken,
                    RefreshToken = tokenres.RefreshToken,
                };

                var message = new SendOTPService();
                var iSsuccess = await message.sendWithAppCode(user?.MobileNumber, AppCode,"");
                return new ResultViewModel() { ResultObject = returnModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS } ;
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.GET_ERROR(ex) };
            }
        }

        public async Task<bool> AddFavoriteMerchant(string consumerGuid,string merchantGuid  )
        {
            try
            {
                var fav  = new ConsumerFavorites
                {
                    ConsumerGuid = consumerGuid,
                    MerchantGuid = merchantGuid,
                };
                await db.context.ConsumerFavorites.AddAsync(fav);
                db.context.SaveChanges();
                return true;
            }
            catch ( Exception)
            {
                return false; 
            }
        }

        public async Task<bool> RemoveFavoriteMerchant(string consumerGuid, string merchantGuid)
        {
            using (var command=db.context.Database.BeginTransaction())
            {
                try
                {
                    var merchants = db.context.ConsumerFavorites
                        .Where(x => x.MerchantGuid == merchantGuid && x.ConsumerGuid == consumerGuid).ToList();

                        db.context.ConsumerFavorites.RemoveRange(merchants);
                        await  db.context.SaveChangesAsync();
                        await command.CommitAsync();
                        return true;
                }
                catch ( Exception)
                {
                    command.Rollback();
                    return false;
                }
            }
     }
         
    }

    public class NearestModel
    {
        public string storeId { get; set; }
        public string Company { get; set; }
        public string MerchantContact { get; set; }
        public string StoreAddress { get; set; }
        public string LandMark { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public IEnumerable<string> Category { get; set; }
        public double Distance { get; set; }
        public double Duration { get; set; }
        public double Rating { get; set; }
        public bool isPrepaid { get; set; }
        public bool IsAllowedPickUp { get; set; }
        public bool IsAllowedAdvanceOrder { get; set; }
        public decimal MininumPurchaseAmount { get; set; }
        public string StoreImagePath { get; set; }
        public IEnumerable<string> CategoryImagePath { get; set; }
        public string Day { get; set; }
        public bool IsOn { get; set; }
        public DateTime Openning { get; set; }
        public DateTime Closing { get; set; }
        public bool IsOpen { get; set; }
    }
}
