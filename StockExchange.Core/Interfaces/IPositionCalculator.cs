using StockExchange.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockExchange.Core.Interfaces
{
    public interface IPositionCalculator
    {
        /// <summary>
        /// Recalculates positions and returns updated position collection
        /// </summary>
        /// <param name="currentPositions">Current position collection</param>
        /// <param name="currentStockState">Current state of stock history</param>
        /// <returns></returns>
        Task<IEnumerable<Position>> RecalculatePositions(IEnumerable<Position> currentPositions, IEnumerable<Kline> currentStockState);
    }
}
