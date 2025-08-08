using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core
{

  public  class ResetAccountMailService : IMessage<Mail>
    {
        private static string Baseurl = "https://pf-other-service.azurewebsites.net/";
        public async Task<bool> send(Mail param,string token)
        {
            string body = $"";
            param.body = body;
            param.header = "";
            param.subject = "Reset Account";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",  token);
                param.header = "Account Verification";
                string json = JsonConvert.SerializeObject(param);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var Res = await client.PostAsync($"api/v1/email/sendemail/reset-account", httpContent);
                if (!Res.IsSuccessStatusCode) return false;
                var Response = Res.Content.ReadAsStringAsync().Result;
                return !string.IsNullOrWhiteSpace(Response);
            }
        }
    }
}
