using EF.Models;
using Microsoft.EntityFrameworkCore;
namespace EF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}
