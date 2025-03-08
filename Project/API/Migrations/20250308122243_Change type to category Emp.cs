using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ChangetypetocategoryEmp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeTypeId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeeTypeCode",
                table: "EmployeeType",
                newName: "EmployeeCategoryCode");

            migrationBuilder.RenameColumn(
                name: "EmployeeTypeId",
                table: "Employee",
                newName: "EmployeeCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_EmployeeTypeId",
                table: "Employee",
                newName: "IX_Employee_EmployeeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeCategoryId",
                table: "Employee",
                column: "EmployeeCategoryId",
                principalTable: "EmployeeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeCategoryId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeeCategoryCode",
                table: "EmployeeType",
                newName: "EmployeeTypeCode");

            migrationBuilder.RenameColumn(
                name: "EmployeeCategoryId",
                table: "Employee",
                newName: "EmployeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_EmployeeCategoryId",
                table: "Employee",
                newName: "IX_Employee_EmployeeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId",
                principalTable: "EmployeeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
