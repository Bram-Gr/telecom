using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities;

namespace Repository.Configuration
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasData(
                new Bill
                {
                    Id = new Guid("9F6943A3-4F5E-471C-9B6C-A427C8BF4B20"),
                    UserID = new Guid("8A55F01B-1CD0-4848-B7AE-86C40B1AD289"),
                    TotalAmount = 100.00,
                    BillingDate = DateTime.Now,
                    OtherBillDetails = "Bill for the month of January"
                },
                new Bill
                {
                    Id = new Guid("46D99311-79E0-46B2-BA06-D50480A7B1C3"),
                    UserID = new Guid("12AE765A-189B-4194-81E6-0B4046F32853"),
                    TotalAmount = 75.00,
                    BillingDate = DateTime.Now,
                    OtherBillDetails = "Bill for the month of January"
                },
                new Bill
                {
                    Id = new Guid("F8FF0B05-A399-4629-ACE4-EDF4EA173EE1"),
                    UserID = new Guid("2A4425E8-F6BF-4D34-9C8D-5236751F7635"),
                    TotalAmount = 25.00,
                    BillingDate = DateTime.Now,
                    OtherBillDetails = "Bill for the month of January"
                }

                );
        }
    

    }
}
