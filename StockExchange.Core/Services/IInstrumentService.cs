using StockExchange.Core.Entities;
using System.Threading.Tasks;

namespace StockExchange.Core.Services
{
    public interface IInstrumentService
    {
        /// <summary>
        /// Creates new instrument with selected name and code
        /// </summary>
        /// <param name="name">Human friendly name of new instrument</param>
        /// <param name="code">Code of new instrument, must be unique</param>
        /// <returns></returns>
        Task<Instrument> CreateInstrument(string name, string code);
        /// <summary>
        /// Returns instrument with selected code. Code is not case sensitive.
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Instance of <see cref="Instrument"/>, if there is no instrument with
        /// selected code returns null</returns>
        Task<Instrument> GetInstrumentByCode(string code);

    }
}
