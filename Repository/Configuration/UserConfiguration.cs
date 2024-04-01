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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                               new User
                               {
                                   Id = Guid.NewGuid(),
                                   Username = "Jon&Linda",
                                   Email = "jonsablinski@gmail.com",
                                   Password = "password"
                               },
                                new User
                                {
                                    Id = Guid.NewGuid(),
                                    Username = "BillieBob",
                                    Email = " bbop102@yahoo.com",
                                    Password = "SinginBobby200"
                                },
                                new User
                                {
                                    Id = Guid.NewGuid(),
                                    Username = "Sally",
                                    Email = "sallyfields1968@gmail.com",
                                    Password = "theSally!0!"
                                }
                );
        }
    }
}
