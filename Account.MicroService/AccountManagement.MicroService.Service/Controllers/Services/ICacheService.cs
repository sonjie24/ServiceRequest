using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers.Services
{
 public interface ICacheService<T>
    {
        Task<T> GetCacheValue(string key);
        Task  Delete(string key);
        Task  SetCacheValue(string key,T data);
    }
}
