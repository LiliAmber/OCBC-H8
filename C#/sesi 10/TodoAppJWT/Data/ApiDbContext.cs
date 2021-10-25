using Microsoft.EntityFrameworkCore;
using TodoAppJWT.Data;
using TodoAppJWT.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TodoAppJWT.Data 
{
    public class ApiDbContext : IdentityDbContext 
    {
        public virtual DbSet<ItemData> Items { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) 
            : base(options)
        {

        }
    }
}