using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace asp02
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<SecondMiddleware>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            app.UserFirstMiddleware();
            app.UseSecondMiddleware();

            app.UseRouting();
             // tao end point

            app.UseEndpoints((endpoint) => {
                endpoint.MapGet("/about.html",async (context) => {
                    await context.Response.WriteAsJsonAsync("Trang gioi thieu");
                });

                endpoint.MapGet("/product.html", async (context) => {
                    await context.Response.WriteAsJsonAsync("Trang san pham");
                });
            });


            app.Map("/admin", (app1) => {
                // tao re nhanh

                app1.UseRouting();

                // EP1
                app1.UseEndpoints((endpoints) => {
                    endpoints.MapGet("/user", async(context) => {
                        await context.Response.WriteAsync("User management page!");
                    });
                });


                app1.UseEndpoints((endpoints) => {
                    endpoints.MapGet("/product", async(context) => {
                        await context.Response.WriteAsync("Product management page!");
                    });
                });

                // // EP2
                // app.Run(async (context) => {
                //     await context.Response.WriteAsync("Admin page");
                // });


            });


            app.Run(async (context) => {
                await context.Response.WriteAsync("Hello ASP.NET Core");
            });
        }
    }
}
