using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SomDasAntigasWebApp.Models;

namespace SomDasAntigasWebApp.Data
{
    public class DiscDbContext : IdentityDbContext
    {
        public DbSet<Disc> Disc { get; set; }
        public DbSet<Genre> Genre { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var stringConn = config.GetConnectionString("StringConn");
            optionsBuilder.UseSqlServer(stringConn);
        }
    }
}
