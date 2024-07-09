using Microsoft.EntityFrameworkCore;
using WebApplication1.models;

namespace WebApplication1.data
{
    public class appdbcontext : DbContext
    {
        public DbSet<personel> Personeller { get; set; }

        public appdbcontext(DbContextOptions<appdbcontext> options) : base(options)
        {
        }
    }
}
