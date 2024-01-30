using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Data.Migrations
{
    public partial class roomstoguests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_GuestId",
                table: "Rooms",
                column: "GuestId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Guests_GuestId",
                table: "Rooms",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Guests_GuestId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_GuestId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Rooms");
        }
    }
}
