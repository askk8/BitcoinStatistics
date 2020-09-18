using BTCStats.Data.MarketData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data
{
    public class MarketDataObject
    {
        [JsonProperty("current_price")]
        public List<CurrentPriceObject> Current_price { get; set; }
        [JsonProperty("market_cap")]
        public List<CurrentPriceObject> Market_cap { get; set; }
        [JsonProperty("total_volume")]
        public List<CurrentPriceObject> Total_volume { get; set; }
    }
}
