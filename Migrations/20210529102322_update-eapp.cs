using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMatching_OOPII_FinalProject.Migrations
{
    public partial class updateeapp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "jobType",
                table: "jobs",
                newName: "JobType");

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "employeeApplications",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "employeeApplications");

            migrationBuilder.RenameColumn(
                name: "JobType",
                table: "jobs",
                newName: "jobType");
        }
    }
}
