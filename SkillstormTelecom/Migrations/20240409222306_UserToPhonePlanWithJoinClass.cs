using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillstormTelecom.Migrations
{
    /// <inheritdoc />
    public partial class UserToPhonePlanWithJoinClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {          

            migrationBuilder.CreateIndex(
                name: "IX_UserPhonePlans_PlanID",
                table: "UserPhonePlans",
                column: "PlanID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPhonePlans_PhonePlans_PlanID",
                table: "UserPhonePlans",
                column: "PlanID",
                principalTable: "PhonePlans",
                principalColumn: "PlanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPhonePlans_Users_UserID",
                table: "UserPhonePlans",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPhonePlans_PhonePlans_PlanID",
                table: "UserPhonePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPhonePlans_Users_UserID",
                table: "UserPhonePlans");

            migrationBuilder.DropIndex(
                name: "IX_UserPhonePlans_PlanID",
                table: "UserPhonePlans");           
        }
    }
}
