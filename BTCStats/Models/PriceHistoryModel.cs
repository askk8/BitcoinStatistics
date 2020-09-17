using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Models
{
    public class PriceHistoryModel
    {
        public string Id { get; set; }

        public string Symbol { get; set; }

        public string Name { get; set; }

        //public string Localization { get; set; }

        //public string Image { get; set; }

        //public List<MarketDataModel> Market_data { get; set; }

        //public string Community_data { get; set; }

        //public List<MarketDataModel> Developer_data { get; set; }

        //public List<MarketDataModel> Public_interest_stats { get; set; }

    }
}
