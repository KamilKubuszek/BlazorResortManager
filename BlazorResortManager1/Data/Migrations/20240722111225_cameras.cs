using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class cameras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "camera",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_camera", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cameraLiftBinding",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    liftId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cameraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cameraLiftBinding", x => x.id);
                    table.ForeignKey(
                        name: "FK_cameraLiftBinding_camera_cameraId",
                        column: x => x.cameraId,
                        principalTable: "camera",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cameraLiftBinding_lift_liftId",
                        column: x => x.liftId,
                        principalTable: "lift",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cameraResortBinding",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cameraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cameraResortBinding", x => x.id);
                    table.ForeignKey(
                        name: "FK_cameraResortBinding_camera_cameraId",
                        column: x => x.cameraId,
                        principalTable: "camera",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cameraResortBinding_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cameraTrackBinding",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    trackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cameraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cameraTrackBinding", x => x.id);
                    table.ForeignKey(
                        name: "FK_cameraTrackBinding_camera_cameraId",
                        column: x => x.cameraId,
                        principalTable: "camera",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cameraTrackBinding_track_trackId",
                        column: x => x.trackId,
                        principalTable: "track",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cameraLiftBinding_cameraId",
                table: "cameraLiftBinding",
                column: "cameraId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraLiftBinding_liftId",
                table: "cameraLiftBinding",
                column: "liftId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraResortBinding_cameraId",
                table: "cameraResortBinding",
                column: "cameraId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraResortBinding_resortId",
                table: "cameraResortBinding",
                column: "resortId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraTrackBinding_cameraId",
                table: "cameraTrackBinding",
                column: "cameraId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraTrackBinding_trackId",
                table: "cameraTrackBinding",
                column: "trackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cameraLiftBinding");

            migrationBuilder.DropTable(
                name: "cameraResortBinding");

            migrationBuilder.DropTable(
                name: "cameraTrackBinding");

            migrationBuilder.DropTable(
                name: "camera");
        }
    }
}
