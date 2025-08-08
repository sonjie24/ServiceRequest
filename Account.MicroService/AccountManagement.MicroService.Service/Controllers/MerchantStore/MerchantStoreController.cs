using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using AccountManagement.MicroService.Controllers.validation;
using AccountManagement.Framework.Models;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.MicroService.Hubs.Managers;
using AccountManagement.MicroService.Controllers.Publisher;
using AccountManagement.Framework.Data;
using AccountManagement.FrameWork.Models;
using Microsoft.Net.Http.Headers;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Account-Merchant-Store")]
    public class MerchantStoreController : Controller
    {
        private readonly IMerchantStoreManager<MerchantStoreEntity> storemanager;
        private readonly IMerchantAccountManager<MerchantAccountEntity> merchantUserManager;
        private readonly IGenericQueryManager genericQuery;
        private readonly IPublisher publisher;
        private readonly Database db;


        public MerchantStoreController(
             IGenericQueryManager genericQuery,
             IMerchantStoreManager<MerchantStoreEntity> storemanager,
             IMerchantAccountManager<MerchantAccountEntity> merchantUserManager
            , IPublisher publisher, Database db)
        {
            this.storemanager = storemanager;
            this.genericQuery = genericQuery;
            this.merchantUserManager = merchantUserManager;
            this.publisher = publisher;
            this.db = db;
        }
        #region Post


        private async Task<ResultViewModel> RegistrationValidation(MerchantStoreBaseRouteModel model, string merchantId)
        {
            try
            {
                if (model == null) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT };
                if (!string.IsNullOrEmpty(model.Email) && !(new EmailValidation().validate(model.Email))) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS };
                //if (string.IsNullOrWhiteSpace(model.Email)) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS };

                //Check model states
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = error.ErrorMessage };
                    }
                }

                if (model.ContactFirstName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED("First Name") };
                if (model.ContactLastName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED("Last Name") };

                var items = await storemanager.Where(x => (x.Company == model.Company.Trim() || x.Email == model.Email) && x.GUID != merchantId);
                if (items.Count() > 0) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "Email or Company is already exists" };
                return new ResultViewModel() { ResultObject = true, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS };
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
            }
        }

        private async Task<ResultViewModel> RegistrationValidationAddBranch(AddBranchMerchantStoreBaseRouteModel model, string merchantId)
        {
            try
            {
                if (model == null) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT };
                if (!string.IsNullOrEmpty(model.Email) && !(new EmailValidation().validate(model.Email))) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS };
                //if (string.IsNullOrWhiteSpace(model.Email)) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS };

                //Check model states
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = error.ErrorMessage };
                    }
                }

                if (model.ContactFirstName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED("First Name") };
                if (model.ContactLastName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED("Last Name") };

                var items = await storemanager.Where(x => (x.Company == model.Company.Trim() || x.Email == model.Email) && x.GUID != merchantId);
                if (items.Count() > 0) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "Email or Company is already exists" };
                return new ResultViewModel() { ResultObject = true, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS };
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
            }
        }

        /// <summary>
        /// Register new store
        /// </summary>
        ///// <param name="model"></param>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.MechantStoreRoute.RegisterStore)]
        public async Task<IActionResult> RegisterStore([FromBody] MerchantCreateStoreRouteModel model)
        {
            try
            {
                var result = await RegistrationValidation(model, "");
                if (!(bool)result?.ResultObject) return BadRequest(result);
                if (model.IsSocial && string.IsNullOrEmpty(model.SocialId)) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_SOCIAL_ID });
                if (!ModelState.IsValid) return BadRequest(result);
                if (model.CategoryIds.Count() == 0) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "Category Not Found." });
                var categories = await genericQuery.All<CategoryEntity>();
                if (categories == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "No Category Record Found." });

                var Storecategories = new List<MerchantCategoryEntity>();
                var parent = await storemanager.FindOne(model.MainBranchId);
                var merchant = new MerchantStoreEntity();
                merchant.Company = model.Company;
                merchant.Parent = parent;
                merchant.Email = model.Email.Trim();
                merchant.ContactNo = model.ContactNumber;
                merchant.ContactFirstName = model.ContactFirstName;
                merchant.ContactLastName = model.ContactLastName;
                merchant.NoOfEmployees = model.NoOfEmployees;
                merchant.Address1 = model.Address1;
                merchant.Address2 = model.Address2;
                merchant.Barangay = model.Barangay;
                merchant.CityMunicipality = model.CityMunicipality;
                merchant.Province = model.Province;
                merchant.Region = model.Region;
                merchant.ZipCode = model.ZipCode;
                merchant.LandMark = model.LandMark;
                merchant.AutoAccept = false;
                merchant.Prepaid = true;
                merchant.isAllowedAdvanceOrder =model.isAllowedAdvanceOrder;
                merchant.isAllowedPickUp =  model.isAllowedPickUp;
                merchant.Categories = new List<MerchantCategoryEntity>();

                foreach (var category in model.CategoryIds)
                {
                    var Found = categories.FirstOrDefault(xx => xx.GUID == category.CategoryId);
                    if (Found == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = $"Selected Category Not Found." });
                    merchant.Categories.Add(new MerchantCategoryEntity()
                    {
                        Category = Found,
                    });
                }

                //TODO role is not yet defined
                var user = new MerchantAccountEntity
                {
                    GUID = merchant.GUID,
                    Merchant = merchant,
                    Password = model.Password,
                    FirstName = model.ContactFirstName,
                    LastName = model.ContactLastName,
                    MobileNumber = model.ContactNumber,
                    EmailAddress = model.Email,
                };
                result = await storemanager.Register(merchant, user);

                if (result.ResultEnum == Result.Success.ToString())
                {
                    AddStore(merchant);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }


        /// <summary>
        /// Add Branch
        /// </summary>
        ///// <param name="model"></param>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.MechantStoreRoute.AddRelatedStore)]
        public async Task<IActionResult> AddRelatedStore([FromBody] AddBranchMerchantStoreBaseRouteModel model)
        {
            try
            {
                var result = await RegistrationValidationAddBranch(model, "");
                if (!(bool)result?.ResultObject) return BadRequest(result);
                if (string.IsNullOrWhiteSpace(model.BranchGroup)) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "Branch Group Id cannot be empty." });
                if (!ModelState.IsValid) return BadRequest(result);
                if (model.CategoryIds.Count() == 0) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "Category Not Found." });
                var categories = await genericQuery.All<CategoryEntity>();
                if (categories == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "No Category Record Found." });
                var relaredBranch = await storemanager.Where(x => x.BranchGroup == model.BranchGroup);
                if (relaredBranch == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "Branch Group Id not found." });

                var Storecategories = new List<MerchantCategoryEntity>();
                var parent = await storemanager.FindOne(model.MainBranchId);
                var merchant = new MerchantStoreEntity();
                merchant.Company = model.Company;
                merchant.BranchGroup = model.BranchGroup;
                merchant.Parent = parent;
                merchant.Email = model.Email.Trim();
                merchant.ContactNo = model.ContactNumber;
                merchant.ContactFirstName = model.ContactFirstName;
                merchant.ContactLastName = model.ContactLastName;
                merchant.NoOfEmployees = model.NoOfEmployees;
                merchant.Address1 = model.Address1;
                merchant.Address2 = model.Address2;
                merchant.Barangay = model.Barangay;
                merchant.CityMunicipality = model.CityMunicipality;
                merchant.Province = model.Province;
                merchant.Region = model.Region;
                merchant.ZipCode = model.ZipCode;
                merchant.LandMark = model.LandMark;
                merchant.isAllowedAdvanceOrder = model.isAllowedAdvanceOrder;
                merchant.isAllowedPickUp = model.isAllowedPickUp;
                merchant.Categories = new List<MerchantCategoryEntity>();
                foreach (var category in model.CategoryIds)
                {
                    var Found = categories.FirstOrDefault(xx => xx.GUID == category.CategoryId);
                    if (Found == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = $"Selected Category Not Found." });
                    merchant.Categories.Add(new MerchantCategoryEntity()
                    {
                        Category = Found,
                    });
                }

                result = await storemanager.AddRelatedBranch(merchant);
                if (result.ResultEnum == Result.Success.ToString())
                {
                    AddStore(merchant);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }


        private void AddStore(MerchantStoreEntity store)
        {
            try
            {
                var accountModel = new MerchantAccount
                {
                    StoreId = store.GUID,
                    AutoAccept=store.AutoAccept,
                    Company=store.Company,
                    Prepaid=store.Prepaid,
                };
                publisher.Publish(accountModel, "ADD_MERCHANT");
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        ///  get all related branch for the givent store
        /// </summary>
        /// <param name="BranchGroup"></param>
        /// <param name="merchantId">Login merchant store</param>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.MechantStoreRoute.GetRelatedStore)]
        public async Task<IActionResult> GetRelatedStore([FromRoute] string BranchGroup, [FromRoute] string merchantId)
        {
            try
            {
                var relaredBranch = await storemanager.Where(x => x.BranchGroup == BranchGroup && x.GUID != merchantId);
                var models = new List<object>();
                foreach (var model in relaredBranch)
                {
                    var categories = from i in model.Categories select new { CategoryId = i.GUID };

                    var item = new
                    {
                        Id = model.GUID,
                        Company = model.Company,
                        MainBranchId = model?.Parent?.GUID,
                        BranchGroup = model.BranchGroup,
                        CategoryId = categories,
                        Email = model?.Email,
                        ContactNumber = model?.ContactNo,
                        ContactFirstName = model.ContactFirstName,
                        ContactLastName = model.ContactLastName,
                        NoOfEmployees = model.NoOfEmployees,
                        Address1 = model?.Address1,
                        Address2 = model?.Address2,
                        Barangay = model?.Barangay,
                        CityMunicipality = model?.CityMunicipality,
                        Province = model?.Province,
                        Region = model?.Region,
                        ZipCode = model?.ZipCode,
                        LandMark = model.LandMark,
                        ImagePath = model.ImagePath,
                        Latitude = model.Latitude,
                        Longitude = model.Longitude,
                        IsDocsComplied = model.IsDocsComplied,
                        isAllowedAdvanceOrder = model.isAllowedAdvanceOrder,
                        isAllowedPickUp = model.isAllowedPickUp,
                        Status = model.Status.ToString(),
                    };
                    models.Add(item);
                }
                return Ok(new ResultViewModel() { ResultObject = models, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });

            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

        #endregion
        #region Patch


        /// <summary>
        /// update account info
        /// </summary>
        /// <param name="model"></param>
        /// <returns>accessToken</returns> 
        /// <returns>refreshToken</returns> 
        /// <returns>userId</returns>  
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.MechantStoreRoute.Update)]
        public async Task<IActionResult> UpdateModel([FromBody] MerchantUpdateStoreRouteModel model, string merchantId)
        {
            try
            {
                var result = await RegistrationValidation(model, merchantId);
                if (!(bool)result.ResultObject) return BadRequest(result);
                if (!ModelState.IsValid) return BadRequest(result);

                var store = await storemanager.FindOne(merchantId);
                if (store == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Store not found." });

                //validation if provided category guid is existing in category table
                var categories = await genericQuery.All<CategoryEntity>();
                if (categories == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = "No Category Record Found." });
                var newstorecategories = new List<MerchantCategoryEntity>();
                foreach (var category in model.CategoryIds)
                {
                    var Found = categories.FirstOrDefault(xx => xx.GUID == category.CategoryId);
                    if (Found == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = $"Selected Category Not Found." });
                    var ni = new MerchantCategoryEntity()
                    {
                        Category = Found,
                        MerchantStore = store
                    };
                    newstorecategories.Add(ni);
                }

                bool IsNewEmail = store.Email != model.Email;
                double.TryParse(model.Latitude, out var Latitude);
                double.TryParse(model.Longitude, out var Longitude);
                store.Company = model.Company;
                store.LandMark = model.LandMark;
                store.ContactNo = model.ContactNumber;
                store.Email = model.Email;
                store.ContactFirstName = model.ContactFirstName;
                store.ContactLastName = model.ContactLastName;
                store.NoOfEmployees = model.NoOfEmployees;
                store.Address1 = model.Address1;
                store.Address2 = model.Address2;
                store.Barangay = model.Barangay;
                store.CityMunicipality = model.CityMunicipality;
                store.Province = model.Province;
                store.Region = model.Region;
                store.ZipCode = model.ZipCode;
                store.Latitude = Latitude;
                store.Longitude = Longitude;
                store.Location = Common.CreateGeometryPoint(Longitude, Latitude);
                store.LandMark = model.LandMark;
                store.ImagePath = model.ImagePath;
                store.ModifiedBy = HttpContext.GetUserId();
                store.DateModified = Common.getDateNow();
                store.Prepaid = model.Prepaid;
                store.AutoAccept = model.AutoAccept;
                store.MerchantKmRange = model.MerchantKmRange;
                store.RiderKmRange = model.RiderKmRange;
                store.IsDocsComplied = model.IsDocsComplied;
                store.isAllowedAdvanceOrder = model.isAllowedAdvanceOrder;
                store.isAllowedPickUp = model.isAllowedPickUp;

                var User = await merchantUserManager.FindOne(store.GUID);
                if (User != null)
                {
                    User.FirstName = model.ContactFirstName;
                    User.LastName = model.ContactLastName;
                    User.MobileNumber = model.ContactNumber;
                    User.EmailAddress = model.Email;
                    User.ModifiedBy = store.ModifiedBy;
                    User.DateModified = store.DateModified;
                    User.MobileNumber = store.ContactNo;
                }

                var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                var isUpdate = await storemanager.UpdateModel(store, User, newstorecategories, IsNewEmail, token, model.baseUrl);
                var storeCategories = await storemanager.FindMerchantCategories(store.GUID);
                foreach (var item in storeCategories)
                {
                    model.CategoryIds.Add(new CategoryModel
                    {
                        CategoryId = item.Category.GUID
                    });
                }


                if (isUpdate) {
                    AddStore(store);
                    return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = model, ResultMessage = Constants.MESSAGE_SUCCESS });
                }
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }


        /// <summary>
        /// update store status
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status">1=active,2=pending,3=cancelled</param>
        /// <returns>return json result</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.MechantStoreRoute.UpdateStatus)]
        public async Task<IActionResult> UpdateStatus([FromRoute] string merchantId, [FromRoute] EStatus status)
        {
            try
            {
                var model = await storemanager.FindOne(merchantId);
                if (model == null) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Error.ToString() });
                if (status == EStatus.Active)
                {
                    model.IsDocsComplied = true;
                }
                model.Status = status;
                var isUpdated = await storemanager.Update(model);
                var userStatus = new
                {
                    merchantId = merchantId,
                    Status = model.Status.ToString(),
                };
                await new MerchantStoreHubManager().PublishAccountStatus(userStatus);
                if (!isUpdated) return BadRequest(new ResultFailed(Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
                var result = new ResultViewModel();
                result.ResultEnum = Result.Success.ToString();
                result.ResultMessage = Constants.MESSAGE_SUCCESS;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }
     
            [HttpGet(ApiRoutes.MechantStoreRoute.GetMinimumPurchase)]
            public async Task<IActionResult> GetMinimumPurchase([FromRoute] string merchantId )  
            {
                var merchant =await storemanager.FindOne(merchantId);
                if (merchant == null) return Ok(new ResultSuccess());
                var model = new
                {
                    minimumOrderAmount = merchant.MininumPurchaseAmount
                };
                return Ok(new ResultSuccess(model));
            }


        /// <summary>
        /// Set Order Minimum amount
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpPatch(ApiRoutes.MechantStoreRoute.UpdateMinimumPurchase)]
        public async Task<IActionResult> UpdateMinimumPurchase([FromRoute] string merchantId, [FromRoute] decimal amount)
        {
            try
            {
                var response = await storemanager.FindOne(merchantId);
                if (response == null) return BadRequest(new ResultSuccess( Constants.MESSAGE_ACCOUNT_NOT_EXISTS));
                response.MininumPurchaseAmount = amount;
                var isUpdated = await storemanager.Update(response);
                var dnow = Common.getDateNow();

                var categories = from i in response.Categories select new { CategoryId = i.GUID };
                var os = await genericQuery.FindOneWhere<MerchantOpeningHour>(x => x.Day == dnow.ToString("ddd") && x.MerchantId == response.GUID);
                var model = new
                {
                    Id = response.GUID,
                    Company = response.Company,
                    MainBranchId = response?.Parent?.GUID,
                    BranchGroup = response.BranchGroup,
                    CategoryId = categories,
                    Email = response?.Email,
                    MobileNumber = response?.ContactNo,
                    firstName = response?.ContactFirstName,
                    LastName = response?.ContactLastName,
                    NoOfEmployees = response.NoOfEmployees,
                    Prepaid = response.Prepaid,
                    AutoAccept = response.AutoAccept,
                    MerchantKmRange = response.MerchantKmRange,
                    RiderKmRange = response.RiderKmRange,
                    Address1 = response?.Address1,
                    Address2 = response?.Address2,
                    Barangay = response?.Barangay,
                    CityMunicipality = response?.CityMunicipality,
                    Province = response?.Province,
                    Region = response?.Region,
                    ZipCode = response?.ZipCode,
                    LandMark = response.LandMark,
                    ImagePath = response.ImagePath,
                    Latitude = response.Latitude,
                    Longitude = response.Longitude,
                    MininumPurchaseAmount = response.MininumPurchaseAmount,
                    IsDocsComplied = response.IsDocsComplied,
                    isAllowedAdvanceOrder = response.isAllowedAdvanceOrder,
                    isAllowedPickUp = response.isAllowedPickUp,
                    Status = response.Status.ToString(),
                    Day = dnow.ToString("ddd"),
                    IsOn = os?.IsOn, 
                    Openning = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0),
                    Closing = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0),
                    IsOpen = Convert.ToBoolean(os.IsOn) && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0) >= dnow
                };
                return Ok(new ResultSuccess(model));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

        /// <summary>
        /// Set Document Submission as complied
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="isComplied">Complied=1,Not=0</param>
        /// <returns></returns>
        [HttpPatch(ApiRoutes.MechantStoreRoute.SetDocIsComplied)]
        public async Task<IActionResult> SetDocIsComplied([FromRoute] string merchantId, [FromRoute] bool isComplied)
        {
            try
            {
                var response = await storemanager.FindOne(merchantId);
                if (response == null) return BadRequest(new ResultSuccess(Constants.MESSAGE_ACCOUNT_NOT_EXISTS));
                response.IsDocsComplied = isComplied;
                var isUpdated = await storemanager.Update(response);
                var dnow = Common.getDateNow();
                var categories = from i in response.Categories select new { CategoryId = i.GUID };
                var os = await genericQuery.FindOneWhere<MerchantOpeningHour>(x => x.Day == dnow.ToString("ddd") && x.MerchantId == response.GUID);
                var model = new
                {
                    Id = response.GUID,
                    Company = response.Company,
                    MainBranchId = response?.Parent?.GUID,
                    BranchGroup = response.BranchGroup,
                    CategoryId = categories,
                    Email = response?.Email,
                    MobileNumber = response?.ContactNo,
                    firstName = response?.ContactFirstName,
                    LastName = response?.ContactLastName,
                    NoOfEmployees = response.NoOfEmployees,
                    Prepaid = response.Prepaid,
                    AutoAccept = response.AutoAccept,
                    MerchantKmRange = response.MerchantKmRange,
                    RiderKmRange = response.RiderKmRange,
                    Address1 = response?.Address1,
                    Address2 = response?.Address2,
                    Barangay = response?.Barangay,
                    CityMunicipality = response?.CityMunicipality,
                    Province = response?.Province,
                    Region = response?.Region,
                    ZipCode = response?.ZipCode,
                    LandMark = response.LandMark,
                    ImagePath = response.ImagePath,
                    Latitude = response.Latitude,
                    Longitude = response.Longitude,
                    MininumPurchaseAmount = response.MininumPurchaseAmount,
                    IsDocsComplied = response.IsDocsComplied,
                    isAllowedAdvanceOrder = response.isAllowedAdvanceOrder,
                    isAllowedPickUp = response.isAllowedPickUp,
                    Status = response.Status.ToString(), 
                    Day = dnow.ToString("ddd"),
                    IsOn = os?.IsOn,
                    Openning = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0),
                    Closing = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0),
                    IsOpen = Convert.ToBoolean(os.IsOn) && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0) >= dnow
                };
                return Ok(new ResultSuccess(model));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }


        /// <summary>
        /// Update Store Location
        /// </summary>
        /// <param name="model"></param>
        /// <param name="merchantId"></param>
        /// <returns>success</returns>  
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.MechantStoreRoute.UpdateLongLat)]
        public async Task<IActionResult> UpdateLocation([FromBody] UpdateLongLatRouteModel model,[FromRoute] string merchantId )
        {
            try
            {
                //var userId = HttpContext.GetUserId();
                if (model == null) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_INVALID_INPUT });
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = error.ErrorMessage });
                    }
                }

                var store = await storemanager.FindOne(merchantId);
                if (store == null) return BadRequest(new ResultViewModel() { ResultMessage = "Store does not exists"});
                if (store.Status != EStatus.Active) return BadRequest(new ResultViewModel() { ResultMessage =  "Store is not active"});

                double Longitude = 0.00;
                double Latitude = 0.00;
                double.TryParse(model.Longitude, out Longitude);
                double.TryParse(model.Latitude, out Latitude);
                store.Longitude = Longitude;
                store.Latitude = Latitude;
                store.Location = Common.CreateGeometryPoint(Longitude, Latitude);
                var isSuccess = await storemanager.UpdateLongLat(store);
                if (!isSuccess) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
                return Ok(new ResultViewModel() { ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
        }

        #endregion
        #region Get

        /// <summary>
        /// Get store information
        /// </summary>
        /// <param name="merchantId"></param> 
        /// <returns>return store information</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.MechantStoreRoute.Get)]
        public async Task<IActionResult> GetById([FromRoute] string merchantId)
        {
            try
            {
                var response = await storemanager.FindOne(merchantId);
                if (response == null) return Ok(new ResultViewModel() { ResultMessage = "merchant does not exists." });
                var storeCateg = await storemanager.FindMerchantCategories(merchantId);
                var categories= from i in storeCateg select new { CategoryId = i.Category.GUID };

                var dnow = Common.getDateNow();
                var os = await genericQuery.FindOneWhere<MerchantOpeningHour>(x=>x.Day ==dnow.ToString("ddd") && x.MerchantId== merchantId);
                var model = new
                {
                    Id = response.GUID,
                    Company = response.Company,
                    MainBranchId = response?.Parent?.GUID,
                    BranchGroup = response.BranchGroup,
                    CategoryId = categories,
                    Email = response?.Email,
                    MobileNumber = response?.ContactNo,
                    firstName = response?.ContactFirstName,
                    LastName = response?.ContactLastName,
                    NoOfEmployees = response.NoOfEmployees,
                    Prepaid = response.Prepaid,
                    AutoAccept = response.AutoAccept,
                    MerchantKmRange = response.MerchantKmRange,
                    RiderKmRange = response.RiderKmRange,
                    Address1 = response?.Address1,
                    Address2 = response?.Address2,
                    Barangay = response?.Barangay,
                    CityMunicipality = response?.CityMunicipality,
                    Province = response?.Province,
                    Region = response?.Region,
                    ZipCode = response?.ZipCode,
                    LandMark = response.LandMark,
                    ImagePath = response.ImagePath,
                    Latitude = response.Latitude,
                    Longitude = response.Longitude,
                    MininumPurchaseAmount = response.MininumPurchaseAmount,
                    IsDocsComplied = response.IsDocsComplied,
                    isAllowedAdvanceOrder = response.isAllowedAdvanceOrder,
                    isAllowedPickUp = response.isAllowedPickUp,
                    Status = response.Status.ToString(),
                    Day = dnow.ToString("ddd"),
                    IsOn = os?.IsOn,
                    Openning = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0),
                    Closing = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0),
                    IsOpen = Convert.ToBoolean(os.IsOn) &&  new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0) >= dnow
                };
                return Ok(new ResultViewModel() { ResultObject = model, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

        /// <summary>
        /// Get All stores
        /// </summary>
        /// <param name="status">0=all,1=active,2=pending,3=cancelled</param>
        /// <param name="skip"></param>
        /// <param name="take"></param> 
        /// <returns>Return list of stores</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.MechantStoreRoute.GetAll)]
        public async Task<IActionResult> GetAllStore([FromRoute] FilterEStatus status = FilterEStatus.All, [FromRoute] int skip = 0, [FromRoute] int take =50)
        {
            try
            {
                IQueryable<MerchantStoreEntity> storeResults = null;
                if (status == FilterEStatus.All) storeResults = await storemanager.All();
                if (status != FilterEStatus.All) storeResults = await storemanager.Where(x => x.Status == status.convertToEStatus());
                var Response = storeResults?.OrderByDescending(x=>x.DateCreated).Skip(skip).Take(take).ToList();

                var dnow = Common.getDateNow();
                //if (Response.Count() == 0) return BadRequest(new ResultViewModel() { ResultMessage = "No merchants found." });
                var models = new List<object>();

                foreach (var model in Response)
                {

                    var categories = from i in model.Categories select new { CategoryId = i.GUID };
                    var os = await genericQuery.FindOneWhere<MerchantOpeningHour>(x=>x.Day ==dnow.ToString("ddd") && x.MerchantId==model.GUID);

                    var item = new   
                    {
                        Id = model.GUID,
                        Company = model.Company,
                        MainBranchId = model?.Parent?.GUID,
                        BranchGroup = model.BranchGroup,
                        CategoryId = categories,
                        Email = model?.Email,
                        ContactNumber = model?.ContactNo,
                        ContactFirstName = model.ContactFirstName,
                        ContactLastName = model.ContactLastName,
                        NoOfEmployees = model.NoOfEmployees,
                        Prepaid = model.Prepaid,
                        AutoAccept = model.AutoAccept,
                        MerchantKmRange = model.MerchantKmRange,
                        RiderKmRange = model.RiderKmRange,
                        Address1 = model?.Address1,
                        Address2 = model?.Address2,
                        Barangay = model?.Barangay,
                        CityMunicipality = model?.CityMunicipality,
                        Province = model?.Province,
                        Region = model?.Region,
                        ZipCode = model?.ZipCode,
                        LandMark = model.LandMark,
                        ImagePath  = model.ImagePath,
                        Latitude  = model.Latitude,
                        Longitude  = model.Longitude,
                        MininumPurchaseAmount = model.MininumPurchaseAmount,
                        IsDocsComplied = model.IsDocsComplied,
                        isAllowedAdvanceOrder = model.isAllowedAdvanceOrder,
                        isAllowedPickUp = model.isAllowedPickUp,
                        Status = model.Status.ToString(),
                        Day = dnow.ToString("ddd"),
                        IsOn = os?.IsOn,
                        Openning = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0),
                        Closing = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0),
                        IsOpen = Convert.ToBoolean(os.IsOn) && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0) >= dnow

                    };
                 
                    models.Add(item);
 
                }
                return Ok(new ResultViewModel() { ResultObject = models, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });

            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

        /// <summary>
        /// Get All nearest Riders
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param> 
        /// <returns>Return list of riders</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.MechantStoreRoute.GetNearestRider)]
        public async Task<IActionResult> GetAllMobile([FromRoute]int skip=0,[FromRoute] int take=15)
        {
            try
            {
                var id = HttpContext.GetUserId();
                var account = await merchantUserManager.FindOne(id);
                if (account == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in" });
                if (account.Merchant == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Merchant not found." });
                var point = account.Merchant.Location;
                var results = await storemanager.GetNearest(point, account.Merchant.RiderKmRange, skip, take);
                if (results.Item1)
                    return Ok(new ResultViewModel() { ResultObject = results.Item2, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
                else
                    return BadRequest(new ResultViewModel() { ResultObject = results.Item2, ResultEnum = Result.Failed.ToString(), ResultMessage = results.Item2.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

         



        /// <summary>
        /// Verify account
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Email Verified Successfully</returns>
        /// <response code="200">Email Verified Successfully</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.MechantStoreRoute.VerifyEmail)]
        public async Task<IActionResult> VerifyEmail([FromRoute] string storeUserId)
        {
            try
            {
                var isSuccess = await storemanager.VerifyEmail(storeUserId);
                if (!isSuccess) return BadRequest(Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST);
                return Ok("Email Verified Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

        #endregion
        #region Delete

        /// <summary>
        /// Delete store
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns> 
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpDelete(ApiRoutes.MechantStoreRoute.Delete)]
        public async Task<IActionResult> Delete([FromRoute] string userId)
        {
            try
            {
                var isSuccess = await storemanager.Delete(userId);
                if (isSuccess) return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS, ResultObject = true });
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }


        [HttpPost(ApiRoutes.MechantStoreRoute.storeIsCloseCurrent)]
        public async Task<IActionResult> storeIsCloseCurrent([FromRoute] string merchantId, [FromRoute] bool isClose)
        {
            var dnow = Common.getDateNow();
            var isupdate = false;
            var scheds = await genericQuery.Where<MerchantOpeningHour>(x => x.Day == dnow.ToString("ddd") && x.MerchantId ==merchantId);
            var response = await genericQuery.FindOne<MerchantStoreEntity>(merchantId);
            if (response != null)
            {
                await genericQuery.AddOrUpdate(response);
            }
            foreach (var sched in scheds)
            {
                sched.IsOn = isClose ? "true": "false" ;
                await genericQuery.AddOrUpdate(sched);
                isupdate = true;
            }

            if (isupdate) await genericQuery.CommitChanges();

            var storeCateg = await storemanager.FindMerchantCategories(merchantId);
            var categories = from i in storeCateg select new { CategoryId = i.Category.GUID };
            var os = await genericQuery.FindOneWhere<MerchantOpeningHour>(x => x.MerchantId == merchantId && x.Day == dnow.ToString("ddd"));

            var model = new
            {
                Id = response.GUID,
                Company = response.Company,
                MainBranchId = response?.Parent?.GUID,
                BranchGroup = response.BranchGroup,
                CategoryId = categories,
                Email = response?.Email,
                MobileNumber = response?.ContactNo,
                firstName = response?.ContactFirstName,
                LastName = response?.ContactLastName,
                NoOfEmployees = response.NoOfEmployees,
                Prepaid = response.Prepaid,
                AutoAccept = response.AutoAccept,
                MerchantKmRange = response.MerchantKmRange,
                RiderKmRange = response.RiderKmRange,
                Address1 = response?.Address1,
                Address2 = response?.Address2,
                Barangay = response?.Barangay,
                CityMunicipality = response?.CityMunicipality,
                Province = response?.Province,
                Region = response?.Region,
                ZipCode = response?.ZipCode,
                LandMark = response.LandMark,
                ImagePath = response.ImagePath,
                Latitude = response.Latitude,
                Longitude = response.Longitude,
                IsDocsComplied = response.IsDocsComplied,
                isAllowedAdvanceOrder = response.isAllowedAdvanceOrder,
                isAllowedPickUp = response.isAllowedPickUp,
                Status = response.Status.ToString(),
                ClosedReason = response.ClosedReason,
                //ClosedReason = bool.TryParse(os?.IsOn,out bool isOn) ? "": response.ClosedReason ,
                Day = dnow.ToString("ddd"),
                IsOn = os?.IsOn,
                Openning = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0),
                Closing = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0),
                IsOpen =   new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0) >= dnow

            };
            return Ok(new ResultSuccess(model));
        }

        /// <summary>
        /// close store (current Day)
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        [HttpPost(ApiRoutes.MechantStoreRoute.storeIsCloseCurrentV2)]
        public async Task<IActionResult> storeIsCloseCurrentV2([FromBody] IsStoreCloseRequestModel payload)
        {
            var dnow = Common.getDateNow();
            var isupdate = false;
            var scheds = await genericQuery.Where<MerchantOpeningHour>(x=>x.Day==dnow.ToString("ddd") && x.MerchantId== payload.merchantId);
            var response = await genericQuery.FindOne<MerchantStoreEntity>(payload.merchantId);
            if (response != null)
            {
                response.ClosedReason = payload.Reason;
                await genericQuery.AddOrUpdate(response);
            }
            foreach (var sched in scheds)
            {
                sched.IsOn = payload?.IsOn.ToString().ToLower();
                await genericQuery.AddOrUpdate(sched);
                isupdate = true;
            }
           
            if (isupdate)  await genericQuery.CommitChanges();

            var storeCateg = await storemanager.FindMerchantCategories(payload.merchantId);
            var categories = from i in storeCateg select new { CategoryId = i.Category.GUID };
            var os = await genericQuery.FindOneWhere<MerchantOpeningHour>( x => x.MerchantId==payload. merchantId && x.Day == dnow.ToString("ddd"));

            var model = new
            {
                Id = response.GUID,
                Company = response.Company,
                MainBranchId = response?.Parent?.GUID,
                BranchGroup = response.BranchGroup,
                CategoryId = categories,
                Email = response?.Email,
                MobileNumber = response?.ContactNo,
                firstName = response?.ContactFirstName,
                LastName = response?.ContactLastName,
                NoOfEmployees = response.NoOfEmployees,
                Prepaid = response.Prepaid,
                AutoAccept = response.AutoAccept,
                MerchantKmRange = response.MerchantKmRange,
                RiderKmRange = response.RiderKmRange,
                Address1 = response?.Address1,
                Address2 = response?.Address2,
                Barangay = response?.Barangay,
                CityMunicipality = response?.CityMunicipality,
                Province = response?.Province,
                Region = response?.Region,
                ZipCode = response?.ZipCode,
                LandMark = response.LandMark,
                ImagePath = response.ImagePath,
                Latitude = response.Latitude,
                Longitude = response.Longitude,
                IsDocsComplied = response.IsDocsComplied,
                isAllowedAdvanceOrder = response.isAllowedAdvanceOrder,
                isAllowedPickUp = response.isAllowedPickUp,
                Status = response.Status.ToString(),
                ClosedReason = response.ClosedReason,
                //ClosedReason = bool.TryParse(os?.IsOn,out bool isOn) ? "": response.ClosedReason ,
                Day = dnow.ToString("ddd"),
                IsOn = os?.IsOn,
                Openning = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0),
                Closing = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0),
                IsOpen =  new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0) >= dnow
 
            };
            return Ok(new ResultSuccess(model));
        }


        //public const string storeIsCloseCurrent = Base + "/merchant/store-is-close-current/{merchantId}/{isClose}";
        //public const string storeIsCloseAllDays = Base + "/merchant/store-is-close-all-days/{merchantId}/{isClose}";


        /// <summary>
        /// close store (All Days)
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        [HttpPost(ApiRoutes.MechantStoreRoute.storeIsCloseAllDays)]
        public async Task<IActionResult> storeIsCloseAllDays([FromRoute] string merchantId,[FromRoute] bool isClose)
        {
            var dnow = Common.getDateNow() ;
            var isupdate = false; 
            var scheds = await genericQuery.Where<MerchantOpeningHour>(x => x.MerchantId ==merchantId);
            var response = await genericQuery.FindOne<MerchantStoreEntity>(merchantId);
            if (response != null)
            {
                await genericQuery.AddOrUpdate(response);
            }
            foreach (var sched in scheds)
            {
                sched.IsOn =  isClose ? "true" : "false";
                await genericQuery.AddOrUpdate(sched);
                isupdate = true;
            }
            if (isupdate) await genericQuery.CommitChanges();
            var storeCateg = await storemanager.FindMerchantCategories(merchantId);
            var categories = from i in storeCateg select new { CategoryId = i.Category.GUID };
            var os = await genericQuery.FindOneWhere<MerchantOpeningHour>(x => x.Day == dnow.ToString("ddd") && x.MerchantId == merchantId);

            var model = new
            {
                Id = response.GUID,
                Company = response.Company,
                MainBranchId = response?.Parent?.GUID,
                BranchGroup = response.BranchGroup,
                CategoryId = categories,
                Email = response?.Email,
                MobileNumber = response?.ContactNo,
                firstName = response?.ContactFirstName,
                LastName = response?.ContactLastName,
                NoOfEmployees = response.NoOfEmployees,
                Prepaid = response.Prepaid,
                AutoAccept = response.AutoAccept,
                MerchantKmRange = response.MerchantKmRange,
                RiderKmRange = response.RiderKmRange,
                Address1 = response?.Address1,
                Address2 = response?.Address2,
                Barangay = response?.Barangay,
                CityMunicipality = response?.CityMunicipality,
                Province = response?.Province,
                Region = response?.Region,
                ZipCode = response?.ZipCode,
                LandMark = response.LandMark,
                ImagePath = response.ImagePath,
                Latitude = response.Latitude,
                Longitude = response.Longitude,
                IsDocsComplied = response.IsDocsComplied,
                isAllowedAdvanceOrder = response.isAllowedAdvanceOrder,
                isAllowedPickUp = response.isAllowedPickUp,
                Status = response.Status.ToString(),
                ClosedReason =  response.ClosedReason ,
                //ClosedReason = bool.TryParse(os?.IsOn,out bool isOn) ? "": response.ClosedReason ,
                Day = dnow.ToString("ddd"),
                IsOn = os?.IsOn ,
                Openning = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0),
                Closing = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0),
                IsOpen =   new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0) >= dnow
            };
            return Ok(new ResultSuccess(model));
        }

        [HttpPost(ApiRoutes.MechantStoreRoute.storeIsCloseAllDaysV2)]
        public async Task<IActionResult> storeIsCloseAllDaysV2([FromBody] IsStoreCloseRequestModel payload)
        {
            var dnow = Common.getDateNow();
            var isupdate = false;
            var scheds = await genericQuery.Where<MerchantOpeningHour>(x => x.MerchantId == payload.merchantId);
            var response = await genericQuery.FindOne<MerchantStoreEntity>(payload.merchantId);
            if (response != null)
            {
                response.ClosedReason = payload.Reason;
                await genericQuery.AddOrUpdate(response);
            }
            foreach (var sched in scheds)
            {
                sched.IsOn = payload?.IsOn.ToString().ToLower();
                await genericQuery.AddOrUpdate(sched);
                isupdate = true;
            }
            if (isupdate) await genericQuery.CommitChanges();
            var storeCateg = await storemanager.FindMerchantCategories(payload.merchantId);
            var categories = from i in storeCateg select new { CategoryId = i.Category.GUID };
            var os = await genericQuery.FindOneWhere<MerchantOpeningHour>(x => x.Day == dnow.ToString("ddd") && x.MerchantId == payload.merchantId);

            var model = new
            {
                Id = response.GUID,
                Company = response.Company,
                MainBranchId = response?.Parent?.GUID,
                BranchGroup = response.BranchGroup,
                CategoryId = categories,
                Email = response?.Email,
                MobileNumber = response?.ContactNo,
                firstName = response?.ContactFirstName,
                LastName = response?.ContactLastName,
                NoOfEmployees = response.NoOfEmployees,
                Prepaid = response.Prepaid,
                AutoAccept = response.AutoAccept,
                MerchantKmRange = response.MerchantKmRange,
                RiderKmRange = response.RiderKmRange,
                Address1 = response?.Address1,
                Address2 = response?.Address2,
                Barangay = response?.Barangay,
                CityMunicipality = response?.CityMunicipality,
                Province = response?.Province,
                Region = response?.Region,
                ZipCode = response?.ZipCode,
                LandMark = response.LandMark,
                ImagePath = response.ImagePath,
                Latitude = response.Latitude,
                Longitude = response.Longitude,
                IsDocsComplied = response.IsDocsComplied,
                isAllowedAdvanceOrder = response.isAllowedAdvanceOrder,
                isAllowedPickUp = response.isAllowedPickUp,
                Status = response.Status.ToString(),
                ClosedReason = response.ClosedReason,
                //ClosedReason = bool.TryParse(os?.IsOn,out bool isOn) ? "": response.ClosedReason ,
                Day = dnow.ToString("ddd"),
                IsOn = os?.IsOn,
                Openning = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0),
                Closing = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0),
                IsOpen = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.FromTime.Substring(0, 2)), int.Parse(os.FromTime.Substring(3, 2).Trim()), 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(os.ToTime.Substring(0, 2)), int.Parse(os.ToTime.Substring(3, 2).Trim()), 0) >= dnow

            };
            return Ok(new ResultSuccess(model));
        }
        #endregion
    }

    public class IsStoreCloseRequestModel
    {
        public string merchantId  { get; set; }
        public bool  IsOn  { get; set; }
        public string Reason { get; set; }
    }
}