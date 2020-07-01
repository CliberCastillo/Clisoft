using Clisoft.Aplication.Interface;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Aplication.Service;
using Clisoft.Aplication.Service.Entity;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Repository.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Clisoft.Infraestructure.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Aplicacion

            services.AddScoped(typeof(IBaseAppService<,>), typeof(BaseAppService<,>));
            services.AddScoped<ICargoAppService, CargoAppService>();
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
            services.AddScoped<IMascotaAppService, MascotaAppService>();
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IPerfilAppService, PerfilAppService>();
            services.AddScoped<IEmpleadoAppService, EmpleadoAppService>();

            #endregion

            #region Infraestructura

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IMascotaRepository, MascotaRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();

            #endregion
        }
    }
}
