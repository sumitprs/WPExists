
namespace WPExists
{
    partial class WPExists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WPExists));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProcessStart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProcessStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnBatchSize = new System.Windows.Forms.ToolStripSplitButton();
            this.batch4000 = new System.Windows.Forms.ToolStripMenuItem();
            this.batch2000 = new System.Windows.Forms.ToolStripMenuItem();
            this.batch1000 = new System.Windows.Forms.ToolStripMenuItem();
            this.batch750 = new System.Windows.Forms.ToolStripMenuItem();
            this.batch500 = new System.Windows.Forms.ToolStripMenuItem();
            this.batch250 = new System.Windows.Forms.ToolStripMenuItem();
            this.batch100 = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentIPLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRunningThreadCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.PercentCompleted = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LaunchOPLTECH = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStopOperation = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInputList = new System.Windows.Forms.RichTextBox();
            this.lblTotalDone = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ConsoleBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProcessStart,
            this.btnProcessStop,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "&Process";
            // 
            // btnProcessStart
            // 
            this.btnProcessStart.Name = "btnProcessStart";
            this.btnProcessStart.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.btnProcessStart.Size = new System.Drawing.Size(170, 22);
            this.btnProcessStart.Text = "&Start";
            this.btnProcessStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnProcessStop
            // 
            this.btnProcessStop.Enabled = false;
            this.btnProcessStop.Name = "btnProcessStop";
            this.btnProcessStop.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.btnProcessStop.Size = new System.Drawing.Size(170, 22);
            this.btnProcessStop.Text = "S&top";
            this.btnProcessStop.Click += new System.EventHandler(this.btnProcessStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.securityToolStripMenuItem,
            this.proxyToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "&Configuration";
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.securityToolStripMenuItem.Text = "&Security";
            this.securityToolStripMenuItem.Click += new System.EventHandler(this.securityToolStripMenuItem_Click);
            // 
            // proxyToolStripMenuItem
            // 
            this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
            this.proxyToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.proxyToolStripMenuItem.Text = "&Settings";
            this.proxyToolStripMenuItem.Click += new System.EventHandler(this.proxyToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "&Data";
            this.dataToolStripMenuItem.Visible = false;
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importToolStripMenuItem.Text = "&Import Raw Data";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportToolStripMenuItem.Text = "&Export Result";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBatchSize,
            this.CurrentIPLabel,
            this.currentIP,
            this.lblRunningThreadCount,
            this.Progress,
            this.PercentCompleted,
            this.lblTimer,
            this.toolStripStatusLabel3,
            this.LaunchOPLTECH});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnBatchSize
            // 
            this.btnBatchSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batch4000,
            this.batch2000,
            this.batch1000,
            this.batch750,
            this.batch500,
            this.batch250,
            this.batch100});
            this.btnBatchSize.Image = ((System.Drawing.Image)(resources.GetObject("btnBatchSize.Image")));
            this.btnBatchSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBatchSize.Name = "btnBatchSize";
            this.btnBatchSize.Size = new System.Drawing.Size(137, 20);
            this.btnBatchSize.Text = "Request Batch Size";
            // 
            // batch4000
            // 
            this.batch4000.Name = "batch4000";
            this.batch4000.Size = new System.Drawing.Size(98, 22);
            this.batch4000.Text = "4000";
            this.batch4000.Click += new System.EventHandler(this.batch4000_Click);
            // 
            // batch2000
            // 
            this.batch2000.Name = "batch2000";
            this.batch2000.Size = new System.Drawing.Size(98, 22);
            this.batch2000.Text = "2000";
            this.batch2000.Click += new System.EventHandler(this.batch4000_Click);
            // 
            // batch1000
            // 
            this.batch1000.Name = "batch1000";
            this.batch1000.Size = new System.Drawing.Size(98, 22);
            this.batch1000.Text = "1000";
            this.batch1000.Click += new System.EventHandler(this.batch4000_Click);
            // 
            // batch750
            // 
            this.batch750.Name = "batch750";
            this.batch750.Size = new System.Drawing.Size(98, 22);
            this.batch750.Text = "750";
            this.batch750.Click += new System.EventHandler(this.batch4000_Click);
            // 
            // batch500
            // 
            this.batch500.Name = "batch500";
            this.batch500.Size = new System.Drawing.Size(98, 22);
            this.batch500.Text = "500";
            this.batch500.Click += new System.EventHandler(this.batch4000_Click);
            // 
            // batch250
            // 
            this.batch250.Name = "batch250";
            this.batch250.Size = new System.Drawing.Size(98, 22);
            this.batch250.Text = "250";
            this.batch250.Click += new System.EventHandler(this.batch4000_Click);
            // 
            // batch100
            // 
            this.batch100.Name = "batch100";
            this.batch100.Size = new System.Drawing.Size(98, 22);
            this.batch100.Text = "100";
            this.batch100.Click += new System.EventHandler(this.batch4000_Click);
            // 
            // CurrentIPLabel
            // 
            this.CurrentIPLabel.Name = "CurrentIPLabel";
            this.CurrentIPLabel.Size = new System.Drawing.Size(66, 17);
            this.CurrentIPLabel.Text = "Current IP: ";
            // 
            // currentIP
            // 
            this.currentIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.currentIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.currentIP.Name = "currentIP";
            this.currentIP.Size = new System.Drawing.Size(44, 17);
            this.currentIP.Text = "0.0.0.0";
            // 
            // lblRunningThreadCount
            // 
            this.lblRunningThreadCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRunningThreadCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRunningThreadCount.Name = "lblRunningThreadCount";
            this.lblRunningThreadCount.Size = new System.Drawing.Size(218, 17);
            this.lblRunningThreadCount.Spring = true;
            this.lblRunningThreadCount.Text = "Active Threads: 0";
            // 
            // Progress
            // 
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(100, 16);
            // 
            // PercentCompleted
            // 
            this.PercentCompleted.Name = "PercentCompleted";
            this.PercentCompleted.Size = new System.Drawing.Size(23, 17);
            this.PercentCompleted.Text = "0%";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(218, 17);
            this.lblTimer.Spring = true;
            this.lblTimer.Text = "00.00.00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel3.Text = "Powered By";
            // 
            // LaunchOPLTECH
            // 
            this.LaunchOPLTECH.Font = new System.Drawing.Font("Myriad Pro", 7F, System.Drawing.FontStyle.Bold);
            this.LaunchOPLTECH.IsLink = true;
            this.LaunchOPLTECH.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.LaunchOPLTECH.Name = "LaunchOPLTECH";
            this.LaunchOPLTECH.Size = new System.Drawing.Size(48, 17);
            this.LaunchOPLTECH.Text = "OPL TECH";
            this.LaunchOPLTECH.Click += new System.EventHandler(this.LaunchOPLTECH_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvResult, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtInputList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalDone, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 404);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResult.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvResult.Location = new System.Drawing.Point(203, 43);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(537, 318);
            this.dgvResult.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.BackColor = System.Drawing.Color.Snow;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnStart.Location = new System.Drawing.Point(207, 367);
            this.btnStart.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(55, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(23, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(153, 15);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Enter Numbers (Count: 00)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStopOperation);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.panel1.Size = new System.Drawing.Size(200, 40);
            this.panel1.TabIndex = 9;
            // 
            // btnStopOperation
            // 
            this.btnStopOperation.AutoSize = true;
            this.btnStopOperation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStopOperation.BackColor = System.Drawing.Color.Snow;
            this.btnStopOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopOperation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStopOperation.Enabled = false;
            this.btnStopOperation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStopOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStopOperation.Location = new System.Drawing.Point(145, 3);
            this.btnStopOperation.Name = "btnStopOperation";
            this.btnStopOperation.Size = new System.Drawing.Size(48, 34);
            this.btnStopOperation.TabIndex = 7;
            this.btnStopOperation.Text = "STOP";
            this.btnStopOperation.UseVisualStyleBackColor = false;
            this.btnStopOperation.Click += new System.EventHandler(this.btnStopOperation_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.BackColor = System.Drawing.Color.Snow;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(7, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear and Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInputList
            // 
            this.txtInputList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtInputList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputList.Location = new System.Drawing.Point(3, 43);
            this.txtInputList.Name = "txtInputList";
            this.txtInputList.Size = new System.Drawing.Size(194, 318);
            this.txtInputList.TabIndex = 10;
            this.txtInputList.Text = "";
            this.txtInputList.TextChanged += new System.EventHandler(this.txtInputList_TextChanged);
            // 
            // lblTotalDone
            // 
            this.lblTotalDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalDone.AutoSize = true;
            this.lblTotalDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDone.Location = new System.Drawing.Point(426, 12);
            this.lblTotalDone.Name = "lblTotalDone";
            this.lblTotalDone.Size = new System.Drawing.Size(90, 15);
            this.lblTotalDone.TabIndex = 4;
            this.lblTotalDone.Text = "Completed : 00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ConsoleBox);
            this.splitContainer1.Size = new System.Drawing.Size(960, 404);
            this.splitContainer1.SplitterDistance = 743;
            this.splitContainer1.TabIndex = 3;
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ConsoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleBox.Location = new System.Drawing.Point(0, 0);
            this.ConsoleBox.Margin = new System.Windows.Forms.Padding(10);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.Size = new System.Drawing.Size(213, 404);
            this.ConsoleBox.TabIndex = 0;
            this.ConsoleBox.Text = "";
            // 
            // WPExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "WPExists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WPExists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WPExists_FormClosing);
            this.Load += new System.EventHandler(this.WPExists_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentIPLabel;
        private System.Windows.Forms.ToolStripStatusLabel currentIP;
        private System.Windows.Forms.ToolStripStatusLabel lblRunningThreadCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel LaunchOPLTECH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalDone;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripSplitButton btnBatchSize;
        private System.Windows.Forms.ToolStripMenuItem batch4000;
        private System.Windows.Forms.ToolStripMenuItem batch2000;
        private System.Windows.Forms.ToolStripMenuItem batch1000;
        private System.Windows.Forms.ToolStripMenuItem batch750;
        private System.Windows.Forms.ToolStripMenuItem batch500;
        private System.Windows.Forms.ToolStripMenuItem batch250;
        private System.Windows.Forms.ToolStripMenuItem batch100;
        private System.Windows.Forms.ToolStripStatusLabel lblTimer;
        public System.Windows.Forms.ToolStripProgressBar Progress;
        private System.Windows.Forms.ToolStripStatusLabel PercentCompleted;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnProcessStart;
        private System.Windows.Forms.ToolStripMenuItem btnProcessStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtInputList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox ConsoleBox;
        private System.Windows.Forms.Button btnStopOperation;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}

