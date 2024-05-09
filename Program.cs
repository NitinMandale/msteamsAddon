// Generated with EchoBot .NET Template version v4.22.0

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace EchoBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting application...");
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Application is shutting down...");
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureLogging((logging) =>
                    {
                        logging.AddDebug();
                        logging.AddConsole();
                    });
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://localhost:5001/");
                });
    }
}
