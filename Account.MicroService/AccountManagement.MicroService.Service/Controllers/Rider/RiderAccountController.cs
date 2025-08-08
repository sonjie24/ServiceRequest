using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Data;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using AccountManagement.MicroService.Controllers.Publisher;
using AccountManagement.MicroService.Controllers.validation;
using AccountManagement.MicroService.Hubs.Manager;
using AccountManagement.MicroService.RouteModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Account-Rider")]
    public class RiderAccountController : Controller
    {
        private readonly IRiderAccoutManager<RiderAccountEntity> accountManager;
        private readonly IPublisher publisher;
        private Database db;
        private IGenericQueryManager genericQuery;

        public Task RiderHubController { get; private set; }

        public RiderAccountController(
            IRiderAccoutManager<RiderAccountEntity> _accountManager,
            IPublisher publisher
            , Database db = null, IGenericQueryManager genericQuery = null)
        {
            accountManager = _accountManager;
            this.publisher = publisher;
            this.db = db;
            this.genericQuery = genericQuery;
        }


        #region Post

        private async Task<ResultViewModel>
        RegistrationValidation(
            RiderCreateAccountRouteModel model,
            string userId
        )
        {
            try
            {
                if (model == null)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage = Constants.MESSAGE_INVALID_INPUT
                    };
                if (model.Password != model.ConfirmPassword)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage = "Password do not match."
                    };
                if (
                    !string.IsNullOrWhiteSpace(model.Email) &&
                    !new EmailValidation().validate(model.Email)
                )
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS
                    };

                //Check model states
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return new ResultViewModel()
                        {
                            ResultObject = false,
                            ResultEnum = Result.Error.ToString(),
                            ResultMessage = error.ErrorMessage
                        };
                    }
                }

                if (model.FirstName.hasSpecialChar())
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage =  Constants .GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model .FirstName))
                    };
                if (model.MiddleName.hasSpecialChar())
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage = Constants .GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model .MiddleName))
                    };
                if (model.LastName.hasSpecialChar())
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage =
                            Constants
                                .GET_SPECIAL_CHAR_NOT_ALLOWED(nameof(model
                                    .LastName))
                    };

                var items =
                    await accountManager
                        .Where(x =>
                            (
                            x.MobileNumber == model.MobileNumber ||
                            x.EmailAddress == model.Email
                            ) &&
                            x.GUID != userId);

                if (items.Count() > 0)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage =
                            "The mobile/Email is already registered."
                    };
                return new ResultViewModel()
                {
                    ResultObject = true,
                    ResultEnum = Result.Success.ToString(),
                    ResultMessage = Constants.MESSAGE_SUCCESS
                };
            }
            catch (Exception ex)
            {
                return new ResultViewModel()
                {
                    ResultObject = false,
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = ex.Message
                };
            }
        }

        

        private async Task<ResultViewModel> UpdateValidation(RiderUpdateAccountRouteModel model, string userId)
        {
            try
            {
                if (model == null)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage = Constants.MESSAGE_INVALID_INPUT
                    };
                if (
                    !string.IsNullOrWhiteSpace(model.Email) &&
                    !new EmailValidation().validate(model.Email)
                )
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS
                    };

                //Check model states
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        return new ResultViewModel()
                        {
                            ResultObject = false,
                            ResultEnum = Result.Error.ToString(),
                            ResultMessage = error.ErrorMessage
                        };
                    }
                }

                var items =(await accountManager
                        .Where(x =>
                            x.MobileNumber == model.MobileNumber &&
                            x.GUID != userId)).ToList();

                if (items.Count() > 0)
                    return new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Error.ToString(),
                        ResultMessage = Constants.MESSAGE_MOBILE_ALREADY_EXISTS
                    };

                return new ResultViewModel()
                {
                    ResultObject = true,
                    ResultEnum = Result.Success.ToString(),
                    ResultMessage = Constants.MESSAGE_SUCCESS
                };
            }
            catch (Exception ex)
            {
                return new ResultViewModel()
                {
                    ResultObject = false,
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = ex.Message
                };
            }
        }

        /// <summary>
        /// Register Rider Account
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Access Token</returns>
        /// <returns>Refresh Token</returns>
        /// <returns>userId</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.RiderAccountRoute.Register)]
        public async Task<IActionResult> Register([FromBody] RiderCreateAccountRouteModel model)
        {
            try
            {
                var result = await RegistrationValidation(model, "");
                if (!(bool) result.ResultObject) return BadRequest(result);
                if (!ModelState.IsValid) return BadRequest(result);
                var account =
                    new RiderAccountEntity()
                    {
                        MobileNumber = model.MobileNumber.Trim(),
                        EmailAddress = model.Email.Trim(),
                        FirstName = model.FirstName.Trim(),
                        MiddleName = model.MiddleName.Trim(),
                        LastName = model.LastName.Trim(),
                        Password = model.Password,
                        profile =
                            new PersonProfile()
                            {
                                FirstName = model.FirstName,
                                MiddleName = model.MiddleName,
                                LastName = model.LastName,
                                MobileNumber = model.MobileNumber,
                                EmailAddress = model.Email
                            }
                    };

                account.profile.GUID = account.GUID;
                result = await accountManager.Register(account);

                if (result.ResultEnum==Result.Success.ToString())
                {
                    var accountModel = new RiderAccount
                    {
                        RiderId = account.GUID,
                        EmailAddress=account.EmailAddress,
                        FirstName=account.FirstName,
                        MiddleName=account.MiddleName,
                        LastName=account.LastName,
                        MobileNumber=account.MobileNumber,
                    };

                   await publisher.Publish(accountModel, "ADD_RIDER");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = Constants.GET_ERROR(ex)
                });
            }
        }

        /// <summary>
        /// Register Rider Account
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Access Token</returns>
        /// <returns>Refresh Token</returns>
        /// <returns>userId</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.RiderAccountRoute.Register2)]
        public async Task<IActionResult> Register2([FromBody] RiderCreateAccountRouteModel model)
        {
            try
            {
                var result = await RegistrationValidation(model, "");
                if (!(bool)result.ResultObject) return BadRequest(result);
                if (!ModelState.IsValid) return BadRequest(result);
                var account = new RiderAccountEntity()
                    {
                        MobileNumber = model.MobileNumber.Trim(),
                        EmailAddress = model.Email.Trim(),
                        FirstName = model.FirstName.Trim(),
                        MiddleName = model.MiddleName.Trim(),
                        LastName = model.LastName.Trim(),
                        Password = model.Password,
                        profile =
                            new PersonProfile()
                            {
                                FirstName = model.FirstName,
                                MiddleName = model.MiddleName,
                                LastName = model.LastName,
                                MobileNumber = model.MobileNumber,
                                EmailAddress = model.Email
                            }
                    };

                account.profile.GUID = account.GUID;
                result = await accountManager.RegisterV2(account);
                if (result.ResultEnum == Result.Success.ToString())
                {
                    var accountModel = new RiderAccount
                    {
                        RiderId = account.GUID,
                        EmailAddress = account.EmailAddress,
                        FirstName = account.FirstName,
                        MiddleName = account.MiddleName,
                        LastName = account.LastName,
                        MobileNumber = account.MobileNumber,
                    };

                    await publisher.Publish(accountModel, "ADD_RIDER");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = Constants.GET_ERROR(ex)
                });
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
        [HttpPost(ApiRoutes.RiderAccountRoute.Login)]
        public async Task<IActionResult> Login([FromBody] MobilePasswordLogin model)
        {
            ResultViewModel result = new ResultViewModel();
            result.ResultEnum = Result.Failed.ToString();
            result.ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST;
            if (model == null)  return BadRequest(result =
                new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = Constants.MESSAGE_INVALID_INPUT
                });

            //Check model states
            foreach (var modelState in ViewData.ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    return BadRequest(result =
                        new ResultViewModel()
                        {
                            ResultEnum = Result.Error.ToString(),
                            ResultMessage = error.ErrorMessage
                        });
                }
            }

            if (ModelState.IsValid)
            {
                //Check Account if Exist
                var account =
                    new RiderAccountEntity()
                    {
                        MobileNumber = model.MobileNumber,
                        Password = model.Password
                    };
                result = await accountManager.Login(account);
                return Ok(result);
            }
            return BadRequest(result);
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
        [HttpPost(ApiRoutes.RiderAccountRoute.LoginV2)]
        public async Task<IActionResult> LoginV2([FromBody] MobilePasswordLogin model)
        {
            ResultViewModel result = new ResultViewModel();
            result.ResultEnum = Result.Failed.ToString();
            result.ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST;
            if (model == null) return BadRequest(result =
               new ResultViewModel()
               {
                   ResultEnum = Result.Error.ToString(),
                   ResultMessage = Constants.MESSAGE_INVALID_INPUT
               });

            //Check model states
            foreach (var modelState in ViewData.ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    return BadRequest(result =
                        new ResultViewModel()
                        {
                            ResultEnum = Result.Error.ToString(),
                            ResultMessage = error.ErrorMessage
                        });
                }
            }

            if (ModelState.IsValid)
            {
                //Check Account if Exist
                var account =
                    new RiderAccountEntity()
                    {
                        MobileNumber = model.MobileNumber,
                        Password = model.Password
                    };
                result = await accountManager.LoginV2(account);
                return Ok(result);
            }
            return BadRequest(result);
        }


        /// <summary>
        ///

        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <returns>return json result</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>

        [HttpPost(ApiRoutes.RiderAccountRoute.RefreshToken)]
        [AllowAnonymous]
        public async Task<IActionResult>
        Refresh([FromBody] RefereshTokenRequest model)
        {
            var token =
                HttpContext
                    .Request
                    .Headers[HeaderNames.Authorization]
                    .ToString()
                    .Replace("Bearer ", "");
            var response =
                await accountManager.RefreshToken(token, model.RefreshToken);
            if (response.ResultEnum != Result.Success.ToString())
                return BadRequest(response);
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
        [HttpPatch(ApiRoutes.RiderAccountRoute.Update)]
        public async Task<IActionResult>   UpdateModel( [FromBody] RiderUpdateAccountRouteModel model,
            string userId )
        {
            try
            {
                var result = await UpdateValidation(model, userId);
                if (!(bool) result.ResultObject) return BadRequest(result);
                if (!ModelState.IsValid) return BadRequest(result);

                var account = await accountManager.FindOne(userId);
                if (account == null) return BadRequest(result);

                account.FirstName = model.FirstName;
                account.MiddleName = model.MiddleName;
                account.LastName = model.LastName;
                account.MobileNumber = model.MobileNumber;
                account.EmailAddress = model.Email;
                account.ImagePath = model.ImagePath;
                account.profile.Rider = account;
                account.profile.Prefix = model.Prefix;
                account.profile.FirstName = model.FirstName;
                account.profile.MiddleName = model.MiddleName;
                account.profile.LastName = model.LastName;
                account.profile.Suffix = model.Suffix;
                account.profile.Nationality = model.Nationality;
                account.profile.CivilStatus = model.CivilStatus;
                account.profile.Gender = model.Gender;
                account.profile.DateBirth = model.DateBirth;
                account.profile.PlaceBirth = model.PlaceBirth;
                account.profile.MobileNumber = model.MobileNumber;
                account.profile.TelNo = model.TelNo;
                account.profile.Address1 = model.Address1;
                account.profile.Address2 = model.Address2;
                account.profile.Barangay = model.Barangay;
                account.profile.CityMunicipality = model.CityMunicipality;
                account.profile.Province = model.Province;
                account.profile.Region = model.Region;
                account.profile.ZipCode = model.ZipCode;
                account.profile.ImagePath = model.ImagePath;
                account.profile.AboutMe = model.AboutMe;
                account.profile.ModifiedBy = HttpContext.GetUserId();
                account.profile.DateModified = Common.getDateNow();
                account.profile.TransportType = model.TransportType;
                account.profile.yearModel = model.yearModel;
                account.profile.Make = model.Make;
                account.profile.Model = model.Model;
                account.profile.PlateNo = model.PlateNo;
                account.profile.Color = model.Color; 
                 
                if (await accountManager.Update(account))
                {
                    var accountModel = new RiderAccount
                    {
                        RiderId = account.GUID,
                        EmailAddress = account.EmailAddress,
                        FirstName = account.FirstName,
                        MiddleName = account.MiddleName,
                        LastName = account.LastName,
                        MobileNumber = account.MobileNumber,
                    };
                    await publisher.Publish(accountModel, "ADD_RIDER");
                    return Ok(new ResultViewModel()
                    {
                        ResultEnum = Result.Success.ToString(),
                        ResultObject = model,
                        ResultMessage = Constants.MESSAGE_SUCCESS
                    });
                }
                else
                {
                    return BadRequest(new ResultViewModel()
                    {
                        ResultEnum = Result.Failed.ToString(),
                        ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = Constants.GET_ERROR(ex)
                });
            }
        }

        /// <summary>
        /// Update booking limit
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="limitAmount"></param>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.RiderAccountRoute.UpdateLimit)]
        public async Task<IActionResult> UpdateLimit( [FromRoute] string userId,[FromRoute] string limitAmount)
        {
            try
            {
                decimal.TryParse(limitAmount, out var Amount);
                if (Amount<0) return    BadRequest(new ResultViewModel { ResultEnum= Result.Failed.ToString(), ResultMessage="Invalid Amount" });
                var account = await accountManager.FindOne(userId);
                if (account == null) return BadRequest(new ResultViewModel { ResultEnum = Result.Failed.ToString(), ResultMessage =  Constants.MESSAGE_ACCOUNT_NOT_EXISTS});
                account.LimitAmount = Amount;
                //push changes to rider through socket
                var _riderInfo = new
                {
                    riderId = userId,
                    limit = Amount
                };
                if (await accountManager.Update(account))

                //await RiderHubManager.PublishBookingLimit(_riderInfo);
                return Ok(new ResultViewModel()
                {
                    ResultEnum = Result.Success.ToString(),
                    ResultMessage = Constants.MESSAGE_SUCCESS
                });
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                });

            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = Constants.GET_ERROR(ex)
                });
            }
        }


        /// <summary>
        /// update user status
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status">1=active,2=pending,3=cancelled,5=Blocked</param>
        /// <returns>return json result</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.RiderAccountRoute.UpdateStatus)]
        public async Task<IActionResult>
        UpdateStatus([FromRoute] string userId, [FromRoute] RiderStatus status)
        {
            try
            {
                var model = await accountManager.FindOne(userId);
                if (model == null) return BadRequest(new ResultFailed( Constants.MESSAGE_ACCOUNT_NOT_EXISTS ));
                if (status == RiderStatus.Active)
                {
                    model.IsDocsComplied = true;
                }
                model.Status = status;
                var isUpdated = await accountManager.Update(model);
                if (!isUpdated) return BadRequest(new ResultFailed( Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));

                var userStatus = new
                {
                    userId = userId,
                    Status = model.Status.ToString(),
                };

                await new RiderHubManager().PublishAccountStatus(userStatus);

                var bookings = getTripsLog(userId);
                var tripsCount = bookings.Count();

                var item = getRiderInfo(model, tripsCount);
                return Ok(new ResultSuccess(item));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }
        }


        /// <summary>
        /// Set account online/offline (V1)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status">Offline,Online</param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPatch(ApiRoutes.RiderAccountRoute.UpdateOnlineOfflineStatusV1)]
        public async Task<IActionResult> UpdateOnlineOfflineStatusV1( [FromRoute] string userId, [FromRoute] RiderOnlineOffline status,[FromRoute] double latitude, [FromRoute] double longitude  )
        {
            try
            {
                var model = await accountManager.FindOne(userId);
                if (model == null) return BadRequest(new ResultFailed(Constants.MESSAGE_ACCOUNT_NOT_EXISTS));
                model.RiderOnlineOffline = status;
                model.Latitude = latitude;
                model.Longitude = longitude;

                ///TODO temporary Auto Online
                if (status==RiderOnlineOffline.Online)
                {
                    model.DeliveryStatus = status == RiderOnlineOffline.Online ? RiderDeliveryStat.Available : RiderDeliveryStat.UnAvailable;
                }

                var gf = NtsGeometryServices.Instance.CreateGeometryFactory(4326);
                var Location = gf.CreatePoint(new Coordinate(longitude, latitude));
                model.Location = Location;

                await accountManager.Update(model);

                var userStatus = new
                {
                    userId = userId,
                    Status = status.ToString(),
                };

                var bookings = getTripsLog(userId);
                var tripsCount = bookings.Count();


                var _rider = new RiderActivityEntity();
                _rider.Activity= status.ToString();
                _rider.DateTimeLog = Common.getDateNow();
                _rider.Status = status.ToString();
                _rider.RiderId = userId;
                db.context.RiderActivities.Add(_rider);
                db.context.SaveChanges();

                await new RiderHubManager().PublishOnlineOfflineStatus(userStatus);
                var riderInfo =  getRiderInfo(model, tripsCount);
                return Ok(new ResultSuccess(riderInfo));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }
        }

        /// <summary>
        /// Update Online offline Status
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        [HttpPatch(ApiRoutes.RiderAccountRoute.UpdateOnlineOfflineStatusV2)]
        public async Task<IActionResult> UpdateOnlineOfflineStatusV2([FromRoute] string userId, [FromRoute] RiderOnlineOffline status, [FromRoute] double latitude, [FromRoute] double longitude)
        {
            try
            {
                var model = await accountManager.FindOne(userId);
                if (model == null) return BadRequest(new ResultFailed(Constants.MESSAGE_ACCOUNT_NOT_EXISTS));
                model.RiderOnlineOffline = status;
                model.Latitude = latitude;
                model.Longitude = longitude;

                ///TODO temporary Auto Online
                if (status == RiderOnlineOffline.Online)
                {
                    model.DeliveryStatus = status == RiderOnlineOffline.Online ? RiderDeliveryStat.Available : RiderDeliveryStat.UnAvailable;
                }

                var gf = NtsGeometryServices.Instance.CreateGeometryFactory(4326);
                var Location = gf.CreatePoint(new Coordinate(longitude, latitude));
                model.Location = Location; 
                await accountManager.Update(model); 
                var userStatus = new
                {
                    userId = userId,
                    Status = status.ToString(),
                };


                var bookings = getTripsLog(userId);
                var tripsCount = bookings.Count();

                var _rider = new RiderActivityEntity();
                _rider.Activity = status.ToString();
                _rider.DateTimeLog = Common.getDateNow();
                _rider.Status = status.ToString();
                _rider.RiderId = userId;
                db.context.RiderActivities.Add(_rider);
                db.context.SaveChanges();

                await new RiderHubManager().PublishOnlineOfflineStatus(userStatus);
                var riderInfo = getRiderInfo(model,tripsCount);
                return Ok(new ResultSuccess(riderInfo));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }
        }

        /// <summary>
        /// Update Rider Delivery Status
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status"> UnAvailable=0, Available=1, Busy=2,</param>
        /// <returns>return json result</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost(ApiRoutes.RiderAccountRoute.UpdateDeliveryStatus)]
        public async Task<IActionResult> UpdateDeliveryStatus([FromRoute] string userId, [FromRoute]  RiderDeliveryStat status)
        {
            try
            {
                var model = await accountManager.FindOne(userId);
                if (model == null) return BadRequest(new ResultFailed(Constants.MESSAGE_ACCOUNT_NOT_EXISTS));
                model.DeliveryStatus = status;
                await accountManager.Update(model);
                 
                var userStatus = new
                {
                    userId = userId,
                    Status = status.ToString(),
                };

                var _rider = new RiderActivityEntity();
                _rider.Activity = status.ToString();
                _rider.DateTimeLog = Common.getDateNow();
                _rider.Status = status.ToString();
                _rider.RiderId = userId;
                db.context.RiderActivities.Add(_rider);
                db.context.SaveChanges();

                await new RiderHubManager().PublishBookingStatus(userStatus);
                return Ok(new ResultSuccess(model));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }

        }


        /// <summary>
        /// Change user Password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>return json result</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>

        [HttpPatch(ApiRoutes.RiderAccountRoute.ChangePassword)]
        public async Task<IActionResult>  ChangePassword([FromBody] ChangePasswordOldRouteModel model)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(model.NewPassword) ||
                    string.IsNullOrWhiteSpace(model.ConfirmNewPassword)
                )
                    return BadRequest(new ResultViewModel()
                    {
                        ResultMessage = Constants.MESSAGE_INVALID_PASSWORD,
                        ResultEnum = Result.Error.ToString()
                    });
                if (model.NewPassword != model.ConfirmNewPassword)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultMessage = Constants.MESSAGE_NOT_MATCH_PASSWORD,
                        ResultEnum = Result.Error.ToString()
                    });
                if (model.NewPassword.Length < 8)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultMessage =
                            Constants.MESSAGE_INVALID_PASSWORD_LENGTH,
                        ResultEnum = Result.Error.ToString()
                    });
                var account = await accountManager.FindOne(model.UserId);
                if (account == null)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS,
                        ResultEnum = Result.Error.ToString()
                    });

                //verifiy old password
                var isvalidOldPassword =
                    accountManager  .VerifyPasswordAsync(model.OldPassword,
                        account.Password);
                if (!isvalidOldPassword)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultMessage = "Invalid Old Password",
                        ResultEnum = Result.Error.ToString()
                    });

                //check if password has been used to this account.
                var isPasswordUsed =  accountManager .IsOldPasswordUsed(model.UserId, model.NewPassword);
                if (isPasswordUsed)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultMessage = "Cannot use old password",
                        ResultEnum = Result.Error.ToString()
                    });

                //encrypt password and save
                account.Password = model.NewPassword;
                var isUpdated =
                    await accountManager.ChangePasswordAsync(account);
                if (!isUpdated)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultMessage =
                            Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST,
                        ResultEnum = Result.Failed.ToString()
                    });
                var result = new ResultViewModel();
                result.ResultEnum = Result.Success.ToString();
                result.ResultMessage = Constants.MESSAGE_SUCCESS;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = Constants.GET_ERROR(ex)
                });
            }
        }

        /// <summary>
        /// Verify Email or Mobile for Password Reset
        /// </summary>
        /// <param name="emailOrMobile"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.RiderAccountRoute.VerifyEmailOrMobile)]
        public async Task<IActionResult>  VerifyEmailOrMobile([FromBody] AppCodeRider model)
        {
            if (string.IsNullOrWhiteSpace(model.mobile))
                NotFound(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_INVALID_INPUT
                });
            if (model.mobile.StartsWith("63") && model.mobile.Length != 12)
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_INVALID_MOBILE_NUMBER
                });
            if (
                !model.mobile.StartsWith("63") &&
                new EmailValidation().validate(model.mobile) == false
            )
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS
                });

            var account =  ( await accountManager .Where(x => x.MobileNumber == model.mobile ||  x.EmailAddress == model.mobile) ).FirstOrDefault();

            if (account == null)
                return NotFound(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS
                });

            //if (account.Status != EStatus.Active) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_ACTIVE });
            var success =  await accountManager.VerifyAccountAsync(model.mobile, account, model.AppCode);
            if (success)
            {
                return Ok(new ResultViewModel()
                {
                    ResultEnum = Result.Success.ToString(),
                    ResultMessage = "Success"
                });
            }
            else
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Success.ToString(),
                    ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                });
            }
        }

        /// <summary>
        /// Register Mobile No
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.RiderAccountRoute.RegisterMobile)]
        public async Task<IActionResult>  RegisterMobile([FromBody] AppCodeRider model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.mobile)) BadRequest(new ResultFailed(Constants.MESSAGE_INVALID_INPUT));
                if (model.mobile.StartsWith("63") && model.mobile.Length != 12) return BadRequest(new ResultFailed(Constants.MESSAGE_INVALID_MOBILE_NUMBER));

                var account = (await accountManager
                    .Where(x => x.MobileNumber == model.mobile))
                        .FirstOrDefault();

                if (account != null) return BadRequest(new ResultFailed(Constants.MESSAGE_ACCOUNT_ALREADY_EXISTS));

                var success = await accountManager.RegisterMobileAsync(model.mobile, model.AppCode);
                if (success)
                {
                    return Ok(new ResultSuccess());
                }
                else
                {
                    return BadRequest(new ResultFailed(Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
                }

            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }
        }

        /// <summary>
        /// Reset user password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>return json result</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPatch(ApiRoutes.RiderAccountRoute.ResetPassword)]
        public async Task<IActionResult>  ResetPassword([FromBody] ChangePasswordMobileRouteModel model)
        {
            if (model == null)
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_INVALID_INPUT
                });

            if (model.NewPassword != model.ConfirmNewPassword)
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_NOT_MATCH_PASSWORD
                });

            //if (model.NewPassword.Length < 8) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = " " });
            if (string.IsNullOrWhiteSpace(model.MobileOrEmail))
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_INVALID_MOBILE_NUMBER
                });
            if (
                model.MobileOrEmail.StartsWith("63") &&
                model.MobileOrEmail.Length != 12
            )
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_INVALID_PASSWORD_LENGTH
                });
            if (
                !model.MobileOrEmail.StartsWith("63") &&
                new EmailValidation().validate(model.MobileOrEmail) == false
            )
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_INVALID_EMAIL_ADDRESS
                });
            var account =
                (
                await accountManager .Where(x =>
                        x.MobileNumber == model.MobileOrEmail ||
                        x.EmailAddress == model.MobileOrEmail)
                ).SingleOrDefault();

            if (account == null)
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS
                });
            if (account.Status != RiderStatus.Active)
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_ACTIVE
                });
            account.Password = model.NewPassword;
            var result = await accountManager.ResetPasswordAsync(account);
            if (result.ResultEnum == Result.Success.ToString())
                return Ok(result);
            return BadRequest(result);
        }


