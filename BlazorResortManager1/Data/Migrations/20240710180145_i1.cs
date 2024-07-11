using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class i1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resort_yrNoCityCode_yrNoCityCodeId",
                table: "resort");

            migrationBuilder.DropIndex(
                name: "IX_resort_yrNoCityCodeId",
                table: "resort");

            migrationBuilder.DropColumn(
                name: "yrNoCityCodeId",
                table: "resort");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "yrNoCityCodeId",
                table: "resort",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_resort_yrNoCityCodeId",
                table: "resort",
                column: "yrNoCityCodeId");

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
