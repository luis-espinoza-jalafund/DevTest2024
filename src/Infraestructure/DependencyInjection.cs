using DevTest.Repositories;
using DevTest.Repositories.Interfaces;
using DevTest.Services;

namespace DevTest.Infraestructure;

public static class DependencyInjection
{
    public static IServiceCollection AddLocalInfraestructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddLocalRepositories()
            .AddLocalServices();
        return services;

    }
    

    public static IServiceCollection AddDbInfraestructure(this IServiceCollection services, IConfiguration configuration)
    {
         return services;

    }

    public static IServiceCollection AddLocalRepositories(this IServiceCollection services)
    {
        services.AddSingleton<ILocalPollsRepository, LocalPollRepository>();
        return services;
    }

        public static IServiceCollection AddLocalServices(this IServiceCollection services)
    {
        services.AddScoped<ILocalPollServices, LocalPollServices>();
        return services;
    }


}