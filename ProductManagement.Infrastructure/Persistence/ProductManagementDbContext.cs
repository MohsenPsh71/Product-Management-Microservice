
using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Infrastructure.Persistence
{
    internal class ProductManagementDbContext : DbContext
    {
        public ProductManagementDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }
}
