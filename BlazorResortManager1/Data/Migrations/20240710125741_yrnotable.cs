using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class yrnotable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "cityCodeId",
                table: "resort",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "yrNoCityCode",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yrNoCityCode", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resort_cityCodeId",
                table: "resort",
                column: "cityCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_resort_yrNoCityCode_cityCodeId",
                table: "resort",
                column: "cityCodeId",
                principalTable: "yrNoCityCode",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resort_yrNoCityCode_cityCodeId",
                table: "resort");

            migrationBuilder.DropTable(
                name: "yrNoCityCode");

            migrationBuilder.DropIndex(
                name: "IX_resort_cityCodeId",
                table: "resort");

            migrationBuilder.DropColumn(
                name: "cityCodeId",
                table: "resort");
        }
    }
}
