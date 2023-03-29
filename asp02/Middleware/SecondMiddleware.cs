using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class SecondMiddleware : IMiddleware

{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (context.Request.Path == "/not.html")
        {
            context.Response.Headers.Add("SecondMiddleware", "You're not allow to access");
            var datafromFirstMiddleware = context.Items["DataFirstMiddleware"]; 

            if (datafromFirstMiddleware != null){
                await context.Response.WriteAsync((string)datafromFirstMiddleware);
            }
            await context.Response.WriteAsync("You're not allow to access");
        }
        else {
            context.Response.Headers.Add("SecondMiddleware", "You can access");

             var datafromFirstMiddleware = context.Items["DataFirstMiddleware"]; 

            if (datafromFirstMiddleware != null){    
                await context.Response.WriteAsync((string)datafromFirstMiddleware);
            }

            await next(context);

            
        }
    }
}
