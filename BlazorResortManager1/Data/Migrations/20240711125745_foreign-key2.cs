using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class foreignkey2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resort_yrNoCityCode_yrNoCityCodeId",
                table: "resort");

            migrationBuilder.AlterColumn<Guid>(
                name: "yrNoCityCodeId",
                table: "resort",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_resort_yrNoCityCode_yrNoCityCodeId",
                table: "resort",
                column: "yrNoCityCodeId",
                principalTable: "yrNoCityCode",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resort_yrNoCityCode_yrNoCityCodeId",
                table: "resort");

            migrationBuilder.AlterColumn<Guid>(
                name: "yrNoCityCodeId",
                table: "resort",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_resort_yrNoCityCode_yrNoCityCodeId",
                table: "resort",
                column: "yrNoCityCodeId",
                principalTable: "yrNoCityCode",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
