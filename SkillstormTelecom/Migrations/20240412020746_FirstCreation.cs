﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkillstormTelecom.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    BillingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Otherbilldetails = table.Column<string>(name: "Other bill details", type: "nvarchar(max)", nullable: true),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhonePlanID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Otherdevicedetails = table.Column<string>(name: "Other device details", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceID);
                });

            migrationBuilder.CreateTable(
                name: "PhonePlans",
                columns: table => new
                {
                    PhonePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceLimit = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Otherplandetails = table.Column<string>(name: "Other plan details", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhonePlans", x => x.PhonePlanId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserPhonePlan",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhonePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAdded = table.Column<DateTime>(name: "Date Added", type: "datetime2", nullable: true, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhonePlan", x => new { x.UserId, x.PhonePlanId });
                    table.ForeignKey(
                        name: "FK_UserPhonePlan_PhonePlans_PhonePlanId",
                        column: x => x.PhonePlanId,
                        principalTable: "PhonePlans",
                        principalColumn: "PhonePlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPhonePlan_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillID", "BillingAddress", "BillingDate", "Other bill details", "TotalAmount", "UserID" },
                values: new object[,]
                {
                    { new Guid("46d99311-79e0-46b2-ba06-d50480a7b1c3"), null, new DateTime(2024, 4, 11, 22, 7, 45, 919, DateTimeKind.Local).AddTicks(6007), "Bill for the month of January", 75.0, new Guid("12ae765a-189b-4194-81e6-0b4046f32853") },
                    { new Guid("9f6943a3-4f5e-471c-9b6c-a427c8bf4b20"), null, new DateTime(2024, 4, 11, 22, 7, 45, 919, DateTimeKind.Local).AddTicks(5948), "Bill for the month of January", 100.0, new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("f8ff0b05-a399-4629-ace4-edf4ea173ee1"), null, new DateTime(2024, 4, 11, 22, 7, 45, 919, DateTimeKind.Local).AddTicks(6012), "Bill for the month of January", 25.0, new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635") }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceID", "Other device details", "PhoneNumber", "PhonePlanID", "UserID" },
                values: new object[,]
                {
                    { new Guid("08c6c029-3853-4a20-86b3-e5da9adedb96"), null, "555-555-5556", new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("19c80b17-b246-4ac9-a459-1ae9bf32f949"), null, "555-555-5558", new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("1fabc5a9-5e7e-42f3-ac49-5e9ddd7a2500"), null, "555-555-5557", new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("3804e1ca-5eea-4915-bd6c-47b8ee9994cb"), "Sally's Iphone 15", "555-555-5555", new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("ab2072b6-32b1-4ca4-aeac-8bf4afae0088"), null, "555-555-5890", new Guid("319cf1f0-ab87-4a64-845f-9b873a547872"), new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635") },
                    { new Guid("e7fc1146-5be0-4b3e-8db2-846d5b954ae6"), null, "555-555-5889", new Guid("a0233acc-383c-4a9e-b867-34d7ba382512"), new Guid("12ae765a-189b-4194-81e6-0b4046f32853") }
                });

            migrationBuilder.InsertData(
                table: "PhonePlans",
                columns: new[] { "PhonePlanId", "DeviceLimit", "Other plan details", "PlanName", "Price" },
                values: new object[,]
                {
                    { new Guid("05444900-9ac7-4dd5-b69f-221c098a1493"), 1, "Unlimited talk and text with 5GB of data.", "Unlimited Talk and Text", 50.0 },
                    { new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), 4, "Unlimited talk, text, and data for 4 devices.", "Family Plan", 100.0 },
                    { new Guid("319cf1f0-ab87-4a64-845f-9b873a547872"), 1, "500 minutes, 500 texts, and 1GB of data.", "Basic Plan", 25.0 },
                    { new Guid("a0233acc-383c-4a9e-b867-34d7ba382512"), 2, "Unlimited talk, text, and data.", "Unlimited Everything", 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("12ae765a-189b-4194-81e6-0b4046f32853"), " bbop102@yahoo.com", "SinginBobby200", "BillieBob" },
                    { new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635"), "sallyfields1968@gmail.com", "theSally!0!", "Sally" },
                    { new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289"), "jonsablinski@gmail.com", "password", "Jon&Linda" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPhonePlan_PhonePlanId",
                table: "UserPhonePlan",
                column: "PhonePlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "UserPhonePlan");

            migrationBuilder.DropTable(
                name: "PhonePlans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
