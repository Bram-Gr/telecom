using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillstormTelecom.Migrations
{
    /// <inheritdoc />
    public partial class thirdCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("46d99311-79e0-46b2-ba06-d50480a7b1c3"),
                column: "BillingDate",
                value: new DateTime(2024, 4, 2, 16, 13, 20, 711, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("9f6943a3-4f5e-471c-9b6c-a427c8bf4b20"),
                column: "BillingDate",
                value: new DateTime(2024, 4, 2, 16, 13, 20, 711, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillID",
                keyValue: new Guid("f8ff0b05-a399-4629-ace4-edf4ea173ee1"),
                column: "BillingDate",
                value: new DateTime(2024, 4, 2, 16, 13, 20, 711, DateTimeKind.Local).AddTicks(6757));
        }
    }
}
