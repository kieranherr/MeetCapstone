using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetCapstone.Migrations
{
    public partial class MeetDatabase6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Meets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Meets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Meets",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Zip",
                table: "Meets",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Meets");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Meets");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Meets");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Meets");
        }
    }
}
