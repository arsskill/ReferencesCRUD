using Application.Interfaces;
using DAL.MSSQL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MSSQL
{
    public static class DependencyInjection
    {
        public static void AddDalMSSQL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IReferencesRepository>(provider => new ReferencesRepository());
        }
    }
}
