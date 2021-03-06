﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TsSharp.Models;
using TsSharp.Data;

namespace TsSharp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=baki2;Trusted_Connection=True;";
            services.AddDbContext<ApplicationContext>(options=>
                options.UseSqlServer(connectionString));
            
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html";
                await context.Response.SendFileAsync(Path.Combine(env.WebRootPath, "index.html"));
            });

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();

            //    // добавляем сборку через webpack
            //    app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
            //    {
            //        HotModuleReplacement = true
            //    });
            //}

            ////app.UseDefaultFiles();
            //app.UseStaticFiles();
            //app.UseMvc(routes=> {
            //    routes.MapRoute(
            //        name: "default",
            //        template:"{controller=Home}/{action=Index}/{id?}"
            //        );

            //    routes.MapSpaFallbackRoute("angular-fallback",
            //        new {controller="Home",action="Index" });
            //});

            //app.Run(async (context) =>
            //{
            //    context.Response.ContentType = "text/html";
            //    await context.Response.SendFileAsync(Path.Combine(env.WebRootPath,"index.html"));
            //});
        }
    }
}
