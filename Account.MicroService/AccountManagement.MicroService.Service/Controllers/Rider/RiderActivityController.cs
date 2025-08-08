using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Data;
using AccountManagement.Framework.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Rider-Activities")]
    public class RiderActivityController  : Controller
    {
        private Database db;
        private readonly IGenericQueryManager genericQuery;

        public RiderActivityController( 
            IGenericQueryManager genericQuery,
            Database db)
        {
            this.genericQuery = genericQuery;
            this.db = db;
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RiderAccountRoute.GetRiderActivityStatus)]
        public  async   Task<IActionResult> GetRiderActivityStatus([FromRoute] string riderId,[FromRoute] int skip=0,[FromRoute] int take=10)
        {
            try
            {
                //List<riderActivity> activities = new List<riderActivity>();
                //activities.Add(new riderActivity { Status = "ACCEPTED", activity = "ORDER ID:YR-89731210" });
                //activities.Add(new riderActivity { Status = "STOPPED", activity = "Last Moving Time 00:04:04" });
                //activities.Add(new riderActivity { Status = "START MOVING", activity = "Last Stoppage Time 00:06:04" });
                //activities.Add(new riderActivity { Status = "STOPPED", activity = "Last Moving Time 00:07:04" });
                //return Ok(activities);

                var activties = await db.context.RiderActivities
                    .Where(x => x.RiderId == riderId)
                    .Skip(skip)
                    .Take(take)
                    .ToListAsync();

                var returnActivities = new List<object>();
                foreach (var item in activties)
                {

                    var returnModel = new
                    {
                        activityId = item.GUID,
                        Status = item.Status,
                        Activity = item.Activity,
                        Reference = item.Reference,
                        ActivityDate = item.DateTimeLog, 
                    };
                    returnActivities.Add(returnModel);
                }



                return Ok(new ResultViewModel { ResultObject = returnActivities, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });

            }

            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }

        [HttpPost(ApiRoutes.RiderAccountRoute.AddRiderActivityStatus)]
        public async Task<IActionResult> AddRiderActivityStatus([FromBody] riderActivity model , [FromRoute] string riderId)
        {
            try
            {
                var activity = new RiderActivityEntity
                {
                    RiderId=riderId,
                    Status = model.Status,
                    Activity = model.activity,
                    Reference = "",
                };
                await genericQuery.AddOrUpdate(activity);
                await genericQuery.CommitChanges();

                var returnModel = new
                {
                    activityId = activity.GUID,
                    Status = activity.Status,
                    Activity = activity.Activity,
                    Reference = activity.Reference,
                    ActivityDate = activity.DateTimeLog
                };
              
                return Ok(new ResultViewModel { ResultObject = returnModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return  BadRequest(new ResultViewModel { ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }
    }
    public class riderActivity
    {
        public string Status { get; set; }
        public string activity { get; set; }
    }
}
