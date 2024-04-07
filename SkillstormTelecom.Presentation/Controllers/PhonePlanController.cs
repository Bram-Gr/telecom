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

    [Route("api/phoneplan")]
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
            Console.WriteLine(PlanId);
            if (device == null)
                return BadRequest("Device object is null");

            var createdDevice = await _service.Device.addDeviceByPlanAsync(device, PlanId);
            return CreatedAtRoute("DeviceById", new { id = createdDevice.Id }, createdDevice);
        }
    }
}
