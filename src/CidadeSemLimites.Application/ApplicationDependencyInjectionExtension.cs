using CidadeSemLimites.Application.AutoMapper;
using CidadeSemLimites.Application.UseCases.Posts.Add;
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
        }
        private static void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }
    }
}
