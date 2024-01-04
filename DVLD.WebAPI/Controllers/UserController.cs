using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.DataAccess.Repositories.Interfaces;
using DVLD.WebAPI.AuthService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DVLD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public dbContextDVLD _db { get; set; }
        public UserController(IUserRepository userRepository,dbContextDVLD db) 
        {
            _userRepository = userRepository;
            _db = db;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserReadDto?>> GetUser(int id)
        {
            UserReadDto? user = await _userRepository.ReadUser(id);

            if(user == null)
            {
                return NotFound($"User with id = [{ id }] is Not Found");
            }

            return Ok( user );
        }


        [HttpPost("/api/login")]
        public async Task<ActionResult<UserReadDto?>> LoginUser([FromBody] UserLoginDto userLogin)
        {
            HttpContext ctx = HttpContext;
            UserReadDto? userRead = await _userRepository.ReadUserAsync(userLogin.UserName,userLogin.Password);

            if(userRead == null)
            {
                return BadRequest("Failed To Login");
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim("FirstName" ,userRead.Person.FirstName),
                new Claim("LastName"  ,userRead.Person.LastName),
                new Claim("Email"     ,userRead.Person.Email),
                new Claim("UserName"  ,userRead.UserName),
                new Claim("Permission",userRead.Permission.ToString())
            };
            ClaimsIdentity claimsIdentity = new(claims,Policies.AuthSheme);
            ClaimsPrincipal claimsPrincipal = new(claimsIdentity);

            await ctx.SignInAsync(Policies.AuthSheme, claimsPrincipal);
            return Ok( userRead );

        }

        [Authorize(Policy = "AuthRequirmentTest")]
        [HttpGet("/api/test")]
        public async Task<ActionResult<string>> Test()
        {
            return "your email is john.doe@example.com";
        }





        // Tests

        [HttpGet]// For test
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return _db.Users.ToList();

        }


    }
}
