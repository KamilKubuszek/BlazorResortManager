using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class descforcameras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "camera",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "camera");
        }
    }
}
