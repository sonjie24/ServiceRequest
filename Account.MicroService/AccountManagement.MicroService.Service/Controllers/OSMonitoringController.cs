using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "App-os-version")]
    public class OSMonitoringController:Controller
    {
        private IGenericQueryManager manager;
        public OSMonitoringController(IGenericQueryManager manager)
        {
            this.manager = manager;
        }

        [HttpPost("api/v1/App-os-version")]
        public async Task<IActionResult> Create([FromBody] Payload model)
        {
            try
            {
                var app = await manager.FindOneWhere<AppOsMonitoring>(x => x.UserId == model.UserId);
                if (app == null) app = new AppOsMonitoring();
                app.DeviceType = model.DeviceType;
                app.AppType = model.AppType;
                app.AppVersion = model.AppVersion;
                app.UserId = model.UserId;
                app.OsVersion = model.Osversion;
                app.UserType = model.UserType;
                app.DeviceModel = model.DeviceModel;
                app.Manufacturer = model.Manufacturer;
                await manager.AddOrUpdate(app);
                await manager.CommitChanges();

                var returnModel = new
                {
                    Id = app.GUID,
                    DeviceType = app.DeviceType,
                    AppType = app.AppType,
                    AppVersion = app.AppVersion,
                    UserId = app.UserId,
                    UserType = app.UserType,
                    Osversion = app.OsVersion,
                    DeviceModel = app.DeviceModel,
                    Manufacturer = app.Manufacturer,

                };

                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }

        [HttpPut("api/v1/App-os-version/{Id}")]
        public async Task<IActionResult> Modify([FromBody] Payload model, [FromRoute] string Id)
        {
            try
            {
                var app = await manager.FindOne<AppOsMonitoring>(Id);
                app.AppType = model.AppType;
                app.AppVersion = model.AppVersion;
                app.DeviceType = model.DeviceType;
                app.UserId = model.UserId;
                app.UserType = model.UserType;
                app.OsVersion= model.Osversion;
                app.DeviceModel = model.DeviceModel;
                app.Manufacturer = model.Manufacturer;
                await manager.AddOrUpdate(app);
                await manager.CommitChanges();

                var returnModel = new
                {
                    Id = app.GUID,
                    DeviceType = app.DeviceType,
                    AppType = app.AppType,
                    AppVersion = app.AppVersion,
                    UserId = app.UserId,
                    UserType = app.UserType,
                    Osversion = app.OsVersion,
                    DeviceModel = app.DeviceModel,
                    Manufacturer = app.Manufacturer,
                };
                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }

        [HttpGet("api/v1/App-os-version-all/{userId}")]
        public async Task<IActionResult> getAll([FromRoute] string userId)
        {
            try
            {
                var appss = await manager.Where<AppOsMonitoring>(x=>x.UserId==userId);
                var returnModels = new List<object>();

                foreach (var model in appss)
                {
                    var returnModel = new
                    {
                        Id = model.GUID,
                        DeviceType = model.DeviceType,
                        AppType = model.AppType,
                        AppVersion = model.AppVersion,
                        UserId = model.UserId,
                        UserType = model.UserType,
                        Osversion = model.OsVersion,
                        DeviceModel = model.DeviceModel,
                        Manufacturer = model.Manufacturer,
                    };
                    returnModels.Add(returnModel);
                }
                return Ok( new ResultSuccess(returnModels));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }

        [HttpGet("api/v1/App-os-version-last/{userId}")]
        public async Task<IActionResult> getLast([FromRoute] string userId)
        {
            try
            {
                var appss = await manager.Where<AppOsMonitoring>(x=>x.UserId==userId);
                var model = appss.ToList().OrderBy(x => x.Id).LastOrDefault();
                if (model == null) return Ok( new ResultSuccess());

                var returnModel = new
                {
                    Id = model.GUID,
                    DeviceType = model.DeviceType,
                    AppType = model.AppType,
                    AppVersion = model.AppVersion,
                    UserId = model.UserId,
                    UserType = model.UserType,
                    Osversion = model.OsVersion,
                    DeviceModel = model.DeviceModel,
                    Manufacturer = model.Manufacturer,
                };

                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }

        [HttpDelete("api/v1/App-os-version/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] string Id)
        {
            try
            {
                var model = await manager.FindOne<AppOsMonitoring>(Id);
                await manager.Delete(model);
                await manager.CommitChanges();

                var returnModel = new
                {
                    Id = model.GUID,
                    DeviceType = model.DeviceType,
                    AppType = model.AppType,
                    AppVersion = model.AppVersion,
                    UserId = model.UserId,
                    UserType = model.UserType,
                    Osversion = model.OsVersion,
                    DeviceModel = model.DeviceModel,
                    Manufacturer = model.Manufacturer,
                };

                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }
    }

    public class Payload
    {
        public string DeviceType { get; set; }
        public string AppVersion { get; set; }
        public string AppType { get; set; }
        public string UserId { get; set; }
        public string UserType { get; set; }
        public string Osversion { get; set; }
        public string DeviceModel { get; set; }
        public string Manufacturer { get; set; }
    }
}
