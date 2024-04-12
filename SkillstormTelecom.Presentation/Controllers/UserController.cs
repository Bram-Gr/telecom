using Shared.DataTransferObjects;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace SkillstormTelecom.Presentation.Controllers
{
    [Route("api/user/{userId:guid}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;
        public UserController(IServiceManager userService) =>
            _service = userService;


        [HttpGet("bills")]
        public async Task<IActionResult> GetBills(Guid userId)
        {
            var bills = await _service.PhonePlan.GetTotalPriceOfPhonePlansByUserIdAsync(userId, trackChanges: false);
            return Ok(bills);
        }

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
            return Ok(phonePlans);
        }


        [HttpPost("phoneplan/{planId:guid}", Name = "planByUserId")]
        public async Task<IActionResult> AddPlanByUser(Guid userId, Guid planId)
        {
            if (planId == null)
                return BadRequest("Plan object is null");

            await _service.UserPhonePlan.AddPlanAsync(planId, userId);
            return Created();
        }

        [HttpDelete("phoneplan/{planId:guid}")]
        public async Task<IActionResult> DeletePlanByUser(Guid userId,Guid planId)
        {
         
            Console.WriteLine(planId);
            if (planId == null)
                return BadRequest("Plan object is null");

            await _service.UserPhonePlan.DeletePlanAsync(planId, userId);
            return NoContent();
        }
    }
}
