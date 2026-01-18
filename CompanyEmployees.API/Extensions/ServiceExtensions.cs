using System;
using System.Net;
using CompanyEmployees.Domain.Interfaces;
using CompanyEmployees.Infrastructure.Logging;
using CompanyEmployees.Infrastructure.Persistence;
using CompanyEmployees.Infrastructure.Repository;
using CompanyEmployees.Application.Interfaces;
using CompanyEmployees.Application.Services;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader());
        });

    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
            
        });

    
     public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            // Configure EF Core PostgreSQL
            services.AddDbContext<CompanyEmployeeDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddSingleton<ILoggerManager, LoggerManager>();

            return services;
        }

    public static void ConfigureRepositoryManager(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryManager, RepositoryManager>();
    }

    public static void ConfigureServiceManager(this IServiceCollection services)
    {
        services.AddScoped<IServiceManager, ServiceManager>();
    }
}
