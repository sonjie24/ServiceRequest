using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Collections.Generic;
using AccountManagement.MicroService.RouteModels;
using AccountManagement.MicroService.Controllers.validation;
using AccountManagement.Framework.Models;
using AccountManagement.Framework.Core.Interfaces;
using Microsoft.Net.Http.Headers;
using AccountManagement.MicroService.Hubs.Managers;
using AccountManagement.MicroService.Controllers.Publisher;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Account-Consumer")]
    public class ConsumerAccountController : Controller
    {
        private IConsumerAccountManager<ConsumerAccountEntity> accountManager;
        private IMerchantAccountManager<MerchantAccountEntity> merchantManager;
        private IGenericQueryManager genericQueryManager;
        private readonly IPublisher publisher; 

        public ConsumerAccountController(IConsumerAccountManager<ConsumerAccountEntity> _accountManager,
            IMerchantAccountManager<MerchantAccountEntity> merchantManager,
            IGenericQueryManager genericQueryManager, IPublisher publisher)
        {
            accountManager = _accountManager;
            this.merchantManager = merchantManager;
            this.genericQueryManager = genericQueryManager;
            this.publisher = publisher; 
        }

        private async Task<ResultViewModel> RegistrationValidation(ConsumerCreateAccountRouteModel model,string userId)
        {
            try
            {
                if (model == null) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT };
                if (model.IsSocial && string.IsNullOrEmpty(model.SocialId)) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "Invalid social Id." };
                if (string.IsNullOrWhiteSpace(model.FirstName) )  return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "Name cannot be empty." };
                if (!model.IsSocial &&  string.IsNullOrWhiteSpace(model.MobileNumber)  &&  string.IsNullOrWhiteSpace(model.Email))  return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "Mobile number or email is required" };
                //if (!model.IsSocial &&  string.IsNullOrWhiteSpace(model.Password) )  return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "Password is required for not socialite account"};
                //if (!model.IsSocial && model.Password.Length<8 )  return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_PASSWORD_LENGTH};
                if (!model.IsSocial && !string.IsNullOrEmpty(model.Email) && !(new EmailValidation().validate(model.Email))) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "Invalid Email Format" };

                //Check model states
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = error.ErrorMessage };
                    }
                }

                if (model.FirstName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage =Constants.GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model.FirstName))};
                if (model.LastName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model.LastName)) };

                var items = await accountManager.Where(x => (x.EmailAddress == model.Email && !string.IsNullOrEmpty(model.Email)) || x.MobileNumber == model.MobileNumber && x.GUID!= userId);
                if (items.Count() > 0) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "The Email or Mobile is already registered."};
                return new ResultViewModel() { ResultObject = true, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS };
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
            }
        }


        private ResultViewModel  UpdateValidation(ConsumerUpdateAccountRouteModel model, string userId)
        {
            try
            {
                if (model == null) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT };
                if (string.IsNullOrWhiteSpace(model.FirstName) || string.IsNullOrWhiteSpace(model.LastName)) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "First Name and Last Name cannot be empty" };
                if (string.IsNullOrWhiteSpace(userId)) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "User does not exists" };
                //Check model states
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = error.ErrorMessage };
                    }
                }
                if (model.FirstName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model.FirstName)) };
                if (model.LastName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model.LastName)) };
                //var items = await accountManager.Where(x => (x.EmailAddress == model.Email && !string.IsNullOrEmpty(model.Email)) || x.MobileNumber == model.MobileNumber && x.GUID != userId);
                //if (items.Count() > 0) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "The Email or Mobile is already registered." };
                return new ResultViewModel() { ResultObject = true, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS };
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
            }
        }

        #region Post

        /// <summary>
        /// Register consumer account
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Token and userId</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ConsumerAccountRoute.Register)]
        public async Task<IActionResult> Register([FromBody] ConsumerCreateAccountRouteModel model)
        {
            try
            {
                var result = await RegistrationValidation(model,"");
                if (!(bool)result.ResultObject) return BadRequest(result);

                if (!ModelState.IsValid) return BadRequest(result);
                var account = new ConsumerAccountEntity()
                {
                    EmailAddress = model.Email,
                    MobileNumber = model.MobileNumber.Trim(),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    IsSocial = model.IsSocial,
                    SocialId = model.SocialId,
                    AppCode=model.AppCode,
                    Status= ConsumerStatus.Active,
                };
                result = await accountManager.Register(account);
                //if (result.ResultEnum == Result.Success.ToString())
                //{
                //    var accountmodel = new  ConsumerAcccount
                //    {
                //        ConsumerId = account.GUID
                //    };
                //    publisher.Publish(accountmodel, "admin");
                //}
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum=Result.Error.ToString(), ResultMessage= Constants.GET_ERROR(ex) });
            }
        }

         


        /// <summary>
        /// Register consumer account
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Token and userId</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ConsumerAccountRoute.RegisterByDevice)]
        public async Task<IActionResult> RegisterByDevice([FromRoute] string deviceId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(deviceId)) return BadRequest(new ResultFailed("Invalid Input"));
                var account = new ConsumerAccountEntity()
                {
                    DeviceId =  deviceId,
                    Status = ConsumerStatus.Active,
                };
                var result = await accountManager.RegisterDevice(account);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }


        /// <summary>
        /// User Login
        /// </summary>
        /// <param name="model"></param>
        ///<returns>accessToken</returns> 
        /// <returns>refreshToken</returns> 
        /// <returns>userId</returns>  
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ConsumerAccountRoute.Login)]
        public async Task<IActionResult> Login([FromBody] ConsumerLoginRouteModel model)
        {
            ResultViewModel result = new ResultViewModel();
            result.ResultEnum = Result.Failed.ToString();
            result.ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST;

            //if (string.IsNullOrWhiteSpace(model.mobileNoEmailOrSocialId)) return BadRequest(result = new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = "Invalid mobile,email or social id" });
            //if (!model.isSocial && model.mobileNoEmailOrSocialId.StartsWith("63") && (model.mobileNoEmailOrSocialId.Length != 12)) return BadRequest(result = new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_MOBILE_NUMBER });
            //if (!model.isSocial && !model.mobileNoEmailOrSocialId.StartsWith("63") && !new EmailValidation().validate(model.mobileNoEmailOrSocialId)) return BadRequest(result = new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS });

            //Check model states
            foreach (var modelState in ViewData.ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    return BadRequest(result = new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = error.ErrorMessage });
                }
            }

            if (ModelState.IsValid)
            {
                //Check Account if Exist
                var account = new ConsumerAccountEntity()
                {
                    IsSocial = model.isSocial,
                    SocialId =   model.mobileNoEmailOrSocialId,
                    EmailAddress = model.mobileNoEmailOrSocialId,//!model.isSocial && !model.mobileNoEmailOrSocialId.StartsWith("63") ? model.mobileNoEmailOrSocialId : "",
                    MobileNumber= model.mobileNoEmailOrSocialId, //!model.isSocial &&  model.mobileNoEmailOrSocialId.StartsWith("63") ? model.mobileNoEmailOrSocialId : "",
                    AppCode=model.AppCode
                };

                result = await accountManager.Login(account);
                return Ok(result);
            }
            return BadRequest(result);
        }

         


        /// <summary>
        /// get by Device Id
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ConsumerAccountRoute.LoginByDeviceId)]
        public async Task<IActionResult> LoginByDeviceId([FromRoute] string deviceId)
        {
            try
            {
                var result = await accountManager.LoginByDeviceId(deviceId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }
        }


        /// <summary>
        ///     Generate Refersh Token
        /// </summary>
        /// <param name="model">Refresh Token</param>
        /// <returns>Json object</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ConsumerAccountRoute.RefreshToken)]
        public async Task<IActionResult> Refresh([FromBody] RefereshTokenRequest model)
        {
            var token = HttpContext.Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
          
             var response = await accountManager.RefreshToken(token, model.RefreshToken);
            if (response.ResultEnum != Result.Success.ToString()) return BadRequest(response);
            return Ok(response);
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
        [HttpPatch(ApiRoutes.ConsumerAccountRoute.Update)]
        public async Task<IActionResult> UpdateModel([FromBody] ConsumerUpdateAccountRouteModel model, string userId)
        {
            try
            {
                if (model == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
                if (!ModelState.IsValid) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
                var result =   UpdateValidation(model,  userId);
                if (!(bool)result.ResultObject) return BadRequest(result);

                var account = await accountManager.FindOne(userId);
                if (account == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
                //account.EmailAddress = model.Email;
                //account.MobileNumber = model.MobileNumber;
                account.FirstName = model.FirstName;
                account.LastName = model.LastName;
                account.ImagePath = model.ImagePath;
                account.ModifiedBy = HttpContext.GetUserId();
                account.DateModified = Common.getDateNow();
                var isUpdate = await accountManager.Update(account);

                if (isUpdate) return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultObject = model, ResultMessage = Constants.MESSAGE_SUCCESS });
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });

            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }
         
        /// <summary>
        /// update user status
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status">1=active,2=pending,3=cancelled,4=InActive,5=Blocked</param>
        /// <returns>return json result</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.ConsumerAccountRoute.UpdateStatus)]
        public async Task<IActionResult> UpdateStatus([FromRoute] string userId, [FromRoute] ConsumerStatus status)
        {
            ResultViewModel result = new ResultViewModel();
            result.ResultEnum = Result.Failed.ToString();
            result.ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST;
            try
            {
                var model = await accountManager.FindOne(userId);
                if (model == null) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Error.ToString() });
                model.Status = status;
                var isUpdated = await accountManager.Update(model);

                var userStatus = new
                {
                    userId = userId,
                    Status = model.Status.ToString(),
                };

                await new ConsumerHubManager().PublishAccountStatus(userStatus);

                if (!isUpdated) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST, ResultEnum = Result.Failed.ToString() });
                result.ResultEnum = Result.Success.ToString();
                result.ResultMessage = Constants.MESSAGE_SUCCESS;
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(result);

            }
        }
         
        #endregion
        #region Get

        /// <summary>
        /// Get User information
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>return user information</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.Get)]
        public async Task<IActionResult> GetByUserId([FromRoute] string userId)
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                var account = await accountManager.FindOne(userId);
                //var response = items.FirstOrDefault();
                if (account == null) return Ok(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                var model = new
                {
                    userId = account.GUID,
                    Email = account?.EmailAddress,
                    MobileNumber = account?.MobileNumber,
                    Rating = account.Rating / account.RatingCount == 0 ? 1 : account.RatingCount,
                    FirstName = account?.FirstName,
                    LastName = account?.LastName,
                    ImagePath = account?.ImagePath,
                    IsSocial = account?.IsSocial,
                    SocialId = account?.SocialId,
                    OrderCount = account.OrderCount,
                    Status = account.Status.ToString(),
                    //== EStatus.Active ? "Active" : account.Status == EStatus.Pending ? "Pending" : "Cancelled",
                };
                return Ok(new ResultViewModel() { ResultObject = model, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <param name="status">0=all,1=active,2=pending,3=cancelled</param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns>Return list of users</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.GetAll)]
        public async Task<IActionResult> GetUsers([FromQuery] ConsumerFilterStatus status =  ConsumerFilterStatus.All, [FromRoute] int skip=0, [FromRoute] int take=50)
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                IQueryable<ConsumerAccountEntity> accountsResults = null;
                if (status == ConsumerFilterStatus.All) accountsResults = await accountManager.Where(x=>x.MobileNumber!="");
                if (status != ConsumerFilterStatus.All) accountsResults = await accountManager.Where(x =>  x.MobileNumber!="" &&  x.Status == status.convertToEStatus());
                var accounts = accountsResults?.OrderByDescending(x=>x.DateCreated).Skip(skip).Take(take).ToList();
                //if (accounts.Count() == 0) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                List<object> models = new List<object>();
                foreach (var account in accounts)
                {
                    var model = new
                    {
                        userId = account.GUID,
                        Email = account?.EmailAddress,
                        MobileNumber = account?.MobileNumber,
                        Rating = account.Rating/account.RatingCount==0 ? 1 : account.RatingCount,
                        FirstName = account?.FirstName,
                        LastName = account?.LastName,
                        ImagePath = account?.ImagePath,
                        IsSocial = account?.IsSocial,
                        SocialId = account?.SocialId,
                        OrderCount = account.OrderCount,
                        Status = account.Status.ToString(),
                        //== EStatus.Active ? "Active" : account.Status == EStatus.Pending ? "Pending" : "Cancelled",

                    };
                    models.Add(model);
                }
                return Ok(new ResultViewModel() { ResultObject = models, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
        }

            /// <summary>
            /// add favorite merchant
            /// </summary>
            /// <param name="userId"></param>
            /// <param name="merchantId"></param>
            /// <returns></returns>
            [HttpPost(ApiRoutes.ConsumerAccountRoute.AddFavoriteMerchant)]
            public async Task<IActionResult> AddFavoriteMerchant([FromRoute] string userId,[FromRoute] string merchantId)
            {
                try
                {
                    if (string.IsNullOrEmpty(userId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                    if (string.IsNullOrEmpty(merchantId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                    var response = await accountManager.AddFavoriteMerchant(userId, merchantId);
                    if (response) 
                        return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
                   else
                        return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
                }
                catch (Exception ex)
                {
                    return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.GET_ERROR(ex)});
                }
            }


        [HttpDelete(ApiRoutes.ConsumerAccountRoute.RemoveFavoriteMerchant)]
        public async Task<IActionResult> RemoveFavoriteMerchant([FromRoute] string userId, [FromRoute] string merchantId)
        {
            try
            {
                if (string.IsNullOrEmpty(userId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                if (string.IsNullOrEmpty(merchantId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                var response = await accountManager.RemoveFavoriteMerchant(userId, merchantId);
                if (response)
                    return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
                else
                    return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }

        /// <summary>
        /// Get All nearest merchants
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param> 
        /// <returns>Return list of merchants</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.GetNearestMerchantAll)]
        public async Task<IActionResult> GetNearestMerchantAll([FromRoute]string longitude,[FromRoute] string latitude,[FromRoute] int skip=0, [FromRoute] int take=15)
        {
            try
            {
                var id = HttpContext.GetUserId();
                var account = await accountManager.FindOne(id);
                if (account == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in" });

                double.TryParse(longitude, out var Longitude);
                double.TryParse(latitude, out var Latitude);

                var point = Common.CreateGeometryPoint(Longitude, Latitude);
                var results = await  accountManager.GetNearest(point, skip, take);
                if (results.Item1)
                    return Ok(new ResultViewModel() { ResultObject = results.Item2, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
                else
                    return BadRequest(new ResultViewModel() { ResultObject = results.Item2, ResultEnum = Result.Failed.ToString(), ResultMessage = results.Item2.ToString()});
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

        /// <summary>
        ///  Get All nearest merchants by Name
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <param name="merchantName"></param>
        /// <returns>Return list of merchants</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.GetNearestMerchantAllByName)]
        public async Task<IActionResult> GetNearestMerchantAllByName([FromRoute] string longitude, [FromRoute] string latitude, [FromRoute] string merchantName)
        {
            try
            {
                var id = HttpContext.GetUserId();
                var account = await accountManager.FindOne(id);
                if (account == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in" });

                double.TryParse(longitude, out var Longitude);
                double.TryParse(latitude, out var Latitude);

                var point = Common.CreateGeometryPoint(Longitude, Latitude);
                var results = await accountManager.GetNearestByName(point, merchantName);
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
        /// Get All nearest merchants by Category
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param> 
        /// <returns>Return list of merchants</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.GetNearestMerchantCategory)]
        public async Task<IActionResult> GetNearestMerchantCategory([FromRoute]string category, [FromRoute] string longitude, [FromRoute] string latitude, [FromRoute] int skip = 0, [FromRoute] int take = 15)
        {
            try
            {
                var id = HttpContext.GetUserId();
                var account = await accountManager.FindOne(id);
                if (account == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in" });

                double.TryParse(longitude, out var Longitude);
                double.TryParse(latitude, out var Latitude);
                var point = Common.CreateGeometryPoint(Longitude, Latitude);
                var results = await accountManager.GetNearestCategory(category, point, skip, take);
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
        /// Get All nearest merchants by Favorites
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param> 
        /// <returns>Return list of merchants</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.GetNearestMerchantFavorites)]
        public async Task<IActionResult> GetNearestMerchantFavorites(  [FromRoute] string longitude, [FromRoute] string latitude, [FromRoute] int skip = 0, [FromRoute] int take = 15)
        {
            try
            {
                var userId = HttpContext.GetUserId();
                var account = await accountManager.FindOne(userId);
                if (account == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in" });
                double.TryParse(longitude, out var Longitude);
                double.TryParse(latitude, out var Latitude);
                var point = Common.CreateGeometryPoint(Longitude, Latitude);
                var results = await accountManager.GetFavorites(userId,point, skip, take);
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
        /// Get All Contacts
        /// </summary>      
        /// <returns>Return list of users</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">UnAthorized</response>
        /// <response code="500">Server error</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.GetContatcs)]
        public async Task<IActionResult> GetContactList()
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                IQueryable<ConsumerAccountEntity> accountsResults = null;
                accountsResults = await accountManager.Where(c => c.Status == ConsumerStatus.Active);

                string contacts = "";
                //foreach (var account in accountsResults)
                //{

                //    contacts = string.Concat(account?.MobileNumber, ",", contacts);

                //}
                foreach (var account in accountsResults)
                {

                    if (account.MobileNumber.Length == 12)
                    {
                        contacts = string.Concat(account?.MobileNumber, ",", contacts);
                    }

                }

                return Ok(new ResultViewModel() { ResultObject = contacts.Remove(contacts.Length - 1, 1), ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
        }

        #endregion
        #region Delete

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Json object</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpDelete(ApiRoutes.ConsumerAccountRoute.Delete)]
        public async Task<IActionResult> Delete([FromRoute] string userId)
        {
            try
            {
                var isSuccess = await accountManager.Delete(userId);
                if (isSuccess) return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS, ResultObject = true });
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
            catch (Exception)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.ConsumerAccountRoute.GetBySocialId)]
        public async Task<IActionResult> GetbySocialId([FromBody] AppCodeModel model, [FromRoute] string socialId)
        {
            try
            {
                var result = await accountManager.CheckSocialId(socialId,model.AppCode);
                if (result.ResultEnum == Result.Success.ToString()) return Ok(result);
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum=Result.Error.ToString(), ResultMessage=Constants.GET_ERROR(ex)});
            }
        }


        [HttpPost(ApiRoutes.ConsumerAccountRoute.GetMerchantSchedule)]
        public async Task<IActionResult> GetMerchantSchedule([FromBody] MerchantSchedRequest model)
        {
            try
            {
                var data = await accountManager.GetMerchantSched(model.merchantId, model.dateTime);
                if (data != null)
                    return Ok(new ResultSuccess(data));
                else
                    return BadRequest(new ResultFailed());
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.ConsumerAccountRoute.RegisterMobile)]
        public async Task<IActionResult> RegisterMobile([FromRoute] string mobileNo,[FromBody] AppCodeModel model )
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mobileNo)) return  NotFound(new ResultFailed( Constants.MESSAGE_INVALID_INPUT ));
                if (mobileNo.StartsWith("63") && mobileNo.Length != 12)  return BadRequest(new ResultFailed( Constants.MESSAGE_INVALID_MOBILE_NUMBER ));

                var account =  (await accountManager.Where(x => x.MobileNumber == mobileNo)) .FirstOrDefault();
                if (account != null)  return BadRequest(new ResultFailed(Constants.MESSAGE_ACCOUNT_ALREADY_EXISTS));

                var success = await accountManager.RegisterMobileAsync(mobileNo, model.AppCode);
                if (success) return Ok(new ResultSuccess());
                else return BadRequest(new ResultFailed(  Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(Constants.GET_ERROR(ex)));
            }
        }
        #endregion
    }
    public class AppCodeModel
    {
        public string AppCode { get; set; }
    }
    public class MerchantSchedRequest
    {
        public string merchantId { get; set; }
        public DateTime dateTime  { get; set; }

    }
}