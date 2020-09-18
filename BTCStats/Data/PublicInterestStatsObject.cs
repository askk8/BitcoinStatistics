using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data
{
    public class PublicInterestStatsObject
    {
        [JsonProperty("alexa_rank")]
        public int Alexa_rank { get; set; }
        [JsonProperty("bing_matches")]
        public int Bing_matches { get; set; }
    }
}
