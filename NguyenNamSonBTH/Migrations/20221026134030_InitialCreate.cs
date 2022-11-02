using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenNamSonBTH515.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    StudentID = table.Column<string>(type: "TEXT", nullable: true),
                    StudentName = table.Column<string>(type: "TEXT", nullable: true),
                    StudentAge = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}