using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Models
{
    public class MarketDataModel
    {

        [JsonProperty("current_price")]
        public List<CurrentPriceModel> Market_data { get; set; }

        [JsonProperty("market_cap")]
        public List<CurrentPriceModel> Market_cap { get; set; }

        [JsonProperty("total_volume")]
        public List<CurrentPriceModel> Total_volume { get; set; }


    }
}
