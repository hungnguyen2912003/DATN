using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Fixmistakeintreatmentmethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentMethod_Department_DepartmentId",
                table: "TreatmentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentMethod_Room_RoomId",
                table: "TreatmentMethod");

            migrationBuilder.DropIndex(
                name: "IX_TreatmentMethod_RoomId",
                table: "TreatmentMethod");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "TreatmentMethod");

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartmentId",
                table: "TreatmentMethod",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentMethod_Department_DepartmentId",
                table: "TreatmentMethod",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentMethod_Department_DepartmentId",
                table: "TreatmentMethod");

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartmentId",
                table: "TreatmentMethod",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "TreatmentMethod",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentMethod_RoomId",
                table: "TreatmentMethod",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentMethod_Department_DepartmentId",
                table: "TreatmentMethod",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentMethod_Room_RoomId",
                table: "TreatmentMethod",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id");
        }
    }
}
