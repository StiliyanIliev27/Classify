using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classify.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsAprovedPropToPublisherEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAproved",
                table: "Publishers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAproved",
                table: "Publishers");
        }
    }
}
