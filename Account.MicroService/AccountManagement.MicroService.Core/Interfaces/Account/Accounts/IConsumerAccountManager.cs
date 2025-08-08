using AccountManagement.Framework.Models;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core.Interfaces
{
  public interface IConsumerAccountManager<T>:IAccount<T>
    {

        Task<ResultViewModel> RegisterDevice(T model);
        Task<ResultViewModel> LoginByDeviceId(string deviceId);
        Task<Tuple<bool, object>> GetNearest(Point consumerLocation , int skip, int take);
        Task<Tuple<bool, object>> GetNearestByName(Point consumerLocation , string Name);
        Task<Tuple<bool, object>> GetNearestCategory(string Category,Point consumerLocation , int skip, int take);
        Task<Tuple<bool, object>> GetFavorites(string userId, Point consumerLocation , int skip, int take);
        Task<ResultViewModel> CheckSocialId(string socialId,string AppCode);
        Task<bool> RegisterMobileAsync(string mobile,string AppCode);
        Task<bool> AddFavoriteMerchant(string consumerGuid, string merchantGuid);
        Task<bool> RemoveFavoriteMerchant(string consumerGuid, string merchantGuid);
        Task<object> GetMerchantSched(string merchantId, DateTime  dateTime  );
    }
}
