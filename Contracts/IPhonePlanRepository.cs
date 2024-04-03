using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IPhonePlanRepository
    {
        Task<IEnumerable<PhonePlan>> GetAllPhonePlansAsync(Guid userId, bool trackChanges);
        Task<PhonePlan> GetPhonePlanAsync(Guid userId, Guid id, bool trackChanges);
    }
}
