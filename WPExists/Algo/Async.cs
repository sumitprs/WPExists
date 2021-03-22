using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPExists.Action;

namespace WPExists.Algo
{
    public static class Async
    {
        public static async System.Threading.Tasks.Task HttpClintProxyAsync(List<string> list, WPExists wPExists)
        {
            try
            {
                var urls = list.Select(s => s = SettingConfig.API_BASE_URL + s).ToList();
                List<string> proxyList = SettingConfig.ProxyIPCollection;
                if (SettingConfig.USEPROXY)
                {
                    var random = new Random();
                    var currentProxy = proxyList[random.Next(proxyList.Count)];
                    wPExists.CurrentProxyIP = currentProxy;
                    WebProxy proxy = new WebProxy
                    {
                        Address = new Uri("http://" + currentProxy),
                    };
                    HttpClientHandler clientHandler = new HttpClientHandler()
                    {
                        Proxy = proxy,
                    };
                    using (HttpClient client = new HttpClient(clientHandler))
                    {
                        //Start requests for all of them
                        var requests = urls.Select
                        (
                            url => client.GetAsync(url)
                        ).ToList();

                        wPExists.RunningThreadCount = requests.Count;

                        //Wait for all the requests to finish
                        await System.Threading.Tasks.Task.WhenAll(requests);

                        //Get the responses
                        var responses = requests.Select
                            (
                                task => task.Result
                            );

                        Thread thw = new Thread(delegate ()
                        {
                            var data = responses.ToList();
                            List<WAResponse> aResponses = (List<WAResponse>)data.Select(a => new WAResponse
                            {
                                Number = a.RequestMessage.RequestUri.AbsolutePath.Split('/').Last().ToString(),
                                Exists = a.Content.ReadAsStringAsync().Result,
                                StatusCode = Convert.ToInt32(a.StatusCode),
                                StatusDescription = a.ReasonPhrase
                            });
                            wPExists.WAResponseList = aResponses;
                        })
                        {
                            IsBackground = true
                        };
                        thw.Start();
                    }
                }
                else
                {
                    wPExists.CurrentProxyIP = "PROXY DISABLED";

                    var client = new HttpClient();

                    //Start requests for all of them
                    var requests = urls.Select
                        (
                            url => client.GetAsync(url)
                        ).ToList();

                    wPExists.RunningThreadCount = requests.Count;

                    //Wait for all the requests to finish
                    await System.Threading.Tasks.Task.WhenAll(requests);

                    //Get the responses
                    var responses = requests.Select
                        (
                            task => task.Result
                        );

                    Thread thp = new Thread(delegate ()
                    {
                        var data = responses.ToList();
                        List<WAResponse> aResponses = (List<WAResponse>)data.Select(a => new WAResponse
                        {
                            Number = a.RequestMessage.RequestUri.AbsolutePath.Split('/').Last().ToString(),
                            Exists = a.Content.ReadAsStringAsync().Result,
                            StatusCode = Convert.ToInt32(a.StatusCode),
                            StatusDescription = a.ReasonPhrase
                        }).ToList();
                        wPExists.WAResponseList = aResponses;
                    })
                    {
                        IsBackground = true
                    };
                    thp.Start();
                }
            }
            catch (HttpRequestException ex)
            {
                wPExists.SetError = ex.Message + Environment.NewLine + ex.InnerException;
            }
        }
    }
}
