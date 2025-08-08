using System.Threading.Tasks;
using AccountManagement.Framework.Models;

namespace AccountManagement.Framework.Core.Interfaces
{
    public interface IMerchantAccountManager<T>  : IAccount<T>
    {
        Task<bool> ActivateAccount(string guid);
        Task<bool> SendResetEmail(string EmailAddress, string userGuid, string baseUrl);

        Task<bool> ChangePassword(T model);
        Task<ResultViewModel> ResetPassword(T model);
        bool IsOldPasswordUsed(string UserId, string newPassword );
        bool VerifyPassword(string PlainPassword, string encryptedPassword);
        Task<ResultViewModel> GetRoleForms(string  roleId);
        Task<ResultViewModel> GetUserRoles(string  userId);
        Task<ResultViewModel> GetUserRolesForms(string  userId);

    }
}
