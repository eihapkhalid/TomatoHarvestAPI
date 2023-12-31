﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using TomatoHarvestAPI.DataAccess.Repository.IRepository;
using TomatoHarvestAPI.Models;
using Microsoft.Extensions.Configuration; // استيراد المكتبة اللازمة


namespace TomatoHarvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        #region Jwt Configuration
        IConfiguration configuration;
        #endregion

        #region Dependency Injection
        private readonly IUnitOfWork _unitOfWork;
        public LoginController(IUnitOfWork unitOfWork, IConfiguration iconfig)
        {
            _unitOfWork = unitOfWork;
            configuration = iconfig;
        }
        #endregion

        #region Login function
        // POST https://localhost:7255/api/login
        [HttpPost("Login")]
        // [Route("Login")] dont write this !
        [AllowAnonymous]
        public IActionResult Login([FromBody] TbUser user)
        {
            var response = Unauthorized();
            var xuser = _unitOfWork.TbUser.AuthorizeUser(user.UserName, user.Password);
            if (xuser != null)
            {
                var newToken = GenerateToken(HttpContext.RequestServices.GetRequiredService<IConfiguration>(), user);
                return Ok(new { token = newToken });//new obj has key named token with value newToken 
            }
            return response;
        }
        #endregion

    #region GenerateToken Function:
        string GenerateToken(IConfiguration configuration, TbUser user)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(configuration["Jwt:Issuer"],
                    configuration["Jwt:Audience"],
                    null,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
    #endregion

}
}
