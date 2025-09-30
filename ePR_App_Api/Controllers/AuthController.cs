using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using ePR_App_Api.Data;
using ePR_App_Api.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ePR_App_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [JwtAuthorize]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;
        private AppDbContext dbContext;
        private readonly IConfiguration _configuration;
        public AuthController(AppDbContext context,TokenService tokenService,IConfiguration configuration)
        {
            dbContext = context;
            _tokenService = tokenService;
            _configuration = configuration;
        }
        [AllowAnonymous]
        [HttpGet("GetLogin")]
        public async Task<IActionResult> GetLogin(string email, string password,string? deviceid)
        {
            try
            {
                var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email || u.UserId==email);
                if (user == null)
                {
                    return Unauthorized(new { success = false, message = "Invalid credentials" });
                }
                else
                {
                    var token = _tokenService.GenerateToken(email);
                    //upodate user table
                    user.DeviceID = deviceid;
                    await dbContext.SaveChangesAsync();
                    //
                    return Ok(new { success = true, token, user });
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Internal Server Error",
                    details = ex.Message
                });
            }
            
        }
        // ---------------- Active Directory Login ----------------
        [AllowAnonymous]
        [HttpGet("LoginAD")]
        public async Task<IActionResult> LoginAD(string login, string password,string? deviceid, [FromServices] AdService adService)
        {
            try
            {
                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                    return BadRequest(new { success = false, message = "Username/Email and password are required" });

                if (!adService.ValidateUser(login, password, out var result))
                    return Unauthorized(new { success = false, message = "Invalid username/email or password" });

                // Generate JWT token using sAMAccountName as unique identity
                var username = result.Properties["sAMAccountName"]?[0]?.ToString();

                var token = _tokenService.GenerateToken(username ?? login);
                //upodate user table
                var user =await dbContext.Users.Where(x => x.UserId == login || x.Email == login).FirstOrDefaultAsync();
                if (user != null)
                {
                    user.DeviceID = deviceid;
                    await dbContext.SaveChangesAsync();
                }
                //
                return Ok(new
                {
                    success = true,
                    token,
                    user = new
                    {
                        Username = username,
                        DisplayName = result.Properties["displayName"]?[0]?.ToString(),
                        Email = result.Properties["mail"]?[0]?.ToString()
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = "Internal Server Error", details = ex.Message });
            }
        }


    }
}
