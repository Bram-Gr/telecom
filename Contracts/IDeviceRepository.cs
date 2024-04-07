using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IDeviceRepository
    {
        Task<IEnumerable<Device>> GetAllDevicesAsync(Guid userId, bool trackChanges);
        void CreateDevice(Device device);
        void DeleteDevice(Device device);
        Task<Device> GetDeviceAsync(Guid deviceId, bool trackChanges);
    }
}
