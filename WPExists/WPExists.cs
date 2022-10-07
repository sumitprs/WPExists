using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPExists.Action;

namespace WPExists
{
    public partial class WPExists : Form
    {
        #region ConsoleBox
        public string SetInfo
        {
            set
            {
                ConsoleBox.PerformSafely(() => ConsoleBox.Select(ConsoleBox.TextLength, 0));
                ConsoleBox.PerformSafely(() => ConsoleBox.SelectionColor = Color.DodgerBlue);
                //Clipboard.SetImage(Properties.Resources.information_button);
                //ConsoleBox.PerformSafely(() => ConsoleBox.Paste());
                ConsoleBox.PerformSafely(() => ConsoleBox.AppendText("֍ " + value));
                ConsoleBox.PerformSafely(() => ConsoleBox.AppendText(Environment.NewLine));
                ConsoleBox.PerformSafely(() => ConsoleBox.ScrollToCaret());
            }
        }
        public string SetWarning
        {
            set
            {
                ConsoleBox.PerformSafely(() => ConsoleBox.Select(ConsoleBox.TextLength, 0));
                ConsoleBox.PerformSafely(() => ConsoleBox.SelectionColor = Color.Coral);
                //Clipboard.SetImage(Properties.Resources.exclamation);
                //ConsoleBox.PerformSafely(() => ConsoleBox.Paste());
                ConsoleBox.PerformSafely(() => ConsoleBox.AppendText("֍ " + value));
                ConsoleBox.PerformSafely(() => ConsoleBox.AppendText(Environment.NewLine));
                ConsoleBox.PerformSafely(() => ConsoleBox.ScrollToCaret());
            }
        }
        public string SetError
        {
            set
            {
                ConsoleBox.PerformSafely(() => ConsoleBox.Select(ConsoleBox.TextLength, 0));
                ConsoleBox.PerformSafely(() => ConsoleBox.SelectionColor = Color.Red);
                //Clipboard.SetImage(Properties.Resources.cancel);
                //ConsoleBox.PerformSafely(() => ConsoleBox.Paste());
                ConsoleBox.PerformSafely(() => ConsoleBox.AppendText("֍ " + value));
                ConsoleBox.PerformSafely(() => ConsoleBox.AppendText(Environment.NewLine));
                ConsoleBox.PerformSafely(() => ConsoleBox.ScrollToCaret());
            }
        }
        #endregion

