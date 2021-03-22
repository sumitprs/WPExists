using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPExists.Action;

namespace WPExists.Algo
{
    public class Task
    {
        public static async System.Threading.Tasks.Task DoTaskQuery(List<string> current, WPExists wPExists, CancellationTokenSource tokenSource)
        {
            CancellationToken token = tokenSource.Token;
            if (SettingConfig.USEPROXY)
            {
                List<string> proxyList = SettingConfig.ProxyIPCollection;
                int currentProxy = 0;
                if (currentProxy >= proxyList.Count)
                {
                    currentProxy = 0;
                }
                string proxyIP = proxyList[currentProxy].Split(':')[0].ToString();
                int proxyPort = Convert.ToInt32(proxyList[currentProxy].Split(':')[1].ToString());
                wPExists.CurrentProxyIP = proxyList[currentProxy];

                var tasks = current
                .Select(data => System.Threading.Tasks.Task.Factory.StartNew(arg => DoQueryWithProxy(proxyIP, proxyPort, data, token, wPExists),
                TaskContinuationOptions.LongRunning | TaskContinuationOptions.PreferFairness))
                .ToArray();

                wPExists.RunningThreadCount = tasks.Count();
                System.Threading.Tasks.Task.WaitAll(tasks, token);
            }
            else
            {
                wPExists.CurrentProxyIP = "PROXY DISABLED";

                var tasks = current
                                .Select(data => System.Threading.Tasks.Task.Factory.StartNew(arg => DoQuery(data, token, wPExists),
                                TaskContinuationOptions.LongRunning | TaskContinuationOptions.PreferFairness))
                                .ToArray();
                wPExists.RunningThreadCount = tasks.Count();
                System.Threading.Tasks.Task.WaitAll(tasks, token);
            }
        }
        private static void DoQueryWithProxy(string proxyIP, int proxyPort, string mobileNumber, CancellationToken ct, WPExists wPExists)
        {
            if (ct.IsCancellationRequested)
            {
                try
                {
                    wPExists.SetError = "Operation Canceled.";
                    wPExists.ProcessCompleted = wPExists.StopRequested = true;
                    ct.ThrowIfCancellationRequested();
                }
                catch (Exception ex)
                {
                    wPExists.SetError = ex.Message;
                }
            }

            WAResponse wa = new WAResponse();
            wa.Number = mobileNumber;
            try
            {
                string url = SettingConfig.API_BASE_URL + mobileNumber;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
                WebProxy myproxy = new WebProxy(proxyIP, proxyPort);
                myproxy.BypassProxyOnLocal = false;
                request.Proxy = myproxy;
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Thread ts = new Thread(delegate ()
                {
                    Stream newStream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(newStream);

                    wa.Exists = sr.ReadToEnd();
                    wa.StatusCode = Convert.ToInt32(response.StatusCode);
                    wa.StatusDescription = response.StatusDescription;
                });
                ts.IsBackground = true;
                ts.Start();
            }
            catch (Exception ex)
            {
                wPExists.SetError = ex.Message + Environment.NewLine + ex.InnerException;
                wa.Exception = ex.Message;
                wa.InnerException = ex.InnerException.Message;
            }
            finally
            {
                wPExists.WAResponse = wa;
            }
        }
        private static void DoQuery(string mobileNumber, CancellationToken ct, WPExists wPExists)
        {
            if (ct.IsCancellationRequested)
            {
                try
                {
                    wPExists.SetError = "Operation Canceled.";
                    wPExists.ProcessCompleted = wPExists.StopRequested = true;
                    ct.ThrowIfCancellationRequested();
                }
                catch (Exception ex)
                {
                    wPExists.SetError = ex.Message;
                }
            }

            WAResponse wa = new WAResponse();
            wa.Number = mobileNumber;
            try
            {
                string url = SettingConfig.API_BASE_URL + mobileNumber;
                var client = new RestClient(url);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var data = response.Content;

                Thread ts = new Thread(delegate ()
                {
                    wa.Exists = response.Content;
                    wa.StatusCode = Convert.ToInt32(response.StatusCode);
                    wa.StatusDescription = response.StatusDescription;
                });
                ts.IsBackground = true;
                ts.Start();
            }
            catch (Exception ex)
            {
                wPExists.SetError = ex.Message + Environment.NewLine + ex.InnerException;
                wa.Exception = ex.Message;
                wa.InnerException = ex.InnerException.Message;
            }
            finally
            {
                wPExists.WAResponse = wa;
            }
        }
    }
}
