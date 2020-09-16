using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Models
{
    public class PriceHistoryModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("localization")]
        public string Localization { get; set; }

        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("market_data")]
        public string Market_data { get; set; }

        [JsonProperty("current_price")]
        public List<CurrentPriceModel> Current_price { get; set; }

        [JsonProperty("market_cap")]
        public string Market_cap { get; set; }

        [JsonProperty("community_data")]
        public string Community_data { get; set; }

    }
}
