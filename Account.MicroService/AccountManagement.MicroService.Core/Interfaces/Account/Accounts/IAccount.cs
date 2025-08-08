using AccountManagement.Framework.Models;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core.Interfaces
{
    public interface IAccount<T> : IActions<T>
    {

        Task<ResultViewModel> Register(T model);
        Task<ResultViewModel> Login(T model);
        Task<ResultViewModel> RefreshToken(string AccessToken, string RefreshToken);
    }
}
