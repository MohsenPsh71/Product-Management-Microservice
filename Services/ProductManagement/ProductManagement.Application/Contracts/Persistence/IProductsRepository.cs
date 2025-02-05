using ProductManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Contracts.Persistence
{
    public interface IProductsRepository: IGenericRepository<Product>
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetAllProductsById(int id);
    }
}
