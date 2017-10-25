namespace XmrStakGui
{
    internal static class Consts
    {
        internal const string ConfigFile = "config.json";
        internal const string ConfigTxtFile = "config.txt";
        internal const string CpuMiner = "xmr-stak-cpu.exe";
        internal const string AmdMiner = "xmr-stak-amd.exe";
        internal const string NvidiaMiner = "xmr-stak-nvidia.exe";

        internal static string[] Miners = new[] { Consts.CpuMiner, Consts.AmdMiner, Consts.NvidiaMiner };

    }
}