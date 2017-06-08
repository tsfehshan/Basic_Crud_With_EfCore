using Basic_Crud_With_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud_With_EFCore.Utilities
{
    public class MSSQLDbContext : DbContext
    {
        public MSSQLDbContext(DbContextOptions<MSSQLDbContext> options) : base(options)  
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
        }

        public DbSet<Product> Products { get; set; }
    }
}
