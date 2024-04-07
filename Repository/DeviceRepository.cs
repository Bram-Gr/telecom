using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateDevice(Device device) => Create(device);

        public async Task<IEnumerable<Device>> GetAllDevicesAsync(Guid UserID, bool trackChanges) =>
            await FindByCondition(d => d.UserID.Equals(UserID), trackChanges).ToListAsync();

        public Task<Device> GetDeviceAsync(Guid deviceId, bool trackChanges)=>
           FindByCondition(d => d.Id.Equals(deviceId), trackChanges).SingleOrDefaultAsync();
        

        public void DeleteDevice(Device device) => Delete(device);
    }
}
