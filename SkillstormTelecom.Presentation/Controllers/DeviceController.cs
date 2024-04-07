using Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillstormTelecom.Presentation.Controllers
{
    [Route("api/device/{deviceId:guid}")]
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
    }
}
