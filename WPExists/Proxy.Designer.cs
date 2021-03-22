
namespace WPExists
{
    partial class Proxy
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProxyList = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.rbtTask = new System.Windows.Forms.RadioButton();
            this.rbtHashSet = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtWebDriver = new System.Windows.Forms.RadioButton();
            this.rbtAsync = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveBaseAPIUrl = new System.Windows.Forms.Button();
            this.txtBaseAPIUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtWebSocket = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Proxy IP with port number\r\n(one each line. ex. 192.168.0.100:8080)";
            // 
            // txtProxyList
            // 
            this.txtProxyList.Location = new System.Drawing.Point(15, 81);
            this.txtProxyList.Margin = new System.Windows.Forms.Padding(4);
            this.txtProxyList.Multiline = true;
            this.txtProxyList.Name = "txtProxyList";
            this.txtProxyList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProxyList.Size = new System.Drawing.Size(265, 355);
            this.txtProxyList.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 447);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 26);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 447);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseProxy.Location = new System.Drawing.Point(17, 17);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(139, 19);
            this.chkUseProxy.TabIndex = 4;
            this.chkUseProxy.Text = "Enable Proxy Use";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // rbtTask
            // 
            this.rbtTask.AutoSize = true;
            this.rbtTask.Location = new System.Drawing.Point(23, 58);
            this.rbtTask.Name = "rbtTask";
            this.rbtTask.Size = new System.Drawing.Size(51, 19);
            this.rbtTask.TabIndex = 1;
            this.rbtTask.TabStop = true;
            this.rbtTask.Text = "Task";
            this.rbtTask.UseVisualStyleBackColor = true;
            this.rbtTask.CheckedChanged += new System.EventHandler(this.rbtHashSet_CheckedChanged);
            // 
            // rbtHashSet
            // 
            this.rbtHashSet.AutoSize = true;
            this.rbtHashSet.Location = new System.Drawing.Point(23, 27);
            this.rbtHashSet.Name = "rbtHashSet";
            this.rbtHashSet.Size = new System.Drawing.Size(72, 19);
            this.rbtHashSet.TabIndex = 0;
            this.rbtHashSet.TabStop = true;
            this.rbtHashSet.Text = "HashSet";
            this.rbtHashSet.UseVisualStyleBackColor = true;
            this.rbtHashSet.CheckedChanged += new System.EventHandler(this.rbtHashSet_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtWebSocket);
            this.groupBox2.Controls.Add(this.rbtWebDriver);
            this.groupBox2.Controls.Add(this.rbtAsync);
            this.groupBox2.Controls.Add(this.rbtTask);
            this.groupBox2.Controls.Add(this.rbtHashSet);
            this.groupBox2.Location = new System.Drawing.Point(311, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 190);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode of Operation";
            // 
            // rbtWebDriver
            // 
            this.rbtWebDriver.AutoSize = true;
            this.rbtWebDriver.Location = new System.Drawing.Point(23, 121);
            this.rbtWebDriver.Name = "rbtWebDriver";
            this.rbtWebDriver.Size = new System.Drawing.Size(101, 19);
            this.rbtWebDriver.TabIndex = 3;
            this.rbtWebDriver.TabStop = true;
            this.rbtWebDriver.Text = "ChromeDriver";
            this.rbtWebDriver.UseVisualStyleBackColor = true;
            this.rbtWebDriver.CheckedChanged += new System.EventHandler(this.rbtHashSet_CheckedChanged);
            // 
            // rbtAsync
            // 
            this.rbtAsync.AutoSize = true;
            this.rbtAsync.Location = new System.Drawing.Point(23, 89);
            this.rbtAsync.Name = "rbtAsync";
            this.rbtAsync.Size = new System.Drawing.Size(56, 19);
            this.rbtAsync.TabIndex = 2;
            this.rbtAsync.TabStop = true;
            this.rbtAsync.Text = "Async";
            this.rbtAsync.UseVisualStyleBackColor = true;
            this.rbtAsync.CheckedChanged += new System.EventHandler(this.rbtHashSet_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(294, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 461);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveBaseAPIUrl);
            this.groupBox1.Controls.Add(this.txtBaseAPIUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(311, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base API";
            // 
            // btnSaveBaseAPIUrl
            // 
            this.btnSaveBaseAPIUrl.AutoSize = true;
            this.btnSaveBaseAPIUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveBaseAPIUrl.Location = new System.Drawing.Point(59, 83);
            this.btnSaveBaseAPIUrl.Name = "btnSaveBaseAPIUrl";
            this.btnSaveBaseAPIUrl.Size = new System.Drawing.Size(44, 25);
            this.btnSaveBaseAPIUrl.TabIndex = 2;
            this.btnSaveBaseAPIUrl.Text = "Save";
            this.btnSaveBaseAPIUrl.UseVisualStyleBackColor = true;
            this.btnSaveBaseAPIUrl.Click += new System.EventHandler(this.btnSaveBaseAPIUrl_Click);
            // 
            // txtBaseAPIUrl
            // 
            this.txtBaseAPIUrl.Location = new System.Drawing.Point(9, 54);
            this.txtBaseAPIUrl.Name = "txtBaseAPIUrl";
            this.txtBaseAPIUrl.Size = new System.Drawing.Size(144, 21);
            this.txtBaseAPIUrl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Base API Url";
            // 
            // rbtWebSocket
            // 
            this.rbtWebSocket.AutoSize = true;
            this.rbtWebSocket.Location = new System.Drawing.Point(23, 152);
            this.rbtWebSocket.Name = "rbtWebSocket";
            this.rbtWebSocket.Size = new System.Drawing.Size(87, 19);
            this.rbtWebSocket.TabIndex = 4;
            this.rbtWebSocket.TabStop = true;
            this.rbtWebSocket.Text = "WebSocket";
            this.rbtWebSocket.UseVisualStyleBackColor = true;
            this.rbtWebSocket.CheckedChanged += new System.EventHandler(this.rbtHashSet_CheckedChanged);
            // 
            // Proxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(489, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkUseProxy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProxyList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proxy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Proxy_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProxyList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.RadioButton rbtTask;
        private System.Windows.Forms.RadioButton rbtHashSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtAsync;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveBaseAPIUrl;
        private System.Windows.Forms.TextBox txtBaseAPIUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtWebDriver;
        private System.Windows.Forms.RadioButton rbtWebSocket;
    }
}