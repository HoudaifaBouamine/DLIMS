using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            UserReadDto? userRead = await _userRepository.ReadUserAsync(userLogin.UserName,userLogin.Password);

            if(userRead == null)
            {
                return BadRequest("Failed To Login");
            }

            return Ok( userRead );
        }








        // Tests

        [HttpGet]// For test
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return _db.Users.ToList();

        }


    }
}
