using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkillstormTelecom.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
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
                    Otherbilldetails = table.Column<string>(name: "Other bill details", type: "nvarchar(max)", nullable: true)
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
                    PlanID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    PlanID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceLimit = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Otherplandetails = table.Column<string>(name: "Other plan details", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhonePlans", x => x.PlanID);
                });

            migrationBuilder.CreateTable(
                name: "UserPhonePlans",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhonePlans", x => new { x.UserID, x.PlanID });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "PhonePlans",
                columns: new[] { "PlanID", "DeviceLimit", "Other plan details", "PlanName", "Price" },
                values: new object[,]
                {
                    { new Guid("05444900-9ac7-4dd5-b69f-221c098a1493"), 1, "Unlimited talk and text with 5GB of data.", "Unlimited Talk and Text", 50.0 },
                    { new Guid("2d2f6606-6325-4e26-9c54-e8eb44521e85"), 4, "Unlimited talk, text, and data for 4 devices.", "Family Plan", 100.0 },
                    { new Guid("319cf1f0-ab87-4a64-845f-9b873a547872"), 1, "500 minutes, 500 texts, and 1GB of data.", "Basic Plan", 25.0 },
                    { new Guid("a0233acc-383c-4a9e-b867-34d7ba382512"), 2, "Unlimited talk, text, and data.", "Unlimited Everything", 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("12ae765a-189b-4194-81e6-0b4046f32853"), " bbop102@yahoo.com", "SinginBobby200", "BillieBob" },
                    { new Guid("2a4425e8-f6bf-4d34-9c8d-5236751f7635"), "sallyfields1968@gmail.com", "theSally!0!", "Sally" },
                    { new Guid("8a55f01b-1cd0-4848-b7ae-86c40b1ad289"), "jonsablinski@gmail.com", "password", "Jon&Linda" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "PhonePlans");

            migrationBuilder.DropTable(
                name: "UserPhonePlans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
