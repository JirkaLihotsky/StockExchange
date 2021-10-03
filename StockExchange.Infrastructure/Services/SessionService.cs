using StockExchange.Core.Entities;
using StockExchange.Core.Services;
using System.Threading.Tasks;

namespace StockExchange.Infrastructure.Services
{
    public class SessionService : ISessionService
    {

        public Task<Session> OpenNewSession(string instrumentCode)
        {
            throw new System.NotImplementedException();
        }
    }
}
