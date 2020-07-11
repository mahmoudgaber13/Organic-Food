using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthApplication.Areas.Identity.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AuthApplication.Data;
using Omu.AwesomeMvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using AuthApplication.Models;
using AuthApplication.Infrastructure;
using AuthApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace AuthApplication
{
    public class Startup
    {
        public  Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public  void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new RequireHttpsAttribute());
            });
            services.ConfigureApplicationCookie(o => {
                o.ExpireTimeSpan = TimeSpan.FromDays(5);
                o.SlidingExpiration = true;
            });
            services.Configure<DataProtectionTokenProviderOptions>(o =>o.TokenLifespan = TimeSpan.FromHours(3));

            services.AddTransient<EmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);
           
            services.AddIdentity<ApplicationUser, ApplicationRole>(
                options =>
                {
                    options.Stores.MaxLengthForKeys = 128;
                    options.SignIn.RequireConfirmedAccount = true;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                }).AddEntityFrameworkStores<AuthDBContext>()
                .AddDefaultUI().AddDefaultTokenProviders();

            services.AddControllersWithViews();
            services.AddRazorPages();
            var provider = new AweMetaProvider();
            services.AddMvc(o =>
            {
                o.ModelMetadataDetailsProviders.Add(provider);
            });

            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = "414874387876-m638msb4pr56bdafi792bmg1pbcdgk0b.apps.googleusercontent.com";
                options.ClientSecret = "9yfJ9h8vjwrsburiIf2VR52_";
            });
            services.AddDbContext<AuthDBContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("AuthDBContextConnection")));
            services.AddCloudscribePagination();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(20);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddHttpContextAccessor();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvcCore();

            

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {

            Seeding.SeedData(userManager, roleManager);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
