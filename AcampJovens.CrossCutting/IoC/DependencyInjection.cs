using AcampJovens.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AcampJovens.CrossCutting.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
        string? server = Environment.GetEnvironmentVariable("DB_SERVER") ??
                         configuration.GetSection("DATABASE")["SERVER"];
        
        string? port = Environment.GetEnvironmentVariable("DB_PORT") ??
                       configuration.GetSection("DATABASE")["PORT"];
        
        string? database = Environment.GetEnvironmentVariable("DB_NAME") ??
                           configuration.GetSection("DATABASE")["NAME"];
        
        string? user = Environment.GetEnvironmentVariable("DB_USER") ??
                       configuration.GetSection("DATABASE")["USER"];
        
        string? password = Environment.GetEnvironmentVariable("DB_PASSWORD") ??
                           configuration.GetSection("DATABASE")["PASSWORD"];
        
        string connectionString = $"Host={server};" +
                                  $"Port={port};" +
                                  $"Pooling=true;" +
                                  $"Database={database};" +
                                  $"User Id={user};" +
                                  $"Password={password};";

        services.AddDbContext<AcampJovensDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        return services;
    }
}