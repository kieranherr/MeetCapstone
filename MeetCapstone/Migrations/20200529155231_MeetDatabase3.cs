using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetCapstone.Migrations
{
    public partial class MeetDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "Clients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientId1",
                table: "Clients",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Clients_ClientId1",
                table: "Clients",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Clients_ClientId1",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ClientId1",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Clients");
        }
    }
}
