using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Account-Admin-Permission")]
    public class AdminRoleController:Controller
    {
        private readonly IGenericQueryManager generic;
        private IAdminAccountManager<AdminAccountEntity> accountManager;
        public AdminRoleController(IGenericQueryManager generic, IAdminAccountManager<AdminAccountEntity> accountManager)
        {
            this.generic = generic;
            this.accountManager = accountManager;
        }

        [HttpGet("/api/v1/admin/get-forms/{module}")]
        public async Task<IActionResult> GetRouteModels([FromRoute] string module)
        {

            var data = await generic.Where<AdminRouteModel>(x=>x.Module==module);
            var returnModel = data.Select(x => new
            {
                 x.GUID,
                 x.Grouping,
                 x.RouteName,
                 x.RoutePath,
                 x.Action,
                 x.Global, 
            });
            return Ok(new ResultViewModel { ResultMessage = "Success", ResultObject = returnModel, ResultEnum = Result.Success.ToString() });

        }

        [HttpGet("/api/v1/admin/get-roles")]
        public async Task<IActionResult> getRoles()
        {

            var data = await generic.Where<AdminRole>(x=>x.Status==true);
            var returnModel = data.Select(x => new
            {
                x.GUID,
                x.RoleName,
            });
            return Ok(new ResultViewModel { ResultMessage = "Success", ResultObject = returnModel, ResultEnum = Result.Success.ToString() });
        }

        [HttpGet("/api/v1/admin/get-roles-forms/{roleId}")]
        public async Task<IActionResult> getRoleForms([FromRoute] string roleId)
        {
            return Ok(await accountManager.GetRoleForms(roleId)); 
        }

        [HttpGet("/api/v1/admin/get-user-roles/{userId}")]
        public async Task<IActionResult> userRoles([FromRoute] string userId)
        {
            return Ok(await accountManager.GetUserRoles(userId));
        }

        [HttpGet("/api/v1/admin/get-user-roles-forms/{userId}")]
        public async Task<IActionResult> userRolesForms([FromRoute] string userId)
        {
            return Ok(await accountManager.GetUserRolesForms(userId));
        }

        //posting
        [HttpPost("/api/v1/admin/add-forms")]
        public async Task<IActionResult> addForm([FromBody] List<AdminRouteModelRequest>   models)
        {

            var items = await generic.Where<AdminRouteModel>(x => x.Module == models.First().Module);

            foreach (var item in items) await generic.Delete(item);

            foreach (var model in models)
            {
                var entry = new AdminRouteModel
                {
                    Action = model.Action,
                    Global = model.Global,
                    Grouping = model.Grouping,
                    Module = model.Module,
                    RouteName = model.RouteName,
                    RoutePath = model.RoutePath,
                };
                await generic.AddOrUpdate(entry);
            }
            
            await generic.CommitChanges();
            return Ok(new ResultViewModel { ResultMessage = "Success", ResultEnum = Result.Success.ToString() });
        }

        [HttpPost("/api/v1/admin/add-roles/{roleName}")]
        public async Task<IActionResult> AddRoles([FromRoute] string  roleName)
        {
            var entry = new AdminRole
            {
                RoleName = roleName
            };
            await generic.AddOrUpdate(entry);

            await generic.CommitChanges();
            return Ok(new ResultViewModel { ResultMessage = "Success", ResultEnum = Result.Success.ToString() });

        }


        [HttpPost("/api/v1/admin/add-user-role/{userId}")]
        public async Task<IActionResult> AssignuserRoles([FromRoute] string userId,[FromBody]  List<string> roleIds)
        {
            var users = await generic.Where<AdminUserRole>(x => x.UserId == userId);
            foreach (var user in users)
            {
                await generic.Delete(user);
            }

            foreach (var role in roleIds)
            {
                var userRole = new AdminUserRole
                {
                    RoleId = role,
                    UserId = userId
                };

                await generic.AddOrUpdate(userRole);
            }

            await generic.CommitChanges();

            return Ok(new ResultViewModel { ResultEnum=Result.Success.ToString(), ResultMessage="Success" });
        }

        /// <summary>
        /// Add user Type
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ///
        [HttpPost("/api/v1/admin/user/add-type")]
        public async Task<IActionResult> AddRole([FromBody] AdminUserType model)
        {
            try
            {
                var role = new MerchantUserTypeEntity
                {
                    UserType = model.UserType,
                    RoleName = model.RoleName,
                    IsSave = model.IsSave,
                    IsView = model.IsView,
                    IsEdit = model.IsEdit,
                    IsPrint = model.IsPrint,
                };

                var returnModel = new
                {

                };

                await generic.AddOrUpdate(role);
                return Ok(new ResultViewModel
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.MESSAGE_SUCCESS,
                    ResultObject = role
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel
                {
                    ResultEnum = Result.Failed.ToString(),
                    ResultMessage = Constants.GET_ERROR(ex)
                });
            }
        }


        /// <summary>
        /// Add roles to form
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="models"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/admin/add-role-to-forms/{roleId}")]
        public async Task<IActionResult> addRoleToForm([FromRoute] string roleId, [FromBody]  List<RoleToRouteModelRequest> models)
        {
            try
            {
                var items = await generic.Where<AdminRouteModelRole>(x => x.RoleId == roleId);
                foreach (var item in items) await generic.Delete(item);
                foreach (var model in models)
                {
                    var entry = new AdminRouteModelRole
                    {
                        RoleId = roleId,
                        Action = model.Action,
                        RouteModelId = model.RouteModelId,
                        RoutePath = model.RoutePath,
                    };
                    await generic.AddOrUpdate(entry);
                }
                await generic.CommitChanges();
                return Ok(new ResultViewModel { ResultMessage = "Success", ResultEnum = Result.Success.ToString() });
            }
            catch (Exception)
            {
                return BadRequest(new ResultViewModel { ResultMessage = "failed", ResultEnum = Result.Failed.ToString() });
            }
        }

    } 

    public class AdminUserType
    {
        public string UserType { get; set; }
        public string RoleName { get; set; }
        public bool IsSave { get; set; }
        public bool IsView { get; set; }
        public bool IsEdit { get; set; }
        public bool IsPrint { get; set; }
    }

    public class AdminUserRestriction : AdminUserType
    {
        public string MerchantUserId { get; set; }
        public string Email { get; set; }
    }
    public class AdminRouteModelRequest 
    {
        public string Module { get; set; }
        public string Grouping { get; set; }
        public string RouteName { get; set; }
        public string RoutePath { get; set; }
        public string Action { get; set; }
        public bool Global { get; set; } 
    }  
}
