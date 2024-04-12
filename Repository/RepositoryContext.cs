using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Repository.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;    


namespace Repository
{
    public class RepositoryContext : DbContext 
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<PhonePlan> PhonePlans { get; set; }
  /*      public DbSet<UserPhonePlan> UserPhonePlans { get; set; }*/
        public DbSet<Device> Devices { get; set; }
        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<UserPhonePlan>()
                .HasKey(up => new { up.UserId, up.PhonePlanId });

            modelBuilder.Entity<User>()
                .HasMany(u => u.PhonePlans)
                .WithMany(up => up.Users)
                .UsingEntity<UserPhonePlan>();

            modelBuilder.Entity<PhonePlan>()
           .HasMany(u => u.Users)
           .WithMany(up => up.PhonePlans)
           .UsingEntity<UserPhonePlan>();


            modelBuilder.Entity<UserPhonePlan>(model =>
            {
                model.Property(up => up.DateAdded)
                .HasDefaultValueSql("getdate()");
            });



            modelBuilder.ApplyConfiguration(new UserConfiguration());
/*            modelBuilder.ApplyConfiguration(new UserPhonePlanConfiguration());*/
            modelBuilder.ApplyConfiguration(new PhonePlanConfiguation());
         modelBuilder.ApplyConfiguration(new DeviceConfiguration());
         modelBuilder.ApplyConfiguration(new BillConfiguration());
/*        modelBuilder.ApplyConfiguration(new RoleConfiguration());*/

        }
    }
}
