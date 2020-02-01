using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTempCrud.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace BlogTempCrud.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AuthenticationMiddleware
    {
        private AppDbContext _context;
        public AuthenticationMiddleware(AppDbContext context)
        {
            _context = context;
        }

        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var path = httpContext.Request.Path;
            if (path.HasValue && path.Value.StartsWith("/BlogAdmin"))
            {
                if (httpContext.Session.GetString("LoginName") == null)
                {
                    httpContext.Response.Redirect("/AdminLogin");
                }
            }
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddleware>();
        }
    }
}
