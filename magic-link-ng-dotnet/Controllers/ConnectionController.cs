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

        private string composeURL(string path, bool isDebugEnv, string rootURL) 
        {
            if (isDebugEnv) 
            {
                return $"http://{rootURL}/{path}";
            } 
            else 
            {
                return $"https://{rootURL}/be/{path}";
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] ConnectionRequest connectionRequest)
        {
            var loginData = JsonConvert.SerializeObject(new
            {
                AccountName = connectionRequest.accountName,
                Password = connectionRequest.password,
                AppId = "M4",
                subscriptionkey = connectionRequest.subscriptionKey
            });

            try
            {
                var response = await httpClient.PostAsync(
                    composeURL("account-manager/login", connectionRequest.isDebugEnv, connectionRequest.rootURL), 
                    new StringContent(loginData, System.Text.Encoding.UTF8, "application/json")
                );
                if (!response.IsSuccessStatusCode)
                {
                    return new ContentResult {
                        StatusCode = (int)response.StatusCode,
                        Content = $"Error on login: {response.ReasonPhrase}"
                    };
                }

                string result = response.Content.ReadAsStringAsync().Result;
                if (string.IsNullOrEmpty(result))
                {
                    return new ContentResult {
                        StatusCode = 500,
                        Content = "Invalid login"
                    };
                }

                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(result);
                return loginResponse;
            }
            catch (System.Exception e)
            {
                return new ContentResult {
                    StatusCode = 500,
                    Content = e.Message
                };
            }
        }

        [HttpPost("logout")]
        public async Task<ActionResult<bool>> Logout([FromBody] LogoutRequest request)
        {
            var authorizationData = JsonConvert.SerializeObject(new
            {
                Type = "JWT",
                SecurityValue = request.JwtToken
            });
            try
            {
                HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Post, composeURL("account-manager/logoff", request.isDebugEnv, request.rootURL));
                msg.Headers.TryAddWithoutValidation("Authorization", authorizationData);
                msg.Headers.TryAddWithoutValidation("Content-Type", "application/json");
                var response = await httpClient.SendAsync(msg);

                if (!response.IsSuccessStatusCode)
                {
                    return new ContentResult {
                        StatusCode = (int)response.StatusCode,
                        Content = $"Error on logout: {response.ReasonPhrase}"
                    };
                }

                return true;
            }
            catch (System.Exception e)
            {
                return new ContentResult {
                    StatusCode = 500,
                    Content = e.Message
                };
            }
        }
    }
}