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
using Entities.Exceptions;  

namespace Service
{
    public class DeviceService : IDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public DeviceService(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<DeviceDto>> GetDevicesByUserIdAsync(Guid userId, bool trackChanges)
        {
            var devices = await _repositoryManager.Device.GetAllDevicesAsync(userId, trackChanges);
            var devicesDtos = _mapper.Map<IEnumerable<DeviceDto>>(devices);
            return devicesDtos;
        }

        public async Task<DeviceDto> addDeviceByPlanAsync(DeviceForCreationDto device, Guid planId)
        {

            // Retrieve devices associated with the user
            var userDevices = await _repositoryManager.Device.GetDevicesByPhonePlanAsync(device.UserID, planId, false);
            var phonePlan = await _repositoryManager.PhonePlan.GetPhonePlanByIdAsync(planId, false);
            // Check if the user has the phone plan
            var userPlans = await _repositoryManager.PhonePlan.GetPhonePlansByUserIdAsync(device.UserID, false);
            if (!userPlans.Any(plan => plan.Id == phonePlan.Id))
            {
                throw new PhonePlanNotFoundException(planId);
            }
            // Count the number of devices associated with the user by the phone plan
            int userDeviceCount = userDevices.Count(); 
            if (userDeviceCount < phonePlan.DeviceLimit)
            {

                var deviceEntity = _mapper.Map<Device>(device);
                deviceEntity.PhonePlanID = planId;
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
                throw new DeviceNotFoundException(deviceId);
            }

            _repositoryManager.Device.DeleteDevice(device);
            await _repositoryManager.SaveAsync();
        }

        public async Task UpdateDeviceAsync(Guid id, DeviceForUpdateDto deviceForUpdate, bool trackChanges)
        {
            var deviceEntity = await _repositoryManager.Device.GetDeviceAsync(id, trackChanges);

            if (deviceEntity == null)
            {
                throw new DeviceNotFoundException(id);
            }

            var userDevicesForPlan = await _repositoryManager.Device.GetDevicesByPhonePlanAsync(deviceEntity.UserID, deviceEntity.PhonePlanID, false);
            var phonePlan = await _repositoryManager.PhonePlan.GetPhonePlanByIdAsync(deviceForUpdate.PhonePlanID, false);

            if (phonePlan == null)
            {
                throw new Exception("Associated phone plan not found.");
            }

            int userDeviceCountForPlan = userDevicesForPlan.Count();

            if (userDeviceCountForPlan <= phonePlan.DeviceLimit)
            {
                _mapper.Map(deviceForUpdate, deviceEntity);
                await _repositoryManager.SaveAsync();
            }
            else
            {
                throw new Exception("Exceeded Device Limit for that plan");
            }
        }

    }



}
