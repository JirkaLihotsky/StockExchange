using Microsoft.Extensions.DependencyInjection;
using StockExchange.Core.Interfaces;
using StockExchange.Core.Services;
using StockExchange.Infrastructure.Services;
using StockExchange.Infrastructure.Services.EmptyServices;
using System;
using System.Threading;

namespace StockExchange.Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceProvider provider = GetServiceProvider();

                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                CancellationToken token = cancellationTokenSource.Token;

                StockExchangeSimulatorRuntime runtime = new StockExchangeSimulatorRuntime(provider);
                runtime.Start(args[0], token);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        static ServiceProvider GetServiceProvider()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<ISessionService, EmptySessionService>();
            services.AddTransient<IInstrumentService, EmptyInstrumentService>();
            services.AddTransient<IPositionCalculator, EmptyPositionCalculator>();
            services.AddTransient<IProfitEvaluator, EmptyProfitEvaluator>();
            services.AddTransient<IStockStateReader, EmptyStockStateReader>();

            ServiceProvider provider = services.BuildServiceProvider();
            return provider;
        }
    }
}