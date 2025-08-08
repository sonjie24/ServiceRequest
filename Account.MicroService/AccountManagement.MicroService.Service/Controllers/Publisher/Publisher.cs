using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;

namespace AccountManagement.MicroService.Controllers.Publisher
{
    public class Publisher:IPublisher
    {
        private readonly ITopicClient topicClient;

        public Publisher(ITopicClient topicClient)
        {
            this.topicClient = topicClient;
        }

        public Task Publish<T>(T model, string label)
        {
            var jsonstring = JsonConvert.SerializeObject(model);
            var message = new Message(Encoding.UTF8.GetBytes(jsonstring));
            //message.UserProperties["messageType"] = typeof(T).Name;
            message.Label = label;
            return topicClient.SendAsync(message);
        }
    }
}
