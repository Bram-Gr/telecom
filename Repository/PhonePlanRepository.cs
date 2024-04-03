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
    public class PhonePlanRepository : RepositoryBase<PhonePlan>, IPhonePlanRepository
    {
        public PhonePlanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task<IEnumerable<PhonePlan>> GetAllPhonePlansAsync(Guid userId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<PhonePlan> GetPhonePlanAsync(Guid userId, Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }

}
