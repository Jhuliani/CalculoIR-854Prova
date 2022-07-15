using CalculoIR_854Prova.Presentation;
using CalculoIR_854Prova.Services;
using CalculoIR_854Prova.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CalculoIR_854Prova
{
    public class Program
    {
        public static void Main(string[] args)
        {
         

            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var screen = serviceProvider.GetService<IScreen>();

            screen.BegginApp();

           
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IScreen, Screen>()
                .AddScoped<ITaxCalculator, TaxCalculator>();


        }
    }
}
