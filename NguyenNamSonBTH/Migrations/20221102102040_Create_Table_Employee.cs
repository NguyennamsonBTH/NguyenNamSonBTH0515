using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenNamSonBTH515.Migrations
{
    public partial class Create_Table_Employee​ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "Office",
                table: "Employee",
                newName: "EmpName");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Employee",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Employee",
                newName: "EmpID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "Employee",
                newName: "Office");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employee",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "EmpID",
                table: "Employee",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employee",
                type: "TEXT",
                nullable: true);
        }
    }
}
