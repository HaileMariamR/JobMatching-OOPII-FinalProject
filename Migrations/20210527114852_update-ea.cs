using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMatching_OOPII_FinalProject.Migrations
{
    public partial class updateea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateofApplication",
                table: "employeeApplications",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateofApplication",
                table: "employeeApplications");
        }
    }
}
