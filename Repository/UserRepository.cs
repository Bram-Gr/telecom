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
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(Guid id, bool trackChanges)=>
                    await FindByCondition(u => u.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
    }
  
}
