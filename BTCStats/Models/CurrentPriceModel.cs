using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Models
{
    public class CurrentPriceModel
    {
        [JsonProperty("usd")]
        public string USD { get; set; }

        [JsonProperty("btc")]
        public string BTC { get; set; }

        [JsonProperty("vet")]
        public string VET { get; set; }

        [JsonProperty("eth")]
        public string ETH { get; set; }
    }
}
