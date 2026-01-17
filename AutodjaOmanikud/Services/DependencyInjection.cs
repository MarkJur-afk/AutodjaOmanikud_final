using AutodjaOmanikud.Data;
using AutodjaOmanikud.Interfaces;
using AutodjaOmanikud.Models;
using AutodjaOmanikud.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AutodjaOmanikud.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // DbContext
            services.AddScoped<AutoDbContext>();
            
            // Repositories
            services.AddScoped<IRepository<Owner>, BaseRepository<Owner>>();
            services.AddScoped<IRepository<Car>, BaseRepository<Car>>();
            services.AddScoped<IRepository<Service>, BaseRepository<Service>>();
            services.AddScoped<IRepository<ServiceType>, BaseRepository<ServiceType>>();
            
            // Services
            services.AddScoped<ICarService, CarService>();
            
            return services;
        }
    }
}