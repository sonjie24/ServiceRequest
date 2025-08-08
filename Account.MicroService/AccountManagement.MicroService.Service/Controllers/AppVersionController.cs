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
    [ApiExplorerSettings(GroupName = "App-version")]
    [Produces("application/json")]
    public class AppVersionController : Controller
    {
        private IGenericQueryManager  manager;
        public AppVersionController(IGenericQueryManager manager)
        {
            this.manager = manager;
        }

        [HttpPost("api/v1/App-version")]
        public async Task<IActionResult> Create([FromBody] AppVersionRequest  model)
        {
            try
            {
                var package = await manager.FindOneWhere<AppVersion>(x => x.PackageName == model.PackageName);
                if (package!=null) return BadRequest(new ResultFailed("Package Name exists"));

                var app = new AppVersion
                {
                    AppName = model.AppName,
                    PackageName = model.PackageName,
                    Version = model.Version,
                    MinimumVersion=model.MinimumVersion,
                };

                await manager.AddOrUpdate(app);
                await manager.CommitChanges();

                var returnModel = new
                {
                     Id=app.GUID,
                     AppName=app.AppName,
                     PackageName = app.PackageName,
                     MinimumVersion = app.MinimumVersion,
                     Version=app.Version,
                };

                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message ));
            }
        }

        [HttpPut("api/v1/App-version/{Id}")]
        public async Task<IActionResult> Modify([FromBody] AppVersionRequest model,[FromRoute] string Id)
        {
            try
            {
                var app = await manager.FindOne<AppVersion>(Id);
                app.AppName = model.AppName;
                app.PackageName = model.PackageName;
                app.Version = model.Version;
                app.MinimumVersion = model.MinimumVersion;
                await manager.AddOrUpdate(app);
                await manager.CommitChanges();

                var returnModel = new
                {
                    Id = app.GUID,
                    AppName = app.AppName,
                    PackageName = app.PackageName,
                    MinimumVersion = app.MinimumVersion,
                    Version = app.Version,
                };

                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }

        [HttpGet("api/v1/App-version-all")]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var appss = await manager.All<AppVersion>();
                var returnModels = new List<object>();

                foreach (var app in appss)
                {
                    var returnModel = new
                    {
                        Id = app.GUID,
                        AppName = app.AppName,
                        PackageName = app.PackageName,
                        MinimumVersion = app.MinimumVersion,
                        Version = app.Version,

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

        [AllowAnonymous]
        [HttpGet("api/v1/App-version-last/{AppName}")]
        public async Task<IActionResult> getLast([FromRoute] string AppName)
        {
            try
            {
               var appss = await manager.Where<AppVersion>(x=>x.AppName==AppName);
               var app = appss.ToList().OrderBy(x=>x.Id).LastOrDefault();
               if (app == null) return Ok( new ResultSuccess());
               var returnModel = new
                {
                    Id = app.GUID,
                    AppName = app.AppName,
                    PackageName = app.PackageName,
                    MinimumVersion = app.MinimumVersion,
                    Version = app.Version,
                };

                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }

        [AllowAnonymous]
        [HttpGet("api/v2/App-version-last/{packageName}")]
        public async Task<IActionResult> getLastByPackage([FromRoute] string packageName)
        {
            try
            {
                var appss = await manager.Where<AppVersion>(x => x.PackageName == packageName);
                var app = appss.ToList().OrderBy(x => x.Id).LastOrDefault();
                if (app == null) return Ok(new ResultSuccess());
                var returnModel = new
                {
                    Id = app.GUID,
                    AppName = app.AppName,
                    PackageName = app.PackageName,
                    MinimumVersion = app.MinimumVersion,
                    Version = app.Version,
                };
                return Ok(new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex.Message));
            }
        }

        [HttpDelete("api/v1/App-version/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] string Id)
        {
            try
            {
                var app = await manager.FindOne<AppVersion>(Id);
                await manager.Delete(app);
                await  manager.CommitChanges();

                var returnModel = new
                {
                    Id = app.GUID,
                    AppName = app.AppName,
                    PackageName = app.PackageName,
                    MinimumVersion = app.MinimumVersion,
                    Version = app.Version,
                };

                return Ok( new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResultFailed(ex.Message));
            }
        }
    }

    public class AppVersionRequest
    {
        public string AppName { get; set; }
        public string PackageName { get; set; }
        public string MinimumVersion { get; set; }
        public string Version { get; set; } 

    }
}
