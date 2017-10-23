namespace XmrStakGui
{
    public class CpuThreadsConf
    {
        public bool low_power_mode { get; set; }
        public bool no_prefetch { get; set; }
        public int affine_to_cpu { get; set; }
    }
}