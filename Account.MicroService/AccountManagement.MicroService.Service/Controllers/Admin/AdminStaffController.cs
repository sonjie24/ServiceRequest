using System;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models.Models.Accounts.Admin; 
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Admin-Staff")]
    public class AdminStaffController : Controller
    {
        private readonly IGenericQueryManager genericQuery;
        public AdminStaffController(IGenericQueryManager genericQuery)
        {
            this.genericQuery = genericQuery;
        }

        /// <summary>
        /// Add Staff
        /// </summary>
        /// <param name="staffRequest"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/admin/add-staff")]
        public async Task<ActionResult> AddStaff([FromBody] AdminStaffRequest staffRequest)
        {
            try
            {
                var req = new  AdminEmployeeEntity
                {
                    ContactNo = staffRequest.ContactNo,
                    EffectivityDate = staffRequest.EffectivityDate,
                    FirstName = staffRequest.FirstName,
                    LastName = staffRequest.LastName,
                    JobDescription = staffRequest.JobDescription,
                    WithEffectivity = staffRequest.SetEffectivity,
                    Status = staffRequest.Status ,
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
                    SetEffectivity = model.WithEffectivity,
                    Status = staffRequest.Status,
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
        [HttpPatch("/api/v1/admin/update-staff/{staffId}")]
        public async Task<ActionResult> UpdateStaff([FromBody] AdminStaffRequest staffRequest, [FromRoute] string staffId)
        {
            try
            {
                var req = await genericQuery.FindOne<AdminEmployeeEntity>(staffId);
                if (req == null) return NotFound(new ResultViewModel { ResultMessage = "Staff not found", ResultEnum = Result.Failed.ToString() });

                req.ContactNo = staffRequest.ContactNo;
                req.EffectivityDate = staffRequest.EffectivityDate;
                req.FirstName = staffRequest.FirstName;
                req.LastName = staffRequest.LastName;
                req.JobDescription = staffRequest.JobDescription;
                req.Status = staffRequest.Status ;

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
                    SetEffectivity = model.WithEffectivity,
                    Status = model.Status,
                };
                return Ok(new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex.Message));
            }
        }

        /// <summary>
        /// update staff status
        /// </summary>
        /// <param name="staffId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpPatch("/api/v1/admin/update-staff-status/{staffId}/{status}")]
        public async Task<ActionResult> UpdateStaffStatus([FromRoute] string staffId, [FromRoute] bool status)
        {
            try
            {
                var req = await genericQuery.FindOne<AdminEmployeeEntity>(staffId);
                if (req == null) return NotFound(new ResultViewModel { ResultMessage = "Staff not found", ResultEnum = Result.Failed.ToString() });
                req.Status = status;
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
                    SetEffectivity = model.WithEffectivity,
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
        /// Find All  
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/v1/admin/staff")]
        public async Task<ActionResult> FindAll()
        {
            try
            {
                var staffs = (await genericQuery.All<AdminEmployeeEntity>()).OrderByDescending(x=>x.DateCreated);
                //check if emp is already added
                var reqs = staffs.Select(staff => new
                {
                    Id = staff.GUID,
                    ContactNo = staff.ContactNo,
                    EffectivityDate = staff.EffectivityDate,
                    FirstName = staff.FirstName,
                    LastName = staff.LastName,
                    JobDescription = staff.JobDescription,
                    SetEffectivity = staff.WithEffectivity,
                    Status = staff.Status,
                });
                return Ok(new ResultSuccess(reqs));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex.Message));
            }
        }

        /// <summary>
        /// Find Staff
        /// </summary>
        /// <param name="staffId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/admin/staff/{staffId}")]
        public async Task<ActionResult> FindOne([FromRoute] string staffId)
        {
            try
            {
                var staffs = (await genericQuery.Where<AdminEmployeeEntity>(x =>   x.GUID == staffId));
                //check if emp is already added
                var reqs = staffs.Select(staff => new
                {
                    Id = staff.GUID,
                    ContactNo = staff.ContactNo,
                    EffectivityDate = staff.EffectivityDate,
                    FirstName = staff.FirstName,
                    LastName = staff.LastName,
                    JobDescription = staff.JobDescription,
                    SetEffectivity = staff.WithEffectivity,
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
        /// <param name="staffId"></param>
        /// <returns></returns>
        [HttpDelete("/api/v1/admin/delete-staff/{staffId}")]
        public async Task<ActionResult> DeleteStaff( [FromRoute] string staffId)
        {
            try
            {
                var req = await genericQuery.FindOne<AdminEmployeeEntity>(staffId);
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
