using StockExchange.Core.Entities;
using StockExchange.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockExchange.Infrastructure.Services
{
    public class InstrumentService : IInstrumentService
    {
        public Task<Instrument> CreateInstrument(string name, string code)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Instrument>> GetAllInstruments()
        {
            throw new System.NotImplementedException();
        }

        public Task<Instrument> GetInstrumentByCode(string code)
        {
            throw new System.NotImplementedException();
        }
    }
}
