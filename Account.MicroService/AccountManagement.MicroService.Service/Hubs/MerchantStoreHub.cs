using System;
using Microsoft.AspNetCore.SignalR;

namespace AccountManagement.MicroService.Hubs
{
    public class MerchantStoreHub:Hub
    {
        public void UpdateStatus(object data) => Clients.All.SendAsync("UpdateStatus", data);
    }
}
