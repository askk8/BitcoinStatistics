using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data
{
    public class ImageObject
    {
        [JsonProperty("image")]
        public List<string> image { get; set; }
        [JsonProperty("image.thumb")]
        public string thumb { get; set; }
        [JsonProperty("image.small")]
        public string small { get; set; }
    }
}
