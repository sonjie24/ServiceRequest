using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Data
{
    public static class GlobalExtensions
    {
        //Expression<Func<T, bool>> expression
        //public static async Task<IEnumerable<T>> WhereAsync<T>(
        //this IEnumerable<T> source, Func<T, Task<bool>> predicate)
        //{
        //    var results = new ConcurrentQueue<T>();
        //    var tasks = source.Select(
        //        async x =>
        //        {
        //            if (await predicate(x))
        //                results.Enqueue(x);
        //        });
        //    await Task.WhenAll(tasks);
        //    return results;
        //}
    }

}
