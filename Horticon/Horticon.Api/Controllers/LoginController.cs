using Core.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] AuthenticateUserCommand command)
        {
            if (command.Username == "smael" && command.Password == "1234")
            {
                var claims = new[]
                {
                    new Claim("userId", "1"), // Aqui é adicionado o id do usuário
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Authentication:SecretKey"]));
                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                (
                    claims: claims,
                    signingCredentials: credential,
                    expires: DateTime.Now.AddMinutes(300),
                    issuer: _config["Authentication:Issuer"],
                    audience: _config["Authentication:Audience"]
                );

                var jwtToken = new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                };

                return Ok(jwtToken);
            }
            else
                return Unauthorized();
        }
    }
}