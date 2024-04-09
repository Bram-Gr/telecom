using Microsoft.EntityFrameworkCore.Metadata;
using Service.Contracts;
using Contracts;
using AutoMapper;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
      private readonly Lazy<IUserService> _userService;
      private readonly Lazy<IBillService> _billService;
      private readonly Lazy<IDeviceService> _deviceService;
      private readonly Lazy<IPhonePlanService> _phonePlanService;
      private readonly Lazy<IUserPhonePlanService> _userPhonePlanService;
     

    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper, logger));
            _billService = new Lazy<IBillService>(() => new BillService(repositoryManager, mapper, logger));
            _deviceService = new Lazy<IDeviceService>(() => new DeviceService(repositoryManager, mapper, logger));  
            _phonePlanService = new Lazy<IPhonePlanService>(() => new PhonePlanService(repositoryManager, mapper, logger));
            _userPhonePlanService = new Lazy<IUserPhonePlanService>(() => new UserPhonePlanService(repositoryManager, mapper,logger));
        }

        public IUserService User => _userService.Value;
        public IBillService Bill => _billService.Value;
        public IDeviceService Device => _deviceService.Value;
        public IPhonePlanService PhonePlan => _phonePlanService.Value;
        public IUserPhonePlanService UserPhonePlan => _userPhonePlanService.Value;
            
    }
}
