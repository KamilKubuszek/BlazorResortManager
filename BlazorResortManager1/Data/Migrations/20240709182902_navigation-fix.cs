using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class navigationfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_permit_AspNetUsers_ApplicationUserId",
                table: "permit");

            migrationBuilder.DropIndex(
                name: "IX_permit_ApplicationUserId",
                table: "permit");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "permit");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "permit",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_permit_userId",
                table: "permit",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_permit_AspNetUsers_userId",
                table: "permit",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_permit_AspNetUsers_userId",
                table: "permit");

            migrationBuilder.DropIndex(
                name: "IX_permit_userId",
                table: "permit");

            migrationBuilder.AlterColumn<Guid>(
                name: "userId",
                table: "permit",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "permit",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_permit_ApplicationUserId",
                table: "permit",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_permit_AspNetUsers_ApplicationUserId",
                table: "permit",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
