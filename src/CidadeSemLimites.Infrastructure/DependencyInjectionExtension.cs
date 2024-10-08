using CidadeSemLimites.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CidadeSemLimites.Infrastructure
{
    public static class DependencyInjectionExtension
    { 
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddRepository(services);
        }
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("Connection")!;
            services.AddDbContext<CidadeSemLimitesDbContext>(config => config.UseSqlServer(connectionString));
        }
        private static void AddRepository(IServiceCollection services)
        {

        }
    }
}
