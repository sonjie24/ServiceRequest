//using System;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading.Tasks;
//using Newtonsoft.Json;

//namespace AccountManagement.Framework.Core
//{ 
//    public class RegisterOTPService  : IMessage<string>
//    {
//        public async Task<bool> send(string param, string token)
//        {
//            using (var client = new HttpClient())
//            {
//                var otp = new OPTModel
//                {
//                    mobilenumber = param
//                };
//                client.BaseAddress = new Uri("https://pf-other-service.azurewebsites.net/");
//                client.DefaultRequestHeaders.Clear();
//                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
//                string json = JsonConvert.SerializeObject(otp);
//                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
//                var Res = await client.PostAsync($"api/v1/sendOTP/{otp.mobilenumber}", httpContent);
//                if (!Res.IsSuccessStatusCode) return false;
//                var Response = Res.Content.ReadAsStringAsync().Result;
//                return !string.IsNullOrWhiteSpace(Response);
//            }
//        }
//    }
//}
