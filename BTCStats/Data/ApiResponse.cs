using BTCStats.Data.DeveloperData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data
{
    public class ApiResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        //[JsonProperty("localization")]
        //public List<LocalizationObject> Localization { get; set; }
        //[JsonProperty("image")]
        //public List<ImageObject> Image { get; set; }
        //[JsonProperty("market_data")]
        //public List<MarketDataObject> Market_data { get; set; }
        //[JsonProperty("community_data")]
        //public List<CommunityDataObject> Community_data { get; set; }
        //[JsonProperty("developer_data")]
        //public List<DeveloperDataObject> Developer_data { get; set; }
        //[JsonProperty("public_interest_stats")]
        //public List<PublicInterestStatsObject> Public_interest_stats { get; set; }

    }
}
