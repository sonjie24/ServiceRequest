using System;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using AccountManagement.MicroService.Controllers.Request.V1.Merchants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.MicroService.Controllers.MerchantStore
{
    [ApiExplorerSettings(GroupName = "Merchant-Staff")]
    public class MerhantStaffController : Controller
    {
        private readonly IGenericQueryManager genericQuery;
        public MerhantStaffController(IGenericQueryManager genericQuery )
        {
            this.genericQuery = genericQuery;
        }

        /// <summary>
        /// Add Staff
        /// </summary>
        /// <param name="staffRequest"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/merchant/add-staff")]
        public async Task<ActionResult> AddStaff([FromBody] MerchantStaffRequest staffRequest)
        {

            try
            {
                var store = await genericQuery.FindOne<MerchantStoreEntity>(staffRequest.MerchantId);
                if (store == null) return NotFound(new ResultViewModel { ResultMessage = "Merchant not found", ResultEnum = Result.Failed.ToString() });
                //check if emp is already added
                var req = new MerchantStaff
                {
                    ContactNo = staffRequest.ContactNo,
                    EffectivityDate = staffRequest.EffectivityDate,
                    FirstName = staffRequest.FirstName,
                    LastName = staffRequest.LastName,
                    JobDescription = staffRequest.JobDescription,
                    MerchantId = store.GUID,
                    SetEffectivity = staffRequest.SetEffectivity,
                    Status = staffRequest.Status,
                };

                var model = await genericQuery.AddOrUpdate(req);
                await genericQuery.CommitChanges();

                var returnModel = new
                {
                    Id = model.GUID,
                    ContactNo = model.ContactNo,
                    EffectivityDate = model.EffectivityDate,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    JobDescription = model.JobDescription,
                    MerchantId = store.GUID,
                    SetEffectivity = model.SetEffectivity,
                    Status = model.Status,
                }; 
                return Ok(new ResultViewModel { ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultMessage = ex.Message, ResultEnum = Result.Error.ToString() });
            }
        }

        /// <summary>
        /// Update Staff
        /// </summary>
        /// <param name="staffRequest"></param>
        /// <param name="staffId"></param>
        /// <returns></returns>
        [HttpPatch("/api/v1/merchant/update-staff/{staffId}")]
        public async Task<ActionResult> UpdateStaff([FromBody] MerchantStaffRequest staffRequest, [FromRoute] string staffId)
        {
            try
            {
                var store = await genericQuery.FindOne<MerchantStoreEntity>(staffRequest.MerchantId);
                if (store == null) return NotFound(new ResultViewModel { ResultMessage = "Merchant not found", ResultEnum = Result.Failed.ToString() });
                var req = await genericQuery.FindOne<MerchantStaff>(staffId);
                if (req == null) return NotFound(new ResultViewModel { ResultMessage = "Staff not found", ResultEnum = Result.Failed.ToString() });

                req.ContactNo = staffRequest.ContactNo;
                req.EffectivityDate = staffRequest.EffectivityDate;
                req.FirstName = staffRequest.FirstName;
                req.LastName = staffRequest.LastName;
                req.JobDescription = staffRequest.JobDescription;
                req.MerchantId = store.GUID;
                req.SetEffectivity = staffRequest.SetEffectivity;
                req.Status = staffRequest.Status;

                var model = await genericQuery.AddOrUpdate(req);
                await genericQuery.CommitChanges();

                var returnModel = new
                {
                    Id = model.GUID,
                    ContactNo = model.ContactNo,
                    EffectivityDate = model.EffectivityDate,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    JobDescription = model.JobDescription,
                    MerchantId = store.GUID,
                    SetEffectivity = model.SetEffectivity,
                    Status = model.Status,
                };
                return Ok(new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }
        }

        /// <summary>
        /// update staff status
        /// </summary>
        /// <param name="staffId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpPatch("/api/v1/merchant/update-staff-status/{staffId}/{status}")]
        public async Task<ActionResult> UpdateStaffStatus([FromRoute] string staffId, [FromRoute] bool status)
        {
            try
            {
                var req = await genericQuery.FindOne<MerchantStaff>(staffId);
                if (req == null) return NotFound(new ResultFailed("Staff not found"));

                //Update Store status if admin account
                var store = (await genericQuery.Where<MerchantStoreEntity>(x => x.Id == req.Id)).FirstOrDefault();
                //if (store == null) return NotFound(new ResultViewModel { ResultMessage = "Merchant not found", ResultEnum = Result.Failed.ToString() });
                req.Status = status;
                var model = await genericQuery.AddOrUpdate(req);

                //update merchant_account status
                var staff_accounts = await genericQuery.Where<MerchantAccountEntity>(x => x.StaffId == staffId);

                var stat = status ? EStatus.Active : EStatus.Cancelled;
                foreach (var account in staff_accounts)
                {
                    account.Status = stat;
                    await genericQuery.AddOrUpdate(account);
                }
                await genericQuery.CommitChanges();

                var returnModel = new
                {
                    Id = model.GUID,
                    ContactNo = model.ContactNo,
                    EffectivityDate = model.EffectivityDate,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    JobDescription = model.JobDescription,
                    MerchantId = store?.GUID,
                    SetEffectivity = model.SetEffectivity,
                    Status = model.Status,
                };
                return Ok(new ResultViewModel { ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultMessage = ex.Message, ResultEnum = Result.Error.ToString() });
            }
        }




        /// <summary>
        /// Find All by MerchantId
        /// </summary>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/merchant/staff/{merchantId}")]
        public async Task<ActionResult> FindAll([FromRoute] string merchantId)
        {
            try
            {
                var staffs = (await genericQuery.Where<MerchantStaff>(x => x.MerchantId == merchantId)).OrderByDescending(x=>x.Id);
                //check if emp is already added
                var reqs = staffs.Select(staff => new
                {
                    Id = staff.GUID,
                    ContactNo = staff.ContactNo,
                    EffectivityDate = staff.EffectivityDate,
                    FirstName = staff.FirstName,
                    LastName = staff.LastName,
                    JobDescription = staff.JobDescription,
                    MerchantId = staff.MerchantId,
                    SetEffectivity = staff.SetEffectivity,
                    Status = staff.Status,
                });
                return Ok(new ResultViewModel { ResultObject = reqs, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultMessage = ex.Message, ResultEnum = Result.Error.ToString() });
            }
        }
        /// <summary>
        /// Find Staff
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="staffId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/merchant/staff/{merchantId}/{staffId}")]
        public async Task<ActionResult> FindOne([FromRoute] string merchantId, [FromRoute] string staffId)
        {
            try
            {
                var staffs = (await genericQuery.Where<MerchantStaff>(x => x.MerchantId == merchantId && x.GUID == staffId));
                //check if emp is already added
                var reqs = staffs.Select(staff => new
                {
                    Id = staff.GUID,
                    ContactNo = staff.ContactNo,
                    EffectivityDate = staff.EffectivityDate,
                    FirstName = staff.FirstName,
                    LastName = staff.LastName,
                    JobDescription = staff.JobDescription,
                    MerchantId = staff.MerchantId,
                    SetEffectivity = staff.SetEffectivity,
                    Status = staff.Status,
                });
                return Ok(new ResultViewModel { ResultObject = reqs, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultMessage = ex.Message, ResultEnum = Result.Error.ToString() });
            }
        }


        
        /// <summary>
        /// Remove Staff
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="staffId"></param>
        /// <returns></returns>
        [HttpDelete("/api/v1/merchant/delete-staff/{merchantId}/{staffId}")]
        public async Task<ActionResult> DeleteStaff([FromRoute] string merchantId, [FromRoute] string staffId)
        {
            try
            {
                var store = await genericQuery.FindOne<MerchantStoreEntity>(merchantId);
                if (store == null) return NotFound(new ResultViewModel { ResultMessage = "Merchant not found", ResultEnum = Result.Failed.ToString() });
                var req = await genericQuery.FindOne<MerchantStaff>(staffId);
                if (req == null) return NotFound(new ResultViewModel { ResultMessage = "Staff not found", ResultEnum = Result.Failed.ToString() });
                var model = await genericQuery.Delete(req);
                await genericQuery.CommitChanges();
                return Ok(new ResultViewModel { ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultMessage = ex.Message, ResultEnum = Result.Error.ToString() });
            }
        }
    }
}
