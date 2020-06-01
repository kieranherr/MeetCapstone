using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetCapstone.Migrations
{
    public partial class MeetCapstone6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
