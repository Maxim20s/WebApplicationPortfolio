using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace WebApplicationPortfolio
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            //Adding support for controllers and views
            services.AddControllersWithViews()
                //Show compatibility with ASP.Net Core 3.0 
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
