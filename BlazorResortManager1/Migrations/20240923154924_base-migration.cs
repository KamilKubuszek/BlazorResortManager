using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class basemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "liftType",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    iconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liftType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "trackDifficulty",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trackDifficulty", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "widgetWhitelistedUrl",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    siteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_widgetWhitelistedUrl", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "YrNoCityCode",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YrNoCityCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resort",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    webpage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yrNoCityCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    approved = table.Column<bool>(type: "bit", nullable: false),
                    coordinatesX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    coordinatesY = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resort", x => x.id);
                    table.ForeignKey(
                        name: "FK_resort_YrNoCityCode_yrNoCityCodeId",
                        column: x => x.yrNoCityCodeId,
                        principalTable: "YrNoCityCode",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "camera",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_camera", x => x.id);
                    table.ForeignKey(
                        name: "FK_camera_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "lift",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    lengthMeters = table.Column<int>(type: "int", nullable: false),
                    estimatedDurationTimeMinutes = table.Column<int>(type: "int", nullable: false),
                    peoplePerHour = table.Column<int>(type: "int", nullable: false),
                    capacityPerSeat = table.Column<int>(type: "int", nullable: false),
                    liftTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lift", x => x.id);
                    table.ForeignKey(
                        name: "FK_lift_liftType_liftTypeId",
                        column: x => x.liftTypeId,
                        principalTable: "liftType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_lift_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "permit",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    resortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permit", x => x.id);
                    table.ForeignKey(
                        name: "FK_permit_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_permit_resort_resortId",
                        column: x => x.resortId,
                        principalTable: "resort",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "track",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    totalHeightMeters = table.Column<int>(type: "int", nullable: false),
                    inclination = table.Column<int>(type: "int", nullable: false),
                    illuminated = table.Column<bool>(type: "bit", nullable: false),
                    snowGroomed = table.Column<bool>(type: "bit", nullable: false),
                    marking = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    lengthMeters = table.Column<int>(type: "int", nullable: false),
                    trackDifficultyId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_track_trackDifficulty_trackDifficultyId",
                        column: x => x.trackDifficultyId,
                        principalTable: "trackDifficulty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cameraLiftBinding_lift_liftId",
                        column: x => x.liftId,
                        principalTable: "lift",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "liftStatus",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    opened = table.Column<bool>(type: "bit", nullable: false),
                    openingTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    closingTime = table.Column<TimeOnly>(type: "time", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
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
                    openingTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    closingTime = table.Column<TimeOnly>(type: "time", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_resortStatus_statusSheet_statusSheetId",
                        column: x => x.statusSheetId,
                        principalTable: "statusSheet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cameraTrackBinding_track_trackId",
                        column: x => x.trackId,
                        principalTable: "track",
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "trackStatus",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    opened = table.Column<bool>(type: "bit", nullable: false),
                    openingTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    closingTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    snowCover = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_camera_resortId",
                table: "camera",
                column: "resortId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraLiftBinding_cameraId",
                table: "cameraLiftBinding",
                column: "cameraId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraLiftBinding_liftId",
                table: "cameraLiftBinding",
                column: "liftId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraTrackBinding_cameraId",
                table: "cameraTrackBinding",
                column: "cameraId");

            migrationBuilder.CreateIndex(
                name: "IX_cameraTrackBinding_trackId",
                table: "cameraTrackBinding",
                column: "trackId");

            migrationBuilder.CreateIndex(
                name: "IX_lift_liftTypeId",
                table: "lift",
                column: "liftTypeId");

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
                name: "IX_permit_resortId",
                table: "permit",
                column: "resortId");

            migrationBuilder.CreateIndex(
                name: "IX_permit_userId",
                table: "permit",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_resort_yrNoCityCodeId",
                table: "resort",
                column: "yrNoCityCodeId");

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
                name: "IX_track_trackDifficultyId",
                table: "track",
                column: "trackDifficultyId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "cameraLiftBinding");

            migrationBuilder.DropTable(
                name: "cameraTrackBinding");

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
                name: "widgetWhitelistedUrl");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "camera");

            migrationBuilder.DropTable(
                name: "lift");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "statusSheet");

            migrationBuilder.DropTable(
                name: "track");

            migrationBuilder.DropTable(
                name: "liftType");

            migrationBuilder.DropTable(
                name: "resort");

            migrationBuilder.DropTable(
                name: "trackDifficulty");

            migrationBuilder.DropTable(
                name: "YrNoCityCode");
        }
    }
}
