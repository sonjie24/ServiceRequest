using System;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core
{
    public interface IMessage <T>
    {
        Task<bool> send(T param,string token);
    }

    public interface IMessage2<T>: IMessage<T>
    {
        Task<bool> sendWithAppCode(T param, string appCode, string token);
    }
    public interface IMessage3<T> : IMessage2<T>
    {
        Task<Tuple<bool, string> > sendWithAppCodeReturnOTP(T param, string appCode, string token);
    }
}
