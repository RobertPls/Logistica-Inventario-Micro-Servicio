using Application.Inventario;
using Domain.Inventario.Repositories;
using Infrastructure.Inventario.EF.Config.Context;
using Infrastructure.Inventario.EF.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Inventario
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddApplication();
            services.AddDbContext<ReadDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("InventarioConnectionString"));
            });
            services.AddScoped<IAlmacenRepository, AlmacenRepository>();
            return services;
        }

        public static bool Contains(this string source, string toCheck,StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }

    }
}
