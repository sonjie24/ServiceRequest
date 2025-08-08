using AccountManagement.Framework.Models;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core.Interfaces
{
    public   interface IMerchantStoreManager<T> : IActions<T>
    {
        Task<ResultViewModel> Register(T model,MerchantAccountEntity adminUser);
        Task<ResultViewModel> AddRelatedBranch(T model);
        Task<Tuple<bool, object>> GetNearest(Point  storeLocation, double riderDistance, int skip, int take);
        Task<bool> VerifyEmail(string guid);
        //Task<bool> EmailNewStoreStaff(string Email, string firsName, string StaffGUID, string token);
        Task<bool> UpdateLongLat(MerchantStoreEntity model );
        Task<bool> UpdateModel(MerchantStoreEntity model ,MerchantAccountEntity adminUser , List<MerchantCategoryEntity> newItems,bool IsNewEmail,string token,string baseUrl);
        Task<List<MerchantCategoryEntity>> FindMerchantCategories(string merchantId);

  

        //Task<bool> AddMerchantRating(MerchantStoreEntity store, RiderToMerchantRatingEntity ratingEntity);
        //Task<object> GetMerchantRating(string merchantId, int skip, int take);
        //Task<object> GetTotalMerchantRating(string merchantId);
        //Task<bool> AddConsumerToMerchantReview(MerchantStoreEntity store, ConsumerToMerchantRatingEntity ratingEntity);
        //Task<object> GetConsumerToMerchantReview(string merchantId, int skip, int take);

    }
}
