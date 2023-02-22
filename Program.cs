using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace core3Demo
{
    public class Program
    {
        static void Main()
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHost(builder => builder
                    .UseHttpListenerServer()
                    .Configure(app => app
                        .Use(FooMiddleware)
                        .Use(BarMiddleware)
                        .Use(BazMiddleware)))
                .Build()
                .Run();
        }
       public static RequestDelegate FooMiddleware(RequestDelegate next) => async context =>
        {
            //999
            await context.Response.WriteAsync("Foo=>");
            await next(context);
        };
        public static RequestDelegate BarMiddleware(RequestDelegate next) => async context =>
        {
            await context.Response.WriteAsync("Bar=>");
            await next(context);
        };

        public static RequestDelegate BazMiddleware(RequestDelegate next)
        => context => context.Response.WriteAsync("Baz");

    }

}
