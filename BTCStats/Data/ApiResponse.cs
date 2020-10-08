using BTCStats.Data.DeveloperData;
using Microsoft.AspNetCore.SignalR;
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
        public string ID { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        //[JsonProperty("localization")]
        //public List<LocalizationObject> Localization { get; set; }
        //[JsonProperty("image")]
        //public List<ImageObject> image { get; set; }
        //[JsonProperty("market_data")]
        //public List<MarketDataObject> market_data { get; set; }
        //[JsonProperty("community_data")]
        //public List<CommunityDataObject> community_data { get; set; }
        //[JsonProperty("developer_data")]
        //public List<DeveloperDataObject> developer_data { get; set; }
        //[JsonProperty("public_interest_stats")]
        //public List<PublicInterestStatsObject> public_interest_stats { get; set; }

    }

        public class JSONArray
    {
        public IList<ApiResponse> APIResponseInfo { get; set; }
    }
}
