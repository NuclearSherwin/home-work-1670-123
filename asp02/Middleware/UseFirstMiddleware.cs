using Microsoft.AspNetCore.Builder;

public static class UserFirstMiddlewareMethod{
    public static void UserFirstMiddleware(this IApplicationBuilder app){
        app.UseMiddleware<FirstMiddleware>();
    }

    public static void UseSecondMiddleware(this IApplicationBuilder app){
        app.UseMiddleware<SecondMiddleware>();
    }
}