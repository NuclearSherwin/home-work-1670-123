using Microsoft.Extensions.Hosting;

public class MyStartUp
{
    // Dang ky cac dich vu cua ung dung
    public void ConfigureServices(IServiceCollection services)
    {

    }

    // xay dung pipeline (Chuoi Middle ware)
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.Run(async (HttpContext context) => {
            await context.Response.WriteAsync("Hello this is my startup");
        });
    }
}