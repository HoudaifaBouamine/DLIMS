using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVLD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User?>> GetUser(int id)
        {
            User? user = await _userRepository.ReadUser(id);

            if(user == null)
            {
                return NotFound($"User with id = [{ id }] is Not Found");
            }

            return Ok( user );
        }


        [HttpGet("hi/{id}")]
        public async Task<ActionResult<User?>> GetUserDto(int id)
        {
            User? user = await _userRepository.ReadUserDto(id);

            if (user == null)
            {
                return NotFound($"User with id = [{id}] is Not Found");
            }

            return Ok(user);
        }

    }
}
