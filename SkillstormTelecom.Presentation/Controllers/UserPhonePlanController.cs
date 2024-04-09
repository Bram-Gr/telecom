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
    [Route("api/userphoneplan/{UserId:guid}")]
    [ApiController]
    public class UserPhonePlanController: ControllerBase
    {
        private readonly IServiceManager _service;
        public UserPhonePlanController(IServiceManager userPhonePlanService) =>
            _service = userPhonePlanService;

        [HttpPost(Name="planByUserId")]
        public async Task<IActionResult> AddPlanByUser([FromBody] UserPhonePlanDto plan, Guid userId)
        {
            if (plan == null)
                return BadRequest("Plan object is null");

            var addedPlan = await _service.UserPhonePlan.AddPlanAsync(plan, userId);
            return CreatedAtRoute("planByUserId",addedPlan);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePlanByUser([FromBody] UserPhonePlanDto plan, Guid userId)
        {
            if (plan == null)
                return BadRequest("Plan object is null");

            await _service.UserPhonePlan.DeletePlanAsync(plan, userId);
            return NoContent();
        }
    }
}
