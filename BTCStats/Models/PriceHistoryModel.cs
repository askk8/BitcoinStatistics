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

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("market_data")]
        public List<MarketDataModel> Market_data { get; set; }

        [JsonProperty("community_data")]
        public string Community_data { get; set; }

        [JsonProperty("developer_data")]
        public List<MarketDataModel> Developer_data { get; set; }

        [JsonProperty("public_interest_stats")]
        public List<MarketDataModel> Public_interest_stats { get; set; }

    }
}
