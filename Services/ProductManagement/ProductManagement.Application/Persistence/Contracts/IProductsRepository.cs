using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Contracts.Persistence
{
    public interface IProductsRepository: IGenericRepository<Product>
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetAllProductsById(Guid id);
    }
}
