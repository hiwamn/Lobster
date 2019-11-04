using ApplicationServices;
using Dal.Ef;
using Dal.Ef.Services;
using Domain.Contract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreExtension
{
    public static class AppExtensions
    {
        
        public static void ConfigureCors(this IApplicationBuilder app)
        {
            app.UseCors("CorsPolicy");
        }
        public static void ConfigureSwager(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AccountOwner API V1");
            });
        }
        public static void ConfigureStaticFiles(this IApplicationBuilder app)
        {
            app.UseStaticFiles();
        }
        public static void ConfigureMvc(this IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();

        }
        public static void ConfigureSession(this IApplicationBuilder app)
        {
            app.UseSession();

        }
        
        public static void ConfigureAll(this IApplicationBuilder app)
        {
            app.ConfigureStaticFiles();
            app.ConfigureSwager();
            app.ConfigureSession();
            app.ConfigureMvc();
        }

    }
}
