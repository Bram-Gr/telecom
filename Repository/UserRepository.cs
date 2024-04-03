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

        public Task<User> GetUserAsync(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
  
}
