using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace AccountManagement.MicroService.Hubs.Managers
{
    public class MerchantStoreHubManager
    {
        public   async Task<HubConnection> Connect()
        {
            try
            {
                var connection =
                    new HubConnectionBuilder()
                        .WithUrl("http://pf-account-service.azurewebsites.net/merchant-store-hub")
                        .Build();

                await connection.StartAsync();
                return connection;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public   async Task<bool> PublishAccountStatus(object riderInfo)
        {
            try
            {
                var connection = await Connect();
                if (connection.State == HubConnectionState.Connected)
                {
                    await connection.InvokeAsync("PublishAccountStatus", riderInfo);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
