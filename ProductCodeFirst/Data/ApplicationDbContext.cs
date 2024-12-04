using Microsoft.EntityFrameworkCore;
using ProductCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCodeFirst.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;database=Product;Trusted_Connection=true;TrustServerCertificate=True");
        }
        public DbSet<Product> Products { get; set; }
    }
}
