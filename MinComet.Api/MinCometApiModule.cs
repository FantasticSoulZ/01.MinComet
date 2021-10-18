using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MinComet.Application;
using MinComet.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
//using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MinComet.Api
{
    [DependsOn(
        //typeof(AbpAutofacModule),
        typeof(AbpAspNetCoreMvcModule),
        typeof(MinCometEntityFrameworkCoreModule),
        typeof(MinCometApplicationModule)
        )]
    public class MinCometApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAspNetCoreMvcOptions>(options=> {
                options
                .ConventionalControllers
                .Create(typeof(MinCometApplicationModule).Assembly);
                //.Create(typeof(MinCometApplicationModule).Assembly,opts=> {
                   // opts.RootPath = "api/login";
                //});
            });

            var services = context.Services;
            // services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.1.2", new OpenApiInfo { Title = "MinComet", Version = "v1" });
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1.1.2/swagger.json", "MinComet v1"));
            }

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
