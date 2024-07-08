using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "resort",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    address = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    email = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    webpage = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resort", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lift",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lift", x => x.id);
                    table.ForeignKey(
                        name: "FK_lift_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "permit",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permit", x => x.id);
                    table.ForeignKey(
                        name: "FK_permit_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_permit_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resortParameter",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resortParameter", x => x.id);
                    table.ForeignKey(
                        name: "FK_resortParameter_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "statusSheet",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    productionVersion = table.Column<bool>(type: "bit", nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statusSheet", x => x.id);
                    table.ForeignKey(
                        name: "FK_statusSheet_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "track",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_track", x => x.id);
                    table.ForeignKey(
                        name: "FK_track_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "liftParameter",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    liftId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liftParameter", x => x.id);
                    table.ForeignKey(
                        name: "FK_liftParameter_lift_liftId",
                        column: x => x.liftId,
                        principalTable: "lift",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "liftStatus",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    opened = table.Column<bool>(type: "bit", nullable: false),
                    parentLiftId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    statusSheetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liftStatus", x => x.id);
                    table.ForeignKey(
                        name: "FK_liftStatus_lift_parentLiftId",
                        column: x => x.parentLiftId,
                        principalTable: "lift",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_liftStatus_statusSheet_statusSheetId",
                        column: x => x.statusSheetId,
                        principalTable: "statusSheet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "resortStatus",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    opened = table.Column<bool>(type: "bit", nullable: false),
                    parentResortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    statusSheetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resortStatus", x => x.id);
                    table.ForeignKey(
                        name: "FK_resortStatus_resort_parentResortId",
                        column: x => x.parentResortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resortStatus_statusSheet_statusSheetId",
                        column: x => x.statusSheetId,
                        principalTable: "statusSheet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "trackParameter",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trackParameter", x => x.id);
                    table.ForeignKey(
                        name: "FK_trackParameter_track_trackId",
                        column: x => x.trackId,
                        principalTable: "track",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trackStatus",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    opened = table.Column<bool>(type: "bit", nullable: false),
                    snowGroomed = table.Column<bool>(type: "bit", nullable: false),
                    illuminated = table.Column<bool>(type: "bit", nullable: false),
                    parentTrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    statusSheetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trackStatus", x => x.id);
                    table.ForeignKey(
                        name: "FK_trackStatus_statusSheet_statusSheetId",
                        column: x => x.statusSheetId,
                        principalTable: "statusSheet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trackStatus_track_parentTrackId",
                        column: x => x.parentTrackId,
                        principalTable: "track",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lift_resortId",
                table: "lift",
                column: "resortId");

            migrationBuilder.CreateIndex(
                name: "IX_liftParameter_liftId",
                table: "liftParameter",
                column: "liftId");

            migrationBuilder.CreateIndex(
                name: "IX_liftStatus_parentLiftId",
                table: "liftStatus",
                column: "parentLiftId");

            migrationBuilder.CreateIndex(
                name: "IX_liftStatus_statusSheetId",
                table: "liftStatus",
                column: "statusSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_permit_ApplicationUserId",
                table: "permit",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_permit_resortId",
                table: "permit",
                column: "resortId");

            migrationBuilder.CreateIndex(
                name: "IX_resortParameter_resortId",
                table: "resortParameter",
                column: "resortId");

            migrationBuilder.CreateIndex(
                name: "IX_resortStatus_parentResortId",
                table: "resortStatus",
                column: "parentResortId");

            migrationBuilder.CreateIndex(
                name: "IX_resortStatus_statusSheetId",
                table: "resortStatus",
                column: "statusSheetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_statusSheet_resortId",
                table: "statusSheet",
                column: "resortId");

            migrationBuilder.CreateIndex(
                name: "IX_track_resortId",
                table: "track",
                column: "resortId");

            migrationBuilder.CreateIndex(
                name: "IX_trackParameter_trackId",
                table: "trackParameter",
                column: "trackId");

            migrationBuilder.CreateIndex(
                name: "IX_trackStatus_parentTrackId",
                table: "trackStatus",
                column: "parentTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_trackStatus_statusSheetId",
                table: "trackStatus",
                column: "statusSheetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "liftParameter");

            migrationBuilder.DropTable(
                name: "liftStatus");

            migrationBuilder.DropTable(
                name: "permit");

            migrationBuilder.DropTable(
                name: "resortParameter");

            migrationBuilder.DropTable(
                name: "resortStatus");

            migrationBuilder.DropTable(
                name: "trackParameter");

            migrationBuilder.DropTable(
                name: "trackStatus");

            migrationBuilder.DropTable(
                name: "lift");

            migrationBuilder.DropTable(
                name: "statusSheet");

            migrationBuilder.DropTable(
                name: "track");

            migrationBuilder.DropTable(
                name: "resort");
        }
    }
}
