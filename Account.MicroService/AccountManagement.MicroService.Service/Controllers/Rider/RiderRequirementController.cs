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
    [ApiExplorerSettings(GroupName = "Rider-Document-Requirements")]
    public class RiderRequirementController : Controller
    {
        private readonly IGenericQueryManager genericManager;

        public RiderRequirementController(IGenericQueryManager genericManager)
        {
            this.genericManager = genericManager;
        }

        /// <summary>
        /// Add new Document
        /// </summary>
        /// <param name="model"></param>
        /// <param name="riderId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost(ApiRoutes.RiderRequirementRoute.Add)]
        public async Task<IActionResult>  Add([FromBody] DocumentRequirementRouteModel model,[FromRoute] string riderId)
        {
            try
            {
                if (model == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_INVALID_INPUT, ResultEnum = Result.Failed.ToString() });
                if (string.IsNullOrEmpty(model.DocumentName) || string.IsNullOrEmpty(model.ImagePath)) return NotFound(new ResultViewModel() { ResultMessage = "Document Name and Imagepath is required", ResultEnum = Result.Failed.ToString() });
                var user = await genericManager.FindOne<RiderAccountEntity>(riderId);
                if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });
                var req = await genericManager.Where<RiderRequirement>(x => x.RiderId==riderId && x.DocumentName == model.DocumentName.Trim());
                if (req.Count()>0) return BadRequest(new ResultViewModel() { ResultMessage = "Document Name is already Exists", ResultEnum = Result.Failed.ToString() });

                var doc = new RiderRequirement
                {
                    RiderId = user.GUID,
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

                return Ok(new ResultViewModel() { ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return NotFound(new ResultViewModel() {   ResultMessage = Constants.GET_ERROR(ex), ResultEnum = Result.Error.ToString() });
            }
        }

        /// <summary>
        /// Update Document
        /// </summary>
        /// <param name="model"></param>
        /// <param name="riderId"></param>
        /// <param name="documentId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPut(ApiRoutes.RiderRequirementRoute.Update)]
        public async Task<IActionResult> Update([FromBody] DocumentRequirementRouteModel model, [FromRoute] string riderId,[FromRoute] string documentId)
        {
            try
            {
                if (model == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_INVALID_INPUT, ResultEnum = Result.Failed.ToString() });
                if (string.IsNullOrEmpty(model.DocumentName) || string.IsNullOrEmpty(model.ImagePath)) return NotFound(new ResultViewModel() { ResultMessage = "Document and Imagepath is required", ResultEnum = Result.Failed.ToString() });
                var user = await genericManager.FindOne<RiderAccountEntity>(riderId);
                if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });

                var doc = await genericManager.FindOne<RiderRequirement>(documentId);
                if (doc == null) return NotFound(new ResultViewModel() { ResultMessage = "Document not found.", ResultEnum = Result.Failed.ToString() });

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

                return Ok(new ResultViewModel() { ResultObject = returnModel, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return NotFound(new ResultViewModel() { ResultMessage = Constants.GET_ERROR(ex), ResultEnum = Result.Error.ToString() });
            }
        }

        /// <summary>
        /// Get all Rider  Documents
        /// </summary>
        /// <param name="riderId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.RiderRequirementRoute.GetAll)]
        public async Task<IActionResult>  GetAll([FromRoute] string riderId )
        {
            try
            {
                var user = await genericManager.FindOne<RiderAccountEntity>(riderId);
                if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });

                var docs=await genericManager.Where<RiderRequirement>(x=>x.RiderId==riderId);
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
                return Ok(new ResultViewModel() { ResultObject = returnModels, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return NotFound(new ResultViewModel() { ResultMessage = Constants.GET_ERROR(ex), ResultEnum = Result.Error.ToString() });
            }
        }

        /// <summary>
        /// Get Document by Id
        /// </summary>
        /// <param name="riderId"></param>
        /// <param name="documentId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.RiderRequirementRoute.GetBydocumentDocumentId)]
        public async Task<IActionResult>  GetBydocumentDocumentId([FromRoute] string riderId,[FromRoute] string documentId)
        {
            try
            {
                var user = await genericManager.FindOne<RiderAccountEntity>(riderId);
                if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });

                var docs = await genericManager.Where<RiderRequirement>(x => x.RiderId == riderId && x.GUID== documentId);
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
                return Ok(new ResultViewModel() { ResultObject = returnModels, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return NotFound(new ResultViewModel() { ResultMessage = Constants.GET_ERROR(ex), ResultEnum = Result.Error.ToString() });
            }
        }

        /// <summary>
        /// Get Document by Document Name
        /// </summary>
        /// <param name="riderId"></param>
        /// <param name="documentName"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpGet(ApiRoutes.RiderRequirementRoute.GetBydocumentDocumentName)]
        public async Task<IActionResult> GetBydocumentDocumentName([FromRoute] string riderId, [FromRoute] string documentName)
        {
            try
            {
                var user = await genericManager.FindOne<RiderAccountEntity>(riderId);
                if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });
                var docs = await genericManager.Where<RiderRequirement>(x => x.RiderId == riderId && x.DocumentName == documentName.Trim());
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
                return Ok(new ResultViewModel() { ResultObject = returnModels, ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return NotFound(new ResultViewModel() { ResultMessage = Constants.GET_ERROR(ex), ResultEnum = Result.Error.ToString() });
            }
        }

        /// <summary>
        /// Remove document
        /// </summary>
        /// <param name="riderId">Rider Id</param>
        /// <param name="documentId">Document Id</param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpDelete(ApiRoutes.RiderRequirementRoute.Remove)]
        public async Task<IActionResult> Remove([FromRoute] string riderId, [FromRoute] string documentId)
        {
            try
            {
                var user = await genericManager.FindOne<RiderAccountEntity>(riderId);
                if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });

                var docs = await genericManager.Where<RiderRequirement>(x => x.RiderId == riderId && x.GUID == documentId);
                if (docs == null) return NotFound(new ResultViewModel() { ResultMessage = "Document not found.", ResultEnum = Result.Failed.ToString() });
                foreach (var doc in docs)
                {
                    await genericManager.Delete(doc);
                }
                await genericManager.CommitChanges();
                return Ok(new ResultViewModel() {  ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.GET_ERROR(ex), ResultEnum = Result.Error.ToString() });
            }
        }

        /// <summary>
        /// Remove All document
        /// </summary>
        /// <param name="riderId">Rider Id</param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpDelete(ApiRoutes.RiderRequirementRoute.RemoveAll)]
        public async Task<IActionResult> RemoveAll([FromRoute] string riderId )
        {
            try
            {
                var user = await genericManager.FindOne<RiderAccountEntity>(riderId);
                if (user == null) return NotFound(new ResultViewModel() { ResultMessage = Constants.MESSAGE_ACCOUNT_NOT_EXISTS, ResultEnum = Result.Failed.ToString() });
                var docs = await genericManager.Where<RiderRequirement>(x => x.RiderId == riderId);
                foreach (var doc in docs)
                {
                    await genericManager.Delete(doc);
                }
                await genericManager.CommitChanges();
                return Ok(new ResultViewModel() { ResultMessage = Constants.MESSAGE_SUCCESS, ResultEnum = Result.Success.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel() { ResultMessage = Constants.GET_ERROR(ex), ResultEnum = Result.Error.ToString() });
            }
        }
    }
}
