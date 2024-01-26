using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SomDasAntigasWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addRelationshipDisc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Disc",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disc_GenreId",
                table: "Disc",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disc_Genre_GenreId",
                table: "Disc",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disc_Genre_GenreId",
                table: "Disc");

            migrationBuilder.DropIndex(
                name: "IX_Disc_GenreId",
                table: "Disc");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Disc");
        }
    }
}
