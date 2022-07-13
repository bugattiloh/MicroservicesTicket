using System.Threading.Tasks;
using MicroservicesTicket.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace SegmentMicroservice.Middleware
{
    public class ExceptionCatcherBllMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionCatcherBllMiddleware(RequestDelegate next)
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
            catch (RefundsWithSameTicketNumberIsNotFoundException ex)
            {
                context.Response.StatusCode = 409;
                await context.Response.WriteAsync(ex.Message);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is PostgresException {SqlState: PostgresErrorCodes.UniqueViolation})
                {
                    context.Response.StatusCode = 409;
                    await context.Response.WriteAsync("Duplicate error");
                }
                else
                {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("Unknown error");
                }
            }
        }
    }
}