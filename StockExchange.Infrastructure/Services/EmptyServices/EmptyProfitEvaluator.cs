using StockExchange.Core.Entities;
using StockExchange.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Infrastructure.Services.EmptyServices
{
    public class EmptyProfitEvaluator : IProfitEvaluator
    {
        public async Task<double> CalculateProfit(IEnumerable<Position> currentPositions)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Current profit was recalculated");

            return await Task.FromResult(0);
        }
    }
}
