using Backend.Vuelos.Repositories;
using Backend_Vuelos.Models;
using Backend_Vuelos.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Backend_Vuelos {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            //Configurar Base de datos y conexion
            services.Configure<ConcurrenciaDatabaseSettings>(Configuration.GetSection(nameof(ConcurrenciaDatabaseSettings)));
            services.AddSingleton<IConcurrenciaDatabaseSettings>(sp =>
            sp.GetRequiredService<IOptions<ConcurrenciaDatabaseSettings>>().Value);
            services.AddHttpClient<IDestinosRepositories, DestinosRepositories>(configuration => 
                            configuration.BaseAddress = new Uri("https://localhost:44369"));//esto va para los del grupo 1
            services.AddSingleton<OrigenesRepositories>();
            services.AddSingleton<VuelosRepositories>();
            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Backend_Vuelos", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Backend_Vuelos v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
