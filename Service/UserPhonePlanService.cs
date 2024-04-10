using AutoMapper;
using Contracts;
using Entities;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserPhonePlanService : IUserPhonePlanService
    {
        private IRepositoryManager _repositoryManager;
        private IMapper _mapper;
        private readonly ILoggerManager _logger;

        public UserPhonePlanService(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<UserPhonePlanDto> AddPlanAsync(UserPhonePlanDto plan, Guid userId)
        {
            var userPhonePlan = _mapper.Map<UserPhonePlan>(plan);
            userPhonePlan.UserID = userId;
            _repositoryManager.UserPhonePlan.CreateUserPhonePlan(userPhonePlan);
            await _repositoryManager.SaveAsync();
            var userPhonePlanDto = _mapper.Map<UserPhonePlanDto>(userPhonePlan);
            return userPhonePlanDto;
        }

        public async Task DeletePlanAsync(Guid planId, Guid userId)
        {
          var phonePlan = await _repositoryManager.PhonePlan.GetPhonePlanByIdAsync(planId, false);
          var user = await _repositoryManager.User.GetUserByIdAsync(userId, false);
            if (phonePlan == null || user == null)
            {
                throw new NotFoundException($"Phone Plan with id{planId} or User with id:{userId}not found");
            }

          user.PhonePlan.Remove(phonePlan);
          
            await _repositoryManager.SaveAsync();

    
        }
    }
}
