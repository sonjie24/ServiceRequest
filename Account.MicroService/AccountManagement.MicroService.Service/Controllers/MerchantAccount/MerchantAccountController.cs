using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using AccountManagement.MicroService.RouteModels;
using System.Linq;
using System.Collections.Generic;
using AccountManagement.MicroService.Controllers.validation;
using AccountManagement.Framework.Models;
using AccountManagement.Framework.Core.Interfaces;
using Microsoft.Net.Http.Headers;
using AccountManagement.MicroService.Hubs.Managers;
using AccountManagement.MicroService.Controllers.Publisher;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Account-Merchant-User")]
    public class MerchantAccountController : Controller
    {
        private readonly IMerchantAccountManager<MerchantAccountEntity> accountManager;
        private readonly IMerchantStoreManager<MerchantStoreEntity> store;
        private readonly IPublisher publisher;

        public MerchantAccountController(
                                IMerchantAccountManager<MerchantAccountEntity> _accountManager,
                                IMerchantStoreManager<MerchantStoreEntity> store, IPublisher publisher)
        {
            this.store = store;
            accountManager = _accountManager;
            this.publisher = publisher;
        }


        #region Post

        private async Task<ResultViewModel> RegistrationValidation(MerchantCreateAccountRouteModel model, string userId)
        {
            try
            {
                if (model == null) return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT };
                if (model.Password != model.ConfirmPassword) return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_NOT_MATCH_PASSWORD };
                if (!(new EmailValidation().validate(model.Email))) return new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS };

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

                var findAccount = await accountManager.Where(x => x.EmailAddress == model.Email && x.GUID != userId);
                if (findAccount.Count() > 0) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_EMAIL_ALREADY_EXISTS };


                return new ResultViewModel() { ResultObject = true, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS };
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) };
            }
        }

        /// <summary>
        /// Register merchant account
        /// </summary>
        /// <param name="model"></param>
        /// <returns>access token</returns>
        /// <returns>refresh token</returns>
        /// <returns>userId</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.MechantAccountRoute.RegisterUser)]
        public async Task<IActionResult> RegisterUser([FromBody] MerchantCreateAccountRouteModel model)
        {
            try
            {
                var result = await RegistrationValidation(model, "");

                if (!(bool)result.ResultObject && !result.ResultMessage.Contains("does not exists")) return BadRequest(result);
                if (!(bool)result.ResultObject && result.ResultMessage.Contains("does not exists")) return NotFound(result);
                if (!ModelState.IsValid) return BadRequest(result);
                if (string.IsNullOrWhiteSpace(model.MerchantId)) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "Main branch does not exists." });

                //check if this merchant is already exists
                var merchant = await store.FindOne(model.MerchantId);
                if (merchant == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "Main branch does not exists." });

                var account = new MerchantAccountEntity();
                account.MerchantId = merchant.Id;
                account.EmailAddress = model.Email.Trim();
                account.MobileNumber = model.MobileNumber;
                account.FirstName = model.FirstName;
                account.LastName = model.LastName;
                account.Password = model.Password;
                account.StaffId = model.StaffId;
                account.UserType = model.UserType;
                result = await accountManager.Register(account);

              
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
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
        [HttpPost(ApiRoutes.MechantAccountRoute.Login)]
        public async Task<IActionResult> Login([FromBody] MerchantLoginModel model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.MobileEmailSocialId)) return Ok(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = "Invalid mobile, email or social id" });
                if (!model.IsSocial && (model.MobileEmailSocialId.Length != 12 && model.MobileEmailSocialId.StartsWith("63"))) return Ok(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = "Mobile # must be 12 digit" });
                if (!model.IsSocial && !model.MobileEmailSocialId.StartsWith("63") && !new EmailValidation().validate(model.MobileEmailSocialId)) return Ok(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = "Invalid Email Address" });

                //Check model states
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return Ok(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = error.ErrorMessage });
                    }
                }

                if (ModelState.IsValid)
                {
                    //Check Account if Exist
                    var account = new MerchantAccountEntity()
                    {
                        SocialId = model.IsSocial ? model.MobileEmailSocialId.Trim() : "",
                        MobileNumber = !model.IsSocial && model.MobileEmailSocialId.StartsWith("63") ? model.MobileEmailSocialId : "",
                        EmailAddress = new EmailValidation().validate(model.MobileEmailSocialId.Trim()) ? model.MobileEmailSocialId.Trim() : "",
                        IsSocial = model.IsSocial,
                        Password = model.Password
                    };
                    var result = await accountManager.Login(account);
                    return Ok(result);
                }
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }


        /// <summary>
        /// Send Email for resetting accounts
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Json object</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.MechantAccountRoute.EmailReset)]
        public async Task<IActionResult> ResetAccount([FromBody] ResetAccountRouteModel model)
        {

            if (string.IsNullOrWhiteSpace(model.baseUrl)) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
            if (new EmailValidation().validate(model.emailAddress) == false) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS });
            var account = await accountManager.Where(x => x.EmailAddress == model.emailAddress);
            if (account.Count() == 0) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
            var isSent = await accountManager.SendResetEmail(model.emailAddress, account.FirstOrDefault().GUID, model.baseUrl);
            if (!isSent) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Unable to send an email" });
            return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>access_token</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.MechantAccountRoute.RefreshToken)]
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
        [HttpPatch(ApiRoutes.MechantAccountRoute.Update)]
        public async Task<IActionResult> UpdateModel([FromBody] MerchantCreateAccountRouteModel model, string userId)
        {
            try
            {
                if (model == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
                //Check model states
                //if (!ModelState.IsValid) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
                var account = await accountManager.FindOne(userId);
                if (account == null) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                var result = await RegistrationValidation(model, userId);
                if (!(bool)result.ResultObject) return BadRequest(result);

                account.EmailAddress = model.Email;
                account.MobileNumber = model.MobileNumber;
                account.FirstName = model.FirstName;
                account.LastName = model.LastName;
                account.Password = model.Password;
                account.ImagePath = model.ImagePath;
                account.ModifiedBy = HttpContext.GetUserId();
                account.DateModified = Common.getDateNow();

                account.StaffId = model.StaffId;
                account.UserType = model.UserType;

                account.Merchant.ContactFirstName = model.FirstName;
                account.Merchant.ContactLastName = model.LastName;
                account.Merchant.ContactNo = model.MobileNumber;
                account.Merchant.Email = model.Email;
                account.Merchant.ModifiedBy = account.ModifiedBy;
                account.Merchant.DateModified = account.DateModified;

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
        /// <param name="status">1=active,2=pending,3=cancelled</param>
        /// <returns>return json result</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.MechantAccountRoute.UpdateStatus)]
        public async Task<IActionResult> UpdateStatus([FromRoute] string userId, [FromRoute] EStatus status)
        {

            try
            {
                var model = await accountManager.FindOne(userId);
                if (model == null) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Error.ToString() });
                model.Status = status;
                var isUpdated = await accountManager.Update(model);

                //var storeaccount = await store.FindOne(model.MerchantId);
                //if (storeaccount!=null)
                //{
                //    storeaccount.Status = status;
                //    await store.Update(storeaccount);
                //}

                if (!isUpdated) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST, ResultEnum = Result.Failed.ToString() });

                var userStatus = new
                {
                    userId = userId,
                    Status = model.Status.ToString(),
                };

                await new MerchantUserHubManager().PublishAccountStatus(userStatus);

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

        /// <summary>
        /// Change user Password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>return json result</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.MechantAccountRoute.ChangePassword)]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordOldRouteModel model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.NewPassword) || string.IsNullOrWhiteSpace(model.ConfirmNewPassword)) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_INVALID_PASSWORD, ResultEnum = Result.Error.ToString() });
                if (model.NewPassword != model.ConfirmNewPassword) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_NOT_MATCH_PASSWORD, ResultEnum = Result.Error.ToString() });
                if (model.NewPassword.Length < 8) return BadRequest(new ResultViewModel() { ResultMessage = "The field Password must be a string or array type with a minimum length of '8'", ResultEnum = Result.Error.ToString() });
                var account = await accountManager.FindOne(model.UserId);
                if (account == null) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Error.ToString() });

                //verifiy old password
                var isvalidOldPassword = accountManager.VerifyPassword(model.OldPassword, account.Password);
                if (!isvalidOldPassword) return BadRequest(new ResultViewModel() { ResultMessage = "Invalid Old Password", ResultEnum = Result.Error.ToString() });

                //check if password has been used to this account.
                var isPasswordUsed = accountManager.IsOldPasswordUsed(model.UserId, model.NewPassword);
                if (isPasswordUsed) return BadRequest(new ResultViewModel() { ResultMessage = "Cannot use old password", ResultEnum = Result.Error.ToString() });

                //encrypt password and save
                account.Password = model.NewPassword;
                var isUpdated = await accountManager.ChangePassword(account);
                if (!isUpdated) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST, ResultEnum = Result.Failed.ToString() });
                var result = new ResultViewModel();
                result.ResultEnum = Result.Success.ToString();
                result.ResultMessage = Constants.MESSAGE_SUCCESS;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }

        /// <summary>
        /// Reset user password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Json object</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.MechantAccountRoute.ResetPassword)]
        public async Task<IActionResult> ResetPassword([FromBody] ChangePasswordEmailRouteModel model)
        {
            if (model == null) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
            if (model.NewPassword != model.ConfirmNewPassword) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_NOT_MATCH_PASSWORD });
            if (new EmailValidation().validate(model.EmailAddress) == false) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS });
            var account = (await accountManager.Where(x => x.EmailAddress == model.EmailAddress)).SingleOrDefault();
            if (account == null) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
            if (account.Status != EStatus.Active) return Ok(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_ACTIVE });
            account.Password = model.NewPassword;
            var result = await accountManager.ResetPassword(account);
            if (result.ResultEnum == Result.Success.ToString()) return Ok(result);
            return BadRequest(result);
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
        [HttpGet(ApiRoutes.MechantAccountRoute.Get)]
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
                    MerchantId = account.Merchant.GUID,
                    MobileNumber = account?.MobileNumber,
                    Email = account.EmailAddress,
                    FirstName = account?.FirstName,
                    LastName = account.LastName,
                    StaffId = account.StaffId,
                    UserType = account.UserType,
                    Status = account.Status == EStatus.Active ? "Active" : account.Status == EStatus.Pending ? "Pending" : "Cancelled",
                };
                return Ok(new ResultViewModel() { ResultObject = model, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
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
        [HttpGet(ApiRoutes.MechantAccountRoute.GetAll)]
        public async Task<IActionResult> GetUsers([FromRoute] string merchantId = "", [FromRoute] FilterEStatus status = FilterEStatus.All, [FromRoute] int skip = 0, [FromRoute] int take = 50)
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                if (string.IsNullOrWhiteSpace(merchantId)) return BadRequest(new ResultViewModel() { ResultMessage = "Merchant Not found." });
                IQueryable<MerchantAccountEntity> accountsResults = null;
                if (status == FilterEStatus.All) accountsResults = await accountManager.Where(x => x.Merchant.GUID == merchantId);
                if (status != FilterEStatus.All) accountsResults = await accountManager.Where(x => x.Status == status.convertToEStatus() && x.Merchant.GUID == merchantId);
                var accounts = accountsResults?.OrderByDescending(x=>x.DateCreated).Skip(skip).Take(take).ToList();
                //if (accounts.Count() == 0) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                List<object> models = new List<object>();
                foreach (var account in accounts)
                {
                    var model = new
                    {
                        userId = account.GUID,
                        MerchantId = account.Merchant?.GUID,
                        MobileNumber = account?.MobileNumber,
                        Email = account.EmailAddress,
                        FirstName = account?.FirstName,
                        LastName = account.LastName,
                        StaffId = account.StaffId,
                        UserType = account.UserType,
                        Status = account.Status == EStatus.Active ? "Active" : account.Status == EStatus.Pending ? "Pending" : "Cancelled",
                    };
                    models.Add(model);
                }
                return Ok(new ResultViewModel() { ResultObject = models, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

        /// <summary>
        /// Verify User account
        /// </summary>
        /// <param name="userGuid"></param>
        /// <returns>verification message</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.MechantAccountRoute.VerifyEmail)]
        public async Task<IActionResult> VerifyEmail([FromRoute] string userGuid)
        {
            try
            {
                var isSuccess = await accountManager.ActivateAccount(userGuid);
                if (!isSuccess) return BadRequest(Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST);
                return Ok("Email Verified Successfully");
            }
            catch (Exception)
            {
                return BadRequest(Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST);
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
        [HttpGet(ApiRoutes.MechantAccountRoute.GetContatcs)]
        public async Task<IActionResult> GetContactList()
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                IQueryable<MerchantAccountEntity> accountsResults = null;
                accountsResults = await accountManager.Where(c => c.Status == EStatus.Active && c.IsAccountConfirmed == true);

                string contacts = "";
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
        [HttpDelete(ApiRoutes.MechantAccountRoute.Delete)]
        public async Task<IActionResult> Delete([FromRoute] string userId)
        {
            try
            {
                var isSuccess = await accountManager.Delete(userId);
                if (isSuccess) return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS, ResultObject = true });
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
            }
        }

        #endregion


    }
     
}