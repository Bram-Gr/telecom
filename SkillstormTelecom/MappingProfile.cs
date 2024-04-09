using AutoMapper;
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
            CreateMap<PhonePlanDto, PhonePlan>();
            CreateMap<UserPhonePlanDto, UserPhonePlan>();
            CreateMap<Bill, BillDto>();
            CreateMap<UserPhonePlan, UserPhonePlanDto>();
         

        }
  
    }
}
