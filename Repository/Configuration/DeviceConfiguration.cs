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
         /*   builder.HasData(
                  new Device
                  {
                      Id = Guid.NewGuid(),
                      PhoneNumber = "555-555-5555",
                      UserID =
                      PlanID =                    
                      OtherDeviceDetails = "Sally's Iphone 15"
                  }
                );*/
        }

    }
}
