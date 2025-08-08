using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Collections.Generic;
using AccountManagement.MicroService.RouteModels;
using AccountManagement.MicroService.Controllers.validation;
using Microsoft.AspNetCore.Http;
using AccountManagement.Framework.Models;
using AccountManagement.Framework.Core.Interfaces;
using Microsoft.Net.Http.Headers;
using AccountManagement.MicroService.Hubs.Managers;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Account-Admin")]
    [Produces("application/json")]
    public class AdministrativeController : Controller
    {
        private IAdminAccountManager<AdminAccountEntity> accountManager;

        public AdministrativeController(IAdminAccountManager<AdminAccountEntity> _accountManager)
        {
            accountManager = _accountManager;
        }

        private async Task<ResultViewModel> RegistrationValidation(AdminBaseRouteModel model, string UserId)
        {
            try
            {
                if (model == null) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT };
                if (!(new EmailValidation().validate(model.Email))) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS };
                //Check model states
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = error.ErrorMessage };
                    }
                }

                if (model.Username.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model.Username)) };
                if (model.FirstName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model.FirstName)) };
                if (model.LastName.hasSpecialChar()) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model.LastName)) };

                var items = await accountManager.Where(x => (x.EmailAddress == model.Email.Trim() || x.Username == model.Username.Trim()) && x.GUID != UserId);
                if (items.Count() > 0) return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = "Email or Username is already taken." };
                return new ResultViewModel() { ResultObject = true, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS };
            }
            catch (Exception ex)
            {
                return new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message };
            }
        }
        #region Post


        /// <summary>
        /// Register administrator account
        /// </summary>
        /// <param name="model"></param>
        /// <returns>accessToken</returns> 
        /// <returns>refreshToken</returns> 
        /// <returns>userId</returns>  
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.AdminAccountRoute.Register)]
        public async Task<IActionResult> Register([FromBody] AdminCreateAccountRouteModel model)
        {
            ResultViewModel result = new ResultViewModel();
            result.ResultEnum = Result.Failed.ToString();
            result.ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST;
            try
            {
                if (string.IsNullOrEmpty(model.Password)) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_PASSWORD });
                if (model.Password != model.ConfirmPassword) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_NOT_MATCH_PASSWORD });

                result = await RegistrationValidation(model, "");
                if (!(bool)result.ResultObject) return BadRequest(result);

                if (!ModelState.IsValid) return BadRequest(result);

                var account = new AdminAccountEntity()
                {
                    EmailAddress = model.Email,
                    StaffId = model.StaffId,
                    MobileNumber = model.MobileNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    JobPosition = model.JobPosition,
                    ValidUntil = model.ValidUntil,
                    Username = model.Username.Trim(),
                    Password = model.Password,
                    SetEffectivity = model.SetEffectivity,
                    UserType = model.RoleId
                };

                result = await accountManager.Register(account);

                //if (result.ResultEnum == Result.Success.ToString())
                //{
                //    var accountmodel = new AdminAccount
                //    {
                //         AdminId=account.GUID
                //    };

                //    publisher.Publish(accountmodel, "admin");
                //}
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.ResultMessage = ex.Message;
                return BadRequest(result);
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
        [HttpPost(ApiRoutes.AdminAccountRoute.Login)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] UsernamePasswordLoginRouteModel model)
        {

            if (model == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT }); ;
            //Check model states
            foreach (var modelState in ViewData.ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = error.ErrorMessage });
                }
            }

            if (ModelState.IsValid)
            {
                //Check Account if Exist
                var userAccount = new AdminAccountEntity()
                {
                    Username = model.Username.Trim(),
                    Password = model.Password,
                };

                var result = await accountManager.Login(userAccount);
                return Ok(result);
            }
            return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
        }

         


        /// <summary>
        /// Send Email for resetting accounts
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Json object</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.AdminAccountRoute.EmailReset)]
        public async Task<IActionResult> ResetAccount([FromBody] ResetAccountRouteModel model)
        {
            if (string.IsNullOrWhiteSpace(model.baseUrl)) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
            if (new EmailValidation().validate(model.emailAddress) == false) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS });
            var account = await accountManager.Where(x => x.EmailAddress == model.emailAddress);
            if (account.Count() == 0) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
            var isSent = await accountManager.SendResetEmail(model.emailAddress, account.FirstOrDefault().GUID, model.baseUrl);
            if (!isSent) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Unable to send an email" });
            return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
        }

         

        /// <summary>
        /// Refresh Token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <returns>return json result</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.AdminAccountRoute.RefreshToken)]
        public async Task<IActionResult> Refresh([FromBody] RefereshTokenRequest model)
        {
            var token = HttpContext.Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var response = await accountManager.RefreshToken(token, model.RefreshToken);
            if (response.ResultEnum != Result.Success.ToString()) return BadRequest(response);
            return Ok(response);
        }

         

        #endregion
        #region  Patch

        /// <summary>
        /// update account info
        /// </summary>
        /// <param name="model"></param>
        /// <returns>accessToken</returns> 
        /// <returns>refreshToken</returns> 
        /// <returns>userId</returns>  
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.AdminAccountRoute.Update)]
        public async Task<IActionResult> UpdateModel([FromBody] AdminUpdateAccountRouteModel model, string userId)
        {
            try
            {
                var result = await RegistrationValidation(model, userId);
                if (!(bool)result.ResultObject) return BadRequest(result);
                if (!ModelState.IsValid) return BadRequest(result);
                var account = await accountManager.FindOne(userId);
                if (account == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
                account.EmailAddress = model.Email;
                account.MobileNumber = model.MobileNumber;
                account.FirstName = model.FirstName;
                account.LastName = model.LastName;
                account.JobPosition = model.JobPosition;
                account.ValidUntil = model.ValidUntil;
                account.SetEffectivity = model.SetEffectivity;
                account.UserType = model.RoleId;
                account.Username = model.Username;
                account.StaffId = model.StaffId;

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
        /// <param name="status">1=active,2=pending,3=cancelled</param>
        /// <returns>return json result</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.AdminAccountRoute.UpdateStatus)]
        public async Task<IActionResult> UpdateStatus([FromRoute] string userId, [FromRoute] EStatus status)
        {
            ResultViewModel result = new ResultViewModel();
            result.ResultEnum = Result.Failed.ToString();
            result.ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST;
            try
            {
                var model = await accountManager.FindOne(userId);
                if (model == null) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });
                model.Status = status;

                var isUpdated = await accountManager.Update(model);

                var userStatus = new
                {
                    userId = userId,
                    Status = model.Status.ToString(),
                };
                await new AdminHubManager().PublishAccountStatus(userStatus);

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

        /// <summary>
        /// Change user Password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>return json result</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.AdminAccountRoute.ChangePassword)]
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
        [HttpPatch(ApiRoutes.AdminAccountRoute.ResetPassword)]
        public async Task<IActionResult> ResetPassword([FromBody] ChangePasswordEmailRouteModel model)
        {
            if (model == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
            if (model.NewPassword != model.ConfirmNewPassword) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_NOT_MATCH_PASSWORD });
            if (new EmailValidation().validate(model.EmailAddress) == false) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS });
            var account = (await accountManager.Where(x => x.EmailAddress == model.EmailAddress)).SingleOrDefault();
            if (account == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
            if (account.Status != EStatus.Active) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_ACTIVE });
            account.Password = model.NewPassword;
            var result = await accountManager.ResetPassword(account);
            if (result.ResultEnum == Result.Success.ToString()) return Ok(result);
            return BadRequest(result);
        }

        #endregion
        #region  Get

        /// <summary>
        /// Get User Information
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <returns>return json result</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.AdminAccountRoute.Get)]
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
                    userId = account?.GUID,
                    StaffId = account?.StaffId,
                    Username = account?.Username,
                    Email = account?.EmailAddress,
                    MobileNumber = account?.MobileNumber,
                    FirstName = account?.FirstName,
                    LastName = account?.LastName,
                    RoleId = account.UserType,
                    JobPosition = account?.JobPosition,
                    ValidUntil = account?.ValidUntil,
                    Status = account?.Status == EStatus.Active ? "Active" : account?.Status == EStatus.Pending ? "Pending" : "Cancelled",
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
        /// <param name="role">0=All</param>
        /// <returns>Return list of users</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">UnAthorized</response>
        /// <response code="500">Server error</response>
        [HttpGet(ApiRoutes.AdminAccountRoute.GetAll)]
        public async Task<IActionResult> GetAll([FromRoute] FilterEStatus status = FilterEStatus.All, [FromRoute] int skip = 0, [FromRoute] int take = 50, [FromRoute] string role = "")
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                List<AdminAccountEntity> accountsResults = new List<AdminAccountEntity>();
                if (status == FilterEStatus.All) accountsResults = (await accountManager.All()).OrderByDescending(x=>x.DateCreated).Skip(skip).Take(take).ToList();
                if (status != FilterEStatus.All) accountsResults = (await accountManager.Where(x => x.Status == status.convertToEStatus())).Skip(skip).Take(take).ToList();
                //if (accountsResults.Count() == 0) return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS });
                List<object> models = new List<object>();
                foreach (var account in accountsResults)
                {
                    var model = new
                    {
                        userId = account.GUID,
                        StaffId = account.StaffId,
                        Username = account?.Username,
                        Email = account?.EmailAddress,
                        MobileNumber = account?.MobileNumber,
                        FirstName = account?.FirstName,
                        LastName = account?.LastName,
                        RoleId = account.UserType,
                        JobPosition = account.JobPosition,
                        ValidUntil = account.ValidUntil,
                        Status = account.Status == EStatus.Active ? "Active" : account.Status == EStatus.Pending ? "Pending" : "Cancelled",
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
        /// Get All Contacts
        /// </summary>
        /// <param name="type"></param>      
        /// <returns>Return list of users</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">UnAthorized</response>
        /// <response code="500">Server error</response>
        [HttpGet(ApiRoutes.AdminAccountRoute.GetContatcs)]
        public async Task<IActionResult> GetContactList([FromRoute] string type = "")
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                List<AdminAccountEntity> accountsResults = new List<AdminAccountEntity>();
                accountsResults = (await accountManager.All()).ToList();

                string contacts = "";
                foreach (var account in accountsResults)
                {

                    contacts = string.Concat(account?.MobileNumber, ",", contacts);

                }

                return Ok(new ResultViewModel() { ResultObject = contacts.Remove(contacts.Length - 1, 1), ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
        }


        #endregion
        #region  Delete
        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Json object</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpDelete(ApiRoutes.AdminAccountRoute.Delete)]
        public async Task<IActionResult> Delete([FromRoute] string userId)
        {
            try
            {
                var isSuccess = await accountManager.Delete(userId);

                var userStatus = new
                {
                    userId = userId,
                    Status = "Deleted",
                };
                await new AdminHubManager().PublishAccountStatus(userStatus);

                if (isSuccess) return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS, ResultObject = true });
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
            catch (Exception)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
            }
        }
        #endregion

    }
}