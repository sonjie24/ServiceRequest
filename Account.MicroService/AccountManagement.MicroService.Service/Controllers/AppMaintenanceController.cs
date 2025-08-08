using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;
using AccountManagement.Framework.Models;
using AccountManagement.Framework.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "App-utilities")]
    [Produces("application/json")]
    public class AppMaintenanceController : Controller
    {

        private IGenericQueryManager manager;
        public AppMaintenanceController(IGenericQueryManager manager)
        {
            this.manager = manager;
        }

        [HttpPost("api/v1/App-maintenance-mode/{appName}/{isMaintenance}")]
        public async Task<IActionResult> Create([FromRoute] string appName, [FromRoute] bool isMaintenance)
        {
            try
            {
                var app = await manager.FindOneWhere<MaintanceMode>(x=>x.AppName==appName);
                if (app == null) app = new MaintanceMode();
                app.AppName = appName;
                app.IsMaintenanceMode = isMaintenance;          
                await manager.AddOrUpdate(app);
                await manager.CommitChanges();
                var returnModel = new
                {
                    Id = app.GUID,
                    AppName = app.AppName,
                    IsMaintenanceMode = app.IsMaintenanceMode,
                };
                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }

        [AllowAnonymous]
        [HttpGet("api/v1/App-maintenance-mode/{appName}")]
        public async Task<IActionResult> getAppStatus([FromRoute] string appName)
        {
            try
            {
                var app = await manager.FindOneWhere<MaintanceMode>(x => x.AppName == appName);

                if (app == null)
                    return Ok(new ResultSuccess());
                var returnModel = new
                {
                    Id = app.GUID,
                    AppName = app.AppName,
                    IsMaintenanceMode = app.IsMaintenanceMode,
                };
                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }
    }
}
