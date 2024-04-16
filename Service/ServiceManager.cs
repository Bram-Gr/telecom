using Microsoft.EntityFrameworkCore.Metadata;
using Service.Contracts;
using Contracts;
using AutoMapper;
using Entities.ConfigurationModels;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
      private readonly Lazy<IUserService> _userService;
      private readonly Lazy<IDeviceService> _deviceService;
      private readonly Lazy<IPhonePlanService> _phonePlanService;
      private readonly Lazy<IUserPhonePlanService> _userPhonePlanService;
      private readonly Lazy<IAuthenticationService> _authenticationService;
     

    public ServiceManager(
            IRepositoryManager repositoryManager,
            ILoggerManager logger,
            IMapper mapper,
            UserManager<User> userManager,
            IOptions<JwtConfiguration> configuration)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper, logger));
            _deviceService = new Lazy<IDeviceService>(() => new DeviceService(repositoryManager, mapper, logger));  
            _phonePlanService = new Lazy<IPhonePlanService>(() => new PhonePlanService(repositoryManager, mapper, logger));
            _userPhonePlanService = new Lazy<IUserPhonePlanService>(() => new UserPhonePlanService(repositoryManager, mapper,logger));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
        }

        public IUserService User => _userService.Value;
        public IDeviceService Device => _deviceService.Value;
        public IPhonePlanService PhonePlan => _phonePlanService.Value;
        public IUserPhonePlanService UserPhonePlan => _userPhonePlanService.Value;
        public IAuthenticationService Authentication => _authenticationService.Value;
    }
}
