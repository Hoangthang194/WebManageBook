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
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Thời gian session hết hạn
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true; // Bắt buộc nếu bạn cần session trong môi trường GDPR
            });
            services.AddHttpContextAccessor();
            services.AddScoped<ISessionService, SessionService>();
            return services;
        }
    }
}
