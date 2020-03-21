using Microsoft.EntityFrameworkCore;
using HomeMeter.Models;

namespace HomeMeter.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<House> House { get; set; }
        public DbSet<Meter> Meter { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder .Entity<House>()
                    .HasIndex(x => new { x.Zip, x.Country, x.City, x.Street, x.Number }).IsUnique();

            builder.Entity<Meter>()
                    .HasOne(x => x.House)
                    .WithOne(x => x.Meter);
        }
    }
}
