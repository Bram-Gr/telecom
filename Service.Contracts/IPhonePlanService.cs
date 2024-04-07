using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IPhonePlanService
    {
        Task<PhonePlan> GetPhonePlanByIdAsync(Guid phonePlanId);
        Task<IEnumerable<PhonePlan>> GetPhonePlansAsync(bool trackChanges);
    }
}
