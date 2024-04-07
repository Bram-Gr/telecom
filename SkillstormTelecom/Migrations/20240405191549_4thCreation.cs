using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillstormTelecom.Migrations
{
    /// <inheritdoc />
    public partial class _4thCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BillingAddress",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("46d99311-79e0-46b2-ba06-d50480a7b1c3"),
                columns: new[] { "BillingAddress", "BillingDate" },
                values: new object[] { null, new DateTime(2024, 4, 5, 15, 15, 48, 824, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("9f6943a3-4f5e-471c-9b6c-a427c8bf4b20"),
                columns: new[] { "BillingAddress", "BillingDate" },
                values: new object[] { null, new DateTime(2024, 4, 5, 15, 15, 48, 824, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("f8ff0b05-a399-4629-ace4-edf4ea173ee1"),
                columns: new[] { "BillingAddress", "BillingDate" },
                values: new object[] { null, new DateTime(2024, 4, 5, 15, 15, 48, 824, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("ab2072b6-32b1-4ca4-aeac-8bf4afae0088"),
                column: "PlanID",
                value: new Guid("319cf1f0-ab87-4a64-845f-9b873a547872"));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("e7fc1146-5be0-4b3e-8db2-846d5b954ae6"),
                column: "PlanID",
                value: new Guid("a0233acc-383c-4a9e-b867-34d7ba382512"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingAddress",
                table: "Bills");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("46d99311-79e0-46b2-ba06-d50480a7b1c3"),
                column: "BillingDate",
                value: new DateTime(2024, 4, 2, 16, 23, 36, 957, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("9f6943a3-4f5e-471c-9b6c-a427c8bf4b20"),
                column: "BillingDate",
                value: new DateTime(2024, 4, 2, 16, 23, 36, 957, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("f8ff0b05-a399-4629-ace4-edf4ea173ee1"),
                column: "BillingDate",
                value: new DateTime(2024, 4, 2, 16, 23, 36, 957, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("ab2072b6-32b1-4ca4-aeac-8bf4afae0088"),
                column: "PlanID",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: new Guid("e7fc1146-5be0-4b3e-8db2-846d5b954ae6"),
                column: "PlanID",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
