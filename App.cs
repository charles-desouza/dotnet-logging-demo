using System;
using Microsoft.Extensions.Logging;

namespace dotnet_logging_demo{
    public class App{
        private readonly ILogger<App> _logger;
        int counter = 0;

        public App(ILogger<App> logger)
        {
            _logger = logger;
        }
        public void Run(){
            // Console.WriteLine($"Counter at : {counter}");
           _logger.LogInformation("Counter at : {counter}",counter);
            counter++;
        }
    }
}