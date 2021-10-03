using StockExchange.Core.Shared.Exceptions;

namespace StockExchange.Core.Exceptions
{
    /// <summary>
    /// Exception indicating, that stock simulator is running and cannot be started
    /// </summary>
    public class StockSimulatorHasBeenAlreadyStartedException : BaseException
    {
    }
}
