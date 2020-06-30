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

            #endregion

            #region Infraestructura

            services.AddScoped(typeof(Domain.Interfaces.Repository.IGenericRepository<>), typeof(Data.Repository.EntityFramework.IGenericRepository<>));
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IMascotaRepository, MascotaRepository>();

            #endregion
        }
    }
}
