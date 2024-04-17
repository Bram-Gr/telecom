using AutoMapper;
using Entities;
using Shared.DataTransferObjects;


namespace SkillstormTelecom
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Device, DeviceDto>().ReverseMap();
            CreateMap<DeviceForCreationDto, Device>();
            CreateMap<User, UserDto>();
            CreateMap<PhonePlanDto, PhonePlan>();
            CreateMap<UserPhonePlanDto, UserPhonePlan>();
            CreateMap<UserPhonePlan, UserPhonePlanDto>();
            CreateMap<DeviceForUpdateDto, Device>().ReverseMap();
            CreateMap<UserForCreationDto, User>();

        }
  
    }
}
