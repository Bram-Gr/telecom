using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillstormTelecom.Presentation.Controllers

{ 

    [Route("api/[controller]")]
    [ApiController]
    public class PhonePlanController: ControllerBase
    {
        private readonly IServiceManager _service;
        public PhonePlanController(IServiceManager userService) =>
            _service = userService;

        [HttpGet]
        public async Task<IActionResult> GetPhonePlans()
        {
            var phonePlans = await _service.PhonePlan.GetPhonePlansAsync(trackChanges: false);
            return Ok(phonePlans);
        }


        [HttpPost("{PlanId:guid}/device")]
        public async Task<IActionResult> AddDeviceByPlan([FromBody] DeviceForCreationDto device, Guid PlanId)
        {
            if (device == null)
                return BadRequest("Device object is null");

            var createdDevice = await _service.Device.addDeviceByPlanAsync(device, PlanId);
            return CreatedAtRoute( new { id = createdDevice.Id }, createdDevice);
        }

        [HttpPost("{planId:guid}/user/{userId:guid}", Name = "planByUserId")]
        public async Task<IActionResult> AddPlanByUser(Guid userId, Guid planId)
        {
            if (planId == null)
                return BadRequest("Plan object is null");

            await _service.UserPhonePlan.AddPlanAsync(planId, userId);
            return Created();
        }

        [HttpDelete("{planId:guid}/user/{userId:guid}")]
        public async Task<IActionResult> DeletePlanByUser(Guid userId, Guid planId)
        {

            Console.WriteLine(planId);
            if (planId == null)
                return BadRequest("Plan object is null");

            await _service.UserPhonePlan.DeletePlanAsync(planId, userId);
            return NoContent();
        }
    }
}
