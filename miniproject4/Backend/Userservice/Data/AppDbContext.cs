using Microsoft.EntityFrameworkCore;
using Userservice.Models;
namespace Userservice.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }
        public DbSet<User> Users
        {
            get;set;
        }
    }
}
