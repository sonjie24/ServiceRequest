using AccountManagement.Framework.Models;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core.Interfaces
{
    public interface ITokenManger<T>
    {
        Task<ResultViewModel> RefreshTokenAsync(string accessToken, string refreshToken);
        Task<AuthenticationResult> GenerateAuthenticationAsync(T user);
        //Task<AuthenticationResult> UpdateOpenToken(ClaimsAccountModel user);
        //Task<ClaimsAccountModel> PopuplateClaims( user);
    }
}
