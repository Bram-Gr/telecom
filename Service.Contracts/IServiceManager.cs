

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IAuthenticationService Authentication { get; }
        IPhonePlanService PhonePlan { get; }
        IDeviceService Device { get; }
        IUserPhonePlanService UserPhonePlan { get; }
        IUserService User { get; }
    }
}
