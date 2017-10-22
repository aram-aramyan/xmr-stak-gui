using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace XmrStakGui
{

    public class Config
    {
        [JsonProperty("configurations")]
        public Configuration[] Configurations { get; set; }

        private static string GetConfigFilePath()
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Consts.ConfigFile);
        }

        public static Config Load()
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(GetConfigFilePath()));
        }

        public void Save()
        {
            File.WriteAllText(GetConfigFilePath(), JsonConvert.SerializeObject(this, Formatting.Indented), Encoding.UTF8);
        }

        public static void ImportConfiguration(string file)
        {
            var config = Load();

            var path = Path.GetDirectoryName(file);
            var fileName = Path.GetFileName(file).ToLower();
            var configTxtPath = Path.Combine(path, Consts.ConfigTxtFile);
            var json = $"{{{File.ReadAllText(configTxtPath)}}}";

            var configuration = config.Configurations.FirstOrDefault(c => c.Path.Equals(path, System.StringComparison.InvariantCultureIgnoreCase));
            if (configuration == null)
            {
                configuration = new Configuration
                {
                    Path = path,
                    Name = path
                };
                config.Configurations = config.Configurations.Union(new[] { configuration }).ToArray();
            }

            switch (fileName)
            {
                case Consts.CpuMiner:
                    configuration.Cpu = JsonConvert.DeserializeObject<XmrStakCpu>(json);
                    break;
                case Consts.AmdMiner:
                    configuration.Amd = JsonConvert.DeserializeObject<XmrStakAmd>(json);
                    break;
                case Consts.NvidiaMiner:
                    configuration.Nvidia = JsonConvert.DeserializeObject<XmrStakNvidia>(json);
                    break;
            }

            config.Save();
        }

       

        //public static T LoadTxt<T>(string file)
        //{
        //    return JsonConvert.DeserializeObject<T>($"{{{File.ReadAllText(file)}}}");
        //}

        public static void SaveTxt<T>(Configuration config, string file)
        {
            var property = config.GetType()
                .GetProperties()
                .FirstOrDefault(p => p.PropertyType == typeof(T));

            if (property == null) return;

            var json = JsonConvert.SerializeObject(property.GetValue(config), Formatting.Indented);
            var text = json.Trim(new char[] { '{', '}', ' ', '\n', '\r', '\t' });

            File.WriteAllText(file, text, Encoding.UTF8);
        }
    }

    public class Configuration
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("xmr_stak_cpu", NullValueHandling = NullValueHandling.Ignore)]
        public XmrStakCpu Cpu { get; set; }

        [JsonProperty("xmr_stak_amd", NullValueHandling = NullValueHandling.Ignore)]
        public XmrStakAmd Amd { get; set; }

        [JsonProperty("xmr_stak_nvidia", NullValueHandling = NullValueHandling.Ignore)]
        public XmrStakNvidia Nvidia { get; set; }
    }

    public class XmrStakCpu
    {

        public CpuThreadsConf[] cpu_threads_conf { get; set; }
        public string use_slow_memory { get; set; }
        public bool nicehash_nonce { get; set; }
        public object aes_override { get; set; }
        public bool use_tls { get; set; }
        public bool tls_secure_algo { get; set; }
        public string tls_fingerprint { get; set; }
        public string pool_address { get; set; }
        public string wallet_address { get; set; }
        public string pool_password { get; set; }
        public int call_timeout { get; set; }
        public int retry_time { get; set; }
        public int giveup_limit { get; set; }
        public int verbose_level { get; set; }
        public int h_print_time { get; set; }
        public bool daemon_mode { get; set; }
        public string output_file { get; set; }
        public int httpd_port { get; set; }
        public bool prefer_ipv4 { get; set; }
    }

    public class CpuThreadsConf
    {
        public bool low_power_mode { get; set; }
        public bool no_prefetch { get; set; }
        public int affine_to_cpu { get; set; }
    }

    public class XmrStakAmd
    {
        public int gpu_thread_num { get; set; }
        public AmdGpuThreadsConf[] gpu_threads_conf { get; set; }
        public int platform_index { get; set; }
        public bool use_tls { get; set; }
        public bool tls_secure_algo { get; set; }
        public string tls_fingerprint { get; set; }
        public string pool_address { get; set; }
        public string wallet_address { get; set; }
        public string pool_password { get; set; }
        public int call_timeout { get; set; }
        public int retry_time { get; set; }
        public int giveup_limit { get; set; }
        public int verbose_level { get; set; }
        public int h_print_time { get; set; }
        public bool daemon_mode { get; set; }
        public string output_file { get; set; }
        public int httpd_port { get; set; }
        public bool prefer_ipv4 { get; set; }
    }

    public class AmdGpuThreadsConf
    {
        public int index { get; set; }
        public int intensity { get; set; }
        public int worksize { get; set; }
        public bool affine_to_cpu { get; set; }
    }

    public class XmrStakNvidia
    {
        public NvidiaGpuThreadsConf[] gpu_threads_conf { get; set; }
        public bool use_tls { get; set; }
        public bool tls_secure_algo { get; set; }
        public string tls_fingerprint { get; set; }
        public string pool_address { get; set; }
        public string wallet_address { get; set; }
        public string pool_password { get; set; }
        public int call_timeout { get; set; }
        public int retry_time { get; set; }
        public int giveup_limit { get; set; }
        public int verbose_level { get; set; }
        public int h_print_time { get; set; }
        public string output_file { get; set; }
        public int httpd_port { get; set; }
        public bool prefer_ipv4 { get; set; }
    }

    public class NvidiaGpuThreadsConf
    {
        public int index { get; set; }
        public int threads { get; set; }
        public int blocks { get; set; }
        public int bfactor { get; set; }
        public int bsleep { get; set; }
        public bool affine_to_cpu { get; set; }
    }

}