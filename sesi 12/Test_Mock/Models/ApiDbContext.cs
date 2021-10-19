using Microsoft.EntityFrameworkCore;
using Test_Mock.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Test_Mock.Data 
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