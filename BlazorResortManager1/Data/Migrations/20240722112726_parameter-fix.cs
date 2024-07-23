using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class parameterfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "difficulty",
                table: "track",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "inclination",
                table: "track",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lengthMeters",
                table: "track",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "marking",
                table: "track",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "totalHeightMeters",
                table: "track",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "capacityPerSeat",
                table: "lift",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "estimatedDurationTimeMinutes",
                table: "lift",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lengthMeters",
                table: "lift",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "peoplePerHour",
                table: "lift",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "lift",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "difficulty",
                table: "track");

            migrationBuilder.DropColumn(
                name: "inclination",
                table: "track");

            migrationBuilder.DropColumn(
                name: "lengthMeters",
                table: "track");

            migrationBuilder.DropColumn(
                name: "marking",
                table: "track");

            migrationBuilder.DropColumn(
                name: "totalHeightMeters",
                table: "track");

            migrationBuilder.DropColumn(
                name: "capacityPerSeat",
                table: "lift");

            migrationBuilder.DropColumn(
                name: "estimatedDurationTimeMinutes",
                table: "lift");

            migrationBuilder.DropColumn(
                name: "lengthMeters",
                table: "lift");

            migrationBuilder.DropColumn(
                name: "peoplePerHour",
                table: "lift");

            migrationBuilder.DropColumn(
                name: "type",
                table: "lift");
        }
    }
}
