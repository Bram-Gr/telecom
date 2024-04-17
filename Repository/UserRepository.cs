using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;
using Shared.DataTransferObjects;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateUser(User user) => Create(user);

        public Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(Guid id, bool trackChanges)=>
                    await FindByCondition(u => u.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<UserDto> GetUserByNameandPass(UserDto user, bool trackChanges) =>
         /*   await FindByCondition(u => u.Username.Equals(user.Username)
               && u.Password.Equals(user.Password), trackChanges).SingleOrDefaultAsync();*/
         await FindByCondition(u => u.Username.Equals(user.Username)
                       && u.Password.Equals(user.Password) 
                  || u.Email.Equals(user.Email) && u.Password.Equals(user.Password), 
                    trackChanges).Select(u => new UserDto
                       {
                   Id = u.Id,
                   Username = u.Username,
                   Password = u.Password,
                   Email = u.Email
               }).SingleOrDefaultAsync();
    }
  
}
