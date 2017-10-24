using Newtonsoft.Json;

namespace XmrStakGui
{
    public class Settings
    {
        [JsonProperty("check_for_updates")]
        public bool CheckForUpdates { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

    }
}