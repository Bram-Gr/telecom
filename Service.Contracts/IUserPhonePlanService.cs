using Entities;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserPhonePlanService
    {
        /* IEnumerable<PhonePlan> GetPhonePlans(Guid userId, bool trackChanges);*/
        Task<UserPhonePlanDto> AddPlanAsync(UserPhonePlanDto plan, Guid userId);
        Task DeletePlanAsync(Guid planId, Guid userId);
    }
}
