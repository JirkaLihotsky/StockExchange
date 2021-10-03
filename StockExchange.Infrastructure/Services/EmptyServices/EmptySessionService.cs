using StockExchange.Core.Entities;
using StockExchange.Core.Services;
using System;
using System.Threading.Tasks;

namespace StockExchange.Infrastructure.Services.EmptyServices
{
    public class EmptySessionService : ISessionService
    {
        /// <summary>
        /// Opens new session for selected instrument
        /// </summary>
        /// <param name="instrumentCode">Code of </param>
        /// <returns></returns>
        public async Task<Session> OpenNewSession(string instrumentCode)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Session for instrument with code {instrumentCode} was opened");

            return await Task.FromResult(new Session());
        }
    }
}
