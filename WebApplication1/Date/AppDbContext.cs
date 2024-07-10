using Microsoft.EntityFrameworkCore;
using WebApplication1.models;

namespace WebApplication1.data
{
    public class AppDbContext : DbContext
    {
        public DbSet<personel> Personeller { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
