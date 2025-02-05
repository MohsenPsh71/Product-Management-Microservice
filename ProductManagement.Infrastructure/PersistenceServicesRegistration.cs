
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Application.Contracts.Persistence;
using ProductManagement.Infrastructure.Persistence;
using ProductManagement.Infrastructure.Repositories;

namespace ProductManagement.Infrastructure
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ProductManagementDbContext>(options =>
            {
                options.UseSqlServer(configuration
                    .GetConnectionString("ProductManagementConnectionString"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IProductsRepository, ProductsRepository>();

            return services;
        }
    }

}
