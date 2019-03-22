using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationApp_API.Data;
using ReservationApp_API.Dtos;
using ReservationApp_API.Models;

namespace ReservationApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository repo;
        public AuthController(IAuthRepository repo)
        {
            this.repo = repo;

        }


        // TODO consider sending info about role and default access and not to hardcode it into controller.
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var userRoleID = 3;             // Id for user role, which is default for registration via web interface.
            var defaultAccess = true;       // True if created user should have assecc to system. False otherwise.


            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();
            if (await repo.UserExists(userForRegisterDto.Username))
                return BadRequest("Username already exist");

            var userToCreate = new User
            {
                Username = userForRegisterDto.Username,
                RoleId = userRoleID,
                IsEnabled = defaultAccess
            };
            var createdUser = await this.repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}