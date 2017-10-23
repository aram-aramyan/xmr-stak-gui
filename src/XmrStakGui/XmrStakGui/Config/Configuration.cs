using Newtonsoft.Json;

namespace XmrStakGui
{
    public class Configuration
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("xmr_stak_cpu", NullValueHandling = NullValueHandling.Ignore)]
        public XmrStakCpu Cpu { get; set; }

        [JsonProperty("xmr_stak_amd", NullValueHandling = NullValueHandling.Ignore)]
        public XmrStakAmd Amd { get; set; }

        [JsonProperty("xmr_stak_nvidia", NullValueHandling = NullValueHandling.Ignore)]
        public XmrStakNvidia Nvidia { get; set; }
    }
}