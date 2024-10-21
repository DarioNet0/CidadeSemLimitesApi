using CidadeSemLimites.Application.AutoMapper;
using CidadeSemLimites.Application.UseCases.Posts.Add;
using CidadeSemLimites.Application.UseCases.Posts.GetAll;
using CidadeSemLimites.Application.UseCases.Posts.GetByDescription;
using CidadeSemLimites.Application.UseCases.Waypoints.Add;
using CidadeSemLimites.Application.UseCases.Waypoints.GetAll;
using Microsoft.Extensions.DependencyInjection;

namespace CidadeSemLimites.Application
{
    public static class ApplicationDependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddUseCase(services);
            AddMapper(services);
        }
        private static void AddUseCase(IServiceCollection services)
        {
            services.AddScoped<IAddPostUseCase, AddPostUseCase>();
            services.AddScoped<IGetAllPostsUseCase, GetAllPostsUseCase>();
            services.AddScoped<IGetPostByDescriptionUseCase, GetPostByDescriptionUseCase>();
            services.AddScoped<IAddWaypointUseCase, AddWaypointUseCase>();
            services.AddScoped<IGetAllWaypointsUseCase, GetAllWaypointsUseCase>();
        }
        private static void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }
    }
}
