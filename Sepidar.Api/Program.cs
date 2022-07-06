using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Sepidar.api;
using Sepidar.api.Base;

namespace Sepidar.Api
{
    public class Program
    {
        public static AppSettingsModel AppSettingsInfo { get; private set; }
        public static void Main(string[] args)
        {
            ReadAppSettingsInfo();
            var host = CreateHostBuilder(args).Build().Seed();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("FixedAsset Host run at : " + DateTime.Now.ToString("f"));
            Console.ResetColor();
            host.Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args)
        {
            var builder = WebHost.CreateDefaultBuilder(args);
            if (AppSettingsInfo.HostRunAsConsole)
            {
                builder = builder.UseHttpSys();
            }
            return builder
                .UseStartup<Startup>()
                .UseUrls(AppSettingsInfo.HostAddress);
        }

        public static void ReadAppSettingsInfo()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json")
                .Build();

            AppSettingsInfo = config.Get<AppSettingsModel>();
        }

    }
}
