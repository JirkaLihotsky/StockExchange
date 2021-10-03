using System.Collections.Generic;

namespace StockExchange.Core.Entities
{
    public class Instrument
    {
        public int InstrumentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
