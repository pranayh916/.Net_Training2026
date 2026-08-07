using Microsoft.EntityFrameworkCore;
using _6th_and_5th_August_Assignment.Models;

namespace _6th_and_5th_August_Assignment.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
    }
}