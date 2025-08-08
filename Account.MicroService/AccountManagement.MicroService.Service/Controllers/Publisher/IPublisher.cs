using System;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace AccountManagement.MicroService.Controllers.Publisher
{
    public interface IPublisher
    {
        Task Publish<T>(T model, string label);
    }
}
