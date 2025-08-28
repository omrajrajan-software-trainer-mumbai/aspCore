using Microsoft.EntityFrameworkCore;

namespace SportsStore_01.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
    }
}