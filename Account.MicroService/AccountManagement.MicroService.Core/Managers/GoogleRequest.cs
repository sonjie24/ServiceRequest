using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Core
{
    public  class GoogleRequest
    {
        private string Baseurl = "https://maps.googleapis.com/maps/";
        public async Task<bool> send(string location)
        {
            //List<Employee> EmpInfo = new List<Employee>();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", param.Header);
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                //string json = JsonConvert.SerializeObject(param);
                //StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                string link = $"api/place/queryautocomplete/json?key=AIzaSyDLxFeAuFYUbnCKSBduPOYbn7eEvwrLo30&input={location}&types=geocode'";
                HttpResponseMessage Res = await client.GetAsync(link);
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    return !string.IsNullOrWhiteSpace(EmpResponse);
                    //Deserializing the response recieved from web api and storing into the Employee list
                    //EmpInfo = JsonConvert.DeserializeObject<Mail>(param);
                }
                return false;
                //returning the employee list to view
                //return View(EmpInfo);
            }
        }

        //public function getLocations($location)
        //{
        //$http = new Client;
        //$response = $http->request('POST', ');
        //$result = json_decode((string) $response->getBody(), true);
        //    return response()->json($result, $this->successStatus);
        //}

    }
}
