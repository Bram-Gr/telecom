﻿using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Service.Contracts
{
    public interface IDeviceService
    {
        Task<IEnumerable<DeviceDto>> GetDevicesByUserIdAsync(Guid userId,bool trackChanges);
        Task<DeviceDto> addDeviceByPlan(DeviceForCreationDto device, PhonePlan phone );
    }
}