        public string CurrentProxyIP
        {
            get { return currentIP.Text; }
            set
            {
                statusStrip1.PerformSafely(() => currentIP.Text = value);
            }
        }
        public bool ProcessCompleted
        {
            set
            {
                Thread te = new Thread(delegate ()
                {
                    if (value)
                        StopProgress();
                });
                te.IsBackground = true;
                te.Start();
            }
        }
        public List<string> InputList
        {
            get
            {
                List<string> v = new List<string>();
                txtInputList.PerformSafely(() => v = txtInputList.Lines.Where(a => a.Trim() != "").ToList());
                return v;
            }
        }
        public bool StopRequested { get; set; }
        private void StopProgress()
        {
            Thread th = new Thread(delegate ()
            {
                int inputCount = InputList.Count;
                int CompletedCount = wAResponse.Count;
                if (CompletedCount == inputCount || StopRequested)
                {
                    menuStrip1.PerformSafely(() => menuStrip1.Enabled = true);
                    statusStrip1.PerformSafely(() => btnBatchSize.Enabled = true);
                    btnStart.PerformSafely(() => btnStart.Enabled = true);
                    menuStrip1.PerformSafely(() => btnProcessStop.Enabled = false);
                    menuStrip1.PerformSafely(() => btnProcessStart.Enabled = true);
                    btnClear.PerformSafely(() => btnClear.Enabled = true);
                    txtInputList.PerformSafely(() => txtInputList.Enabled = true);
                    timer1.Stop();
                    timer1.Enabled = false;
                    SetInfo = "*Process Completed at: " + DateTime.Now + "*";
                    btnStopOperation.PerformSafely(() => btnStopOperation.Enabled = false);
                    statusStrip1.PerformSafely(() => Progress.Style = ProgressBarStyle.Blocks);
                    statusStrip1.PerformSafely(() => Progress.Value = 0);
                    statusStrip1.PerformSafely(() => Progress.Enabled = false);
                }
            });
            th.IsBackground = true;
            th.Start();
        }
        private void StartProgress()
        {
            Thread th = new Thread(delegate ()
            {
                timer1.Enabled = true;
                timer1.Start();
                menuStrip1.PerformSafely(() => menuStrip1.Enabled = false);
                statusStrip1.PerformSafely(() => btnBatchSize.Enabled = false);
                btnStart.PerformSafely(() => btnStart.Enabled = false);
                menuStrip1.PerformSafely(() => btnProcessStart.Enabled = false);
                menuStrip1.PerformSafely(() => btnProcessStop.Enabled = true);
                btnClear.PerformSafely(() => btnClear.Enabled = false);
                txtInputList.PerformSafely(() => txtInputList.Enabled = false);
                StartTime = System.DateTime.Now;
                SetInfo = "*Process Started at: " + DateTime.Now + "*";
                statusStrip1.PerformSafely(() => lblTimer.Text = "00.00.00");
                if (SettingConfig.OPERATION_ASYNC)
                {
                    statusStrip1.PerformSafely(() => Progress.Style = ProgressBarStyle.Marquee);
                }
                statusStrip1.PerformSafely(() => Progress.Enabled = true);
                btnStopOperation.PerformSafely(() => btnStopOperation.Enabled = true);
            });
            th.IsBackground = true;
            th.Start();
        }
        public int RunningThreadCount
        {
            set => lblRunningThreadCount.Text = "Active Threads: " + value;
        }
        private DateTime? _StartTime = null;
        public DateTime? StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                _StartTime = value;
                timer1.Enabled = true;
                timer1.Start();
            }
        }
        private List<WAResponse> wAResponse = new List<WAResponse>();
        public List<WAResponse> WAResponseList
        {
            set
            {
                try
                {
                    Thread te = new Thread(delegate ()
                    {
                        try
                        {
                            wAResponse.AddRange(value);
                            dgvResult.PerformSafely(() => dgvResult.DataSource = new BindingList<WAResponse>(wAResponse));
                            dgvResult.PerformSafely(() => dgvResult.FirstDisplayedScrollingRowIndex = dgvResult.RowCount - 1);
                            lblTotalDone.PerformSafely(() => lblTotalDone.Text = "Completed : " + wAResponse.Count);
                            if(wAResponse.Count==InputList.Count)
                            {
                                StopRequested = true;
                                ProcessCompleted = true;
                            }
                            //=(100*5)/50
                            int progress = (100 * wAResponse.Count) / InputList.Count;
                            statusStrip1.PerformSafely(() => Progress.Value = progress <= 100 ? progress : 100);
                            statusStrip1.PerformSafely(() => PercentCompleted.Text = progress + "%");
                        }
                        catch (Exception ex)
                        {
                            SetError = ex.Message;
                        }
                    });
                    te.IsBackground = true;
                    te.Start();
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    SetError = ex.Message;
                }
            }
        }
        public WAResponse WAResponse
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                try
                {
                    Thread te = new Thread(delegate ()
                    {
                        try
                        {
                            wAResponse.Add(value);
                            dgvResult.PerformSafely(() => dgvResult.DataSource = new BindingList<WAResponse>(wAResponse));
                            dgvResult.PerformSafely(() => dgvResult.FirstDisplayedScrollingRowIndex = dgvResult.RowCount - 1);
                            lblTotalDone.PerformSafely(() => lblTotalDone.Text = "Completed : " + wAResponse.Count);
                            if (wAResponse.Count == InputList.Count)
                            {
                                StopRequested = true;
                                ProcessCompleted = true;
                            }
                            //=(100*5)/50
                            int progress = (100 * wAResponse.Count) / InputList.Count;
                            statusStrip1.PerformSafely(() => Progress.Value = progress <= 100 ? progress : 100);
                            statusStrip1.PerformSafely(() => PercentCompleted.Text = progress + "%");
                        }
                        catch (Exception ex)
                        {
                            SetError = ex.Message;
                        }
                    });
                    te.IsBackground = true;
                    te.Start();
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    SetError = ex.Message;
                }
            }
        }
        public WPExists()
        {
            InitializeComponent();
        }

        WACheck aCheck;

        private void LaunchOPLTECH_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.opltech.com");
        }

        private void proxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proxy proxy = new Proxy();
            proxy.ShowDialog();
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputList.ResetText();
            lblTimer.Text = "00.00.00";
            Progress.Value = 0;
            dgvResult.DataSource = null;
            lblRunningThreadCount.Text = "Active Threads: 0";
            wAResponse.Clear();
        }

        private void batch4000_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (ToolStripMenuItem)sender;
                SettingConfig.REQUEST_BATCH_SIZE = Convert.ToInt32(button.Text);
                btnBatchSize.Text = "Request Batch Size: " + button.Text;
                foreach (var item in btnBatchSize.DropDownItems.OfType<ToolStripMenuItem>())
                {
                    item.Checked = false;
                }
                button.Checked = true;
            }
            catch (Exception ex)
            {
                SetError = ex.Message;
                SettingConfig.REQUEST_BATCH_SIZE = 100;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread tt = new Thread(delegate ()
            {
                StartProgress();
                aCheck = new WACheck(this);
                aCheck.StartCheck();
            })
            {
                IsBackground = true
            };
            tt.Start();
        }

        private void WPExists_Load(object sender, EventArgs e)
        {
            CheckValidity();

            if (!SettingConfig.LOGGEDIN == true)
            {
                //MessageBox.Show("Please Login.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Application.Exit();
            }
            btnBatchSize.Text = "Request Batch Size: " + SettingConfig.REQUEST_BATCH_SIZE;
        }

        private void txtInputList_TextChanged(object sender, EventArgs e)
        {
            Thread tr = new Thread(delegate ()
            {
                int inputCount = InputList.Count;
                lblTotal.PerformSafely(() => lblTotal.Text = "Enter Numbers (Count: " + inputCount + ")");
                statusStrip1.PerformSafely(() => Progress.Value = 0);
                statusStrip1.PerformSafely(() => PercentCompleted.Text = "0%");
            });
            tr.IsBackground = true;
            tr.Start();
        }

        private void btnProcessStop_Click(object sender, EventArgs e)
        {
            StopRequested = true;
            aCheck.tokenSource.Cancel();
            ProcessCompleted = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread tt = new Thread(delegate ()
            {
                try
                {
                    if (StartTime != null)
                    {
                        TimeSpan timeSpan = DateTime.Now.Subtract(Convert.ToDateTime(StartTime));
                        timeSpan = TimeSpan.ParseExact(timeSpan.ToString(), "c", null);
                        lblTimer.Text = String.Format("{0:hh\\:mm\\:ss}", timeSpan);
                    }
                }
                catch (Exception ex)
                {
                    SetError = "Timer: " + ex.Message;
                }
            });
            tt.IsBackground = true;
            tt.Start();
        }

        private void btnStopOperation_Click(object sender, EventArgs e)
        {
            StopRequested = true;
            aCheck.tokenSource.Cancel();
            ProcessCompleted = true;
        }

        private void WPExists_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingConfig.LOGGEDIN = false;
            Application.Exit();
        }

        private void CheckValidity()
        {
            if(DateTime.Today.Year!=2022 && DateTime.Today.Month!=05)
            {
                MessageBox.Show("Evaluation Ended.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
    }
}
