using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Management;

namespace XmrStakGui
{
    internal class ProcessService
    {
        /// <summary>
        /// Gets counts of processes with specified file names
        /// </summary>
        internal int[] GetCountsOfInstances(params string[] names)
        {
            var miners = GetRunningMiners();
            var result = new int[names.Length];
            for (var i = 0; i < names.Length; i++)
            {
                result[i] = miners.Count(m => m.Name.Equals(names[i], StringComparison.InvariantCultureIgnoreCase));
            }
            return result;
        }

        private List<MinerProcess> _runningMiners;
        private DateTime _lastMinersListUpdate = DateTime.MinValue;
        internal List<MinerProcess> GetRunningMiners()
        {
            if ((DateTime.UtcNow - _lastMinersListUpdate).TotalSeconds > 5)
            {
                var names = Consts.Miners;
                var query = "SELECT ProcessId, ExecutablePath FROM Win32_Process";
                var searcher = new ManagementObjectSearcher(query);
                var processList = searcher.Get();
                var dict = new Dictionary<int, string>();
                foreach (ManagementObject obj in processList)
                {
                    try
                    {
                        if (obj["ExecutablePath"] != null && obj["ProcessId"] != null)
                        {
                            var path = obj["ExecutablePath"].ToString();
                            var id = Convert.ToInt32(obj["ProcessId"]);
                            dict[id] = path;
                        }
                    }
                    catch { }
                }

                var processes = Process.GetProcesses().Where(p => dict.ContainsKey(p.Id)).ToList();
                var result = new List<MinerProcess>();
                for (var i = 0; i < names.Length; i++)
                {
                    var where = $"\\{names[i].ToLower()}";
                    result.AddRange(processes
                       .Where(p => dict[p.Id].ToLower().EndsWith(where))
                        .Select(p => new MinerProcess
                        {
                            Name = names[i],
                            Path = dict[p.Id],
                            Process = p
                        }));
                }
                _runningMiners = result;
            }

            return _runningMiners;
        }

        /// <summary>
        /// Run a new instance of miner with specified physical path
        /// </summary>
        internal void RunMiner(string path)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = path
            };
            Process.Start(startInfo);
        }

        /// <summary>
        /// Stops the miners with specified physical path
        /// </summary>
        internal void StopMiners(string path = null)
        {
            var miners = path == null 
                ? GetRunningMiners() 
                : GetRunningMiners().Where(p => p.Path.Equals(path, StringComparison.InvariantCultureIgnoreCase));

            foreach (var miner in miners.ToList())
            {
                try
                {
                    miner.Process.Kill();
                    _runningMiners.Remove(miner);
                }
                catch { }
            }
        }      
    }
}
