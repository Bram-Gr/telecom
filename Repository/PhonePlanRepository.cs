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

        public async Task<IEnumerable<PhonePlan>> GetAllPhonePlans(bool trackChanges)=>
                    await FindAll(trackChanges).OrderBy(p => p.PlanName).ToListAsync();

 

        public Task<PhonePlan> GetPhonePlanByIdAsync(Guid id, bool trackChanges)=> 
            FindByCondition(p => p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<PhonePlan>> GetPhonePlansByIdsAsync(IEnumerable<Guid> phonePlanIds, bool trackChanges)
        {
            return await FindByCondition(p => p.Id.Equals(phonePlanIds), trackChanges).ToListAsync();
        }

        public async Task<IEnumerable<PhonePlan>> GetPhonePlansByUserIdAsync(Guid userId, bool trackChanges)
        {
          /*  return FindByCondition(p => p.Users.Any(up => up.Id.Equals(userId)), trackChanges)
                .OrderBy(p => p.PlanName).ToListAsync();*/
          return await FindByCondition(p => p.Users.Any(up => up.Id.Equals(userId)), trackChanges)
                .OrderBy(p => p.PlanName).ToListAsync();
        }
    }

}
