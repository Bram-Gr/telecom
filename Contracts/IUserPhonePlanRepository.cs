using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IUserPhonePlanRepository
    {
        Task<IEnumerable<UserPhonePlan>> GetAllUserPhonePlansAsync(Guid userId, bool trackChanges);
        Task<UserPhonePlan> GetUserPhonePlanAsync(Guid userId, Guid id, bool trackChanges);
    }
}
