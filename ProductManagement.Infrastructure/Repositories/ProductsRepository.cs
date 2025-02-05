using Microsoft.EntityFrameworkCore;
using ProductManagement.Application.Contracts.Persistence;
using ProductManagement.Domain.Entities;
using ProductManagement.Infrastructure.Persistence;

namespace ProductManagement.Infrastructure.Repositories
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        private readonly ProductManagementDbContext _dbContext;
        public ProductsRepository(ProductManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var products = await _dbContext.Product.ToListAsync();
            return products;
        }

        public async Task<Product> GetAllProductsById(Guid id)
        {
            var products = await _dbContext.Product.FirstOrDefaultAsync(l => l.Id == id);
            return products;
        }
    }
}
