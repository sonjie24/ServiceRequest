using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Hubs
{
    public interface IAdminHub
    {

    }
    public class AdminHub:Hub
    {
        
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception); 
        }
        public override Task OnConnectedAsync()
        {
            Clients.All.SendAsync("NewAccount", "Admin hub Connected");
            return base.OnConnectedAsync(); 
        }

        public void NewAccount(string data) => Clients.All.SendAsync("NewAccount", data);
        public void UpdateStatus(object data) => Clients.All.SendAsync("UpdateStatus", data);
        //public void DeleteAccount(object data) => Clients.All.SendAsync("DeleteAccount", data);
    }
}
