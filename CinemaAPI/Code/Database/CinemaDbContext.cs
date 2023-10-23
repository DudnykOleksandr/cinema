using Microsoft.EntityFrameworkCore;

namespace CinemaAPI.Code.Database
{
    public class CinemaDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public CinemaDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("Database"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().OwnsOne(
                entity => entity.ShowtimeSettings, ownedNavigationBuilder =>
                {
                    ownedNavigationBuilder.ToJson();
                });
        }

        public DbSet<Theater> Theaters { get; set; }
        public DbSet<TheaterHall> TheaterHalls { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
