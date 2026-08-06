using Microsoft.EntityFrameworkCore;
using _6th_August_Practice.Models;

namespace _6th_August_Practice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}