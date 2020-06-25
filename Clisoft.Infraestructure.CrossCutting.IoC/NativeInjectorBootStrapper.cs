using Clisoft.Aplication.Interface.Entity;
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
            //services.AddScoped<IEFRepository, EFRepository>();
            services.AddScoped<ICargoAppService, CargoAppService>();
            services.AddScoped<ICargoRepository, CargoRepository>();
        }
    }
}
