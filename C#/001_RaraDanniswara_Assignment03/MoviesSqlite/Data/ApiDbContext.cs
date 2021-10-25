using Microsoft.EntityFrameworkCore;
using MoviesSqlite.Models;
using MoviesSqlite.Data;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MoviesSqlite.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<MoviesData> Movies {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
            
        }
    }
}