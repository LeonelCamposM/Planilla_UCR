using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Server_Planilla
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Server.Startup>();
                });
    }
}
