using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Controllers.Services
{
    public class AccountCacheService<T> : ICacheService<T>
    {
        private readonly IConnectionMultiplexer connection;

        public AccountCacheService(IConnectionMultiplexer connection)
        {
            this.connection = connection;
        }

        public async Task Delete(string key)
        {
            var db = connection.GetDatabase();
            await db.KeyDeleteAsync(key);
        }

        public async Task<T> GetCacheValue(string key)
        {
            var db = connection.GetDatabase();
            var resp = await db.StringGetAsync(key);
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>( resp);
            return data;
        }

        public async Task SetCacheValue(string key, T data)
        {
            var db = connection.GetDatabase();
            var model  = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            await db.StringSetAsync(key,model);
        }
    }
}
