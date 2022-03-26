using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async(context ,next)=>
            //{
            //    await context.Response.WriteAsync("Hello From my first middleware.");
            //    await next();
            //    await context.Response.WriteAsync("Hello From my first middleware Response.");
            //});
            
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello From my second middleware.");
            //    await next();
            //    await context.Response.WriteAsync("Hello From my second middleware Response.");
            //});
            
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello From My Third Middleware.");
            //    await next();
            //});

            app.UseRouting();


            app.UseEndpoints(async endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    //await context.Response.WriteAsync(env.EnvironmentName);
                    if (env.IsDevelopment())
                    {
                        await context.Response.WriteAsync("Hello from Devlopment");
                    }

                    if (env.IsProduction())
                    {
                        await context.Response.WriteAsync("Hello from Production");
                    }

                    if (env.IsStaging())
                    {
                        await context.Response.WriteAsync("Hello from Staging");
                    }
                    else
                    {
                        await context.Response.WriteAsync(env.EnvironmentName);
                    }
                });
                
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/aniket", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Aniket!");
            //    });
            //});
        }
    }
}
