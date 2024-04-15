﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace SkillstormTelecom.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240415210530_RemovedBillEntity")]
    partial class RemovedBillEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("DeviceID");

                    b.Property<string>("OtherDeviceDetails")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Other device details");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PhoneNumber");

                    b.Property<Guid>("PhonePlanID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3804e1ca-5eea-4915-bd6c-47b8ee9994cb"),
                            OtherDeviceDetails = "Sally's Iphone 15",
                            PhoneNumber = "555-555-5555",
                            PhonePlanID = new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"),
                            UserID = new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289")
                        },
                        new
                        {
                            Id = new Guid("08c6c029-3853-4a20-86b3-e5da9adedb96"),
                            PhoneNumber = "555-555-5556",
                            PhonePlanID = new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"),
                            UserID = new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289")
                        },
                        new
                        {
                            Id = new Guid("1fabc5a9-5e7e-42f3-ac49-5e9ddd7a2500"),
                            PhoneNumber = "555-555-5557",
                            PhonePlanID = new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"),
                            UserID = new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289")
                        },
                        new
                        {
                            Id = new Guid("19c80b17-b246-4ac9-a459-1ae9bf32f949"),
                            PhoneNumber = "555-555-5558",
                            PhonePlanID = new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"),
                            UserID = new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289")
                        },
                        new
                        {
                            Id = new Guid("e7fc1146-5be0-4b3e-8db2-846d5b954ae6"),
                            PhoneNumber = "555-555-5889",
                            PhonePlanID = new Guid("a0233acc-383c-4a9e-b867-34d7ba382512"),
                            UserID = new Guid("12ae765a-189b-4194-81e6-0b4046f32853")
                        },
                        new
                        {
                            Id = new Guid("ab2072b6-32b1-4ca4-aeac-8bf4afae0088"),
                            PhoneNumber = "555-555-5890",
                            PhonePlanID = new Guid("319cf1f0-ab87-4a64-845f-9b873a547872"),
                            UserID = new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635")
                        });
                });

            modelBuilder.Entity("Entities.PhonePlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PhonePlanId");

                    b.Property<int>("DeviceLimit")
                        .HasColumnType("int")
                        .HasColumnName("DeviceLimit");

                    b.Property<string>("OtherPlanDetails")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Other plan details");

                    b.Property<string>("PlanName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PlanName");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("Price");

                    b.HasKey("Id");

                    b.ToTable("PhonePlans");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05444900-9ac7-4dd5-b69f-221c098a1493"),
                            DeviceLimit = 1,
                            OtherPlanDetails = "Unlimited talk and text with 5GB of data.",
                            PlanName = "Unlimited Talk and Text",
                            Price = 50.0
                        },
                        new
                        {
                            Id = new Guid("a0233acc-383c-4a9e-b867-34d7ba382512"),
                            DeviceLimit = 2,
                            OtherPlanDetails = "Unlimited talk, text, and data.",
                            PlanName = "Unlimited Everything",
                            Price = 75.0
                        },
                        new
                        {
                            Id = new Guid("319cf1f0-ab87-4a64-845f-9b873a547872"),
                            DeviceLimit = 1,
                            OtherPlanDetails = "500 minutes, 500 texts, and 1GB of data.",
                            PlanName = "Basic Plan",
                            Price = 25.0
                        },
                        new
                        {
                            Id = new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"),
                            DeviceLimit = 4,
                            OtherPlanDetails = "Unlimited talk, text, and data for 4 devices.",
                            PlanName = "Family Plan",
                            Price = 100.0
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289"),
                            Email = "jonsablinski@gmail.com",
                            Password = "password",
                            Username = "Jon&Linda"
                        },
                        new
                        {
                            Id = new Guid("12ae765a-189b-4194-81e6-0b4046f32853"),
                            Email = " bbop102@yahoo.com",
                            Password = "SinginBobby200",
                            Username = "BillieBob"
                        },
                        new
                        {
                            Id = new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635"),
                            Email = "sallyfields1968@gmail.com",
                            Password = "theSally!0!",
                            Username = "Sally"
                        });
                });

            modelBuilder.Entity("Entities.UserPhonePlan", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhonePlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Date Added")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("UserId", "PhonePlanId");

                    b.HasIndex("PhonePlanId");

                    b.ToTable("UserPhonePlan");
                });

            modelBuilder.Entity("Entities.UserPhonePlan", b =>
                {
                    b.HasOne("Entities.PhonePlan", null)
                        .WithMany()
                        .HasForeignKey("PhonePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
