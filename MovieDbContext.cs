using Microsoft.EntityFrameworkCore;
using MovieSite.Models;

namespace MovieSite
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=movie.db");
        }
    }
}