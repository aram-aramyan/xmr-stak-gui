using System.Collections.Generic;

namespace XmrStakGui
{
    public class XmrStakCpu
    {
        public List<CpuThreadsConf> cpu_threads_conf { get; set; }
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
}