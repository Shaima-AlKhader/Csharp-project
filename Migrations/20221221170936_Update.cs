using Microsoft.EntityFrameworkCore.Migrations;

namespace M11LabShaymaa.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "SongName",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "SId",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Songs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentAlbumAlbumId",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentSingerSingerId",
                table: "Albums",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ParentAlbumAlbumId",
                table: "Songs",
                column: "ParentAlbumAlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ParentSingerSingerId",
                table: "Albums",
                column: "ParentSingerSingerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Singers_ParentSingerSingerId",
                table: "Albums",
                column: "ParentSingerSingerId",
                principalTable: "Singers",
                principalColumn: "SingerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_ParentAlbumAlbumId",
                table: "Songs",
                column: "ParentAlbumAlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Singers_ParentSingerSingerId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ParentSingerSingerId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ParentSingerSingerId",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "AId",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SongName",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SId",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
