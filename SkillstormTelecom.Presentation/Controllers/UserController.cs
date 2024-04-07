using Shared.DataTransferObjects;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace SkillstormTelecom.Presentation.Controllers
{
    [Route("api/user/{UserId:guid}/device")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IServiceManager _service;
        public UserController(IServiceManager userService) =>
            _service = userService;

        /*   [HttpGet("{UserID:guid}")]*/
        [HttpGet]
        public async Task<IActionResult> GetDevicesByUserId(Guid userId)
        {
            var devices = await _service.Device.GetDevicesByUserIdAsync(userId, trackChanges: false);    
            return Ok(devices);
        }


    }
}
