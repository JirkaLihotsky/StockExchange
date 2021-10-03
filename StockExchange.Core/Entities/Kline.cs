using System;

namespace StockExchange.Core.Entities
{
    public class Kline
    {
        public int KlineId { get; set; }
        public int SessionId { get; set; }
        public DateTime OpenTime { get; set; }
        //public Currency Currency { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public Instrument Instrument { get; set; }
        public decimal Volume { get; set; }
        public DateTime? CloseTime { get; set; }
    }
}
