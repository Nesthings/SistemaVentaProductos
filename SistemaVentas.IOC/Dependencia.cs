using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.DAL.Interfaces;
using SistemaVentas.DAL.Implementacion;
using SistemaVentas.BLL.Interfaces;
using SistemaVentas.BLL.Implementacion;
using SistemaVenta.BLL.Implementacion;


namespace SistemaVentas.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBVentasContext>(options =>
            {   
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));

            });


            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IVentaRepository, VentaRepository>();

            services.AddScoped<ICorreoService, CorreoService>();

            services.AddScoped<IFirebaseService, FirebaseService>();

            services.AddScoped<IUtilidadesService, UtilidadesService>();

            services.AddScoped<IRolService, RolService>();

            services.AddScoped<IUsuarioService, UsuarioService>();
        }

    }
}
