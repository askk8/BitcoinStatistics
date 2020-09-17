using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Models
{
    public class MarketDataModel
    {
        public List<CurrentPriceModel> Market_data { get; set; }

        public List<CurrentPriceModel> Market_cap { get; set; }

        public List<CurrentPriceModel> Total_volume { get; set; }


    }
}
