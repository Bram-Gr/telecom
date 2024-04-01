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
         /*   builder.HasData(


                );*/

        }
    }
}
