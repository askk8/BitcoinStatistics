using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data.DeveloperData
{
    public class DeveloperDataObject
    {
        [JsonProperty("forks")]
        public int Forks { get; set; }
        [JsonProperty("stars")]
        public int Stars { get; set; }
        [JsonProperty("subscribers")]
        public int Subscribers { get; set; }
        [JsonProperty("total_issues")]
        public int Total_issues { get; set; }
        [JsonProperty("closed_issues")]
        public int Closed_issues { get; set; }
        [JsonProperty("pull_requests_merged")]
        public int Pull_requests_merged { get; set; }
        [JsonProperty("pull_request_contributors")]
        public int Pull_request_contributors { get; set; }
        [JsonProperty("code_additions_deletions_4_weeks")]
        public List<CodeAdditionsObject> Code_additions_deletions_4_weeks { get; set; }
        [JsonProperty("commit_count_4_weeks")]
        public int Commit_count_4_weeks { get; set; }
    }
}
