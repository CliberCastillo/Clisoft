using AutoMapper;
using Clisoft.Aplication.AutoMapper;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Aplication.Service.Entity;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.CrossCutting.IoC;
using Clisoft.Infraestructure.Data.Context;
using Clisoft.Infraestructure.Data.Repository.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Clisoft.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAutoMapper(c => c.AddProfile<MappingsProfile>(),typeof(Startup));

            services.AddDbContext<BDMemoryKingsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Conexion")));
            NativeInjectorBootStrapper.RegisterServices(services);

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
