using CarAdvisor.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CarAdvisor.API.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; } = null!;
    }
}
