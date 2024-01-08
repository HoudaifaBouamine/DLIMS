using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.WebAPI.AuthService;
using DVLD.WebAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController(IAuthService authService, IDriverRepository driverRepository) : ControllerBase
    {
        private readonly IAuthService _authService = authService;
        private readonly IDriverRepository _driverRepository = driverRepository;

        [HttpPost("login")]
        public async Task<ActionResult<DriverReadDto>> Login([FromBody] DriverLoginDto loginDriver)
        {
            DriverReadDto? driverRead = await _driverRepository.LoginDriverAsync(loginDriver.Email, loginDriver.Password);

            if (driverRead is null)
            {
                return NotFound("Failed To Login");
            }

            await HttpContext.SignInAsync
                    (
                        Auth.Scheme.DriverCookie,
                        _authService.CreateDriverClaimsPrincipal(driverRead, Auth.Scheme.DriverCookie)
                    );

            return Ok(driverRead);
        }

        [HttpPost("register")]
        public async Task<ActionResult<DriverReadDto>> Register([FromBody] DriverCreateDto driverCreate)
        {
            Driver driver = Driver.FromDto(driverCreate);
            DriverReadDto? driverRead = await _driverRepository.CreateDriverAsync(driver);
            
            if(driverRead is null)
            {
                return BadRequest("Failed To register");
            }

            return Ok(driverRead);
        }
        
        [HttpGet("logout")]
        public async Task<string> Logout()
        {
            await HttpContext.SignOutAsync(Auth.Scheme.DriverCookie);
            return "Driver Logout";
        }

        [HttpPut]
        [Authorize(Policy =Auth.Policy.UserPolicy)]
        public async Task Update()
        {

        }
    
    }
}
