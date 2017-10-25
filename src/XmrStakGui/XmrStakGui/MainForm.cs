using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using XmrStakGui.Properties;

namespace XmrStakGui
{
    public partial class MainForm : Form
    {
        //private readonly Color _badColor = Color.Red;
        private readonly Color _bColor = Color.White;
        private readonly Color _goodColor = Color.Green;
        private readonly Color _inactiveColor = Color.Gray;
        //private readonly Color _warningColor = Color.Orange;
        private readonly Config _config;
        private readonly ProcessService _processService = new ProcessService();

        private Panel _selectedPanel;


        public MainForm()
        {
            _config = Config.Load();
            SetCurrentLanguage(_config.Settings.Language);
            InitializeComponent();
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTab(sender as Panel);
        }

        private void panelChild_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is Control control) panel_MouseClick(control.Parent, e);
        }

        public void BindOnClickForPanel(Panel panel)
        {
            var controls = panel.Controls.Cast<Control>();
            foreach (var control in controls)
                control.MouseClick += panelChild_MouseClick;
        }

        private void InitTabs()
        {
            var panels = new[] { pCpu, pAmd, pNvidia };
            foreach (var panel in panels)
            {
                panel.Cursor = Cursors.Hand;
                panel.MouseClick += panel_MouseClick;
                BindOnClickForPanel(panel);
            }
        }

        private void SelectTab(Panel panel)
        {
            if (_selectedPanel != null)
                _selectedPanel.BackColor = Color.Transparent;

            _selectedPanel = panel;
            if (_selectedPanel == null) return;
            _selectedPanel.BackColor = _bColor;
            tabControl.SelectTab(_selectedPanel.Tag.ToString());
        }

        private void SetLabelState(Label label, MiningState state = MiningState.None, params object[] values)
        {
            switch (state)
            {
                case MiningState.Mining:
                    label.Text = string.Format(Resources.MainForm_SetLabelState_Mining, values);
                    label.ForeColor = _goodColor;
                    break;
                default:
                    label.Text = Resources.MainForm_SetLabelState_Not_mining;
                    label.ForeColor = _inactiveColor;
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTabs();
            SelectTab(pCpu);
            SetStatusLabelTags();
            CheckMinersState();
            FillCpuMinersList();
        }


        private static void SetCurrentLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectMinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (sender is OpenFileDialog openFileDialog) AddFile(openFileDialog.FileName);
        }

        private void AddFile(string file)
        {
            _config.Import(file);
            MessageBox.Show(Resources.MainForm_AddFile_Import_complete_);
        }

        private enum MiningState
        {
            None,
            Mining
        }

        private void SetStatusLabelTags()
        {
            lblCpuStatus.Tag = Consts.CpuMiner;
            lblAmdStatus.Tag = Consts.AmdMiner;
            lblNvidiaStatus.Tag = Consts.NvidiaMiner;
        }

        private void CheckMinersState()
        {
            SetMinerStateLabel(lblCpuStatus, lblAmdStatus, lblNvidiaStatus);
        }

        private void SetMinerStateLabel(params Label[] labels)
        {
            var minerNames = labels.Select(l => l.Tag.ToString()).ToArray();
            var minersCounts = _processService.GetCountsOfInstances(minerNames);
            for (var i = 0; i < labels.Length; i++)
            {
                if (minersCounts[i] == 0)
                    SetLabelState(labels[i]);
                else
                    SetLabelState(labels[i], MiningState.Mining, ": " + minersCounts[i]);
            }
        }

        private void stateTimer_Tick(object sender, EventArgs e)
        {
            CheckMinersState();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = !this.Visible;
        }

        private void stopAllMinersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _processService.StopMiners();
            FillCpuMinersList();
            CheckMinersState();
        }

        private void FillCpuMinersList()
        {
            var miners = _processService
                .GetRunningMiners()
                .Where(m => m.Name == Consts.CpuMiner)
                .ToList();

            foreach (var miner in miners.Where(m => m.Config == null))
            {
                miner.Config = _config.Miners.FirstOrDefault(m => m.Path.Equals(miner.Path, StringComparison.InvariantCultureIgnoreCase));
                if (miner.Config != null)
                {
                    miner.State = MinerProcess.MinerState.Mining;
                }
            }

            miners.AddRange(_config.Miners
                .Where(m => !miners.Any(m1 => m1.Path.Equals(m.Path, StringComparison.InvariantCultureIgnoreCase)))
                .Select(m => new MinerProcess
                {
                    Path = m.Path,
                    State = MinerProcess.MinerState.NotMining,
                    Config = m
                }));

            cmbCpu.DataSource = miners;
        }


        private void cmbCpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdCpuImport.Enabled = cmdCpuRun.Enabled = cmdCpuStop.Enabled = false;

            var miner = cmbCpu.SelectedItem as MinerProcess;
            if (miner == null) return;

            switch (miner.State)
            {
                case MinerProcess.MinerState.New:
                    cmdCpuImport.Enabled = true;
                    break;
                case MinerProcess.MinerState.NotMining:
                    cmdCpuRun.Enabled = true;
                    break;
            }
            cmdCpuStop.Enabled = !cmdCpuRun.Enabled;
            cmdCpuRestart.Enabled = cmdCpuStop.Enabled;
            cmdCpuRun.Enabled = true;
        }

        private void cmdCpuImport_Click(object sender, EventArgs e)
        {
            var miner = cmbCpu.SelectedItem as MinerProcess;
            if (miner == null) return;
            AddFile(miner.Path);
            FillCpuMinersList();
        }

        private void cmdCpuRun_Click(object sender, EventArgs e)
        {
            var miner = cmbCpu.SelectedItem as MinerProcess;
            if (miner == null) return;
            _processService.RunMiner(miner.Path);
            FillCpuMinersList();
            CheckMinersState();
        }

        private void cmdCpuStop_Click(object sender, EventArgs e)
        {
            var miner = cmbCpu.SelectedItem as MinerProcess;
            if (miner == null) return;
            miner.Stop();
            FillCpuMinersList();
            CheckMinersState();
        }

        private void cmdCpuRestart_Click(object sender, EventArgs e)
        {
            var miner = cmbCpu.SelectedItem as MinerProcess;
            if (miner == null) return;
            miner.Stop();
            _processService.RunMiner(miner.Path);
            FillCpuMinersList();
            CheckMinersState();
        }

       
    }
}