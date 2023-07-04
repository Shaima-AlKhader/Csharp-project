using Microsoft.EntityFrameworkCore.Migrations;

namespace M11LabShaymaa.Migrations
{
    public partial class UpdateKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Singers_ParentSingerSingerId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Singers",
                table: "Singers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ParentSingerSingerId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "SongId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "SingerId",
                table: "Singers");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ParentSingerSingerId",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Songs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Songs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Singers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Albums",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SingerId",
                table: "Albums",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Singers",
                table: "Singers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_SingerId",
                table: "Albums",
                column: "SingerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Singers_SingerId",
                table: "Albums",
                column: "SingerId",
                principalTable: "Singers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Singers_SingerId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Singers",
                table: "Singers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_SingerId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Singers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "SingerId",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "SongId",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ParentAlbumAlbumId",
                table: "Songs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SingerId",
                table: "Singers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ParentSingerSingerId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "SongId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Singers",
                table: "Singers",
                column: "SingerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "AlbumId");

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
    }
}
