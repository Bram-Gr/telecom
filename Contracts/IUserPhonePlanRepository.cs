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
        void CreateUserPhonePlan(UserPhonePlan userPhonePlan);
        void DeleteUserPhonePlan(UserPhonePlan userPhonePlan);
        IEnumerable<UserPhonePlan> GetPhonePlansByUser(Guid userId, bool trackChanges);
    }
}
