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
    public class PhonePlanConfiguation : IEntityTypeConfiguration<PhonePlan>

    {
        public void Configure(EntityTypeBuilder<PhonePlan> builder)
        {
            builder.HasData(
                new PhonePlan
                {
                    Id = Guid.NewGuid(),
                    PlanName = "Unlimited Talk and Text",
                    DeviceLimit = 1,
                    Price = 50.00,
                    OtherPlanDetails = "Unlimited talk and text with 5GB of data."
                },
                new PhonePlan
                {
                    Id = Guid.NewGuid(),
                    PlanName = "Unlimited Everything",
                    DeviceLimit = 2,
                    Price = 75.00,
                    OtherPlanDetails = "Unlimited talk, text, and data."
                },
                new PhonePlan
                {
                    Id = Guid.NewGuid(),
                    PlanName = "Basic Plan",
                    DeviceLimit = 1,
                    Price = 25.00,
                    OtherPlanDetails = "500 minutes, 500 texts, and 1GB of data."
                },
                new PhonePlan
                {
                    Id = Guid.NewGuid(),
                    PlanName = "Family Plan",
                    DeviceLimit = 4,
                    Price = 100.00,
                    OtherPlanDetails = "Unlimited talk, text, and data for 4 devices."
                }
           );
        }
    }
}
