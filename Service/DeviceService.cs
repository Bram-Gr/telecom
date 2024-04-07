using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

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

        public async Task<DeviceDto> addDeviceByPlanAsync(DeviceForCreationDto device, Guid planId)
        {

            // Retrieve devices associated with the user
            var userDevices = await _repositoryManager.Device.GetAllDevicesAsync(device.UserID, false);
            var phonePlan = await _repositoryManager.PhonePlan.GetPhonePlanByIdAsync(planId, false);

            // Count the number of devices associated with the user

            int userDeviceCount = userDevices.Count(); 
            if (userDeviceCount < phonePlan.DeviceLimit)
            {
                var deviceEntity = _mapper.Map<Device>(device);
                _repositoryManager.Device.CreateDevice(deviceEntity);
                await _repositoryManager.SaveAsync();
                var deviceToReturn = _mapper.Map<DeviceDto>(deviceEntity);
                return deviceToReturn;
            }
            else
            {
                throw new Exception("Exceeded Device Limit");
            }
        }

        public async Task DeleteDeviceAsync(Guid deviceId, bool trackChanges)
        {
            var device = await _repositoryManager.Device.GetDeviceAsync(deviceId, trackChanges);
            if (device == null)
            {
                throw new Exception("Device not found");
            }
            _repositoryManager.Device.DeleteDevice(device);
            await _repositoryManager.SaveAsync();
        }

    }
}
