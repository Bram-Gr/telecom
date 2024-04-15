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

        public async Task AddPlanAsync(Guid planId, Guid userId)
        {

           
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, true);
            var phonePlan = await _repositoryManager.PhonePlan.GetPhonePlanByIdAsync(planId, true);
            if (phonePlan == null)
            {
                throw new PhonePlanNotFoundException(planId);
            }
            user.PhonePlans.Add(phonePlan);

            await _repositoryManager.SaveAsync();

          
        }

       public async Task DeletePlanAsync(Guid planId, Guid userId)
        {
            var phonePlan = await _repositoryManager.PhonePlan.GetPhonePlanByIdAsync(planId, true);
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, true);

            if (phonePlan == null || user == null)
            {
                throw new UserPhonePlanNotFoundException(planId, userId);
            }

            var userPhonePlan = await _repositoryManager.UserPhonePlan.GetUserPhonePlanAsync(userId, planId); 
            if (userPhonePlan != null)
            {
                _repositoryManager.UserPhonePlan.DeleteUserPhonePlan(userPhonePlan);
                await _repositoryManager.SaveAsync();
            }
            else
            {
                throw new UserPhonePlanNotFoundException(planId, userId);
            }
        }

    }
}
