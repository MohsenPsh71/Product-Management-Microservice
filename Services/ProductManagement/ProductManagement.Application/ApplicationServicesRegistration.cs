
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Application.Profiles;
using System.Reflection;

namespace ProductManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
