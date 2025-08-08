using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AccountManagement.MicroService.Controllers
{
    [ApiExplorerSettings(GroupName = "Dragon Pay")]
    [Produces("application/json")]
    public class DragonPayController : ControllerBase
    {
        public DragonPayController()
        {
        }

        [AllowAnonymous]
        [HttpPost("/api/v1/pay")]
        public async Task<IActionResult> Create()
        {
            return Ok("Under development");


            //var client = new HttpClient();

            //var param = new DpParams
            //{
            //    Amount = 1,
            //    Currency = "PHP",
            //    Description = "Test",
            //    Email = "jhoncee2014@gmail.com",
            //    ProcId = "MBTC"
            //};

            //var url = "https://test.dragonpay.ph/api/collect/v1";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //var credentials = System.Text.Encoding.UTF8.GetBytes("REDDSTAR" + ":" +
            //"naD7itZiQVrpTJX");

            //string token = System.Convert.ToBase64String(credentials);
            ////request.Headers.Add("Content-Type", "application/json");
            ////request.Headers.Add("Authorization", "Basic " + token);


            /////
            //client.BaseAddress = new Uri(url);
            //client.DefaultRequestHeaders.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
            //string json = JsonConvert.SerializeObject(param);
            //StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            //var Res = await client.PostAsync($"", httpContent);
            //var Response = Res.Content.ReadAsStringAsync().Result;

            //return Ok(new {
            //    Token=token,
            //    Response= Response,
            //    Request=request
            //});

        }
        public class DpParams
        {
            public decimal Amount { get; set; }
            public string Currency { get; set; }
            public string Description { get; set; }
            public string Email { get; set; }
            public string ProcId { get; set; }
        }
    }
}
