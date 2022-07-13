using System.Threading.Tasks;
using MicroservicesTicket.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace MicroservicesTicket.Middleware
{
    public class ExceptionCatcherMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionCatcherMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (BadHttpRequestException)
            {
                context.Response.StatusCode = 400;
            }
            catch (JsonSchemaTooLargeException ex)
            {
                context.Response.StatusCode = 413;
                await context.Response.WriteAsync(ex.Message);
            }
        }
    }
}