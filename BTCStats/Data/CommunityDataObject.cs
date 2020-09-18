using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCStats.Data
{
    public class CommunityDataObject
    {
        [JsonProperty("facebook_likes")]
        public double Facebook_likes { get; set; }
        [JsonProperty("twitter_followers")]
        public double Wwitter_followers { get; set; }
        [JsonProperty("reddit_average_posts_48h")]
        public double Reddit_average_posts_48h { get; set; }
        [JsonProperty("reddit_average_comments_48h")]
        public double Reddit_average_comments_48h { get; set; }
        [JsonProperty("reddit_subscribers")]
        public double Reddit_subscribers { get; set; }
        [JsonProperty("reddit_accounts_active_48h")]
        public string Reddit_accounts_active_48h { get; set; }
    }
}
