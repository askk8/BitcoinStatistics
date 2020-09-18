using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data
{
    public class LocalizationObject
    {
        [JsonProperty("en")]
        public string EN { get; set; }
        [JsonProperty("de")]
        public string DE { get; set; }
        [JsonProperty("es")]
        public string ES { get; set; }
        [JsonProperty("fr")]
        public string FR { get; set; }
        [JsonProperty("it")]
        public string IT { get; set; }
        [JsonProperty("pi")]
        public string PI { get; set; }
        [JsonProperty("ro")]
        public string RO { get; set; }
        [JsonProperty("hu")]
        public string HU { get; set; }
        [JsonProperty("nl")]
        public string NL { get; set; }
        [JsonProperty("pt")]
        public string PT { get; set; }
        [JsonProperty("sv")]
        public string SV { get; set; }
        [JsonProperty("vi")]
        public string VI { get; set; }
        [JsonProperty("tr")]
        public string TR { get; set; }
        [JsonProperty("ru")]
        public string RU { get; set; }
        [JsonProperty("ja")]
        public string JA { get; set; }
        [JsonProperty("zh")]
        public string ZH { get; set; }
        [JsonProperty("zh-tw")]
        public string ZH_TW { get; set; }
        [JsonProperty("ko")]
        public string KO { get; set; }
        [JsonProperty("ar")]
        public string AR { get; set; }
        [JsonProperty("th")]
        public string TH { get; set; }
        [JsonProperty("id")]
        public string ID { get; set; }

    }
}
