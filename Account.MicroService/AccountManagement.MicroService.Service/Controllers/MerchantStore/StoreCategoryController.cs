using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using AccountManagement.MicroService.Controllers.validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Store-Categories")]
    public class StoreCategoryController : Controller
    {
        private readonly IGenericQueryManager genericQuery;

        public StoreCategoryController(IGenericQueryManager genericQuery)
        {
            this.genericQuery = genericQuery;
        }

#region Post
        /// <summary>
        /// Add Category
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.MerchantStoreCategories.Addcategoties)]
        public async Task<IActionResult>
        Addcategoties([FromBody] CategoryCreateRouteModel model)
        {
            try
            {
                if (model == null)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Failed.ToString(),
                        ResultMessage = Constants.MESSAGE_INVALID_INPUT
                    });
                if (string.IsNullOrWhiteSpace(model.Description))
                    return BadRequest(new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Failed.ToString(),
                        ResultMessage = "Invalid Category Name"
                    });
                if (!ModelState.IsValid)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Failed.ToString(),
                        ResultMessage = Constants.MESSAGE_INVALID_INPUT
                    });
                var parent =
                    await genericQuery.FindOne<CategoryEntity>(model.ParentId);

                var category =
                    new CategoryEntity()
                    {
                        Parent = parent,
                        Description = model.Description,
                        Remarks=model.Remarks,
                        ImagePath = model.ImagePath
                       
                    };
                var result = await genericQuery.AddOrUpdate(category);
                await genericQuery.CommitChanges();
                if (result == null)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Failed.ToString(),
                        ResultMessage =
                            Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST
                    });
                var returnModel =
                    new {
                        Id = result.GUID,
                        ParentId = result?.Parent?.GUID,
                        Description = result.Description,
                        Remarks=result.Remarks,
                        ImagePath = model.ImagePath
                    };
                return Ok(new ResultViewModel()
                {
                    ResultEnum = Result.Success.ToString(),
                    ResultObject = returnModel
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = ex.Message
                });
            }
        }


#endregion

#region Patch
        /// <summary>
        /// Update Category
        /// </summary>
        /// <param name="model"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpPatch(ApiRoutes.MerchantStoreCategories.Update)]
        public async Task<IActionResult>  UpdateModel(
            [FromBody] CategoryCreateRouteModel model,
            string categoryId
        )
        {
            try
            {
                if (model == null)
                    return BadRequest(new ResultFailed(Constants.MESSAGE_INVALID_INPUT)); 
                if (string.IsNullOrWhiteSpace(categoryId))
                    return BadRequest(new ResultFailed(Constants.MESSAGE_ACCOUNT_NOT_EXISTS));
                if (string.IsNullOrWhiteSpace(model.Description))
                    return BadRequest(new ResultFailed( "Invalid Category Name"));
                if (!ModelState.IsValid)  return BadRequest(new ResultFailed( Constants.MESSAGE_INVALID_INPUT));

                var parent =  await genericQuery.FindOne<CategoryEntity>(model.ParentId);
                var category = await genericQuery.FindOne<CategoryEntity>(categoryId);
                if (category == null) return Ok(new ResultFailed("Category not found"));
                category.Parent = parent;
                category.Description = model.Description;
                category.Remarks = model.Remarks;
                category.ImagePath = model.ImagePath;

                var result = await genericQuery.AddOrUpdate(category);
                await genericQuery.CommitChanges();

                if (result == null) return BadRequest(new ResultFailed(Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST));
                var returnModel =
                    new {
                        Id = result.GUID,
                        ParentId = result?.Parent?.GUID,
                        Description = result.Description,
                        Remarks = result.Remarks,
                        ImagePath = model.ImagePath
                    };
                return Ok(new ResultViewModel()
                {
                    ResultEnum = Result.Success.ToString(),
                    ResultObject = returnModel
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = ex.Message
                });
            }
        }
#endregion

#region Get
        /// <summary>
        /// Get Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.MerchantStoreCategories.Get)]
        public async Task<IActionResult> GetById([FromRoute] string categoryId)
        {
            try
            {
                var category =  await genericQuery.FindOne<CategoryEntity>(categoryId);
                if (category == null)  return Ok(new ResultFailed( Constants.MESSAGE_RECORD_NOT_FOUND("Category")));

                 var returnModel =
                    new {
                        Id = category.GUID,
                        ParentId = category?.Parent?.GUID,
                        Description = category.Description,
                        Remarks = category.Remarks,
                        ImagePath = category?.ImagePath
                    };
                return Ok(new ResultSuccess());
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(ex));
            }
        }

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.MerchantStoreCategories.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var categories = await genericQuery.All<CategoryEntity>();
                if (categories.Count() == 0)
                    return BadRequest(new ResultViewModel()
                    {
                        ResultObject = false,
                        ResultEnum = Result.Failed.ToString(),
                        ResultMessage =
                            Constants.MESSAGE_RECORD_NOT_FOUND("Category")
                    });
                var models = new List<object>();
                foreach (var item in categories)
                {
                    var returnModel =
                        new {
                            Id = item.GUID,
                            ParentId = item?.Parent?.GUID,
                            Description = item.Description,
                            Remarks = item.Remarks,
                            ImagePath = item?.ImagePath
                        };
                    models.Add (returnModel);
                }

                return Ok(new ResultViewModel()
                {
                    ResultEnum = Result.Success.ToString(),
                    ResultObject = models
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel()
                {
                    ResultEnum = Result.Error.ToString(),
                    ResultMessage = Constants.GET_ERROR(ex)
                });
            }
        }
#endregion
#region Delete

        //delete is not implemented because if we delete the category
        //we need also to delete the related merchant store and merchantCategory table
        /// <summary>
        /// Delete Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        /// <response code="200">Successful</response>
        /// <response code="400">Bad Request</response>
        //[HttpDelete(ApiRoutes.MerchantStoreCategories.Delete)]
        //public async Task<IActionResult> Delete([FromRoute] int categoryId)
        //{
        //    try
        //    {
        //        var category = await genericQuery.FindOne<StoreCategoryEntity>(categoryId);
        //        if (category == null) return BadRequest(new ResultViewModel() { ResultObject = false, ResultEnum = Result.Failed.ToString(), ResultMessage = Constants.MESSAGE_RECORD_NOT_FOUND });
        //        var isSuccess = await genericQuery.Delete(category);
        //        if (isSuccess) return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS, ResultObject = true });
        //        return BadRequest(new ResultViewModel() { ResultMessage = Constants.MESSAGE_UNABLE_TO_PROCESS_REQUEST });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ResultViewModel() { ResultEnum = Result.Error.ToString(), ResultMessage = ex.Message });
        //    }
        //}
#endregion
    }
}
