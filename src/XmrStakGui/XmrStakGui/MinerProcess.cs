using System.Diagnostics;

namespace XmrStakGui
{
    public class MinerProcess
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Process Process { get; set; }
        public MinerState State { get; set; } = MinerState.New;
        public Miner Config { get; set; }

        public void Stop()
        {
            Process.Kill();
        }

        public override string ToString()
        {
            var processId = Process == null ? string.Empty : $" ({Process.Id})";
            return $"[{State}] - {Path}{processId}";
        }


        public enum MinerState
        {
            New,
            Mining,
            NotMining
        }
    }
}
