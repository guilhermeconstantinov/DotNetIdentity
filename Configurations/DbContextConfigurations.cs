using DotNetIdentity.Infra;
using Microsoft.EntityFrameworkCore;

namespace DotNetIdentity.Configurations;

public static class DbContextConfigurations
{
    public static IServiceCollection AddDbContextConfiguration(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(config.GetConnectionString("DefaultConnection"))
        );

        return services;
    }
}
