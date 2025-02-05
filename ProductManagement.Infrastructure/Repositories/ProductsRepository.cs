using ProductManagement.Application.Contracts.Persistence;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Infrastructure.Repositories
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        public Task<List<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAllProductsById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
