using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Greta_MVC.Migrations
{
    /// <inheritdoc />
    public partial class FixStudentIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameColumn(
                name: "Vardas",
                table: "Student",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Amzius",
                table: "Student",
                newName: "Age");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "Vardas");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Students",
                newName: "Amzius");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }
    }
}
