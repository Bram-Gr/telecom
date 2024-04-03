using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IUserPhonePlanRepository userPhonePlanRepository { get; }
        IUserRepository User { get; }
        IPhonePlanRepository PhonePlan { get; }
        IDeviceRepository Device { get; }
        IBillRepository Bill { get; }
        Task SaveAsync();
    }
}
