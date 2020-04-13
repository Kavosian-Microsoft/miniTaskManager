namespace miniTaskManager
{
    partial class frmTaskManger
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
            this.grpbRunningProcesses = new System.Windows.Forms.GroupBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.menuListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.endTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTaskMgr = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitTaskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpbRunningProcesses.SuspendLayout();
            this.menuListBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbRunningProcesses
            // 
            this.grpbRunningProcesses.Controls.Add(this.lstTasks);
            this.grpbRunningProcesses.Location = new System.Drawing.Point(12, 27);
            this.grpbRunningProcesses.Name = "grpbRunningProcesses";
            this.grpbRunningProcesses.Size = new System.Drawing.Size(365, 220);
            this.grpbRunningProcesses.TabIndex = 0;
            this.grpbRunningProcesses.TabStop = false;
            this.grpbRunningProcesses.Text = "Running Processes";
            // 
            // lstTasks
            // 
            this.lstTasks.ContextMenuStrip = this.menuListBox;
            this.lstTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 29;
            this.lstTasks.Location = new System.Drawing.Point(3, 33);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(359, 184);
            this.lstTasks.TabIndex = 0;
            this.lstTasks.Click += new System.EventHandler(this.lstTasks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Run Process:";
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndProcess.Location = new System.Drawing.Point(264, 309);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(110, 45);
            this.btnEndProcess.TabIndex = 2;
            this.btnEndProcess.Text = "&End Process";
            this.btnEndProcess.UseVisualStyleBackColor = true;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // menuListBox
            // 
            this.menuListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator1,
            this.endTaskToolStripMenuItem});
            this.menuListBox.Name = "menuListBox";
            this.menuListBox.Size = new System.Drawing.Size(138, 54);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.propertiesToolStripMenuItem.Text = "&Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // endTaskToolStripMenuItem
            // 
            this.endTaskToolStripMenuItem.Name = "endTaskToolStripMenuItem";
            this.endTaskToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.endTaskToolStripMenuItem.Text = "&End Process";
            this.endTaskToolStripMenuItem.Click += new System.EventHandler(this.endTaskToolStripMenuItem_Click);
            // 
            // tmrTaskMgr
            // 
            this.tmrTaskMgr.Enabled = true;
            this.tmrTaskMgr.Tick += new System.EventHandler(this.tmrTaskMgr_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shutDownToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshNowToolStripMenuItem,
            this.propertiesToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.exitTaskManagerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // refreshNowToolStripMenuItem
            // 
            this.refreshNowToolStripMenuItem.Name = "refreshNowToolStripMenuItem";
            this.refreshNowToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.refreshNowToolStripMenuItem.Text = "&Refresh now";
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.propertiesToolStripMenuItem1.Text = "&Properties";
            this.propertiesToolStripMenuItem1.Click += new System.EventHandler(this.propertiesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // exitTaskManagerToolStripMenuItem
            // 
            this.exitTaskManagerToolStripMenuItem.Name = "exitTaskManagerToolStripMenuItem";
            this.exitTaskManagerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitTaskManagerToolStripMenuItem.Text = "E&xit Task Manager";
            this.exitTaskManagerToolStripMenuItem.Click += new System.EventHandler(this.exitTaskManagerToolStripMenuItem_Click);
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnOffToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.standByToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.hibernateToolStripMenuItem});
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.shutDownToolStripMenuItem.Text = "&Shut down";
            // 
            // turnOffToolStripMenuItem
            // 
            this.turnOffToolStripMenuItem.Name = "turnOffToolStripMenuItem";
            this.turnOffToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.turnOffToolStripMenuItem.Text = "&Turn Off";
            this.turnOffToolStripMenuItem.Click += new System.EventHandler(this.turnOffToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // standByToolStripMenuItem
            // 
            this.standByToolStripMenuItem.Name = "standByToolStripMenuItem";
            this.standByToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.standByToolStripMenuItem.Text = "&Stand By";
            this.standByToolStripMenuItem.Click += new System.EventHandler(this.standByToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.logOffToolStripMenuItem.Text = "&Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // hibernateToolStripMenuItem
            // 
            this.hibernateToolStripMenuItem.Name = "hibernateToolStripMenuItem";
            this.hibernateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.hibernateToolStripMenuItem.Text = "&Hibernate";
            this.hibernateToolStripMenuItem.Click += new System.EventHandler(this.hibernateToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(264, 360);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 45);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmTaskManger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEndProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbRunningProcesses);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTaskManger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Task manager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTaskManger_Load);
            this.grpbRunningProcesses.ResumeLayout(false);
            this.menuListBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbRunningProcesses;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEndProcess;
        private System.Windows.Forms.ContextMenuStrip menuListBox;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem endTaskToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitTaskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hibernateToolStripMenuItem;
        public System.Windows.Forms.Timer tmrTaskMgr;
        private System.Windows.Forms.Button btnRefresh;
    }
}

