using System;
using Contracts;
using LoggerService;

namespace Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(optons =>
    {
        optons.AddPolicy("CorsPolicy", builder =>
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
         .AllowAnyHeader());
    });

    public static void ConfigureIISIntergration(this IServiceCollection services) =>
    services.Configure<IISOptions>(options =>
    {

    });

    public static void ConfigureLoggerService(this IServiceCollection service) =>
    service.AddSingleton<ILoggerManager, LoggerManager>();
}
