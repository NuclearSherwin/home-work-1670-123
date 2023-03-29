using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public class MyStartUp
    {
        // dk dich vu
        public void ConfigureService(IServiceCollection service)
        {
                
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints=> {
                endpoints.MapGet("/", async (context) => {
                    string html = @"
                <!DOCTYPE html>
                <html>
                <head>
                    <meta charset=""UTF-8"">
                    <title>Trang web đầu tiên</title>
                    <link rel=""stylesheet"" href=""/css/bootstrap.min.css"" />
                    <script src=""/js/jquery.min.js""></script>
                    <script src=""/js/popper.min.js""></script>
                    <script src=""/js/bootstrap.min.js""></script>


                </head>
                <body>
                    <nav class=""navbar navbar-expand-lg navbar-dark bg-danger"">
                            <a class=""navbar-brand"" href=""#"">Brand-Logo</a>
                            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#my-nav-bar"" aria-controls=""my-nav-bar"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                                    <span class=""navbar-toggler-icon""></span>
                            </button>
                            <div class=""collapse navbar-collapse"" id=""my-nav-bar"">
                            <ul class=""navbar-nav"">
                                <li class=""nav-item active"">
                                    <a class=""nav-link"" href=""#"">Trang chủ</a>
                                </li>
                            
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Học HTML</a>
                                </li>
                            
                                <li class=""nav-item"">
                                    <a class=""nav-link disabled"" href=""#"">Gửi bài</a>
                                </li>
                        </ul>
                        </div>
                    </nav> 

                    <h1>Hello World<h1/>
                </body>
                </html>
    ";
                    await context.Response.WriteAsync(html);
                });
            });

            app.UseEndpoints(endpoints=> {
                endpoints.MapGet("/about", async (context) => {
                    await context.Response.WriteAsync("About");
                });
            });

            app.UseEndpoints(endpoints=> {
                endpoints.MapGet("/contact", async (context) => {
                    await context.Response.WriteAsync("Contact");
                });
            });

            app.Map("/abc", app1 => {
                app1.Run(async (context) => {
                    await context.Response.WriteAsync("Content response from ABC");
                });
            });

            // app.Run(async (HttpContext context) => {
            //     await context.Response.WriteAsync("Hello everyone");
            // });

            app.UseStatusCodePages();

        }
}