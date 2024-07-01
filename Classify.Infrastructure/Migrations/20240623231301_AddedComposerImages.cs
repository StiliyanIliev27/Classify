using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classify.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedComposerImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Composers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/6/6a/Johann_Sebastian_Bach.jpg");

            migrationBuilder.UpdateData(
                table: "Composers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/Wolfgang-amadeus-mozart_1.jpg/800px-Wolfgang-amadeus-mozart_1.jpg");

            migrationBuilder.UpdateData(
                table: "Composers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://media.wnyc.org/i/1395/1860/l/80/1/Chopin.jpeg");

            migrationBuilder.UpdateData(
                table: "Composers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Joseph_Karl_Stieler%27s_Beethoven_mit_dem_Manuskript_der_Missa_solemnis.jpg/1200px-Joseph_Karl_Stieler%27s_Beethoven_mit_dem_Manuskript_der_Missa_solemnis.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Composers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Composers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Composers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Composers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "");
        }
    }
}
