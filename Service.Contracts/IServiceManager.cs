

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IBillService Bill { get; }
        IPhonePlanService PhonePlan { get; }
        IDeviceService Device { get; }
        IUserPhonePlanService UserPhonePlan { get; }
        IUserService User { get; }
    }
}
