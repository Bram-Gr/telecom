using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkillstormTelecom.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillID", "BillingDate", "Other bill details", "TotalAmount", "UserID" },
                values: new object[,]
                {
                    { new Guid("46d99311-79e0-46b2-ba06-d50480a7b1c3"), new DateTime(2024, 4, 2, 16, 13, 20, 711, DateTimeKind.Local).AddTicks(6738), "Bill for the month of January", 75.0, new Guid("12ae765a-189b-4194-81e6-0b4046f32853") },
                    { new Guid("9f6943a3-4f5e-471c-9b6c-a427c8bf4b20"), new DateTime(2024, 4, 2, 16, 13, 20, 711, DateTimeKind.Local).AddTicks(6595), "Bill for the month of January", 100.0, new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("f8ff0b05-a399-4629-ace4-edf4ea173ee1"), new DateTime(2024, 4, 2, 16, 13, 20, 711, DateTimeKind.Local).AddTicks(6757), "Bill for the month of January", 25.0, new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635") }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceID", "Other device details", "PhoneNumber", "PlanID", "UserID" },
                values: new object[,]
                {
                    { new Guid("08c6c029-3853-4a20-86b3-e5da9adedb96"), null, "555-555-5556", new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("19c80b17-b246-4ac9-a459-1ae9bf32f949"), null, "555-555-5558", new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("1fabc5a9-5e7e-42f3-ac49-5e9ddd7a2500"), null, "555-555-5557", new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("3804e1ca-5eea-4915-bd6c-47b8ee9994cb"), "Sally's Iphone 15", "555-555-5555", new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") },
                    { new Guid("ab2072b6-32b1-4ca4-aeac-8bf4afae0088"), null, "555-555-5890", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635") },
                    { new Guid("e7fc1146-5be0-4b3e-8db2-846d5b954ae6"), null, "555-555-5889", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("12ae765a-189b-4194-81e6-0b4046f32853") }
                });

            migrationBuilder.InsertData(
                table: "UserPhonePlans",
                columns: new[] { "PlanID", "UserID" },
                values: new object[,]
                {
                    { new Guid("a0233acc-383c-4a9e-b867-34d7ba382512"), new Guid("12ae765a-189b-4194-81e6-0b4046f32853") },
                    { new Guid("319cf1f0-ab87-4a64-845f-9b873a547872"), new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635") },
                    { new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("46d99311-79e0-46b2-ba06-d50480a7b1c3"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("9f6943a3-4f5e-471c-9b6c-a427c8bf4b20"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("f8ff0b05-a399-4629-ace4-edf4ea173ee1"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("08c6c029-3853-4a20-86b3-e5da9adedb96"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("19c80b17-b246-4ac9-a459-1ae9bf32f949"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("1fabc5a9-5e7e-42f3-ac49-5e9ddd7a2500"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("3804e1ca-5eea-4915-bd6c-47b8ee9994cb"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("ab2072b6-32b1-4ca4-aeac-8bf4afae0088"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("e7fc1146-5be0-4b3e-8db2-846d5b954ae6"));

            migrationBuilder.DeleteData(
                table: "UserPhonePlans",
                keyColumns: new[] { "PlanID", "UserID" },
                keyValues: new object[] { new Guid("a0233acc-383c-4a9e-b867-34d7ba382512"), new Guid("12ae765a-189b-4194-81e6-0b4046f32853") });

            migrationBuilder.DeleteData(
                table: "UserPhonePlans",
                keyColumns: new[] { "PlanID", "UserID" },
                keyValues: new object[] { new Guid("319cf1f0-ab87-4a64-845f-9b873a547872"), new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635") });

            migrationBuilder.DeleteData(
                table: "UserPhonePlans",
                keyColumns: new[] { "PlanID", "UserID" },
                keyValues: new object[] { new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289") });
        }
    }
}
