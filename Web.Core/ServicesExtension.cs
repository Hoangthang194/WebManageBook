using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Core.Core.Query;
using Web.Domain.Core;
using Web.Domain.Core.Command;
using Web.Domain.Core.Query;

namespace Web.Core
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServiceOfCore(this IServiceCollection services)
        {
            services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));
            services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
            return services;
        }
    }
}
