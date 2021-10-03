using Microsoft.Extensions.DependencyInjection;
using StockExchange.Core.Entities;
using StockExchange.Core.Exceptions;
using StockExchange.Core.Interfaces;
using StockExchange.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StockExchange.Simulator
{
    public class StockExchangeSimulatorRuntime
    {
        private readonly ServiceProvider serviceProvider;
        private bool isRunning;
        private Task stockReaderTask;
        private Task positionEvaluatorTask;
        private Task profitEvaluatorTask;

        private CancellationToken cancellationToken;
        private Session currentSession;
        private List<Kline> currentKlines;
        private List<Position> currentPositions;

        public StockExchangeSimulatorRuntime(ServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;

            this.isRunning = false;
        }

        public void Start(string instrumentCode, CancellationToken cancellationToken)
        {
            if (this.isRunning)
                throw new StockSimulatorHasBeenAlreadyStartedException();

            ISessionService sessionService = this.serviceProvider.GetService<ISessionService>();

            try 
            {
                this.cancellationToken = cancellationToken;
                this.currentSession = sessionService.OpenNewSession(instrumentCode).Result;

                
                this.stockReaderTask = Task.Factory.StartNew(this.StockReaderLoop);
                this.positionEvaluatorTask = Task.Factory.StartNew(this.PositionCalculatorLoop);
                this.profitEvaluatorTask = Task.Factory.StartNew(this.ProfitEvaluatorLoop);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void StockReaderLoop()
        {
            while (true)
            {
                if (this.cancellationToken.IsCancellationRequested)
                    break;

                IStockStateReader stockStateReader = this.serviceProvider.GetService<IStockStateReader>();
                this.currentKlines = stockStateReader.ReadCurrentKlines().Result.ToList();
                this.currentPositions = stockStateReader.ReadCurrentOpenedPositions().Result.ToList();

                Thread.Sleep(5000);
            }
        }


        private void PositionCalculatorLoop()
        {
            while (true)
            {
                if (this.cancellationToken.IsCancellationRequested)
                    break;

                IPositionCalculator positionCalculator = this.serviceProvider.GetService<IPositionCalculator>();
                this.currentPositions = positionCalculator.RecalculatePositions(this.currentPositions, this.currentKlines). Result.ToList();

                Thread.Sleep(5000);
            }
        }

        private void ProfitEvaluatorLoop()
        {
            while (true)
            {
                if (this.cancellationToken.IsCancellationRequested)
                    break;

                IProfitEvaluator profitEvaluator = this.serviceProvider.GetService<IProfitEvaluator>();
                double profit = profitEvaluator.CalculateProfit(this.currentPositions).Result;

                Thread.Sleep(5000);
            }
        }
    }
}
