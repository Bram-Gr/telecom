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
        Task<IEnumerable<PhonePlan>> GetAllPhonePlans(bool trackChanges);
        Task<IEnumerable<PhonePlan>> GetPhonePlansByIdsAsync(IEnumerable<Guid> phonePlanIds, bool trackChanges);
        Task<PhonePlan> GetPhonePlanByIdAsync(Guid id, bool trackChanges);

  
    }
}
