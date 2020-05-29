using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetCapstone.Migrations
{
    public partial class MeetDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Meets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Garages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Garages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Clients",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Meets_CarId",
                table: "Meets",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Garages_CarId",
                table: "Garages",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Garages_ClientId",
                table: "Garages",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Garages_Cars_CarId",
                table: "Garages",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Garages_Clients_ClientId",
                table: "Garages",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meets_Cars_CarId",
                table: "Meets",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Garages_Cars_CarId",
                table: "Garages");

            migrationBuilder.DropForeignKey(
                name: "FK_Garages_Clients_ClientId",
                table: "Garages");

            migrationBuilder.DropForeignKey(
                name: "FK_Meets_Cars_CarId",
                table: "Meets");

            migrationBuilder.DropIndex(
                name: "IX_Meets_CarId",
                table: "Meets");

            migrationBuilder.DropIndex(
                name: "IX_Garages_CarId",
                table: "Garages");

            migrationBuilder.DropIndex(
                name: "IX_Garages_ClientId",
                table: "Garages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Meets");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Garages");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Garages");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "UserId");
        }
    }
}
