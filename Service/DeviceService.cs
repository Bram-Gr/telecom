using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DeviceService : IDeviceService
    {
        private IRepositoryManager _repositoryManager;
        private IMapper _mapper;

        public DeviceService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DeviceDto>> GetDevicesByUserIdAsync(Guid userId, bool trackChanges)
        {
        /*    var user = _repositoryManager.User.GetUserAsync(UserID, trackChanges);
            if(user == null)
            {
                throw new Exception("User not found");
            }*/

            var devices = await _repositoryManager.Device.GetAllDevicesAsync(userId, trackChanges);
            var devicesDtos = _mapper.Map<IEnumerable<DeviceDto>>(devices);
            return devicesDtos;
        }

    }
}
