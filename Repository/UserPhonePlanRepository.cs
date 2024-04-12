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

        public void CreateUserPhonePlan(UserPhonePlan userPhonePlan)=> Create(userPhonePlan);
        public void DeleteUserPhonePlan(UserPhonePlan userPhonePlan)=> Delete(userPhonePlan);


        public IEnumerable<UserPhonePlan> GetPhonePlansByUser(Guid userId, bool trackChanges)
        {
            var phonePlanIds = FindByCondition(p => p.UserId.Equals(userId), trackChanges).ToList();
            return phonePlanIds;
        }

        public Task GetUserPhonePlan(Guid userId, Guid phonePlanId)
        {
            throw new NotImplementedException();
        }

        public Task<UserPhonePlan> GetUserPhonePlanAsync(Guid userId, Guid planId)
        {
            var userPhonePlan = FindByCondition(p => p.UserId.Equals(userId) && p.PhonePlanId
               .Equals(planId), false)
                .SingleOrDefaultAsync();
            return userPhonePlan;
        }
    }
}
