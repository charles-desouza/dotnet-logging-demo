using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace dotnet_logging_demo
{
    class Program
    {
        static void Main(string[] args)
        {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
 
        var serviceProvider = serviceCollection.BuildServiceProvider();
 
        // var app = serviceProvider.GetService<App>();
        // app.Run();
        // app.Run();
        serviceProvider.GetService<App>().Run();

        Console.WriteLine("Hit return to close");
        Console.ReadLine();
        }

        private static void ConfigureServices(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton(new LoggerFactory()
            .AddConsole()
            .AddDebug());

            serviceCollection.AddLogging(); 

            serviceCollection.AddTransient<App>();
        }
    }
}
