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
                    Id = new Guid("05444900-9AC7-4DD5-B69F-221C098A1493"),
                    PlanName = "Unlimited Talk and Text",
                    DeviceLimit = 1,
                    Price = 50.00,
                    OtherPlanDetails = "Unlimited talk and text with 5GB of data."
                },
                new PhonePlan
                {
                    Id = new Guid("A0233ACC-383C-4A9E-B867-34D7BA382512"),
                    PlanName = "Unlimited Everything",
                    DeviceLimit = 2,
                    Price = 75.00,
                    OtherPlanDetails = "Unlimited talk, text, and data."
                },
                new PhonePlan
                {
                    Id = new Guid("319CF1F0-AB87-4A64-845F-9B873A547872"),
                    PlanName = "Basic Plan",
                    DeviceLimit = 1,
                    Price = 25.00,
                    OtherPlanDetails = "500 minutes, 500 texts, and 1GB of data."
                },
                new PhonePlan
                {
                    Id = new Guid("2D2F6606-6325-4E26-9C54-E8EB44521E85"),
                    PlanName = "Family Plan",
                    DeviceLimit = 4,
                    Price = 100.00,
                    OtherPlanDetails = "Unlimited talk, text, and data for 4 devices."
                }
           );
        }
    }
}
