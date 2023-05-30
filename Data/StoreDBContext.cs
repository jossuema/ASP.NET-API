using DemoTaller.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoTaller.Data
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
