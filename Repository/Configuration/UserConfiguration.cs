/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                               new User
                               {
                                   Id = new Guid("8A55F01B-1CD0-4848-B7AE-86C40B1AD289"),
                                   Username = "Jon&Linda",
                                   Email = "jonsablinski@gmail.com",
                                   Password = "password"
                               },
                                new User
                                {
                                    Id = new Guid("12AE765A-189B-4194-81E6-0B4046F32853"),
                                    Username = "BillieBob",
                                    Email = " bbop102@yahoo.com",
                                    Password = "SinginBobby200"
                                },
                                new User
                                {
                                    Id = new Guid("2A4425E8-F6BF-4D34-9C8D-5236751F7635"),
                                    Username = "Sally",
                                    Email = "sallyfields1968@gmail.com",
                                    Password = "theSally!0!"
                                }
                );
        }
    }
}
*/