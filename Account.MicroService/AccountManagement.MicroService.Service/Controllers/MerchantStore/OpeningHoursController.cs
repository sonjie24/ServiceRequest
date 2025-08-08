using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using AccountManagement.MicroService.Controllers.Request.V1.Merchants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers.MerchantStore
{
    [ApiExplorerSettings(GroupName = "Merchant-Openning-Hour")]
    public class OpeningHoursController:Controller
    {

        private readonly IGenericQueryManager genericQuery;
        public OpeningHoursController(IGenericQueryManager genericQuery)
        {
            this.genericQuery = genericQuery;
        }
 
        /// <summary>
        /// Add Schedule
        /// </summary>
        /// <param name="schedules"></param>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/merchant/openning-hour/{merchantId}")]
        public async Task<ActionResult> AddOrUpdate([FromBody] OpenningHourRequest[] schedules, [FromRoute] string merchantId)
        {
            var dnow = Common.getDateNow();
            var records = await genericQuery.Where<MerchantOpeningHour>(x => x.MerchantId == merchantId);
            foreach (var item in records)
            {
                await genericQuery.Delete(item);
            }

            foreach (var item in schedules )
            {
                var sched = new MerchantOpeningHour
                {
                    MerchantId=merchantId,
                    Day=item.Day,
                    FromTime=item.FromTime,
                    ToTime=item.ToTime,
                    IsOn=item.IsOn.ToLower(),
                };
                await genericQuery.AddOrUpdate(sched);
            }

            await  genericQuery.CommitChanges();
            return Ok();
        }

        /// <summary>
        /// Get Schedule
        /// </summary>
        /// <param name="schedules"></param>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/merchant/openning-hour/{merchantId}")]
        public async Task<ActionResult> FindSched([FromRoute] string merchantId)
        {
            var dnow = Common.getDateNow();
            var records = (await genericQuery.Where<MerchantOpeningHour>(x => x.MerchantId == merchantId))
                .Select(x => new
                    {
                        merchantId = x.MerchantId,
                        Day = x.Day,
                        FromTime = x.FromTime,
                        ToTime = x.ToTime,
                        IsOn = x.IsOn,
                        IsOpen = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), 20, 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), 20, 0) >= dnow
                });   

            return Ok(new ResultViewModel {
             ResultEnum=Result.Failed.ToString(),
             ResultMessage=Constants.MESSAGE_SUCCESS,
             ResultObject= records 
            });
        }
         
        [HttpGet("/api/v1/merchant/get-store-schedule/{merchantId}")]
        public async Task<ActionResult> OpenCloseTime([FromRoute] string merchantId)
        {
            var dnow = Common.getDateNow(); 
            //var store = await genericQuery.FindOne<MerchantStoreEntity>(merchantId);
            var records = (await genericQuery
                .Where<MerchantOpeningHour>(x => x.MerchantId == merchantId && x.Day== dnow.ToString("ddd")))
                .Select(x => new
                {
                    Date = dnow.ToLongDateString(),
                    Day = x.Day,
                    FromTime=x.FromTime,
                    ToTime=x.ToTime,
                    IsOn=x.IsOn ,
                    IsOpen = new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.FromTime.Substring(0, 2)), 20, 0) <= dnow && new DateTime(dnow.Year, dnow.Month, dnow.Day, int.Parse(x.ToTime.Substring(0, 2)), 20, 0) >= dnow
                }).FirstOrDefault();
            return Ok(new ResultSuccess(records));
        }
    }

}
