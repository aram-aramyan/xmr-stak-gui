using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmrStakGui
{
    public partial class MainForm : Form
    {
        private readonly Color BColor = Color.White;
        private readonly Color GoodColor = Color.Green;
        private readonly Color BadColor = Color.Red;
        private readonly Color WarningColor = Color.Orange;
        private readonly Color InactiveColor = Color.Gray;


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
            {
                control.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelChild_MouseClick);
            }
        }        

        private void InitTabs()
        {
            var panels = new[] { pCpu, pAmd, pNvidia};
            foreach (var panel in panels)
            {
                panel.Cursor = Cursors.Hand;
                panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
                bindOnClickForPanel(panel);
            }
        }

        private Panel selectedPanel;
        void SelectTab(Panel panel)
        {
            if (selectedPanel != null)
            {
                selectedPanel.BackColor = Color.Transparent;
            }

            selectedPanel = panel;
            if (selectedPanel != null)
            {
                selectedPanel.BackColor = Color.White;
                tabControl.SelectTab(selectedPanel.Tag.ToString());
            }
        }

       private void SetLabelState(Label label, MiningState state = MiningState.None)
        {
            switch(state)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
           InitTabs();
            SelectTab(pCpu);
            SetLabelState(lblCpuStatus);
            SetLabelState(lblAmdStatus);
            SetLabelState(lblNvidiaStatus);
        }

        private enum MiningState
        {
            None,
            NotMining,
            NotSupported,
            NotFound,
            Mining
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectMinerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
