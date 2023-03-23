using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QuickQuestion.Domain.Model;
using QuickQuestion.Domain.Services;
using QuickQuestion.Model;
using QuickQuestion.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QuickQuestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUser _user;
        private readonly string passKey;
        private readonly string tokenKey;

        public AuthController(IConfiguration configuration, IUser user)
        {
            _configuration = configuration;
            _user = user;
            passKey = configuration.GetSection("Encrypt:PassKey").Value;
            tokenKey = configuration.GetSection("Encrypt:Token").Value;
        }

        [HttpGet]
        [Route("role")]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            var roles = await _user.getRoles();
            return Ok(roles);
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(UserDto userDto)
        {
            var user = await _user.getUser(userDto.Username);

            if (user == null)
            {
                return NotFound("Not Found.");
            }

            var passEncrypt = StringCipher.Encrypt(userDto.Password, passKey);         

            if (user.password != passEncrypt)
            {
                return NotFound("Password incorrect.");
            }

            string token = StringCipher.CreateToken(user, tokenKey);

            return Ok(new { user, token });
        }

    }
}
