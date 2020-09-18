using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data.DeveloperData
{
    public class CodeAdditionsObject
    {
        [JsonProperty("additions")]
        public int Additions { get; set; }
        [JsonProperty("deletions")]
        public int Deletions { get; set; }
    }
}
