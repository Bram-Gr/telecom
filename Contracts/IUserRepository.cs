using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.DataTransferObjects;

namespace Contracts
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
        Task<User> GetUserByIdAsync(Guid id, bool trackChanges);
        Task<UserDto> GetUserByNameandPass(UserDto user, bool trackChanges);
    }
}
