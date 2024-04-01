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
/*            builder.HasData(
                new Bill
                { 
                    Id = Guid.NewGuid(), 
                    UserID =                     
                    TotalAmount = 100.00, 
                    BillingDate = DateTime.Now, 
                    OtherBillDetails = "Bill for the month of January" }
                
                );*/
        }
    

    }
}
