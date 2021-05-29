using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMatching_OOPII_FinalProject.Migrations
{
    public partial class updateeap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "jobOwnerEmail",
                table: "employeeApplications",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "jobOwnerEmail",
                table: "employeeApplications");
        }
    }
}
