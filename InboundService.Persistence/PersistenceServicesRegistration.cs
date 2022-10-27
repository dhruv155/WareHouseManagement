using AutoMapper.Configuration;

using InboundService.Application.Persistence;
using InboundService.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Text;


namespace InboundService.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddDbContext<InboundDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("InboundConnectionString")));
            services.AddScoped(typeof(IGenereicRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;              
        }
    }
}
