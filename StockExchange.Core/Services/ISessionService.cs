using StockExchange.Core.Entities;
using System.Threading.Tasks;

namespace StockExchange.Core.Services
{
    public interface ISessionService
    {
        /// <summary>
        /// Opens new session for selected instrument
        /// </summary>
        /// <param name="instrumentCode">Code of </param>
        /// <returns></returns>
        Task<Session> OpenNewSession(string instrumentCode);
    }
}
