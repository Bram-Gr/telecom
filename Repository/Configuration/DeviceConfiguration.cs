using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasData(
                  new Device
                  {
                      Id = new Guid("3804E1CA-5EEA-4915-BD6C-47B8EE9994CB"),
                      PhoneNumber = "555-555-5555",
                      UserID = new Guid("8A55F01B-1CD0-4848-B7AE-86C40B1AD289"),
                      PhonePlanID = new Guid("2D2F6606-6325-4E26-9C54-E8EB44521E85"),
                      OtherDeviceDetails = "Sally's Iphone 15"
                  },
                  new Device
                  {
                        Id = new Guid("08C6C029-3853-4A20-86B3-E5DA9ADEDB96"),
                        PhoneNumber = "555-555-5556",
                        UserID = new Guid("8A55F01B-1CD0-4848-B7AE-86C40B1AD289"),
                        PhonePlanID = new Guid("2D2F6606-6325-4E26-9C54-E8EB44521E85"),
                  },
                  new Device
                  {
                        Id = new Guid("1FABC5A9-5E7E-42F3-AC49-5E9DDD7A2500"),
                        PhoneNumber = "555-555-5557",
                        UserID = new Guid("8A55F01B-1CD0-4848-B7AE-86C40B1AD289"),
                        PhonePlanID = new Guid("2D2F6606-6325-4E26-9C54-E8EB44521E85"),
                    },
                  new Device
                  {
                        Id = new Guid("19C80B17-B246-4AC9-A459-1AE9BF32F949"),
                        PhoneNumber = "555-555-5558",
                        UserID = new Guid("8A55F01B-1CD0-4848-B7AE-86C40B1AD289"),
                        PhonePlanID = new Guid("2D2F6606-6325-4E26-9C54-E8EB44521E85"),
                    },
                  new Device
                  {
                        Id = new Guid("E7FC1146-5BE0-4B3E-8DB2-846D5B954AE6"),
                        PhoneNumber = "555-555-5889",
                        UserID = new Guid("12AE765A-189B-4194-81E6-0B4046F32853"),
                        PhonePlanID = new Guid("A0233ACC-383C-4A9E-B867-34D7BA382512")
                  },
                  new Device
                  {
                        Id = new Guid("AB2072B6-32B1-4CA4-AEAC-8BF4AFAE0088"),
                        PhoneNumber = "555-555-5890",
                        UserID = new Guid("2A4425E8-F6BF-4D34-9C8D-5236751F7635"),
                        PhonePlanID = new Guid("319CF1F0-AB87-4A64-845F-9B873A547872")
                  }
                );
        }

    }
}
