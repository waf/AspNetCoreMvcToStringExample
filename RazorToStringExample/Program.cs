using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using RazorToStringExample.Controllers;
using RazorToStringExample.Services;

namespace RazorToStringExample
{
    public static class Program
    {
        public static async Task Main(string[] args) // async Main requires C# 7.1
        {
            var website = CreateWebHostBuilder(args).Build();

            var model = ((ViewResult)new HomeController().Index()).Model;

            // render the view with the model
            // must be scoped due to an asp.net internal IViewBufferScope service being scoped
            using (var scope = website.Services.CreateScope())
            {
                var renderer = scope.ServiceProvider.GetService(typeof(RazorViewToStringRenderer)) as RazorViewToStringRenderer;
                var html = await renderer.RenderViewToStringAsync("Home/Index", model);
                Console.WriteLine(html);
            }

            //if we wanted to launch a webserver to serve the dynamic MVC website, we could uncomment the following
            //await website.RunAsync();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
