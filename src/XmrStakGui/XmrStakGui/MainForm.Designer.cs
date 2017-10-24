namespace XmrStakGui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pNvidia = new System.Windows.Forms.Panel();
            this.lblNvidiaStatus = new System.Windows.Forms.Label();
            this.lblNvidiaName = new System.Windows.Forms.Label();
            this.pAmd = new System.Windows.Forms.Panel();
            this.lblAmdStatus = new System.Windows.Forms.Label();
            this.lblAmdName = new System.Windows.Forms.Label();
            this.pCpu = new System.Windows.Forms.Panel();
            this.lblCpuStatus = new System.Windows.Forms.Label();
            this.lblCpuName = new System.Windows.Forms.Label();
            this.tabControl = new XmrStakGui.TablessControl();
            this.tabCpu = new System.Windows.Forms.TabPage();
            this.tabAmd = new System.Windows.Forms.TabPage();
            this.tabNvidia = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectMinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pNvidia.SuspendLayout();
            this.pAmd.SuspendLayout();
            this.pCpu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.Panel1");
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer.Panel1.Controls.Add(this.pNvidia);
            this.splitContainer.Panel1.Controls.Add(this.pAmd);
            this.splitContainer.Panel1.Controls.Add(this.pCpu);
            // 
            // splitContainer.Panel2
            // 
            resources.ApplyResources(this.splitContainer.Panel2, "splitContainer.Panel2");
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            // 
            // pNvidia
            // 
            resources.ApplyResources(this.pNvidia, "pNvidia");
            this.pNvidia.BackColor = System.Drawing.Color.Transparent;
            this.pNvidia.Controls.Add(this.lblNvidiaStatus);
            this.pNvidia.Controls.Add(this.lblNvidiaName);
            this.pNvidia.Name = "pNvidia";
            this.pNvidia.Tag = "tabNvidia";
            // 
            // lblNvidiaStatus
            // 
            resources.ApplyResources(this.lblNvidiaStatus, "lblNvidiaStatus");
            this.lblNvidiaStatus.Name = "lblNvidiaStatus";
            // 
            // lblNvidiaName
            // 
            resources.ApplyResources(this.lblNvidiaName, "lblNvidiaName");
            this.lblNvidiaName.Name = "lblNvidiaName";
            // 
            // pAmd
            // 
            resources.ApplyResources(this.pAmd, "pAmd");
            this.pAmd.BackColor = System.Drawing.Color.Transparent;
            this.pAmd.Controls.Add(this.lblAmdStatus);
            this.pAmd.Controls.Add(this.lblAmdName);
            this.pAmd.Name = "pAmd";
            this.pAmd.Tag = "tabAmd";
            // 
            // lblAmdStatus
            // 
            resources.ApplyResources(this.lblAmdStatus, "lblAmdStatus");
            this.lblAmdStatus.Name = "lblAmdStatus";
            // 
            // lblAmdName
            // 
            resources.ApplyResources(this.lblAmdName, "lblAmdName");
            this.lblAmdName.Name = "lblAmdName";
            // 
            // pCpu
            // 
            resources.ApplyResources(this.pCpu, "pCpu");
            this.pCpu.BackColor = System.Drawing.Color.Transparent;
            this.pCpu.Controls.Add(this.lblCpuStatus);
            this.pCpu.Controls.Add(this.lblCpuName);
            this.pCpu.Name = "pCpu";
            this.pCpu.Tag = "tabCpu";
            // 
            // lblCpuStatus
            // 
            resources.ApplyResources(this.lblCpuStatus, "lblCpuStatus");
            this.lblCpuStatus.Name = "lblCpuStatus";
            // 
            // lblCpuName
            // 
            resources.ApplyResources(this.lblCpuName, "lblCpuName");
            this.lblCpuName.Name = "lblCpuName";
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabCpu);
            this.tabControl.Controls.Add(this.tabAmd);
            this.tabControl.Controls.Add(this.tabNvidia);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabCpu
            // 
            resources.ApplyResources(this.tabCpu, "tabCpu");
            this.tabCpu.BackColor = System.Drawing.Color.White;
            this.tabCpu.Name = "tabCpu";
            // 
            // tabAmd
            // 
            resources.ApplyResources(this.tabAmd, "tabAmd");
            this.tabAmd.BackColor = System.Drawing.Color.White;
            this.tabAmd.Name = "tabAmd";
            // 
            // tabNvidia
            // 
            resources.ApplyResources(this.tabNvidia, "tabNvidia");
            this.tabNvidia.BackColor = System.Drawing.Color.White;
            this.tabNvidia.Name = "tabNvidia";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMinerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // connectMinerToolStripMenuItem
            // 
            resources.ApplyResources(this.connectMinerToolStripMenuItem, "connectMinerToolStripMenuItem");
            this.connectMinerToolStripMenuItem.Name = "connectMinerToolStripMenuItem";
            this.connectMinerToolStripMenuItem.Click += new System.EventHandler(this.connectMinerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // stateTimer
            // 
            this.stateTimer.Enabled = true;
            this.stateTimer.Interval = 5000;
            this.stateTimer.Tick += new System.EventHandler(this.stateTimer_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pNvidia.ResumeLayout(false);
            this.pNvidia.PerformLayout();
            this.pAmd.ResumeLayout(false);
            this.pAmd.PerformLayout();
            this.pCpu.ResumeLayout(false);
            this.pCpu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private TablessControl tabControl;
        private System.Windows.Forms.TabPage tabCpu;
        private System.Windows.Forms.TabPage tabAmd;
        private System.Windows.Forms.TabPage tabNvidia;
        private System.Windows.Forms.Panel pAmd;
        private System.Windows.Forms.Panel pCpu;
        private System.Windows.Forms.Panel pNvidia;
        private System.Windows.Forms.Label lblNvidiaStatus;
        private System.Windows.Forms.Label lblNvidiaName;
        private System.Windows.Forms.Label lblAmdStatus;
        private System.Windows.Forms.Label lblAmdName;
        private System.Windows.Forms.Label lblCpuStatus;
        private System.Windows.Forms.Label lblCpuName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectMinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer stateTimer;
    }
}

