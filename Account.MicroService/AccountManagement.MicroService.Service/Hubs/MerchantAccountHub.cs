using System;
using Microsoft.AspNetCore.SignalR;

namespace AccountManagement.MicroService.Hubs
{
    public class MerchantAccountHub : Hub
    {
        public void UpdateStatus(object data) => Clients.All.SendAsync("UpdateStatus", data); 
    }
}
