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
        private IRepositoryManager _repositoryManager;
        private IMapper _mapper;

        public PhonePlanService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<PhonePlan> GetPhonePlanByIdAsync(Guid phonePlanId) => 
            await _repositoryManager.PhonePlan.GetPhonePlanByIdAsync(phonePlanId, false);

        public async Task<IEnumerable<PhonePlan>> GetPhonePlansAsync(bool trackChanges)
        {
            var phonePlans = await _repositoryManager.PhonePlan.GetAllPhonePlans(trackChanges);
            var phonePlansDto = _mapper.Map<IEnumerable<PhonePlan>>(phonePlans);
            return phonePlansDto;
        }
    }
}
