using CS_EntityFramework_SimpleAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CS_EntityFramework_SimpleAPI.Repositories.DBContexts
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        // Data set definition
        public DbSet<Student> Students { get; set; }
    }
}
