using StockExchange.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockExchange.Core.Interfaces
{
    public interface IStockStateReader
    {
        /// <summary>
        /// Reads klines for current stock state
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Kline>> ReadCurrentKlines();
        /// <summary>
        /// Reads current opened position in stock market
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Position>> ReadCurrentOpenedPositions();
    }
}
