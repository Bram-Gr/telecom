using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IDeviceRepository> _deviceRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IUserPhonePlanRepository> _userPhonePlanRepository;
        private readonly Lazy<IPhonePlanRepository> _phonePlanRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _deviceRepository = new Lazy<IDeviceRepository>(() => new DeviceRepository(_repositoryContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_repositoryContext));
            _userPhonePlanRepository = new Lazy<IUserPhonePlanRepository>(() => new UserPhonePlanRepository(_repositoryContext));
            _phonePlanRepository = new Lazy<IPhonePlanRepository>(() => new PhonePlanRepository(_repositoryContext));
        }   

        public IDeviceRepository Device => _deviceRepository.Value;
        public IUserRepository User => _userRepository.Value;
        public IUserPhonePlanRepository UserPhonePlan => _userPhonePlanRepository.Value;
        public IPhonePlanRepository PhonePlan => _phonePlanRepository.Value;
        public async Task SaveAsync () => await _repositoryContext.SaveChangesAsync();

    }
}
