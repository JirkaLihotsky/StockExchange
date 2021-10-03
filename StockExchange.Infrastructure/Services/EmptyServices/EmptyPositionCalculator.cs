using StockExchange.Core.Entities;
using StockExchange.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Infrastructure.Services.EmptyServices
{
    public class EmptyPositionCalculator : IPositionCalculator
    {
        /// <summary>
        /// Recalculates positions and returns updated position collection
        /// </summary>
        /// <param name="currentPositions">Current position collection</param>
        /// <param name="currentStockState">Current state of stock history</param>
        /// <returns></returns>
        public async Task<IEnumerable<Position>> RecalculatePositions(IEnumerable<Position> currentPositions, IEnumerable<Kline> currentStockState)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Current positions were recalculated");

            return await Task.FromResult(new List<Position>());
        }
    }
}
