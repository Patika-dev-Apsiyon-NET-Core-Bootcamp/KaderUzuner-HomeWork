using HomeWork.Application.Interface;
using HomeWork.Application.Services;
using HomeWork.Domain.Interfaces;
using HomeWork.Infrastructure.Data.Context;
using HomeWork.Infrastructure.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Application.DependencyResolvers
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HomeWorkDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IFoodService, FoodService>();
            services.AddScoped<ICategoryService, CategoryService>();


            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            return services;
        }
    }
}
