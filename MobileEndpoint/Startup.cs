using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationServices;
using CoreExtension;
using Dal.Ef;
using Dal.Ef.Services;
using Domain.Contract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Utility.FireBase;
using Utility.SMS.Rahyab;
using Utility.SiteConstants;

namespace MobileEndpoint
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
            Configuration.GetSection<RahyabParameters>("RahyabParameters");
            Configuration.GetSection<FireBaseSetting>("FireBaseSetting");                       
            Configuration.GetSection<MobileData>("MobileData");                       
            services.ConfigureMySqlContext(Configuration);
            services.ConfigureAll(); 
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.ConfigureAll();
            
        }
    }
}
