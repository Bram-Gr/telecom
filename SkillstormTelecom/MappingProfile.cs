﻿using AutoMapper;
using Entities;
using Shared.DataTransferObjects;


namespace SkillstormTelecom
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Device, DeviceDto>();
            CreateMap<DeviceForCreationDto, Device>();
            CreateMap<User, UserDto>();
       
        }
  
    }
}
