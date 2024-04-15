

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IPhonePlanService PhonePlan { get; }
        IDeviceService Device { get; }
        IUserPhonePlanService UserPhonePlan { get; }
        IUserService User { get; }
    }
}
