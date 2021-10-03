using StockExchange.Core.Entities;
using StockExchange.Core.Services;
using System;
using System.Threading.Tasks;

namespace StockExchange.Infrastructure.Services.EmptyServices
{
    public class EmptyInstrumentService : IInstrumentService
    {
        /// <summary>
        /// Creates new instrument with selected name and code
        /// </summary>
        /// <param name="name">Human friendly name of new instrument</param>
        /// <param name="code">Code of new instrument, must be unique</param>
        /// <returns></returns>
        public async Task<Instrument> CreateInstrument(string name, string code)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Instrument with code {code} and name {name} was created");

            return await Task.FromResult(new Instrument());  
        }

        /// <summary>
        /// Returns instrument with selected code. Code is not case sensitive.
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Instance of <see cref="Instrument"/>, if there is no instrument with
        /// selected code returns null</returns>
        public async Task<Instrument> GetInstrumentByCode(string code)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Instrument with code {code} was returned");

            return await Task.FromResult(new Instrument());
        }
    }
}
