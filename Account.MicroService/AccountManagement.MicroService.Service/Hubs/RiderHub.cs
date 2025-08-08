using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Models;
using Microsoft.AspNetCore.SignalR;

namespace AccountManagement.MicroService.Hubs
{
    //public class WalletBalancePayload
    //{
    //    public string RiderId   { get; set; }
    //    public string WalletId   { get; set; }
    //    public int Skip { get; set; }
    //    public int Take { get; set; }
    //}
    public class RiderHub : Hub
    {
        private readonly IRiderAccoutManager<RiderAccountEntity> account;

        public RiderHub(IRiderAccoutManager<RiderAccountEntity> account)
        {
            this.account = account;
        }
        public void SetDefaulWalletTopUp(object data) =>
        Clients.All.SendAsync("SetDefaulWalletTopUp", data);
        public void DeleteAccount(object data )=>  Clients.All.SendAsync("DeleteAccount", data);
        public void PublishAccountStatus(object data) => Clients.All.SendAsync("PublishAccountStatus", data);
        public void PublishBookingStatus(object data)=> Clients.All.SendAsync("PublishBookingStatus", data);
        public void PublishOnlineOfflineStatus(object data)=>   Clients.All.SendAsync("PublishOnlineOfflineStatus", data);
    }
}
