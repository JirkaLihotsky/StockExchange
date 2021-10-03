using StockExchange.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockExchange.Core.Interfaces
{
    public interface IProfitEvaluator
    {
        Task<double> CalculateProfit(IEnumerable<Position> currentPositions);
    }
}
