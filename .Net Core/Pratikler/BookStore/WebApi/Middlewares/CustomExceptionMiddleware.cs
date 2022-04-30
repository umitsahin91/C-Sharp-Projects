using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApi.Services;

namespace WebApi.Middlewares
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerService _loggerService;



        public CustomExceptionMiddleware(RequestDelegate next, ILoggerService loggerService)
        {
            _next = next;
            _loggerService = loggerService;
        }

        public async Task Invoke(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                
                string message = $"[Request]  HTTP {context.Request.Method,5} - {context.Request.Path,7}";
                _loggerService.Write(message);
                await _next(context);
                watch.Stop();
                message = $"[Response] HTTP {context.Request.Method,5} - {context.Request.Path,7} responded {context.Response.StatusCode,5} in {watch.Elapsed.TotalMilliseconds,10} ms";
                _loggerService.Write(message);
            }
            catch (Exception ex)
            {
                watch.Stop();
                await HandleExeption(context, ex, watch);
            }
           


        }

        private Task HandleExeption(HttpContext context, Exception ex, Stopwatch watch)
        {
            context.Response.ContentType = "applicationjson";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = $"[ERROR] HTTP {context.Request.Method,5} - {context.Response.StatusCode,5} - Error Message : {ex.Message} in {watch.Elapsed.TotalMilliseconds,10} ms";
            _loggerService.Write(message);

            var result = JsonConvert.SerializeObject(new { error = ex.Message },Formatting.None);
            return context.Response.WriteAsync(result);

        }
    }

    public static class CustomExceptionMiddlewareExtencion
    {
        public static IApplicationBuilder UseCustomExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
            
        }
    }
}
