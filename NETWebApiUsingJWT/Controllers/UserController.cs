using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NETWebApiUsingJWT.Model;
using NETWebApiUsingJWT.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NETWebApiUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public UserController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserBE userBE)
        {
            var user = await UserServices.UserAuthentication(userBE);
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("UserID", user.UserName.ToString())
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    configuration["Jwt:Issuer"],
                    configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(120),
                    signingCredentials: signIn
                    );
                var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { Token = tokenValue, User = user });
            }
            else
            {
                return BadRequest(new { Message = "Userid or Password Incorrect"});
            }

        }

        [Authorize]
        [HttpGet]
        [Route("GetUserBook")]
        public IActionResult GetUserBook(int UserId)
        {
            var user = UserServices.GetBoookList(UserId);

            return Ok(user);
        }
    }
}
