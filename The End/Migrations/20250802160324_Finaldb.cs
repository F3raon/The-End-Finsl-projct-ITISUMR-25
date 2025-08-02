using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_End.Migrations
{
    /// <inheritdoc />
    public partial class Finaldb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Categories",
                newName: "Category-Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category-Name",
                table: "Categories",
                newName: "EmployeeName");
        }
    }
}
