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
        public readonly dbContextDVLD _db;

        private readonly IAuthService _authService;

        public UserController(IUserRepository userRepository, dbContextDVLD db, IAuthService authService)
        {
            _userRepository = userRepository;
            _db = db;
            _authService = authService;
        }










        [HttpGet("{id}")]
        [Authorize(Policy = Auth.UserPolicy)]
        public async Task<ActionResult<UserReadDto?>> Get(int id)
        {
            UserReadDto? user = await _userRepository.ReadUser(id);

            if (user == null)
            {
                return NotFound($"User with id = [{id}] is Not Found");
            }

            return Ok(user);
        }
















        [HttpPost("login")]
        public async Task<ActionResult<UserReadDto?>> Login([FromBody] UserLoginDto userLogin)
        {
            UserReadDto? userRead = await _userRepository.ReadUserAsync(userLogin.UserName, userLogin.Password);

            if (userRead == null)
            {
                return BadRequest("Failed To Login");
            }

            await HttpContext.SignInAsync(Auth.UserCookie, _authService.CreateUserClaimsPrincipal(userRead, Auth.UserCookie));
            return Ok(userRead);

        }






        [HttpGet("logout")]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Ok();
        }











        // Tests

        [HttpGet]// For test
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return _db.Users.ToList();

        }




    }
}
