using Microsoft.EntityFrameworkCore;
using ModernProducts.Models;

namespace ModernProducts.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}