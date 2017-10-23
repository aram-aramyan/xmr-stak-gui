using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

// ReSharper disable InconsistentNaming
namespace XmrStakGui
{
    public class Config
    {
        [JsonProperty("configurations")]
        public List<Configuration> Configurations { get; set; }

        [JsonProperty("miners")]
        public List<Miner> Miners { get; set; }

        private static string GetConfigFilePath()
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) ?? string.Empty, Consts.ConfigFile);
        }

        public static Config Load()
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(GetConfigFilePath()));
        }

        public void Save()
        {
            File.WriteAllText(GetConfigFilePath(), JsonConvert.SerializeObject(this, Formatting.Indented),
                Encoding.UTF8);
        }

        public static void Import(string file)
        {
            var config = Load();
            config.ImportMiner(file);
            config.ImportConfiguration(file);
            config.Save();
        }

        private void ImportMiner(string file)
        {
            var fileName = Path.GetFileName(file)?.ToLower();
            if (fileName == null) return;
            var miner = Miners.FirstOrDefault(m => m.Path.Equals(file, StringComparison.InvariantCultureIgnoreCase));
            if (miner == null)
            {
                miner = new Miner
                {
                    Path = file
                };
                Miners.Add(miner);
            }
        }

        private void ImportConfiguration(string file)
        {
            var fileName = Path.GetFileName(file)?.ToLower();
            var path = Path.GetDirectoryName(file);
            if (path == null || fileName == null) return;
            var configTxtPath = Path.Combine(path, Consts.ConfigTxtFile);
            var json = $"{{{File.ReadAllText(configTxtPath)}}}";

            var configuration = new Configuration
            {
                Name = $"Config {DateTime.Now:yyyy-dd-MM-HH-mm-ss}"
            };

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

            var existingConfiguration = Configurations.FirstOrDefault(c => EqualConfigurations(c, configuration));
            if (existingConfiguration == null)
                Configurations.Add(configuration);
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
            var text = json.Trim('{', '}', ' ', '\n', '\r', '\t');

            File.WriteAllText(file, text, Encoding.UTF8);
        }

        private static bool EqualConfigurations(Configuration configuration1, Configuration configuration2)
        {
            return MemberCompare(configuration1.Cpu, configuration2.Cpu)
                   && MemberCompare(configuration1.Amd, configuration2.Amd)
                   && MemberCompare(configuration1.Nvidia, configuration2.Nvidia);
        }

        private static bool MemberCompare<T>(T left, T right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (left == null || right == null)
                return false;

            var type = left.GetType();
            if (type != right.GetType())
                return false;

            if (left as ValueType != null)
                return left.Equals(right);

            // all Arrays, Lists, IEnumerable<> etc implement IEnumerable
            if (left as IEnumerable != null)
            {
                var rightEnumerator = (right as IEnumerable).GetEnumerator();
                rightEnumerator.Reset();
                foreach (var leftItem in left as IEnumerable)
                    // unequal amount of items
                    if (!rightEnumerator.MoveNext())
                    {
                        return false;
                    }
                    else
                    {
                        if (!MemberCompare(leftItem, rightEnumerator.Current))
                            return false;
                    }
            }
            else
            {
                // compare each property
                foreach (var info in type.GetProperties(
                        BindingFlags.Public |
                        BindingFlags.NonPublic |
                        BindingFlags.Instance |
                        BindingFlags.GetProperty))
                    // TODO: need to special-case indexable properties
                    if (!MemberCompare(info.GetValue(left, null), info.GetValue(right, null)))
                        return false;

                // compare each field
                foreach (var info in type.GetFields(
                    BindingFlags.GetField |
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance))
                    if (!MemberCompare(info.GetValue(left), info.GetValue(right)))
                        return false;
            }
            return true;
        }
    }
}