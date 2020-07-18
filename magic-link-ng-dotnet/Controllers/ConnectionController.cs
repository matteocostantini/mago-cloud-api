using System.Net.Http;
using System.Threading.Tasks;
using magic_link_ng_dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace magic_link_ng_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionController : ControllerBase
    {
        private HttpClient httpClient = new HttpClient();
        private string rootURL;
        private bool isDebugEnv;

        private string composeURL(string path) 
        {
            if (this.isDebugEnv) 
            {
                return $"http://{this.rootURL}/{path}";
            } 
            else 
            {
                return $"https://{this.rootURL}/be/{path}";
            }
        }


        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] ConnectionRequest connectionRequest)
        {
            rootURL = connectionRequest.rootURL;
            isDebugEnv = connectionRequest.isDebugEnv;

            var loginData = JsonConvert.SerializeObject(new
            {
                AccountName = connectionRequest.accountName,
                Password = connectionRequest.password,
                AppId = "M4",
                subscriptionkey = connectionRequest.subscriptionKey
            });

            var response = await httpClient.PostAsync(composeURL("account-manager/login"), new StringContent(loginData, System.Text.Encoding.UTF8, "application/json"));
            string result = response.Content.ReadAsStringAsync().Result;
            JObject jResult = JsonConvert.DeserializeObject<JObject>(result);
            return new LoginResponse {
                JwtToken = jResult["JwtToken"]?.ToString()
            };
        }

        [HttpGet("hello")]
        public ActionResult<string> Hello()
        {
            return "hello";
        }
    }
}