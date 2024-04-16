using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SistemaMedico.BunisessLogic.Services;
using SistemaMedico.DataAcces;
using SistemaMedico.DataAcces.Repository;

namespace SistemaMedico.BunisessLogic
{
    public static class ServicesConfiguration
    {
        public static void DataAccess(this IServiceCollection service, string conn)
        {
            service.AddScoped<RolesRepository>();
            SistemaMedicoContext.BuildConnectionString(conn);

        }

        public static void BusinessLogic(this IServiceCollection service)
        {
            service.AddScoped<AccesoService>();

        }
    }
}
