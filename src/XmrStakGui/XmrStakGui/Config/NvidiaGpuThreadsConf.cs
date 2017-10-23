namespace XmrStakGui
{
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