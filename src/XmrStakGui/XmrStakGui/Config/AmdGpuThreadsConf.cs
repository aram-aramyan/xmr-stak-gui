namespace XmrStakGui
{
    public class AmdGpuThreadsConf
    {
        public int index { get; set; }
        public int intensity { get; set; }
        public int worksize { get; set; }
        public bool affine_to_cpu { get; set; }
    }
}