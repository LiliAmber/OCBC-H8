using Microsoft.EntityFrameworkCore;
using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Payment.Data 
{
    public class ApiDbContext : IdentityDbContext 
    {
        // public virtual DbSet<ItemData> Payments { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) 
            : base(options)
        {

        }
        public DbSet<ItemData> Payments {get; set;}
    }
}