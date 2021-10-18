using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MinComet.Domain;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MinComet.EntityFrameworkCore
{
    [DependsOn(typeof(AbpEntityFrameworkCoreModule), typeof(MinCometDomainModule))]
    public class MinCometEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var services = context.Services;
            services.AddAbpDbContext<MinCometDbContext>(opt => {
                opt.AddDefaultRepositories(true);
            });
            //services.AddControllers();
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MinComet", Version = "v1" });
            //});

            Configure<AbpDbContextOptions>(opt =>
            {
                opt.UseSqlServer();
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            //var app = context.GetApplicationBuilder();
            //var env = context.GetEnvironment();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseSwagger();
            //    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MinComet v1"));
            //}

            //app.UseHttpsRedirection();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
        }
    }
}
