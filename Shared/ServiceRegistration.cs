using Application.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Shared.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
        }
    }
}
