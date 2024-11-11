using Web.ApplicationService.Temp.Repository;
using Web.Domain;
using Web.Domain.Temp.Repository;

namespace Web.Infrastructure
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services) {
            services.AddSingleton<IConfigurationBuilder, ConfigurationBuilder>();
            services.AddSingleton<IDapperContext, DapperContext>();
            services.AddSingleton<IConnectionStringProvider, DbContextProvider>();
            return services;
        }
    }
}
