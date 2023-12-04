using API_NET8_CALENDARIO.Middlewares;

namespace API_NET8_CALENDARIO.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app) {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
