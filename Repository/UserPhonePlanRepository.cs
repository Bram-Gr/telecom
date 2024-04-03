using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserPhonePlanRepository : RepositoryBase<UserPhonePlan>, IUserPhonePlanRepository
    {
        public UserPhonePlanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task<IEnumerable<UserPhonePlan>> GetAllUserPhonePlansAsync(Guid userId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<UserPhonePlan> GetUserPhonePlanAsync(Guid userId, Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
