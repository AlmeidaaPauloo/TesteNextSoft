using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TestePratico.src.Data;
using TestePratico.src.repositories;
using TestePratico.src.repositories.implementations;
using TestePratico.src.service;
using TestePratico.src.service.implementations;
using TestePredio.src.repositories.implementacoes;

namespace TestePratico
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
            services.AddCors();
            services.AddControllers();

            services.AddDbContext<TestePraticoContext>(
            opt => opt.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            services.AddScoped<ICondominio, CondominioRepositorie>();
            services.AddScoped<IMorador, MoradorRepositorie>();
            services.AddScoped<IFamilia, FamiliaRepositorie>();            

            services.AddTransient<ICondominioService, CondominioService>();
            services.AddTransient<IFamiliaService, FamiliaService>();
            //services.AddSwaggerGen(c => { c.SwaggerDoc("V1", new OpenApiInfo { Title = "TestePratico V1",Version = "v1", Description ="" }); });
            services.AddSwaggerGen();
        }       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestePratico V1"));        

            app.UseRouting();

            app.UseCors(c => c
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}