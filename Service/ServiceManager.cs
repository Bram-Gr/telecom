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
     

    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper));
            _billService = new Lazy<IBillService>(() => new BillService(repositoryManager, mapper));
            _deviceService = new Lazy<IDeviceService>(() => new DeviceService(repositoryManager, mapper));  
            _phonePlanService = new Lazy<IPhonePlanService>(() => new PhonePlanService(repositoryManager, mapper));
            _userPhonePlanService = new Lazy<IUserPhonePlanService>(() => new UserPhonePlanService(repositoryManager, mapper));
        }

        public IUserService User => _userService.Value;
        public IBillService Bill => _billService.Value;
        public IDeviceService Device => _deviceService.Value;
        public IPhonePlanService PhonePlan => _phonePlanService.Value;
        public IUserPhonePlanService UserPhonePlan => _userPhonePlanService.Value;
            
    }
}
