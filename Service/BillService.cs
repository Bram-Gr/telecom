using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    public class BillService : IBillService
    {
        private IRepositoryManager _repositoryManager;
        private IMapper _mapper;
        private readonly ILoggerManager _logger;

        public BillService(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
    }
}
