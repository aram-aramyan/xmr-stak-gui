using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        private Panel _selectedPanel;


        public MainForm()
        {
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
            var panels = new[] {pCpu, pAmd, pNvidia};
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

        private static void AddFile(string file)
        {
            Config.Import(file);
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
            var processes = Process.GetProcesses();
            SetMinerStateLabel(lblCpuStatus, processes);
            SetMinerStateLabel(lblAmdStatus, processes);
            SetMinerStateLabel(lblNvidiaStatus, processes);
        }

        private void SetMinerStateLabel(Label label, Process[] processes)
        {
            var minerName = label.Tag.ToString();

            var minersCount = processes.Count(p => p.ProcessName == minerName);

            if (minersCount == 0)
            {
                SetLabelState(label);
            }
            else
            {
                SetLabelState(label, MiningState.Mining, ": " + minersCount);
            }

        }

        private void stateTimer_Tick(object sender, EventArgs e)
        {
            CheckMinersState();
        }
    }
}