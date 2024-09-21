using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class wholeThing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resortAdditionRequest");

            migrationBuilder.DropColumn(
                name: "difficulty",
                table: "track");

            migrationBuilder.DropColumn(
                name: "type",
                table: "lift");

            migrationBuilder.AddColumn<int>(
                name: "trackDifficultyId",
                table: "track",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "webpage",
                table: "resort",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "resort",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "resort",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "resort",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "resort",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "resort",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<Guid>(
                name: "liftTypeId",
                table: "lift",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("633BF586-1962-460B-BB0D-429C6D563648"));

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
            ////////////////////////////////////////////////////
            migrationBuilder.InsertData(
               table: "liftType",
               columns: new[] { "id", "name", "iconUrl" },
               values: new object[,]
               {
                    { "633BF586-1962-460B-BB0D-429C6D563648", "T-bar", "not linked" },
                    { "77AE795E-B74C-40ED-9185-5839053A5542", "Gondola", "not linked" },
                    { "0B842C92-B2FE-4901-BCD9-DD7AC21E9E8C", "Chairlift", "not linked" }
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
            migrationBuilder.InsertData(
                table: "trackDifficulty",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { "0", "Easy" },
                    { "1", "Intermediate" },
                    { "2", "Hard" }
            });

            migrationBuilder.CreateIndex(
                name: "IX_track_trackDifficultyId",
                table: "track",
                column: "trackDifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_lift_liftTypeId",
                table: "lift",
                column: "liftTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_lift_liftType_liftTypeId",
                table: "lift",
                column: "liftTypeId",
                principalTable: "liftType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_track_trackDifficulty_trackDifficultyId",
                table: "track",
                column: "trackDifficultyId",
                principalTable: "trackDifficulty",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            


            

            migrationBuilder.Sql("UPDATE track SET trackDifficultyId = 0");
            migrationBuilder.Sql("UPDATE lift SET liftTypeId = '633BF586-1962-460B-BB0D-429C6D563648'");

        }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lift_liftType_liftTypeId",
                table: "lift");

            migrationBuilder.DropForeignKey(
                name: "FK_track_trackDifficulty_trackDifficultyId",
                table: "track");

            migrationBuilder.DropTable(
                name: "liftType");

            migrationBuilder.DropTable(
                name: "trackDifficulty");

            migrationBuilder.DropIndex(
                name: "IX_track_trackDifficultyId",
                table: "track");

            migrationBuilder.DropIndex(
                name: "IX_lift_liftTypeId",
                table: "lift");

            migrationBuilder.DropColumn(
                name: "trackDifficultyId",
                table: "track");

            migrationBuilder.DropColumn(
                name: "liftTypeId",
                table: "lift");

            migrationBuilder.AddColumn<string>(
                name: "difficulty",
                table: "track",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "webpage",
                table: "resort",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "resort",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "resort",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "resort",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "resort",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "resort",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "lift",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "resortAdditionRequest",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    approved = table.Column<bool>(type: "bit", nullable: false),
                    coordinatesX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    coordinatesY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resortAdditionRequest", x => x.id);
                    table.ForeignKey(
                        name: "FK_resortAdditionRequest_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resortAdditionRequest_userId",
                table: "resortAdditionRequest",
                column: "userId");
        }
    }
}
