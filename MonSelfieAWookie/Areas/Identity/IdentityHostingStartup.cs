using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MonSelfieAWookie.Areas.Identity.Data;
using MonSelfieAWookie.Data;

[assembly: HostingStartup(typeof(MonSelfieAWookie.Areas.Identity.IdentityHostingStartup))]
namespace MonSelfieAWookie.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MonSelfieAWookieContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MonSelfieAWookieContextConnection")));

                services.AddDefaultIdentity<MonSelfieAWookieUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MonSelfieAWookieContext>();
            });
        }
    }
}