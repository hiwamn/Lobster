using ApplicationServices;
using Dal.Ef;
using Dal.Ef.Services;
using Domain.Contract;
using Domain.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using Utility;
using Utility.SMS.Rahyab;

namespace CoreExtension
{
    public static class ServiceExtensions
    {
        public static void ConfigureCookie(this IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
        }
            public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            //service.AddCors(o => o.AddPolicy("Hiwa", builder =>
            //{
            //    builder.AllowAnyOrigin()
            //           .AllowAnyMethod()
            //           .AllowAnyHeader();
            //}));
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => 
            {
                
            });
        }
        public static void ConfigureSwager(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "AccountOwner API", Version = "v1" });
            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            //services.AddSingleton<ILoggerManager, LoggerManager>();
        }


        public static void ConfigureSession(this IServiceCollection services)
        {
            services.AddSession();
        }
            public static void ConfigureMvc(this IServiceCollection services)
        {
            //services.AddMvc();


            services.AddMvc(options =>
            {
                //options.Filters.Add(typeof(LogFilterAttribute));
                options.Filters.Add(typeof(CustomExceptionFilter));
                //options.ModelBinderProviders.Insert(0, new CustomBinderProvider());
            }).AddSessionStateTempDataProvider().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<MainContext>(o => o.UseSqlServer(config.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("MobileEndpoint")));
        }
        public static void ConfigureAuthentication(this IServiceCollection services)
        {
            services.AddScoped<IPasswordHasher<User>, HiwaPasswordHasher<User>>();
            //services.AddIdentity<User, Role>().AddEntityFrameworkStores<SqlContext>()/*.AddDefaultTokenProviders()*/.AddErrorDescriber<CustomIdentityErrorDescriber>();
            services.AddIdentity<User, Role>()
            .AddRoleManager<RoleManager<Role>>()
            .AddEntityFrameworkStores<MainContext>()
            //.AddDefaultUI()
            //.AddDefaultTokenProviders();
            .AddErrorDescriber<CustomIdentityErrorDescriber>();
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                //options.Password.RequireDigit = true;
                //options.Password.RequiredLength = 8;
                //options.Password.RequireNonAlphanumeric = true;
                //options.Password.RequireUppercase = true;
                //options.Password.RequireLowercase = true;
                //options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                //options.Lockout.MaxFailedAccessAttempts = 10;
                //options.Lockout.AllowedForNewUsers = true;

                // User settings
                //options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            });

            //Seting the Account Login page
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(100000);
                options.LoginPath = "/Account/Login"; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
                options.LogoutPath = "/Account/Logout"; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = "/Account/AccessDenied"; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                options.SlidingExpiration = false;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.LoginPath = "/Account/Login";
            options.LogoutPath = "/Account/LogOut";
        });
        }

        public static void AddGeneral(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<INotification, RahyabService>();
        }

        public static void AddDb(this IServiceCollection services)
        {
            services.AddScoped<IContext, MainContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IActiveCodeRepository, ActiveCodeRepository>();
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IUpdateRepository, UpdateRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductImageRepository, ProductImageRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IMarkedProductRepository, MarkedProductRepository>();
            services.AddScoped<ILastVisitedProductRepository, LastVisitedProductRepository>();
            services.AddScoped<ISettingRepository, SettingRepository>();
            services.AddScoped<IWeatherPointRepository, WeatherPointRepository>();
            services.AddScoped<IKnowledgeRepository, KnowledgeRepository>();
            services.AddScoped<IKnowledgeImageRepository, KnowledgeImageRepository>();
        }
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICheckUpdate, CheckUpdate>();
            services.AddScoped<IForgetPassword, ForgetPassword>();
            services.AddScoped<IGetNotification, GetNotification>();
            services.AddScoped<ILogin, Login>();
            services.AddScoped<IRegister, Register>();
            services.AddScoped<ISendActiveCode, SendActiveCode>();
            services.AddScoped<IUpdateProfile, UpdateProfile>();
            services.AddScoped<IGetTopProduct, GetTopProduct>();
            services.AddScoped<IRegisterProduct, RegisterProduct>();
            services.AddScoped<IGetHomePageItems, GetHomePageItems>();
            services.AddScoped<IGetProvinces, GetProvinces>();
            services.AddScoped<IGetCities, GetCities>();
            services.AddScoped<IChangeUserStatus, ChangeUserStatus>();
            services.AddScoped<IMarkProduct, MarkProduct>();
            services.AddScoped<IVisitProduct, VisitProduct>();
            services.AddScoped<IGetMarkedProduct, GetMarkedProduct>();
            services.AddScoped<IGetLastVisitedProduct, GetLastVisitedProduct>();
            services.AddScoped<IUnMarkProduct, UnMarkProduct>();
            services.AddScoped<IGetSetting, GetSetting>();
            services.AddScoped<IGetProductById, GetProductById>();
            services.AddScoped<IGetTopKnowledge, GetTopKnowledge>();
            services.AddScoped<IGetMyProduct, GetMyProduct>();
            services.AddScoped<IUpdateSetting, UpdateSetting>();
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddGeneral();
            services.AddDb();
            services.AddRepositories();
            services.AddApplicationServices();
        }

        public static void ConfigureAll(this IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureSwager();
            services.ConfigureIISIntegration();
            services.ConfigureLoggerService();
            services.ConfigureRepositoryWrapper();
            services.ConfigureSession();
            services.ConfigureCookie();
            services.ConfigureMvc();
        }

    }
}
