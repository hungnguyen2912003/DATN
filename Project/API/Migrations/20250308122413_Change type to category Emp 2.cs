using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ChangetypetocategoryEmp2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeCategoryId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeType",
                table: "EmployeeType");

            migrationBuilder.RenameTable(
                name: "EmployeeType",
                newName: "EmployeeCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeCategory",
                table: "EmployeeCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeCategory_EmployeeCategoryId",
                table: "Employee",
                column: "EmployeeCategoryId",
                principalTable: "EmployeeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeCategory_EmployeeCategoryId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeCategory",
                table: "EmployeeCategory");

            migrationBuilder.RenameTable(
                name: "EmployeeCategory",
                newName: "EmployeeType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeType",
                table: "EmployeeType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeCategoryId",
                table: "Employee",
                column: "EmployeeCategoryId",
                principalTable: "EmployeeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
