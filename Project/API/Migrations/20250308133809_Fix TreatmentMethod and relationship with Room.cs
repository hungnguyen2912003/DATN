using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class FixTreatmentMethodandrelationshipwithRoom : Migration
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

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "TreatmentMethod",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartmentId",
                table: "TreatmentMethod",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "TreatmentMethodId",
                table: "Room",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Room_TreatmentMethodId",
                table: "Room",
                column: "TreatmentMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_TreatmentMethod_TreatmentMethodId",
                table: "Room",
                column: "TreatmentMethodId",
                principalTable: "TreatmentMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_TreatmentMethod_TreatmentMethodId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentMethod_Department_DepartmentId",
                table: "TreatmentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentMethod_Room_RoomId",
                table: "TreatmentMethod");

            migrationBuilder.DropIndex(
                name: "IX_Room_TreatmentMethodId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "TreatmentMethodId",
                table: "Room");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "TreatmentMethod",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentMethod_Room_RoomId",
                table: "TreatmentMethod",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
