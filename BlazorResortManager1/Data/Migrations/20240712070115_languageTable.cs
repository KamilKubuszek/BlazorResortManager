using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class languageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "yrNoLanguageCodeId",
                table: "yrNoCityCode",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "YrNoLanguageCode",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YrNoLanguageCode", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_yrNoCityCode_yrNoLanguageCodeId",
                table: "yrNoCityCode",
                column: "yrNoLanguageCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_yrNoCityCode_YrNoLanguageCode_yrNoLanguageCodeId",
                table: "yrNoCityCode",
                column: "yrNoLanguageCodeId",
                principalTable: "YrNoLanguageCode",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yrNoCityCode_YrNoLanguageCode_yrNoLanguageCodeId",
                table: "yrNoCityCode");

            migrationBuilder.DropTable(
                name: "YrNoLanguageCode");

            migrationBuilder.DropIndex(
                name: "IX_yrNoCityCode_yrNoLanguageCodeId",
                table: "yrNoCityCode");

            migrationBuilder.DropColumn(
                name: "yrNoLanguageCodeId",
                table: "yrNoCityCode");
        }
    }
}
