using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.ApplicationService.Temp.Repository;
using Web.Domain.Temp.Repository;
using Web.Domain;
using System.Reflection;
using Web.Domain.Core.Query;
using Web.Domain.Temp.Repository.Query;
using Web.ApplicationService.Temp.Repository.Query;
using Web.Domain.Temp.Repository.Command;
using Web.ApplicationService.Temp.Repository.Command;
using Web.Domain.Core.Command;

namespace Web.ApplicationService
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServiceOfApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.Scan(scan => scan
                    .FromAssemblyOf<TempCommandRepository>() // Chỉ định assembly chứa các class cần đăng ký
                    .AddClasses(classes => classes.AssignableTo(typeof(ICommandRepository<>))) // Tìm tất cả class implement ICommandRepository<>
                    .AsImplementedInterfaces() // Đăng ký các class đó theo interface mà chúng implement
                    .WithScopedLifetime()); // Đặt vòng đời là scoped
            services.Scan(scan => scan
                    .FromAssemblyOf<TempQueryRepository>() // Chỉ định assembly chứa các class cần đăng ký
                    .AddClasses(classes => classes.AssignableTo(typeof(IQueryRepository<>))) // Tìm tất cả class implement ICommandRepository<>
                    .AsImplementedInterfaces() // Đăng ký các class đó theo interface mà chúng implement
                    .WithScopedLifetime()); // Đặt vòng đời là scoped
            return services;
        }
    }
}
