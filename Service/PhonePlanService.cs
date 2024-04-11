using AutoMapper;
using Contracts;
using Entities;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PhonePlanService : IPhonePlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public PhonePlanService(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }

       

        public async Task<PhonePlan> GetPhonePlanByIdAsync(Guid phonePlanId) => 
            await _repositoryManager.PhonePlan.GetPhonePlanByIdAsync(phonePlanId, false);

        public async Task<IEnumerable<PhonePlan>> GetPhonePlansAsync(bool trackChanges)
        {
            var phonePlans = await _repositoryManager.PhonePlan.GetAllPhonePlans(trackChanges);
            var phonePlansToReturn = _mapper.Map<IEnumerable<PhonePlan>>(phonePlans);
            return phonePlansToReturn;
        }

        public async Task<IEnumerable<PhonePlan>> GetPhonePlansByUserIdAsync(Guid userId, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, false);

            var phonePlans = user.PhonePlans;

            return phonePlans;
        }



    }
}
