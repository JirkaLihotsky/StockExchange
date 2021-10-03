using StockExchange.Core.Entities;
using StockExchange.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Infrastructure.Services.EmptyServices
{
    public class EmptyStockStateReader : IStockStateReader
    {
        /// <summary>
        /// Reads klines for current stock state
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Kline>> ReadCurrentKlines()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Current klines from stock was read");

            return await Task.FromResult(new List<Kline>());
        }
        /// <summary>
        /// Reads current opened position in stock market
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Position>> ReadCurrentOpenedPositions()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Opened positions from stock were read");

            return await Task.FromResult(new List<Position>());
        }
    }
}
