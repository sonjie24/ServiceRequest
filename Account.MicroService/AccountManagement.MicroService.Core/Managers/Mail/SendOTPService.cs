using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AccountManagement.Framework.Models;
using Newtonsoft.Json;

namespace AccountManagement.Framework.Core
{

    public class OPTModel
    {
        public string mobilenumber { get; set; }
        public string AppCode { get; set; }
    }
    public class SendOTPService : IMessage3<string>
    {
        public async Task<bool> send(string param, string token)
        { 
            using (var client = new HttpClient())
            {
                var otp = new OPTModel
                {
                    mobilenumber = param
                };
                client.BaseAddress = new Uri("https://pf-other-service.azurewebsites.net/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                string json = JsonConvert.SerializeObject(otp);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var Res = await client.PostAsync($"api/v1/SendOTPSemaphore/{param}", httpContent);
                if (!Res.IsSuccessStatusCode) return false;
                var Response = Res.Content.ReadAsStringAsync().Result;
                return !string.IsNullOrWhiteSpace(Response);
            }
        }

        public async Task<bool> sendWithAppCode(string param, string appCode, string token)
        {
            using (var client = new HttpClient())
            {
                var otp = new OPTModel
                {
                    mobilenumber = param,
                    AppCode = appCode
                };

                client.BaseAddress = new Uri("https://pf-other-service.azurewebsites.net/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
              
                string json = JsonConvert.SerializeObject(otp);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var Res = await client.PostAsync($"api/v1/SendOTPSemaphore/{param}", httpContent);
                if (!Res.IsSuccessStatusCode) return false;
                var Response = Res.Content.ReadAsStringAsync().Result;
                //var account = JsonConvert.DeserializeObject<ResultViewModel>(Response);
                return !string.IsNullOrWhiteSpace(Response);
            }
        }

        public async Task<Tuple<bool, string>> sendWithAppCodeReturnOTP(string param, string appCode, string token)
        {
            using (var client = new HttpClient())
            {
                var otp = new OPTModel
                {
                    mobilenumber = param,
                    AppCode = appCode
                };
                client.BaseAddress = new Uri("https://pf-other-service.azurewebsites.net/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                string json = JsonConvert.SerializeObject(otp);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var Res = await client.PostAsync($"api/v1/SendOTPSemaphore/{param}", httpContent);
                if (!Res.IsSuccessStatusCode) return new Tuple<bool, string>(false, "");
                var Response = Res.Content.ReadAsStringAsync().Result;
                var account = JsonConvert.DeserializeObject<ResultViewModel>(Response);
                var isresp = !string.IsNullOrWhiteSpace(Response);
                return new Tuple<bool, string>(isresp, account.ResultObject.ToString());

            }
        }
    }
}
