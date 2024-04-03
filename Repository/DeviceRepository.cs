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

        public Task<IEnumerable<Device>> GetAllDevicesAsync(Guid userId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Device> GetDeviceAsync(Guid userId, Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
