using Shared.DataTransferObjects;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace SkillstormTelecom.Presentation.Controllers
{
    [Route("api/user/{UserId:guid}/device")]
    /*   [Route("api/[controller]")]*/
    [ApiController]
    public class DeviceController: ControllerBase
    {
        private readonly IServiceManager _service;
        public DeviceController(IServiceManager userService) =>
            _service = userService;

        /*   [HttpGet("{UserID:guid}")]*/
        [HttpGet]
        public async Task<IActionResult> GetDevicesByUserId(Guid userId)
        {
            Console.WriteLine(userId);
            var devices = await _service.Device.GetDevicesByUserIdAsync(userId, trackChanges: false);
            Console.WriteLine(userId);
            return Ok(devices);
        }

    }
}
