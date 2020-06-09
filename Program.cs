using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SkiShopService.Models;

namespace SkiShop
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //List<Ski> ListOfSki = new List<Ski>();
            //ListOfSki.Add(new Ski() { Id = 1, SkiLength = 200, SkiType = "Slalom", Price = 5000 });
            //ListOfSki.Add(new Ski() { Id = 2, SkiLength = 190, SkiType = "Slalom", Price = 4500});
            //ListOfSki.Add(new Ski() { Id = 3, SkiLength = 180, SkiType = "CrossCountry", Price = 3500 });
            //ListOfSki.Add(new Ski() { Id = 4, SkiLength = 170, SkiType = "Freestyle", Price = 4000 });
            //ListOfSki.Add(new Ski() { Id = 5, SkiLength = 190, SkiType = "Downhill", Price = 5000 });
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
