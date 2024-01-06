using DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples;
using DVLD.WebAPI.AuthService;
using DVLD.WebAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IDriverRepository _driverRepository;

        public DriverController(IAuthService authService,IDriverRepository driverRepository)
        {
            _authService = authService;
            _driverRepository = driverRepository;
        }

        [HttpPost("login")]
        public async Task<ActionResult<DriverReadDto>> Login([FromBody] DriverLoginDto loginDriver)
        {
            DriverReadDto? driverRead = await _driverRepository.ReadDriverAsync(loginDriver.Email,loginDriver.Password);

            if(driverRead is null)
            {
                return NotFound("Failed To Login");
            }

            await HttpContext.SignInAsync(Auth.DriverCookie,_authService.CreateDriverClaimsPrincipal(driverRead,Auth.DriverCookie));
            return Ok(driverRead);
        }
        
        [HttpGet("logout")]
        public async Task<string> Logout()
        {
            await HttpContext.SignOutAsync(Auth.DriverCookie);
            return "Driver Logout";
        }
    }
}
