using Microsoft.AspNetCore.Builder;
using Sepidar.Api.Activators.Middlewares;

namespace Sepidar.Api.Activators.Middlewares
{
    public static class MiddlewareExtentions
    {
        
        public static void UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}