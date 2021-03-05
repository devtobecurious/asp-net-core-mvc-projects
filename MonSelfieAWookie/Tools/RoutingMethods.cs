using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Tools
{
    public static class RoutingMethods
    {
        #region Public methods
        public static void UseCustomRoutes(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/hello", async context =>
                {
                    await context.Response.BodyWriter.WriteAsync(System.Text.Encoding.UTF8.GetBytes("Hello !"));
                });

                endpoints.MapControllerRoute(
                    name: "WookieList",
                    pattern: "masuperlistdewookie/{id:int}/{libelle}",
                    defaults: new { controller = "Wookie", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        #endregion
    }
}
