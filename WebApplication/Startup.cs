using Application;
using Application.Services;
using Application.Services.Abs;
using Data;
using Data.Repos;
using Data.Repos.Abs;
using Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class Startup
    {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices (IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 10;

                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            })
                .AddRoles<ApplicationRole>()
                .AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthentication(o =>
            {
                // zabezpieczenia tokenów mailowych wysy³anych do potwierdzenia konta
                o.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                o.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
                o.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            });

            /*services.AddAuthentication("AdminScheme")
                .AddCookie("AdminScheme", options =>
                {
                    options.LoginPath = "/Admin/Account/Login";
                    options.AccessDeniedPath = "/Admin/Account/Login";
                });
            
            services.AddAuthentication ("DefaultScheme")
                .AddCookie("DefaultScheme", options =>
                {
                    options.LoginPath = "/Account/Login";
                    options.AccessDeniedPath = "/Account/Login";
                });*/

            services.AddAuthorization();

            services.ConfigureApplicationCookie(cookie =>
            {
                cookie.LoginPath = "/Account/Login";
                //cookie.LogoutPath = "/Home/Index"; 
                cookie.AccessDeniedPath = "/Account/Login";
                cookie.Cookie.HttpOnly = true; // uniemo¿liwia dostêp do ciasteczek z poziomu skryptów JavaScript
            });

            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            services.AddDistributedMemoryCache();
            services.AddHttpContextAccessor();


            // wysy³anie tokenów potwierdzaj¹cych na maila
            services.Configure<IdentityOptions>(options =>
            {
                options.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider;
            });
            // Konfiguracja okresu wa¿noœci tokena dla DataProtectorTokenProvider
            services.Configure<DataProtectionTokenProviderOptions>(options =>
            {
                options.TokenLifespan = TimeSpan.FromMinutes(30);
            });

            services.AddControllersWithViews();

            services.AddScoped<IUnityOfWork, UnityOfWork>(); 
            services.AddScoped<IPhotosUserRepository, PhotosUserRepository>(); 

            services.AddScoped<IUserAccountService, UserAccountService>();
            services.AddScoped<IRolesService, RolesService>();   
             

            services.AddScoped <IEmailSender, EmailSender>();
        }


        public void Configure (IApplicationBuilder app, IWebHostEnvironment env)
        {
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
            app.UseSession ();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}