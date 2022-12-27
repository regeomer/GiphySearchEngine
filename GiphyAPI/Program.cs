using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GiphyAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Debugger.Launch();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var config = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("hosting.json", true)
                      .Build();

            var host = WebHost.CreateDefaultBuilder(args)
                 // .UseUrls($"http://0.0.0.0:7090;")
                 .UseConfiguration(config)
                 .UseStartup<Startup>();

            return host;
        }
    }
}
