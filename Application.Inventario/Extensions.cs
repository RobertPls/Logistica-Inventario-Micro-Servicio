using Domain.Inventario.Factories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application.Inventario
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IAlmacenFactory, AlmacenFactory>();
            services.AddScoped<IProductoFactory, ProductoFactory>();

            return services;
        }
    }
}
