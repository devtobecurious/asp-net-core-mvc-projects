using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SelfieAWookie.Core.Domain;
using SelfiesAWookie.Core.Infrastructure.Data;
using SelfiesAWookie.Core.Infrastructure.Selfies;
using SelfiesAWookie.Core.Infrastructure.Wookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SelfiesAWookie.Core.Infrastructure.Weapons;

namespace MonSelfieAWookie
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            string connectionString = this.Configuration.GetConnectionString("MaBaseDeDonneesDeSelfies");

            services.AddDbContext<SelfieAWookieDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IWookieRepository, DbWookiesRepository>();
            services.AddScoped<ISelfieRepository, DbSelfiesRepository>();
            services.AddScoped<IWeaponRepository, DbWeaponsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
