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
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer.Panel1.Controls.Add(this.pNvidia);
            this.splitContainer.Panel1.Controls.Add(this.pAmd);
            this.splitContainer.Panel1.Controls.Add(this.pCpu);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(684, 351);
            this.splitContainer.SplitterDistance = 222;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // pNvidia
            // 
            this.pNvidia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNvidia.BackColor = System.Drawing.Color.Transparent;
            this.pNvidia.Controls.Add(this.lblNvidiaStatus);
            this.pNvidia.Controls.Add(this.lblNvidiaName);
            this.pNvidia.Location = new System.Drawing.Point(1, 232);
            this.pNvidia.Name = "pNvidia";
            this.pNvidia.Size = new System.Drawing.Size(227, 117);
            this.pNvidia.TabIndex = 2;
            this.pNvidia.Tag = "tabNvidia";
            // 
            // lblNvidiaStatus
            // 
            this.lblNvidiaStatus.Location = new System.Drawing.Point(9, 47);
            this.lblNvidiaStatus.Name = "lblNvidiaStatus";
            this.lblNvidiaStatus.Size = new System.Drawing.Size(207, 60);
            this.lblNvidiaStatus.TabIndex = 3;
            this.lblNvidiaStatus.Text = "label5";
            // 
            // lblNvidiaName
            // 
            this.lblNvidiaName.AutoSize = true;
            this.lblNvidiaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNvidiaName.Location = new System.Drawing.Point(9, 9);
            this.lblNvidiaName.Name = "lblNvidiaName";
            this.lblNvidiaName.Size = new System.Drawing.Size(194, 24);
            this.lblNvidiaName.TabIndex = 2;
            this.lblNvidiaName.Text = "GPU NVIDIA mining";
            // 
            // pAmd
            // 
            this.pAmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAmd.BackColor = System.Drawing.Color.Transparent;
            this.pAmd.Controls.Add(this.lblAmdStatus);
            this.pAmd.Controls.Add(this.lblAmdName);
            this.pAmd.Location = new System.Drawing.Point(0, 115);
            this.pAmd.Name = "pAmd";
            this.pAmd.Size = new System.Drawing.Size(227, 117);
            this.pAmd.TabIndex = 1;
            this.pAmd.Tag = "tabAmd";
            // 
            // lblAmdStatus
            // 
            this.lblAmdStatus.Location = new System.Drawing.Point(9, 47);
            this.lblAmdStatus.Name = "lblAmdStatus";
            this.lblAmdStatus.Size = new System.Drawing.Size(207, 60);
            this.lblAmdStatus.TabIndex = 3;
            this.lblAmdStatus.Text = "label3";
            // 
            // lblAmdName
            // 
            this.lblAmdName.AutoSize = true;
            this.lblAmdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmdName.Location = new System.Drawing.Point(9, 9);
            this.lblAmdName.Name = "lblAmdName";
            this.lblAmdName.Size = new System.Drawing.Size(172, 24);
            this.lblAmdName.TabIndex = 2;
            this.lblAmdName.Text = "GPU AMD mining";
            // 
            // pCpu
            // 
            this.pCpu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCpu.BackColor = System.Drawing.Color.Transparent;
            this.pCpu.Controls.Add(this.lblCpuStatus);
            this.pCpu.Controls.Add(this.lblCpuName);
            this.pCpu.Location = new System.Drawing.Point(0, 0);
            this.pCpu.Name = "pCpu";
            this.pCpu.Size = new System.Drawing.Size(227, 117);
            this.pCpu.TabIndex = 0;
            this.pCpu.Tag = "tabCpu";
            // 
            // lblCpuStatus
            // 
            this.lblCpuStatus.Location = new System.Drawing.Point(9, 47);
            this.lblCpuStatus.Name = "lblCpuStatus";
            this.lblCpuStatus.Size = new System.Drawing.Size(207, 60);
            this.lblCpuStatus.TabIndex = 1;
            this.lblCpuStatus.Text = "label2";
            // 
            // lblCpuName
            // 
            this.lblCpuName.AutoSize = true;
            this.lblCpuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCpuName.Location = new System.Drawing.Point(9, 9);
            this.lblCpuName.Name = "lblCpuName";
            this.lblCpuName.Size = new System.Drawing.Size(120, 24);
            this.lblCpuName.TabIndex = 0;
            this.lblCpuName.Text = "CPU mining";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCpu);
            this.tabControl.Controls.Add(this.tabAmd);
            this.tabControl.Controls.Add(this.tabNvidia);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(461, 351);
            this.tabControl.TabIndex = 0;
            // 
            // tabCpu
            // 
            this.tabCpu.BackColor = System.Drawing.Color.White;
            this.tabCpu.Location = new System.Drawing.Point(4, 22);
            this.tabCpu.Name = "tabCpu";
            this.tabCpu.Padding = new System.Windows.Forms.Padding(3);
            this.tabCpu.Size = new System.Drawing.Size(453, 325);
            this.tabCpu.TabIndex = 0;
            this.tabCpu.Text = "CPU";
            // 
            // tabAmd
            // 
            this.tabAmd.BackColor = System.Drawing.Color.White;
            this.tabAmd.Location = new System.Drawing.Point(4, 22);
            this.tabAmd.Name = "tabAmd";
            this.tabAmd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmd.Size = new System.Drawing.Size(453, 325);
            this.tabAmd.TabIndex = 1;
            this.tabAmd.Text = "AMD";
            // 
            // tabNvidia
            // 
            this.tabNvidia.BackColor = System.Drawing.Color.White;
            this.tabNvidia.Location = new System.Drawing.Point(4, 22);
            this.tabNvidia.Name = "tabNvidia";
            this.tabNvidia.Size = new System.Drawing.Size(453, 325);
            this.tabNvidia.TabIndex = 2;
            this.tabNvidia.Text = "NVIDIA";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMinerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectMinerToolStripMenuItem
            // 
            this.connectMinerToolStripMenuItem.Name = "connectMinerToolStripMenuItem";
            this.connectMinerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.connectMinerToolStripMenuItem.Text = "Import...";
            this.connectMinerToolStripMenuItem.Click += new System.EventHandler(this.connectMinerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XMR Stak miner|xmr-stak-cpu.exe;xmr-stak-amd.exe;xmr-stak-nvidia.exe";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 396);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 435);
            this.Name = "MainForm";
            this.Text = "XmrStakGui";
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

