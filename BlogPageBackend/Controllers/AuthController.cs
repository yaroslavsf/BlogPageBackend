using BlogPageBackend.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPageBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost("register")]
        public IActionResult Register() //RegistrationModel model
        {
            /* User user = _authService.Register(model, "Usual");

             var claims = _authService.CreateClaims(user);
             string encodedJwt = _authService.CreateJwt(claims, _configuration["SigningKey"]);

             return Ok(new { Token = encodedJwt });*/
            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login() //LoginModel model
        {
            /*var user = _authService.Authenticate(model);
            if (user is null)
            {
                return Unauthorized();
            }

            var claims = _authService.CreateClaims(user);
            string encodedJwt = _authService.CreateJwt(claims, _configuration["SigningKey"]);

            return Ok(new { Token = encodedJwt });*/
            return Ok();
        }
    }
}
