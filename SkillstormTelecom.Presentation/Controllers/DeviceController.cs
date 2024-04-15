using Entities;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects;

namespace SkillstormTelecom.Presentation.Controllers
{
    [Route("api/[controller]/{deviceId:guid}")]
    [ApiController]
    public class DeviceController: ControllerBase
    {
        private readonly IServiceManager _service;
        public DeviceController(IServiceManager userService) =>
            _service = userService;

        [HttpDelete]
        public async Task<IActionResult> DeleteDevice(Guid deviceId)
        {
            Console.WriteLine(deviceId);
            await _service.Device.DeleteDeviceAsync(deviceId, trackChanges: false);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDevice(Guid deviceId,[FromBody] DeviceForUpdateDto device)
        {
            if (device == null)
                return BadRequest("Device object is null");

            await _service.Device.UpdateDeviceAsync(deviceId, device, trackChanges: true);
            return NoContent();
        }
    }
}
