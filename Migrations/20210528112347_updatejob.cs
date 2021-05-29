using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMatching_OOPII_FinalProject.Migrations
{
    public partial class updatejob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyNameLogo",
                table: "jobs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SalaryRange",
                table: "jobs",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "jobType",
                table: "jobs",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyNameLogo",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "SalaryRange",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "jobType",
                table: "jobs");
        }
    }
}
