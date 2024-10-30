using CidadeSemLimites.Domain;
using CidadeSemLimites.Domain.Repositories;
using CidadeSemLimites.Domain.Repositories.Feedback;
using CidadeSemLimites.Domain.Repositories.Posts;
using CidadeSemLimites.Domain.Repositories.Waypoints;
using CidadeSemLimites.Infrastructure.DataAccess;
using CidadeSemLimites.Infrastructure.Repositories;
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

            services.AddScoped<IUnitOfWork, UnityOfWork>();
        }
        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<IPostReadOnlyRepository, PostRepository>();
            services.AddScoped<IPostUpdateOnlyRepository, PostRepository>();
            services.AddScoped<IPostWriteOnlyRepository, PostRepository>();

            services.AddScoped<IWaypointsReadOnlyRepository, WaypointRepository>();
            services.AddScoped<IWaypointsUpdateRepository, WaypointRepository>();
            services.AddScoped<IWaypointWriteOnlyRepository, WaypointRepository>();

            services.AddScoped<IFeedbackReadOnlyRepository, FeedbackRepository>();
            services.AddScoped<IFeedbackUpdateOnlyRepository, FeedbackRepository>();
            services.AddScoped<IFeedbackWriteOnlyRepository, FeedbackRepository>();

        }
    }
}
