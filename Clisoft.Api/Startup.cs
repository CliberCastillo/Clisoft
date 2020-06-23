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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingsProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddDbContext<BDMemoryKingsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Conexion")));
            NativeInjectorBootStrapper.RegisterServices(services);
            services.AddScoped<IRolAppService, RolAppService>();
            services.AddScoped<IRolRepository, RolRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
