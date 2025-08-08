using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;
using AccountManagement.Framework.Models;
using AccountManagement.Framework.Core.Interfaces;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Account-Consumer-Address")]
    public class ConsumerAddressController : Controller
    {
        private IConsumerAccountManager<ConsumerAccountEntity> accountManager;
        private IGenericQueryManager  genericQueryManager;
        public ConsumerAddressController(IConsumerAccountManager<ConsumerAccountEntity> _accountManager,
            IGenericQueryManager genericQueryManager)
        {
            accountManager = _accountManager;
           this.genericQueryManager = genericQueryManager;
        }

        /// <summary>
        /// Add Address
        /// </summary>
        /// <param name="model"></param>
        /// <param name="consumerId"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Failed</response>
        /// <response code="401">Unauthorized</response>
        [HttpPost(ApiRoutes.ConsumerAccountRoute.addressAdd)]
        public async Task<IActionResult> AddAddress([FromBody] ConsumerAddressRouteModel model,[FromRoute] string consumerId) 
        {
            try
            { 
                var user = await accountManager.FindOne(consumerId);
                if (user==null) return BadRequest(new ResultViewModel() { ResultEnum=Result.Failed.ToString(), ResultMessage="Consumer not found" } );

                double.TryParse(model.Longitude, out var Longitude);
                double.TryParse(model.Latitude, out var Latitude);

                var address = new ConsumerAddressBookEntity();
                address.Type = model.AddressType;
                address.Address = model.Address;
                address.Longitude = Longitude;
                address.Latitude = Latitude;
                address.AddressDetail =  model.Address_Details;
                address.RiderInstruction = model.Rider_Instruction;
                address.Location = Common.CreateGeometryPoint(Longitude, Latitude);
                address.Consumer = user;
                address.ModifiedBy = consumerId;
                address.DateModified = Common.getDateNow();
                address.isDefault = false;

                var result =await genericQueryManager.AddOrUpdate(address);
                int affected= await  genericQueryManager.CommitChanges();

                var resultModel = new
                {
                    id = address.GUID,
                    AddressType = address.Type,
                    Address = address.Address,
                    Longitude = address.Longitude,
                    Latitude = address.Latitude,
                    Address_Details = address.AddressDetail,
                    Rider_Instruction = address.RiderInstruction,
                    IsDefault = address.isDefault,
                };

                return   Ok(new ResultViewModel() { ResultObject = resultModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }

        [HttpPut(ApiRoutes.ConsumerAccountRoute.addressUpdate)]
        public async Task<IActionResult>  UpdateAddress([FromBody] ConsumerAddressRouteModelUpdate model, [FromRoute] string consumerId,[FromRoute] string address_id)
        {
            try
            {
                var user = await accountManager.FindOne(consumerId);
                if (user == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Consumer not found" });

                double.TryParse(model.Longitude, out var Longitude);
                double.TryParse(model.Latitude, out var Latitude);
                if (model.Id!=address_id) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Address not found." });

                var addresses =   await genericQueryManager.Where<ConsumerAddressBookEntity>(x => x.Consumer == user && x.GUID==address_id);
                var address = addresses.FirstOrDefault();
                if (address == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Address not found." });

                address.Type = model.AddressType;
                address.Address = model.Address;
                address.Longitude = Longitude;
                address.Latitude = Latitude;
                address.AddressDetail = model.Address_Details;
                address.RiderInstruction = model.Rider_Instruction;
                address.Location = Common.CreateGeometryPoint(Longitude, Latitude);
                address.Consumer = user;
                address.ModifiedBy = consumerId;
                address.DateModified = Common.getDateNow();

                //await genericQueryManager.AddOrUpdate(user);
                var result = await genericQueryManager.AddOrUpdate(address);
                int affected = await genericQueryManager.CommitChanges();

                var resultModel = new
                {

                    id = address.GUID,
                    AddressType = address.Type,
                    Address = address.Address,
                    Longitude = address.Longitude,
                    Latitude = address.Latitude,
                    Address_Details = address.AddressDetail,
                    Rider_Instruction = address.RiderInstruction,
                    IsDefault = address.isDefault,
                };

                return Ok(new ResultViewModel() { ResultObject = resultModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }


        /// <summary>
        /// Set Address as Default
        /// </summary>
        /// <param name="AddressType"></param>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Failed</response>
        /// <response code="401">Unauthorized</response>
        [HttpPatch(ApiRoutes.ConsumerAccountRoute.SetDefault)]
        public async Task<IActionResult> SetDefaultAddress( [FromRoute] string consumerId,[FromRoute] string address_id)
        {
            try
            {
 
                var user = await accountManager.FindOne(consumerId);
                if (user == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Consumer not logged-in" });

                var addressess = (await genericQueryManager.Where<ConsumerAddressBookEntity>(x =>x.ConsumerId ==user.Id));
                var defaultAddress = addressess.Where(x=>x.GUID==address_id).FirstOrDefault();
                if (defaultAddress==null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Address not found" });

                foreach (var address in addressess)//set all others as not default
                {
                  if (address.GUID == defaultAddress.GUID) continue;
                  address.isDefault = false;
                  await   genericQueryManager.AddOrUpdate(address);
                }

                defaultAddress.isDefault = true;
                await genericQueryManager.AddOrUpdate(defaultAddress);
                await genericQueryManager.CommitChanges();
                //if (address == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "No address found of this type." });
                defaultAddress.ModifiedBy = consumerId;
                defaultAddress.DateModified = Common.getDateNow();
                defaultAddress.isDefault = true;
                var returnModel = new
                {
                    id = defaultAddress.GUID,
                    AddressType = defaultAddress.Type,
                    Address = defaultAddress.Address,
                    Longitude = defaultAddress.Longitude,
                    Latitude = defaultAddress.Latitude,
                    Address_Details = defaultAddress.AddressDetail,
                    Rider_Instruction = defaultAddress.RiderInstruction,
                    IsDefault = defaultAddress.isDefault,
                };
                return Ok(new ResultViewModel() { ResultObject = returnModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }

        /// <summary>
        /// Get Default Address
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Failed</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.GetDefault)]
        public async Task<IActionResult> GetDefaultAddress([FromRoute] string consumerId)
        {
            try
            {
                var user = await accountManager.FindOne(consumerId);
                if (user == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Consumer not logged-in" });

                var defaultAddress = (await genericQueryManager.Where<ConsumerAddressBookEntity>(x => x.Consumer == user && x.isDefault == true)).FirstOrDefault();
                if (defaultAddress == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "No location found." });
                var returnModel = new
                {
                    id = defaultAddress.GUID,
                    AddressType = defaultAddress.Type,
                    Address = defaultAddress.Address,
                    Longitude = defaultAddress.Longitude,
                    Latitude = defaultAddress.Latitude,
                    Address_Details = defaultAddress.AddressDetail,
                    Rider_Instruction = defaultAddress.RiderInstruction,
                    IsDefault = defaultAddress.isDefault,
                };
                return Ok(new ResultViewModel() { ResultObject = returnModel, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }
        /// <summary>
        /// Get All Address
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Success</response>
        /// <response code="400">Failed</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet(ApiRoutes.ConsumerAccountRoute.addressAll)]
        public async Task<IActionResult> GetAllAddress([FromRoute] string consumerId)
        {
            try
            {
                var user = await accountManager.FindOne(consumerId);
                if (user == null) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Consumer not logged-in" });

                var addresses = await genericQueryManager.Where<ConsumerAddressBookEntity>(x => x.Consumer == user);
                if (addresses.Count() == 0) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "No location found." });
                
                var returnModels = new List<object>();
                foreach (var address in addresses)
                {
                    var returnModel = new
                    {
                        id = address.GUID,
                        AddressType = address.Type,
                        Address = address.Address,
                        Longitude = address.Longitude,
                        Latitude = address.Latitude,
                        Address_Details = address.AddressDetail,
                        Rider_Instruction = address.RiderInstruction,
                        IsDefault = address.isDefault,
                    };

                    returnModels.Add(returnModel);
                }
              
                return Ok(new ResultViewModel() { ResultObject = returnModels, ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }


        /// <summary>
        /// Remove Address by Type
        /// </summary>
        /// <param name="address_id"></param>
        /// < returns ></ returns >
        /// < response code="200">Success</response>
        /// <response code = "400" > Failed </ response >
        /// < response code="401">Unauthorized</response>
        [HttpDelete(ApiRoutes.ConsumerAccountRoute.removeaddress)]
        public async Task<IActionResult> DeleteAddress([FromRoute] string address_id)
        {
            try
            {
                var addresses = await genericQueryManager.Where<ConsumerAddressBookEntity>(x => x.GUID == address_id);
                if (addresses.Count()==0 ) return BadRequest(new ResultViewModel() { ResultEnum = Result.Failed.ToString(), ResultMessage = "Address not found." });
                foreach (var address in addresses)
                {
                    await genericQueryManager.Delete(address);
                }
                await genericQueryManager.CommitChanges();
                return Ok(new ResultViewModel() { ResultEnum = Result.Success.ToString(), ResultMessage = Constants.MESSAGE_SUCCESS });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultViewModel { ResultEnum = Result.Error.ToString(), ResultMessage = Constants.GET_ERROR(ex) });
            }
        }
    }
}