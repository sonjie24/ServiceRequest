using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.MicroService.Hubs
{
    public class ConsumerHub :Hub
    {
        public void UpdateStatus(object data)=> Clients.All.SendAsync("UpdateStatus", data);
        //public void DeleteAccount(object data)=> Clients.All.SendAsync("DeleteAccount", data);
    }
}
