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

namespace Site
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
            Configuration.GetSection<SiteData>("SiteData");
            services.ConfigureMySqlContext(Configuration);
            services.ConfigureAuthentication();
            services.ConfigureAll();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            app.ConfigureAll();
        }
    }
}
