using System;

namespace StockExchange.Core.Entities
{
    public class Position
    {
        public int PositionId { get; set; }
        public int SessionId { get; set; }
        public decimal OpenPrice { get; set; }
        public Instrument Instrument { get; set; }
        public decimal Quantity { get; set; }
        public DateTime CreatedTime { get; }
    }
}
