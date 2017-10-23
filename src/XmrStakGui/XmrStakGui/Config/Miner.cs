using Newtonsoft.Json;

namespace XmrStakGui
{
    public class Miner
    {
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}