using Dapper.Application.Application;
using Dapper.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Service
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //====================== 1. ChildServices ======================
            services.AddTransient<IContactRepository, ContactRepository>();

            //====================== 2. UnitOfWork ======================
            /* 
             to use  UnitOf Work  need all Above  Servicies
            */
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
