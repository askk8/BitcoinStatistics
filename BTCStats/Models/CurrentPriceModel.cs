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
        public double USD { get; set; }

        [JsonProperty("btc")]
        public double BTC { get; set; }

        [JsonProperty("eth")]
        public double ETH { get; set; }
    }
}