#endregion


     private object getRiderInfo(RiderAccountEntity  model,int Tripscount)
        {
            try
            {
                //var bookings = await genericQuery.Where<BookingMain>(x => x.RiderGUID == model.GUID
                //  && x.DateCreated.Date == dnow && x.Status == "RDO");
                //var x = db.context.ExecuteQuery<BookingMain>("select * from bookingMain");
                //var Tripscount =   bookings.Count();

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
                    TripsCount = Tripscount,
                    TotalEarnings = model.TotalEarnings,
                    TotalHours = model.TotalHours,
                    TotalKms = model.TotalKms,
                    Address = model.profile?.Address1,
                    TransportType = model.profile?.TransportType,
                    yearModel = model.profile?.yearModel,
                    Make = model.profile?.Make,
                    Model = model.profile?.Model,
                    PlateNo = model.profile?.PlateNo,
                    Color = model.profile?.Color

                };
                return  result;
            }
            catch (Exception)
            {
                return null;
            }
        }



     #region Get
        private IQueryable<RiderTripsLog>  getTripsLog(string userId="")
        {

            var dnow = Common.getDateNow().Date;
            if (string.IsNullOrWhiteSpace(userId))
            {
                var bookings = db.context.RiderTripsLogs
                   .Where(x => x.DateCreated.Date == dnow
                   && x.Status == "RDO");
                return bookings;
            }
            else
            {
                var bookings = db.context.RiderTripsLogs
                   .Where(x => x.DateCreated.Date == dnow
                   && x.RiderGUID == userId
                   && x.Status == "RDO");
                return bookings;
            }
        }

        /// <summary>
        /// Get User information
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>return user information</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.RiderAccountRoute.Get)]
        public async Task<IActionResult> GetByUserId([FromRoute] string userid)
        {
            try
            {
                var model = await accountManager.FindOne(userid);
                var bookings = getTripsLog(userid);
                var tripsCount = bookings.Count();

                if (model == null)  return BadRequest(new ResultFailed(  "user is not found." ));
                var result = getRiderInfo(model, tripsCount);
                return Ok(new ResultSuccess( result));
            }
            catch (Exception  )
            {
                return BadRequest(new ResultFailed( Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
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
        [HttpGet(ApiRoutes.RiderAccountRoute.GetAll)]
        public async Task<IActionResult>  GetUsers(
            [FromRoute] RiderFilterStatus status = RiderFilterStatus.All,
            [FromRoute] int skip = 0,
            [FromRoute] int take = 50
        )
        {
            try
            {
                 IQueryable<RiderAccountEntity> Response = null;
                if (status == RiderFilterStatus.All)  Response =  (await accountManager.All()).OrderByDescending(x=>x.DateCreated).Skip(skip).Take(take);
                if (status != RiderFilterStatus.All)  Response = ( await accountManager.Where(x => x.Status == status.convertToEStatus())).OrderByDescending(x=>x.DateCreated).Skip(skip).Take(take);
                if (Response.Count() == 0) return BadRequest(new ResultFailed( "No account found." ));

                List<object> models = new List<object>();
                var bookings = getTripsLog();
                foreach (var model in Response)
                {
                    var tripsCount = bookings.Where(b => b.RiderGUID == model.GUID).Count();
                     var item = getRiderInfo(model, tripsCount); 
                     models.Add (item);
                }
                return Ok(new ResultSuccess( models));
            }
            catch (Exception  )
            {
                return BadRequest(new ResultFailed( Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
            }
        }

        /// <summary>
        /// check if rider complied document requirements
        /// </summary>
        /// <param name="status"></param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        [HttpGet(ApiRoutes.RiderAccountRoute.GetIsDocsComplied)]
        public async Task<IActionResult> GetIsDocsComplied( [FromRoute] string riderId)
        {
            try
            {
                var riderInfo =  await accountManager.FindOne(riderId);
                if (riderInfo  ==  null) return BadRequest(new ResultFailed("Account not found."));
                var returnModel = new
                {
                 IsDocsComplied = riderInfo.IsDocsComplied.ToString()
                };
             return Ok(new ResultSuccess(returnModel));
            }
            catch (Exception  )
            {
                return BadRequest(new ResultFailed(Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
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
        [HttpGet(ApiRoutes.RiderAccountRoute.GetContatcs)]
        public async Task<IActionResult> GetContactList()
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                IQueryable<RiderAccountEntity> accountsResults = null;
                accountsResults = await accountManager.Where(c => c.Status == RiderStatus.Active);

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


        /// <summary>
        /// Get All Ratings
        /// </summary>
        /// <param name="rating"></param>
        /// <returns>Return list of users</returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">UnAthorized</response>
        /// <response code="500">Server error</response>
        [HttpGet(ApiRoutes.RiderAccountRoute.GetContatcsRatings)]
        public async Task<IActionResult> GetRatingList(double rating = 0)
        {
            try
            {
                //string Id = HttpContext.GetUserId();
                IQueryable<RiderAccountEntity> accountsResults = null;
                accountsResults = await accountManager.Where(c => c.Status == RiderStatus.Active && c.Rating == rating);

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
        /// Delete Rider account
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpDelete(ApiRoutes.RiderAccountRoute.Delete)]
        public async Task<IActionResult> Delete([FromRoute] string userId)
        {
            try
            {
                var isSuccess = await accountManager.Delete(userId);
                if (isSuccess)
                    return Ok(new ResultSuccess(true)); 
                var userStatus = new
                {
                    userId = userId,
                    Status ="Deleted",
                };

                await new RiderHubManager().PublishAccountStatus(userStatus);
                return BadRequest(new ResultFailed( Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
            }
            catch (Exception  )
            {
                return BadRequest(new ResultFailed(  Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
            }
        }

        public class AppCodeRider:AppCodeModel
        {
            public string mobile { get; set; }
        }
    }
 }
    #endregion 
