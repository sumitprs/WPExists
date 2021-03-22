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
    public class HashSet
    {
        public static async System.Threading.Tasks.Task DoHashSetQuery(List<string> current, WPExists wPExists, CancellationTokenSource tokenSource)
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


                HashSet<Thread> Threadlist = new HashSet<Thread>();
                foreach (var v in current)
                {
                    Threadlist.Add(new Thread(() => DoQueryWithProxy(proxyIP, proxyPort, v, token, wPExists)));
                }
                foreach (Thread T in Threadlist)
                {
                    T.SetApartmentState(ApartmentState.STA);
                    T.Start();
                }
                foreach (Thread T in Threadlist)
                {
                    if (T.ThreadState == ThreadState.Running)
                    {
                        T.Join();
                    }
                    wPExists.RunningThreadCount = Threadlist.Count();
                }
            }
            else
            {
                HashSet<Thread> Threadlist = new HashSet<Thread>();
                foreach (var v in current)
                {
                    Threadlist.Add(new Thread(() => DoQuery(v, token, wPExists)));
                }
                foreach (Thread T in Threadlist)
                {
                    T.SetApartmentState(ApartmentState.STA);
                    T.Start();
                }
                foreach (Thread T in Threadlist)
                {
                    if (T.ThreadState == ThreadState.Running)
                    {
                        T.Join();
                    }
                    wPExists.RunningThreadCount = Threadlist.Count();
                }
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
