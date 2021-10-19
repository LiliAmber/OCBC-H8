using Microsoft.EntityFrameworkCore;
using Unit_Test_Mock.Models;
using MySql.EntityFrameworkCore;

namespace Unit_Test_Mock.Data 
{
    public class ApiDbContext : DbContext 
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) 
            : base(options)
        {

        }
    }
}