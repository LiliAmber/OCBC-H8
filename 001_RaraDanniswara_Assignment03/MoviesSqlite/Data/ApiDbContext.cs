using Microsoft.EntityFrameworkCore;
using MoviesSqlite.Models;

namespace MoviesSqlite.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<MoviesData> Movies {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
            
        }
    }
}