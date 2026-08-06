using Microsoft.EntityFrameworkCore;
using _4_august_practice.Models;

namespace _4_august_practice.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}