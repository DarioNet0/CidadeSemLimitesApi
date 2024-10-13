﻿using CidadeSemLimites.Application.AutoMapper;
using CidadeSemLimites.Application.UseCases.Posts.Add;
using CidadeSemLimites.Application.UseCases.Posts.GetAll;
using CidadeSemLimites.Application.UseCases.Posts.GetByDescription;
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
        }
        private static void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }
    }
}
