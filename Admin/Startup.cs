using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreExtension;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Utility.SiteConstants;

namespace Admin
{
    public class Startup
    {
        int a = 3;/// <summary>
        /// /
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.GetSection<PanelData>("PanelData");


            services.ConfigureMySqlContext(Configuration);
            services.ConfigureAuthentication();
            services.ConfigureAll();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            app.ConfigureAll();
        }
    }
}/////hiwaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
