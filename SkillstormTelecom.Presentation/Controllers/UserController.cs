using Shared.DataTransferObjects;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace SkillstormTelecom.Presentation.Controllers
{
    [Route("api/user/{UserId:guid}")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IServiceManager _service;
        public UserController(IServiceManager userService) =>
            _service = userService;

       
        [HttpGet("device")]
        public async Task<IActionResult> GetDevicesByUserId(Guid userId)
        {
            var devices = await _service.Device.GetDevicesByUserIdAsync(userId, trackChanges: false);    
            return Ok(devices);
        }

        [HttpGet("phoneplan")]
        public async Task<IActionResult> GetPhonePlans(Guid userId)
        {
            var phonePlans = await _service.PhonePlan.GetPhonePlansByUserIdAsync(userId, trackChanges: false);
            Console.WriteLine("Hello");
            Console.WriteLine(phonePlans);
            return Ok(phonePlans);
        }
    }
}
