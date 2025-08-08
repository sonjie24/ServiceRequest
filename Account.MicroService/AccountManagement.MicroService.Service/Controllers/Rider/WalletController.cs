using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers.Rider
{
    public class WalletController : Controller
    {
        private IGenericQueryManager  queryManager;
        public  WalletController( 
            IGenericQueryManager queryManager
            )
            {
                this.queryManager = queryManager;
            }

        /// <summary>
        /// Add Wallet
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Failed</response>
        /// <response code="401">Unauthorized</response>
        [HttpPost(ApiRoutes.WalletRoute.AddWallet)]
        [ApiExplorerSettings(GroupName = "Wallet")]
        public async Task<IActionResult> AddWallet([FromBody] Wallet  model)
        {
            try
            {
                if (model == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
                var userId = HttpContext.GetUserId();
                if (string.IsNullOrWhiteSpace(userId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in" });

                var gw = new WalletEntity
                {
                   Name=model.Name,
                   ImagePath=model.ImagePath,
                   CreatedBy=userId,
                };

                await  queryManager.AddOrUpdate (gw);
                await queryManager.CommitChanges();
                var returnModel = new
                {
                    Id = gw.GUID,
                    Name = model.Name,
                    ImagePath = model.ImagePath,
                    Status = gw.Status.ToString(),
                };

                return Ok(new ResultViewModel() { ResultObject = returnModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }

        /// <summary>
        /// update Wallet
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Failed</response>
        /// <response code="401">Unauthorized</response>
        [HttpPut(ApiRoutes.WalletRoute.UpdateWallet)]
        [ApiExplorerSettings(GroupName = "Wallet")]
        public async Task<IActionResult> UpdateWallet([FromBody] Wallet model,[FromRoute] string WalletId)
        {
            try
            {
                if (model == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_INVALID_INPUT });
                if (string.IsNullOrWhiteSpace(WalletId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_RECORD_NOT_FOUND("Wallet") });
                var userId = HttpContext.GetUserId();
                if (string.IsNullOrWhiteSpace(userId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in"});

                var gw = await queryManager.FindOne<WalletEntity>(WalletId);
                if (gw==null) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_RECORD_NOT_FOUND("Wallet")});
                gw.Name = model.Name;
                gw.ImagePath = model.ImagePath;
                gw.DateModified = Common.getDateNow();
                gw.ModifiedBy = userId;
                await queryManager.AddOrUpdate(gw);
                await queryManager.CommitChanges();

                var returnModel = new
                {
                    Id = gw.GUID,
                    Name = model.Name,
                    ImagePath = model.ImagePath,
                    Status = gw.Status.ToString(),
                };

                return Ok(new ResultViewModel() { ResultObject = returnModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }


        /// <summary>
        /// Update Wallet status
        /// </summary>
        /// <param name="WalletId"></param>
        /// <param name="status">0=Cancelled,1=Active</param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Failed</response>
        /// <response code="401">Unauthorized</response>
        [HttpPut(ApiRoutes.WalletRoute.UpdateStatus)]
        [ApiExplorerSettings(GroupName = "Wallet")]
        public async Task<IActionResult> UpdateStatus([FromRoute] string WalletId,[FromRoute] WalletStatus status)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(WalletId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_RECORD_NOT_FOUND("Wallet") });
                var userId = HttpContext.GetUserId();
                if (string.IsNullOrWhiteSpace(userId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in" });

                var gw = await queryManager.FindOne<WalletEntity>(WalletId);
                if (gw == null) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_RECORD_NOT_FOUND("Wallet") });
                gw.Status = ConvertStatus(status);
                gw.DateModified =  Common.getDateNow();
                gw.ModifiedBy = userId;
                await queryManager.AddOrUpdate(gw);
                await queryManager.CommitChanges();

                var returnModel = new
                {
                    Id = gw.GUID,
                    Name = gw.Name,
                    ImagePath = gw.ImagePath,
                    Status = gw.Status.ToString(),
                }; 

                return Ok(new ResultViewModel() { ResultObject = returnModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }

        /// <summary>
        /// Get all Wallets
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Failed</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet(ApiRoutes.WalletRoute.AllWallet)]
        [ApiExplorerSettings(GroupName = "Wallet")]
        public async Task<IActionResult> AllWallet()
        {
            try
            {
                var userId = HttpContext.GetUserId();
                if (string.IsNullOrWhiteSpace(userId)) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "User not logged-in" });
                var gws = await queryManager.All<WalletEntity>();
                //if (gws.Count()==0) return NotFound(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage =  "No Record found."});
                var returnModels = new List<object>();
                foreach (var gw in gws)
                {
                    var returnModel = new
                    {
                        Id = gw.GUID,
                        Name = gw.Name,
                        ImagePath = gw.ImagePath,
                        Status = gw.Status.ToString(),
                    };
                    returnModels.Add(returnModel);
                }
                return Ok(new ResultViewModel() { ResultObject = returnModels, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }

        private EStatus ConvertStatus(WalletStatus status)
        {
            switch (status)
            {
                case WalletStatus.Cancelled:
                    return EStatus.Cancelled;
                case WalletStatus.Active:
                    return EStatus.Active;
                default:
                    return EStatus.Active;
            }
        }
        public enum WalletStatus
        {
            Cancelled,
            Active
        }

    }
}
