using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace XmrStakGui
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start((sender as LinkLabel).Text);
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}