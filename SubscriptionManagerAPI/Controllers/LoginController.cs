using Microsoft.AspNetCore.Mvc;
using SubscriptionManagerAPI.Models;


namespace SubscriptionManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] LoginModel login)
        {
            if (login.Username == "admin" && login.Password == "password")
            {
                var token = "fake-jwt-token";
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }
    }
}
