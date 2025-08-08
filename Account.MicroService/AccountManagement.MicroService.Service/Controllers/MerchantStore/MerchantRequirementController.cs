using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Merchant-Document-Requirements")]
    public class MerchantRequirementController : Controller
    {
        private readonly IGenericQueryManager genericManager;

        public MerchantRequirementController(IGenericQueryManager genericManager)
        {
            this.genericManager = genericManager;
        }

        /// <summary>
        /// Add new Document
        /// </summary>
        /// <param name="model"></param>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost(ApiRoutes.MerchantRequirementRoute.Add)]
        public async Task<IActionResult>  Add([FromBody] DocumentRequirementRouteModel model,[FromRoute] string merchantId)
        {
            try
            {
                if (model == null) return NotFound(new ResultFailed(Constants.MESSAGE_INVALID_INPUT));
                if (string.IsNullOrEmpty(model.DocumentName) || string.IsNullOrEmpty(model.ImagePath)) return NotFound(new ResultFailed("Document Name and Imagepath is required"));

                var user = await genericManager.FindOne<MerchantStoreEntity>(merchantId);
                if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });

                var req = await genericManager.Where<MerchantRequirement > (x => x.MerchantId == merchantId && x.DocumentName == model.DocumentName.Trim());
                if (req.Count() > 0) return BadRequest(new ResultFailed("Document Name is already Exists"));

                var doc = new MerchantRequirement
                {
                    MerchantId = user.GUID,
                    DocumentName = model.DocumentName,
                    ImagePath = model.ImagePath,
                };

                await genericManager.AddOrUpdate(doc);
                await genericManager.CommitChanges();

                var returnModel = new
                {
                    documentId  = doc.GUID, 
                    DocumentName = doc.DocumentName.Trim(),
                    ImagePath = doc.ImagePath,
                };

                return Ok(new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return NotFound(new ResultFailed(Constants.GET_ERROR(ex)));
            }
        }

        /// <summary>
        /// Update Document
        /// </summary>
        /// <param name="model"></param>
        /// <param name="merchantId"></param>
        /// <param name="documentId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPut(ApiRoutes.MerchantRequirementRoute.Update)]
        public async Task<IActionResult> Update([FromBody] DocumentRequirementRouteModel model, [FromRoute] string merchantId,[FromRoute] string documentId)
        {
            try
            {
                if (model == null) return NotFound(new ResultFailed(Constants.MESSAGE_INVALID_INPUT));
                if (string.IsNullOrEmpty(model.DocumentName) || string.IsNullOrEmpty(model.ImagePath)) return NotFound(new ResultFailed("Document and Imagepath is required"));
                //var user = await genericManager.FindOne<MerchantStoreEntity>(merchantId);
                //if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });
                var doc = await genericManager.FindOne<MerchantRequirement>(documentId);
                if (doc == null) return NotFound(new ResultFailed("Document not found."));
                doc.DocumentName = model.DocumentName;
                doc.ImagePath = model.ImagePath;
                await genericManager.AddOrUpdate(doc);
                await genericManager.CommitChanges();

                var returnModel = new
                {
                    DocId = doc.GUID,
                    DocumentName = doc.DocumentName,
                    ImagePath = doc.ImagePath,
                };

                return Ok(new ResultSuccess(returnModel));
            }
            catch (Exception ex)
            {
                return NotFound(new ResultFailed(Constants.GET_ERROR(ex)));
            }
        }

        /// <summary>
        /// Get all Merchant  Documents
        /// </summary>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.MerchantRequirementRoute.GetAll)]
        public async Task<IActionResult>  GetAll([FromRoute] string merchantId )
        {
            try
            {
                //var user = await genericManager.FindOne<MerchantStoreEntity>(merchantId);
                //if (user == null) return NotFound(new ResultFailed(Constants.MESSAGE_ACCOUNT_NOT_EXISTS));

                var docs=(await genericManager.Where<MerchantRequirement>(x => x.MerchantId == merchantId)).OrderByDescending(x=>x.DateCreated);

                var returnModels = new List<object>();
                foreach (var doc in docs)
                {
                    var returnModel = new
                    {
                        DocId = doc.GUID,
                        DocumentName = doc.DocumentName,
                        ImagePath = doc.ImagePath,
                    };

                    returnModels.Add(returnModel);
                }
                return Ok(new ResultSuccess(returnModels));
            }
            catch (Exception ex)
            {
                return NotFound(new ResultFailed(Constants.GET_ERROR(ex)));
            }
        }

        /// <summary>
        /// Get Document by Id
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="documentId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.MerchantRequirementRoute.GetBydocumentDocumentId)]
        public async Task<IActionResult>  GetBydocumentDocumentId([FromRoute] string merchantId,[FromRoute] string documentId)
        {
            try
            {
                //var user = await genericManager.FindOne<MerchantStoreEntity>(merchantId);
                //if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });

                var docs = await genericManager.Where<MerchantRequirement>(x => x.MerchantId == merchantId && x.GUID== documentId);
                var returnModels = new List<object>();
                foreach (var doc in docs)
                {
                    var returnModel = new
                    {
                        DocId = doc.GUID,
                        DocumentName = doc.DocumentName,
                        ImagePath = doc.ImagePath,
                    };
                    returnModels.Add(doc);
                }
                return Ok(new ResultSuccess(returnModels));
            }
            catch (Exception ex)
            {
                return NotFound(new ResultFailed(Constants.GET_ERROR(ex)));
            }
        }

        /// <summary>
        /// Get Document by Document Name
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="documentName"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.MerchantRequirementRoute.GetBydocumentDocumentName)]
        public async Task<IActionResult> GetBydocumentDocumentName([FromRoute] string merchantId, [FromRoute] string documentName)
        {
            try
            {
                //var user = await genericManager.FindOne<MerchantStoreEntity>(merchantId);
                //if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });
                var docs = await genericManager.Where<MerchantRequirement>(x => x.MerchantId == merchantId && x.DocumentName == documentName.Trim());
                var returnModels = new List<object>();
                foreach (var doc in docs)
                {
                    var returnModel = new
                    {
                        DocId = doc.GUID,
                        DocumentName = doc.DocumentName,
                        ImagePath = doc.ImagePath,
                    };
                    returnModels.Add(doc);
                }
                return Ok(new ResultSuccess(returnModels));
            }
            catch (Exception ex)
            {
                return NotFound(new ResultFailed(Constants.GET_ERROR(ex)));
            }
        }

        /// <summary>
        /// Remove document
        /// </summary>
        /// <param name="merchantId">Merchant Id</param>
        /// <param name="documentId">Document Id</param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpDelete(ApiRoutes.MerchantRequirementRoute.Remove)]
        public async Task<IActionResult> Remove([FromRoute] string merchantId, [FromRoute] string documentId)
        {
            try
            {
                //var user = await genericManager.FindOne<MerchantStoreEntity>(merchantId);
                //if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });

                var docs = await genericManager.Where<MerchantRequirement>(x => x.MerchantId == merchantId && x.GUID == documentId);
                if (docs == null) return NotFound(new ResultViewModel() { ResultMessage = "Document not found.", ResultEnum = Result.Failed.ToString() });
                foreach (var doc in docs)
                {
                    await genericManager.Delete(doc);
                }
                await genericManager.CommitChanges();
                return Ok(new ResultSuccess());
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(Constants.GET_ERROR(ex)));
            }
        }

        /// <summary>
        /// Remove All document
        /// </summary>
        /// <param name="merchantId">Merchant Id</param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpDelete(ApiRoutes.MerchantRequirementRoute.RemoveAll)]
        public async Task<IActionResult> RemoveAll([FromRoute] string merchantId )
        {
            try
            {
                //var user = await genericManager.FindOne<MerchantStoreEntity>(merchantId);
                //if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });
                var docs = await genericManager.Where<MerchantRequirement>(x => x.MerchantId == merchantId);
                foreach (var doc in docs)
                {
                    await genericManager.Delete(doc);
                }
                await genericManager.CommitChanges();
                return Ok(new ResultSuccess());
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultFailed(Constants.GET_ERROR(ex)));
            }
        }
    }
}
