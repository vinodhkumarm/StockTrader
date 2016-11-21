using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooBoombergGoogleDataStore.DataSources
{
    public class BaseDataSource
    {
        public BaseDataSource()
        {

        }
    }

    public interface IBaseDataSource
    {
        public bool Connect();
        public bool Download();
        public IStockDataCollection GetStockDataForDate(DateTime dateTime);
        public IStockDataCollection GetStockDataForPeriod(DateTime startDate, DateTime endDate);
    }

    public interface IStockDataCollection
        : List<IStockDataTimePair>
    {

    }

    public interface IStockDataPoint
    {
        public string StockSymbol { get; set; }
        public string StockDescription { get;set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal Volume { get;set; }
        public decimal Capital { get; set; }
    }

    public interface IStockDataTimePair
    {
        public DateTime MarketTime { get; set; }
        public IStockDataPoint StockValue { get; set; }
    }
}
