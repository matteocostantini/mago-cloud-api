using magic_link_ng_dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace magic_link_ng_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionController : ControllerBase
    {
        [HttpPost("login")]
        public bool Login(LoginRequest info)
        {
            return true;
        }
    }
}