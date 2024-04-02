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
    public class UserPhonePlanConfiguration : IEntityTypeConfiguration<UserPhonePlan>
    {
        public void Configure(EntityTypeBuilder<UserPhonePlan> builder)
        {
            builder.HasData(
                new UserPhonePlan
                {
                    UserID = new Guid("8A55F01B-1CD0-4848-B7AE-86C40B1AD289"),
                    PlanID = new Guid("2D2F6606-6325-4E26-9C54-E8EB44521E85")
                },
                new UserPhonePlan
                {
                    UserID = new Guid("12AE765A-189B-4194-81E6-0B4046F32853"),
                    PlanID = new Guid("A0233ACC-383C-4A9E-B867-34D7BA382512")
                },
                new UserPhonePlan
                {
                    UserID = new Guid("2A4425E8-F6BF-4D34-9C8D-5236751F7635"),
                    PlanID = new Guid("319CF1F0-AB87-4A64-845F-9B873A547872")
                }


                );
        }
    }
}