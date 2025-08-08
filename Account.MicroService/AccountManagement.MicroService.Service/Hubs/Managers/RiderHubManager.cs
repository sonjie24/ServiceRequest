using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace AccountManagement.MicroService.Hubs.Manager
{
    public class RiderHubManager
    {
        public   async Task<HubConnection> Connect()
        {
            try
            {
                var connection =
                    new HubConnectionBuilder()
                        .WithUrl("http://pf-account-service.azurewebsites.net/rider-hub")
                        .Build();

                await connection.StartAsync();
                return connection;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public   async Task<bool>
        PublishBalance(string RiderId, string WalletId)
        {
            try
            {
                var connection = await Connect();
                if (connection.State == HubConnectionState.Connected)
                {
                    await connection  .InvokeAsync("PublishBalance", new { RiderId, WalletId });
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

        public   async Task<bool> PublishBookingLimit(object riderInfo)
        {
            try
            {
                var connection = await Connect();
                if (connection.State == HubConnectionState.Connected)
                {
                    await connection
                        .InvokeAsync("PublishBookingLimit", riderInfo);
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

        public   async Task<bool> PublishAccountStatus(object riderInfo)
        {
            try
            {
                var connection = await Connect();
                if (connection.State == HubConnectionState.Connected)
                {
                    await connection
                        .InvokeAsync("PublishAccountStatus", riderInfo);
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

        public   async Task<bool> PublishBookingStatus(object riderInfo)
        {
            try
            {
                var connection = await Connect();
                if (connection.State == HubConnectionState.Connected)
                {
                    await connection .InvokeAsync("PublishBookingStatus", riderInfo);
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

        public async Task<bool> PublishOnlineOfflineStatus(object riderInfo)
        {
            try
            {
                var connection = await Connect();
                if (connection.State == HubConnectionState.Connected)
                {
                    await connection.InvokeAsync("PublishOnlineOfflineStatus", riderInfo);
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
