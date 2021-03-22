using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPExists.Action;

namespace WPExists
{
    public partial class Proxy : Form
    {
        public Proxy()
        {
            InitializeComponent();
        }

        private void Proxy_Load(object sender, EventArgs e)
        {
            var ips = SettingConfig.ProxyIPCollection;
            if (ips != null && ips.Count > 0)
            {
                //txtProxyList.Text = string.Join(Environment.NewLine, ips.ToArray());
                txtProxyList.Text = ips.Aggregate((x, y) => x + Environment.NewLine + y);
            }
            chkUseProxy.Checked = SettingConfig.USEPROXY;
            rbtHashSet.Checked = SettingConfig.OPERATION_HASHSET;
            rbtTask.Checked = SettingConfig.OPERATION_TASK;
            rbtAsync.Checked = SettingConfig.OPERATION_ASYNC;
            rbtWebDriver.Checked = SettingConfig.OPERATION_CHROMEDRIVER;
            txtBaseAPIUrl.Text = SettingConfig.API_BASE_URL;
            rbtWebSocket.Checked = SettingConfig.OPERATION_WEBSOCKET;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> shortedIPs = new List<string>();
            if (txtProxyList.Text.Trim() != "")
            {
                int AllLineCount = txtProxyList.Lines.Count();
                var lines = txtProxyList.Lines.Where(a => a.Contains(":")).ToList();
                if (lines.Count > 0)
                {
                    foreach (string ip in lines)
                    {
                        var split = ip.Split(':');

                        IPAddress address;
                        bool b = IPAddress.TryParse(split[0], out address);
                        if (b && Convert.ToInt32(split[1]) > 0 && Convert.ToInt32(split[1]) < 65536)
                            shortedIPs.Add(ip);
                    }
                }
                string st = shortedIPs.Aggregate((x, y) => x + Environment.NewLine + y);
                if (lines.Count > shortedIPs.Count)
                {
                    MessageBox.Show(AllLineCount - shortedIPs.Count + " out of " + lines.Count + " IP(s) are found invalid and being removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtProxyList.Text = st;
                SettingConfig.ProxyIPCollection = shortedIPs;
                this.Close();
            }
        }

        private void chkUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SettingConfig.USEPROXY = txtProxyList.Enabled = btnSave.Enabled = chkUseProxy.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtHashSet_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtHashSet.Checked)
            {
                SettingConfig.OPERATION_HASHSET = true;
                SettingConfig.OPERATION_TASK = false;
                SettingConfig.OPERATION_ASYNC = false;
                SettingConfig.OPERATION_CHROMEDRIVER = false;
                SettingConfig.OPERATION_WEBSOCKET = false;
            }
            else if (rbtTask.Checked)
            {
                SettingConfig.OPERATION_HASHSET = false;
                SettingConfig.OPERATION_TASK = true;
                SettingConfig.OPERATION_ASYNC = false;
                SettingConfig.OPERATION_CHROMEDRIVER = false;
                SettingConfig.OPERATION_WEBSOCKET = false;
            }
            else if (rbtAsync.Checked)
            {
                SettingConfig.OPERATION_HASHSET = false;
                SettingConfig.OPERATION_TASK = false;
                SettingConfig.OPERATION_ASYNC = true;
                SettingConfig.OPERATION_CHROMEDRIVER = false;
                SettingConfig.OPERATION_WEBSOCKET = false;
            }
            else if (rbtWebDriver.Checked)
            {
                SettingConfig.OPERATION_HASHSET = false;
                SettingConfig.OPERATION_TASK = false;
                SettingConfig.OPERATION_ASYNC = false;
                SettingConfig.OPERATION_CHROMEDRIVER = true;
                SettingConfig.OPERATION_WEBSOCKET = false;
            }
            else if (rbtWebSocket.Checked)
            {
                SettingConfig.OPERATION_HASHSET = false;
                SettingConfig.OPERATION_TASK = false;
                SettingConfig.OPERATION_ASYNC = false;
                SettingConfig.OPERATION_CHROMEDRIVER = false;
                SettingConfig.OPERATION_WEBSOCKET = true;
            }
        }

        private void btnSaveBaseAPIUrl_Click(object sender, EventArgs e)
        {
            Uri uri;
            if (txtBaseAPIUrl.Text == "")
                MessageBox.Show("Base API Url can not be empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Uri.IsWellFormedUriString(txtBaseAPIUrl.Text, UriKind.Relative))//(Uri.TryCreate(txtBaseAPIUrl.Text, UriKind.Absolute, out uri))
                MessageBox.Show("Invalid URL.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SettingConfig.API_BASE_URL = txtBaseAPIUrl.Text;
                this.Close();
            }
        }
    }
}
