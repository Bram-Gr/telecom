using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserService
    {
        Task<UserDto> CreateUserAsync(UserForCreationDto user);
        Task<UserDto> getUserByUsernameAndPassword(UserDto user, bool trackChanges);
    }
}
