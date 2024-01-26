using Microsoft.EntityFrameworkCore.Migrations;
using SomDasAntigasWebApp.Models;

#nullable disable

namespace SomDasAntigasWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DiscDbContext();
            context.Genre.AddRange(GetInicialData());
            context.SaveChanges();
        }

        /// <inheritdoc />
        /// 
        private IList<Genre> GetInicialData()
        {
            return new List<Genre>()
            {
                new Genre(){GenreName = "Heavy Metal"},
                new Genre(){GenreName = "Rock"},
                new Genre(){GenreName = "MPB"},
                new Genre(){GenreName = "Dance"}



            };
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
