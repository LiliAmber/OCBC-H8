using Microsoft.EntityFrameworkCore;  
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Payment.Models;  
  
namespace Payment.Data  
{  
    public class PostgreSqlContext: DbContext  
    {  
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)  
        {  
        }  
  
        public DbSet<ItemData> payments { get; set; }  
  
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }  
  
        public override int SaveChanges()  
        {  
            ChangeTracker.DetectChanges();  
            return base.SaveChanges();  
        }  
    }  
}  