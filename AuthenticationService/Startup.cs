using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationService.Data;
using IdentityServer4.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ZigoratApp.Classes;

namespace AuthenticationService
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISqlContext, SqlContext>();
            services.AddDbContext<SqlContext>();
            
            services.AddMvc(options =>
            {
                //options.Filters.Add(typeof(LogFilterAttribute));
                options.Filters.Add(typeof(CustomExceptionFilter));
                //options.ModelBinderProviders.Insert(0, new CustomBinderProvider());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddIdentityServer()
                        .AddDeveloperSigningCredential(filename: "tempkey.rsa")
                        .AddInMemoryApiResources(Config.GetApiResources())
                        .AddInMemoryIdentityResources(Config.GetIdentityResources())
                        .AddInMemoryClients(Config.GetClients());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            //app.UseHttpsRedirection();
            app.UseIdentityServer();
            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
