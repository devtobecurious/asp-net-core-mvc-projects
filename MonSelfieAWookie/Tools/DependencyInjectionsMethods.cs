using Microsoft.Extensions.DependencyInjection;
using SelfieAWookie.Core.Domain;
using SelfiesAWookie.Core.Infrastructure.Selfies;
using SelfiesAWookie.Core.Infrastructure.Weapons;
using SelfiesAWookie.Core.Infrastructure.Wookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Tools
{
    public static class DependencyInjectionsMethods
    {
        #region Public methods
        public static void AddCustomDI(this IServiceCollection services)
        {
            services.AddScoped<IWookieRepository, DbWookiesRepository>();
            services.AddScoped<ISelfieRepository, DbSelfiesRepository>();
            services.AddScoped<IWeaponRepository, DbWeaponsRepository>();
        }
        #endregion
    }
}
