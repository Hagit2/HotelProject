using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Data.Migrations
{
    public partial class employeetorooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_EmployeeId",
                table: "Rooms",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Employees_EmployeeId",
                table: "Rooms",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Employees_EmployeeId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_EmployeeId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Rooms");
        }
    }
}
