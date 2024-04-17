using Shared.DataTransferObjects;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace SkillstormTelecom.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;
        public UserController(IServiceManager userService) =>
            _service = userService;


        [HttpGet("{userId:guid}/bills")]
        public async Task<IActionResult> GetBills(Guid userId)
        {
            var bills = await _service.PhonePlan.GetTotalPriceOfPhonePlansByUserIdAsync(userId, trackChanges: false);
            return Ok(bills);
        }

        [HttpGet("{userId:guid}/device")]
        public async Task<IActionResult> GetDevicesByUserId(Guid userId)
        {
            var devices = await _service.Device.GetDevicesByUserIdAsync(userId, trackChanges: false);
            return Ok(devices);
        }

        [HttpGet("{userId:guid}/phoneplan")]
        public async Task<IActionResult> GetPhonePlans(Guid userId)
        {
            var phonePlans = await _service.PhonePlan.GetPhonePlansByUserIdAsync(userId, trackChanges: false);
            return Ok(phonePlans);
        }


        [HttpPost(Name = "CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto user)
        {
            if (user == null)
                return BadRequest("User object is null");

            var createdUser = await _service.User.CreateUserAsync(user);
            return CreatedAtRoute("CreateUser", new { Id = createdUser.Id }, createdUser);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody]UserDto user)
        {
            if (user == null)
                return BadRequest("User object is null");

            var userToLogin = await _service.User.getUserByUsernameAndPassword(user, trackChanges: false);
            return Ok(userToLogin);
        }

    }
}
