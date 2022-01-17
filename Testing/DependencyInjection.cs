using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing
{
    public static class DependencyInjection
    {
        public static void AddWebApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

        }

    }

   
}
