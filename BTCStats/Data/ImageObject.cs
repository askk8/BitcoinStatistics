using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data
{
    public class ImageObject
    {
        [JsonProperty("thumb")]
        public string Thumb { get; set; }
        [JsonProperty("small")]
        public string Small { get; set; }
    }
}
