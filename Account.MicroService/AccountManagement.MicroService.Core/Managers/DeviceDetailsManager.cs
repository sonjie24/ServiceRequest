//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.Extensions.Logging;
//using AutoMapper;
//using System.Collections.Generic;
//using AccountManagement.Framework.Models;
//using AccountManagement.Framework.Core.Interfaces;
//using AccountManagement.Framework.Data;

//namespace AccountManagement.Framework.Core
//{
//    public class DeviceDetailsManager : IDeviceDetailsManager
//    {

//        #region Properties
//        IMapper imapper;
//        protected readonly Database db;
//        private readonly ILogger ilogger;
//        #endregion

//        #region Constructors
//        public DeviceDetailsManager(ILogger<DeviceDetailsManager> _ilogger, IMapper _mapper, Database _db)
//        {
//            imapper = _mapper;
//            db = _db;
//            ilogger = _ilogger;            
//        }
//        #endregion
        
//        /// <summary>
//        ///     Save and Update Data 
//        /// </summary>
//        /// <param name="model">Model</param>
//        /// <param name="updateMode">Flag to Save or Update the data</param>
//        /// <returns>returns flag if saving is successful or failed</returns>
//        public async Task<ResultViewModel> SaveUpdate(List<DeviceDetail> model, bool updateMode = false)
//        {
//            ResultViewModel result = new ResultViewModel();
//            result.ResultEnum = Result.Failed.ToString();

//            try
//            {      
//                using (var tx = await db.context.Database.BeginTransactionAsync()) // Remove Async for Debugging
//                {
//                    bool saveFlag = true;
//                    DeviceDetail main = null;
              
//                    if (model != null)
//                    {
//                        if (updateMode)
//                        {
//                            foreach (var row in model)
//                            {
//                                var dt = db.context.DeviceDetails.FirstOrDefault(u => u.Id == row.Id);
//                                if (dt != null)
//                                {
//                                    //Main Saving
//                                    dt.Id = row.Id;                         
//                                    dt.RegistrationToken = row.RegistrationToken;

//                                    dt.DeviceId = row.DeviceId;
//                                    dt.UserId = row.UserId;

//                                    dt.ModifiedBy = row.ModifiedBy;
//                                    dt.DateModified = row.DateModified;
//                                    dt.ModifiedBy = row.ModifiedBy;

//                                    main = imapper.Map<DeviceDetail>(dt);
//                                    db.context.DeviceDetails.Update(main);

//                                }                               
//                            }
//                        } else {

//                            foreach (var row in model)
//                            {
//                                var dt = db.context.DeviceDetails.FirstOrDefault(u => u.DeviceId == row.DeviceId);
//                                if (dt != null)
//                                {                                    
//                                    dt.RegistrationToken = row.RegistrationToken;

//                                    dt.DeviceId = row.DeviceId;
//                                    dt.UserId = row.UserId;

//                                    dt.ModifiedBy = row.ModifiedBy;
//                                    dt.DateModified = row.DateModified;
//                                    dt.ModifiedBy = row.ModifiedBy;

//                                    main = imapper.Map<DeviceDetail>(dt);
//                                    db.context.DeviceDetails.Update(main);
//                                }
//                                else
//                                {
//                                    main = imapper.Map<DeviceDetail>(row);
//                                    db.context.DeviceDetails.Add(main);
//                                }
                                   
                                
//                            }
//                        }
//                        // Save to Database
//                        if (saveFlag)
//                        {
//                            await db.context.SaveChangesAsync();
//                            result.ResultEnum = Result.Success.ToString();
//                            result.ResultMessage = "Save Successful!";
//                            result.ResultObject = "";
//                            tx.Commit(); // Commit Transaction
//                        }
//                    }
//                    else
//                    {
//                        result.ResultEnum = Result.Failed.ToString();
//                        result.ResultMessage = "Save Failed! Please try again later.";
//                    }
//                }
//            }
//            catch (Exception ex)
//            {                
//                result.ResultEnum = Result.Error.ToString();
//                result.ResultMessage = ex.Message;
//                ilogger.LogError(ex.Message, ex);
//            }
//            return result;
//        }

//        /// <summary>
//        ///    Update Status
//        /// </summary>
//        /// <returns></returns>
//        public async Task<ResultViewModel> UpdateStatus(StatusModel model, string Id)
//        {
//            ResultViewModel result = new ResultViewModel();
//            DeviceDetail main = null;
//            bool saveFlag = true;
//            try
//            {
//                using (var tx = await db.context.Database.BeginTransactionAsync()) // Remove Async for Debugging
//                {
//                    var dt = db.context.DeviceDetails.FirstOrDefault(u => u.GUID == Id);
//                    if (dt != null)
//                    {
//                        dt.Status =  model.status=="Active"  ? EStatus.Active :  EStatus.Cancelled;
//                        dt.ModifiedBy = model.ModifiedBy;
//                        dt.DateModified = model.DateModified;

//                        main = imapper.Map<DeviceDetail>(dt);
//                        db.context.DeviceDetails.Update(main);
//                    }else
//                        saveFlag = false;
//                        result.ResultEnum = Result.Failed.ToString();
//                        result.ResultMessage = "No data found!";
//                        result.ResultObject = "";

//                    if (saveFlag)
//                    {
//                        await db.context.SaveChangesAsync();
//                        result.ResultEnum = Result.Success.ToString();
//                        result.ResultMessage = "Update Status Successful!";
//                        result.ResultObject = "";
//                        tx.Commit(); // Commit Transaction
//                    }
//                }                              

//            }
//            catch (Exception ex)
//            {
//                result.ResultEnum = Result.Error.ToString();
//                result.ResultMessage = ex.Message;
//                ilogger.LogError(ex.Message, ex);
//            }

//            return result;
//        }


//        /// <summary>
//        ///    Get Data Info
//        /// </summary>
//        /// <returns></returns>
//        public async Task<ResultViewModel> GetInfo(string clientId)
//        {
//            ResultViewModel result = new ResultViewModel();
//            result.ResultEnum = Result.Failed.ToString();

//            try          
//            {
            
//                var lstData = from f in db.context.DeviceDetails.Where(x => x.UserId == clientId)
//                           select new
//                           {
//                               Id = f.Id,
//                               RegistrationToken = f.RegistrationToken,
//                               DeviceId = f.DeviceId,
//                               UserId = f.UserId
//                           };
                               
//                result.ResultEnum = Result.Success.ToString();
//                result.ResultMessage = "Get Successful!";
//                result.ResultObject = lstData.ToList();
//            }
//            catch (Exception ex)
//            {
//                result.ResultEnum = Result.Error.ToString();
//                result.ResultMessage = ex.Message;
//                ilogger.LogError(ex.Message, ex);
//            }
//            return result;
//        }
//    }
//}
