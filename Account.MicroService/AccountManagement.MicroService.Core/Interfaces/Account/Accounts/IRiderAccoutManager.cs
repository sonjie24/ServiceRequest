using System;
using System.Threading.Tasks;
using AccountManagement.Framework.Models;

namespace AccountManagement.Framework.Core.Interfaces
{
    public interface  IRiderAccoutManager<T>:IAccount<T>
    { 
        Task<bool> ChangePasswordAsync(T model);
        Task<ResultViewModel> LoginV2(T model);
        Task<ResultViewModel> RegisterV2(T model);
        Task<ResultViewModel> ResetPasswordAsync(T model);
        bool IsOldPasswordUsed(string UserId, string newPassword);
        bool VerifyPasswordAsync(string PlainPassword, string encryptedPassword);
        Task<bool> VerifyAccountAsync(string emailOrMobile,RiderAccountEntity account,string smsSignature);
        Task<bool> RegisterMobileAsync(string mobile,string smsSignature);

        //Task<bool> AddRiderRating(RiderAccountEntity rider , ConsumerToRiderRatingEntity ratingEntity);
        //Task<object> GetRiderRating(string riderId , int skip, int take);
        //Task<object> GetTotalRiderRating(string riderId);

    }
}
