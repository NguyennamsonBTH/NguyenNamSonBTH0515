using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenNamSonBTH515.Migrations
{
    public partial class Create_Table_Faculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentAge",
                table: "Student",
                newName: "FacultyID");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "Student",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "FacultyID",
                table: "Student",
                newName: "StudentAge");
        }
    }
}
