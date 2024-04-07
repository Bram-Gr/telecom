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
    }

}
