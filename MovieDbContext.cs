using Microsoft.EntityFrameworkCore;
using MovieSite.Models;

namespace MovieSite
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}