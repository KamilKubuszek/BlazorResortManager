using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    /// <inheritdoc />
    public partial class deletebehaviourchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cameraLiftBinding_camera_cameraId",
                table: "cameraLiftBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraLiftBinding_lift_liftId",
                table: "cameraLiftBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraResortBinding_camera_cameraId",
                table: "cameraResortBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraResortBinding_resort_resortId",
                table: "cameraResortBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraTrackBinding_camera_cameraId",
                table: "cameraTrackBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraTrackBinding_track_trackId",
                table: "cameraTrackBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_lift_resort_resortId",
                table: "lift");

            migrationBuilder.DropForeignKey(
                name: "FK_liftParameter_lift_liftId",
                table: "liftParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_liftStatus_lift_parentLiftId",
                table: "liftStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_permit_AspNetUsers_userId",
                table: "permit");

            migrationBuilder.DropForeignKey(
                name: "FK_permit_resort_resortId",
                table: "permit");

            migrationBuilder.DropForeignKey(
                name: "FK_resortParameter_resort_resortId",
                table: "resortParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_resortStatus_resort_parentResortId",
                table: "resortStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_statusSheet_resort_resortId",
                table: "statusSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_track_resort_resortId",
                table: "track");

            migrationBuilder.DropForeignKey(
                name: "FK_trackParameter_track_trackId",
                table: "trackParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_trackStatus_track_parentTrackId",
                table: "trackStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_cameraLiftBinding_camera_cameraId",
                table: "cameraLiftBinding",
                column: "cameraId",
                principalTable: "camera",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraLiftBinding_lift_liftId",
                table: "cameraLiftBinding",
                column: "liftId",
                principalTable: "lift",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraResortBinding_camera_cameraId",
                table: "cameraResortBinding",
                column: "cameraId",
                principalTable: "camera",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraResortBinding_resort_resortId",
                table: "cameraResortBinding",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraTrackBinding_camera_cameraId",
                table: "cameraTrackBinding",
                column: "cameraId",
                principalTable: "camera",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraTrackBinding_track_trackId",
                table: "cameraTrackBinding",
                column: "trackId",
                principalTable: "track",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_lift_resort_resortId",
                table: "lift",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_liftParameter_lift_liftId",
                table: "liftParameter",
                column: "liftId",
                principalTable: "lift",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_liftStatus_lift_parentLiftId",
                table: "liftStatus",
                column: "parentLiftId",
                principalTable: "lift",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_permit_AspNetUsers_userId",
                table: "permit",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_permit_resort_resortId",
                table: "permit",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_resortParameter_resort_resortId",
                table: "resortParameter",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_resortStatus_resort_parentResortId",
                table: "resortStatus",
                column: "parentResortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_statusSheet_resort_resortId",
                table: "statusSheet",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_track_resort_resortId",
                table: "track",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_trackParameter_track_trackId",
                table: "trackParameter",
                column: "trackId",
                principalTable: "track",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_trackStatus_track_parentTrackId",
                table: "trackStatus",
                column: "parentTrackId",
                principalTable: "track",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cameraLiftBinding_camera_cameraId",
                table: "cameraLiftBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraLiftBinding_lift_liftId",
                table: "cameraLiftBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraResortBinding_camera_cameraId",
                table: "cameraResortBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraResortBinding_resort_resortId",
                table: "cameraResortBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraTrackBinding_camera_cameraId",
                table: "cameraTrackBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_cameraTrackBinding_track_trackId",
                table: "cameraTrackBinding");

            migrationBuilder.DropForeignKey(
                name: "FK_lift_resort_resortId",
                table: "lift");

            migrationBuilder.DropForeignKey(
                name: "FK_liftParameter_lift_liftId",
                table: "liftParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_liftStatus_lift_parentLiftId",
                table: "liftStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_permit_AspNetUsers_userId",
                table: "permit");

            migrationBuilder.DropForeignKey(
                name: "FK_permit_resort_resortId",
                table: "permit");

            migrationBuilder.DropForeignKey(
                name: "FK_resortParameter_resort_resortId",
                table: "resortParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_resortStatus_resort_parentResortId",
                table: "resortStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_statusSheet_resort_resortId",
                table: "statusSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_track_resort_resortId",
                table: "track");

            migrationBuilder.DropForeignKey(
                name: "FK_trackParameter_track_trackId",
                table: "trackParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_trackStatus_track_parentTrackId",
                table: "trackStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_cameraLiftBinding_camera_cameraId",
                table: "cameraLiftBinding",
                column: "cameraId",
                principalTable: "camera",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraLiftBinding_lift_liftId",
                table: "cameraLiftBinding",
                column: "liftId",
                principalTable: "lift",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraResortBinding_camera_cameraId",
                table: "cameraResortBinding",
                column: "cameraId",
                principalTable: "camera",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraResortBinding_resort_resortId",
                table: "cameraResortBinding",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraTrackBinding_camera_cameraId",
                table: "cameraTrackBinding",
                column: "cameraId",
                principalTable: "camera",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cameraTrackBinding_track_trackId",
                table: "cameraTrackBinding",
                column: "trackId",
                principalTable: "track",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_lift_resort_resortId",
                table: "lift",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_liftParameter_lift_liftId",
                table: "liftParameter",
                column: "liftId",
                principalTable: "lift",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_liftStatus_lift_parentLiftId",
                table: "liftStatus",
                column: "parentLiftId",
                principalTable: "lift",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_permit_AspNetUsers_userId",
                table: "permit",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_permit_resort_resortId",
                table: "permit",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_resortParameter_resort_resortId",
                table: "resortParameter",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_resortStatus_resort_parentResortId",
                table: "resortStatus",
                column: "parentResortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_statusSheet_resort_resortId",
                table: "statusSheet",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_track_resort_resortId",
                table: "track",
                column: "resortId",
                principalTable: "resort",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trackParameter_track_trackId",
                table: "trackParameter",
                column: "trackId",
                principalTable: "track",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trackStatus_track_parentTrackId",
                table: "trackStatus",
                column: "parentTrackId",
                principalTable: "track",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
