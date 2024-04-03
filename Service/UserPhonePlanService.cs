using AutoMapper;
using Contracts;
using Service.Contracts;
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

        public UserPhonePlanService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
    }
}
