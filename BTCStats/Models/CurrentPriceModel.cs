using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Models
{
    public class CurrentPriceModel
    {
        public double USD { get; set; }
        public double BTC { get; set; }
        public double ETH { get; set; }
    }
}
