using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace XmrStakGui
{
    public partial class MainForm : Form
    {
        private readonly Color BadColor = Color.Red;
        private readonly Color BColor = Color.White;
        private readonly Color GoodColor = Color.Green;
        private readonly Color InactiveColor = Color.Gray;
        private readonly Color WarningColor = Color.Orange;

        private Panel selectedPanel;


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
            panel_MouseClick((sender as Control).Parent, e);
        }

        private void bindOnClickForPanel(Panel panel)
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
                bindOnClickForPanel(panel);
            }
        }

        private void SelectTab(Panel panel)
        {
            if (selectedPanel != null)
                selectedPanel.BackColor = Color.Transparent;

            selectedPanel = panel;
            if (selectedPanel != null)
            {
                selectedPanel.BackColor = Color.White;
                tabControl.SelectTab(selectedPanel.Tag.ToString());
            }
        }

        private void SetLabelState(Label label, MiningState state = MiningState.None)
        {
            label.Tag = state;

            switch (state)
            {
                case MiningState.Mining:
                    label.Text = "Mining";
                    label.ForeColor = GoodColor;
                    break;
                default:
                    label.Text = "Not mining";
                    label.ForeColor = InactiveColor;
                    break;
            }
        }

        private void LoadConfig()
        {
            //var config = Config.Load();

            //Config.SaveTxt<XmrStakCpu>(config.Configurations[0], "config.txt");

            //var cpu = Config.LoadTxt<XmrStakCpu>("config.txt");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTabs();
            SelectTab(pCpu);
            SetLabelState(lblCpuStatus);
            SetLabelState(lblAmdStatus);
            SetLabelState(lblNvidiaStatus);

            LoadConfig();
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
            AddFile((sender as OpenFileDialog).FileName);
        }

        private void AddFile(string file)
        {
            Config.Import(file);
            MessageBox.Show("Import complete!");
        }

        private enum MiningState
        {
            None,
            NotMining,
            NotSupported,
            NotFound,
            Mining
        }
    }
}