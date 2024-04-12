using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public UserService(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<UserDto> CreateUserAsync(UserForCreationDto user)
        {
            var userEntity = _mapper.Map<User>(user);
            _repositoryManager.User.CreateUser(userEntity);
            await _repositoryManager.SaveAsync();
            var userToReturn = _mapper.Map<UserDto>(userEntity);
            return userToReturn;
        }
    }
}
