using Application.UseCases.Reference;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            AddServices(services);
        }
        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<GetByNameUC>();
            services.AddScoped<GetByOrderReferencesUC>();
            services.AddScoped<GetByOrderReferencesUC>();
        }


    }
}
