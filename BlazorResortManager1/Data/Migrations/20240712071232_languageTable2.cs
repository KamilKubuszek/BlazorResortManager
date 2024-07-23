using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class languageTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yrNoCityCode_YrNoLanguageCode_yrNoLanguageCodeId",
                table: "yrNoCityCode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_YrNoLanguageCode",
                table: "YrNoLanguageCode");

            migrationBuilder.RenameTable(
                name: "YrNoLanguageCode",
                newName: "yrNoLanguageCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yrNoLanguageCode",
                table: "yrNoLanguageCode",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_yrNoCityCode_yrNoLanguageCode_yrNoLanguageCodeId",
                table: "yrNoCityCode",
                column: "yrNoLanguageCodeId",
                principalTable: "yrNoLanguageCode",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yrNoCityCode_yrNoLanguageCode_yrNoLanguageCodeId",
                table: "yrNoCityCode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_yrNoLanguageCode",
                table: "yrNoLanguageCode");

            migrationBuilder.RenameTable(
                name: "yrNoLanguageCode",
                newName: "YrNoLanguageCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YrNoLanguageCode",
                table: "YrNoLanguageCode",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_yrNoCityCode_YrNoLanguageCode_yrNoLanguageCodeId",
                table: "yrNoCityCode",
                column: "yrNoLanguageCodeId",
                principalTable: "YrNoLanguageCode",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
