using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classify.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAudioToPieceEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "AudioFile",
                table: "Pieces",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AudioFileContentType",
                table: "Pieces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AudioFileName",
                table: "Pieces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AudioFile", "AudioFileContentType", "AudioFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AudioFile", "AudioFileContentType", "AudioFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AudioFile", "AudioFileContentType", "AudioFileName" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AudioFile", "AudioFileContentType", "AudioFileName" },
                values: new object[] { null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudioFile",
                table: "Pieces");

            migrationBuilder.DropColumn(
                name: "AudioFileContentType",
                table: "Pieces");

            migrationBuilder.DropColumn(
                name: "AudioFileName",
                table: "Pieces");
        }
    }
}
