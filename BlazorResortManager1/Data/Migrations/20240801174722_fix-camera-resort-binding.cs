using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class fixcameraresortbinding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cameraResortBinding");

            migrationBuilder.AddColumn<Guid>(
                name: "resortId",
                table: "camera",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_camera_resortId",
                table: "camera",
                column: "resortId");

            migrationBuilder.AddForeignKey(
                name: "FK_camera_resort_resortId",
                table: "camera",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_camera_resort_resortId",
                table: "camera");

            migrationBuilder.DropIndex(
                name: "IX_camera_resortId",
                table: "camera");

            migrationBuilder.DropColumn(
                name: "resortId",
                table: "camera");

            migrationBuilder.CreateTable(
                name: "cameraResortBinding",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cameraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cameraResortBinding", x => x.id);
                    table.ForeignKey(
                        name: "FK_cameraResortBinding_camera_cameraId",
                        column: x => x.cameraId,
                        principalTable: "camera",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cameraResortBinding_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cameraResortBinding_cameraId",
                table: "cameraResortBinding",
                column: "cameraId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraResortBinding_resortId",
                table: "cameraResortBinding",
                column: "resortId");
        }
    }
}
