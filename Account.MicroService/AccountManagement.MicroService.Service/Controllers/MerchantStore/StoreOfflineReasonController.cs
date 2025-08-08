using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.MicroService.Controllers.MerchantStore
{
    [ApiExplorerSettings(GroupName = "Store-Offline-Reason")]
    public class StoreOfflineReasonController:Controller 
    {
        private IGenericQueryManager genericQuery;

        public StoreOfflineReasonController(IGenericQueryManager genericQuery)
        {
            this.genericQuery = genericQuery;
        }

        [HttpPost("/api/v1/store-offline-reason/{reason}")]
        public async Task<ActionResult> Create([FromRoute] string reason)
        {

            var model = new StoreOfflineReasonEntity
            {
                Reason = reason,
                Status = true
            };

            await genericQuery.AddOrUpdate(model);
            await genericQuery.CommitChanges();

            var returnModel = new
            {
                Id = model.GUID,
                Reason = reason
            };
            return Ok(new ResultSuccess(returnModel));
        }

        [HttpPut("/api/v1/store-offline-reason/{id}/{reason}")]
        public async Task<ActionResult> Update([FromRoute] string id, [FromRoute] string reason)
        {

            var model = await genericQuery.FindOne<StoreOfflineReasonEntity>(id);
            model.Reason = reason;
            await genericQuery.AddOrUpdate(model);
            await genericQuery.CommitChanges();
            var returnModel = new
            {
                Id = model.GUID,
                Reason = reason
            };
            return Ok(new ResultSuccess(returnModel));
        }

        [HttpPut("/api/v1/remove-store-offline-reason/{id}")]
        public async Task<ActionResult> Remove([FromRoute] string id)
        {
            var model = await genericQuery.FindOne<StoreOfflineReasonEntity>(id);
            await genericQuery.Delete(model);
            await genericQuery.CommitChanges();
            return Ok(new ResultSuccess());
        }

        [HttpGet("/api/v1/store-offline-reason")]
        public async Task<ActionResult> GetAll()
        {

            var models = await genericQuery.Where<StoreOfflineReasonEntity>(x=>x.Status==true);
            var returnModels = new List<object>();
            foreach (var item in models)
            {
                var returmodel = new
                {
                    Id = item.GUID,
                    Reason = item.Reason
                };
                returnModels.Add(returmodel);
            }
            return Ok(new ResultSuccess(returnModels));
        }


    }
}
